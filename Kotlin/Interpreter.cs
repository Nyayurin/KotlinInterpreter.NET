using System.Text;
using Kotlin.AST;
using Kotlin.AST.Expression;
using Kotlin.AST.Expression.Primary;

namespace Kotlin;

public class Interpreter {
    private readonly Stack<Dictionary<string, object>> scopes = new();

    public void run(AstNode node) {
        if (node is KotlinFile kotlinFileNode) {
            kotlinFile(kotlinFileNode);
        }
    }

    private void kotlinFile(KotlinFile node) {
        enterScope();
        stdlib();
        foreach (var declarationNode in node.topLevelObjects) {
            declaration(declarationNode);
        }

        callFunction("main", []);
        exitScope();
    }

    private void stdlib() {
        defineFunction("println", args => {
            Console.WriteLine(args[0]);
            return new object();
        });
    }

    private void declaration(Declaration node) {
        if (node is FunctionDeclaration functionDeclarationNode) {
            functionDeclaration(functionDeclarationNode);
        }
    }

    private void functionDeclaration(FunctionDeclaration node) {
        defineFunction(node.name, block(node.body));
    }

    private Func<object[], object> block(Block node) {
        return objects => {
            foreach (var statement in node.statements.statements) {
                if (statement is ExpressionStatement expressionStatement) {
                    expression(expressionStatement.expression);
                }
            }

            return new object();
        };
    }

    private object expression(Expression node) {
        if (node is PostfixUnaryExpression postfixUnaryExpression) {
            if (postfixUnaryExpression.op is PostfixUnarySuffix.CallSuffix callSuffix) {
                var args = callSuffix.valueArguments.arguments
                    .Select(argument => expression(argument.expression)).ToArray();
                if (postfixUnaryExpression.expression is Identifier identifier) {
                    return callFunction(identifier.identifier, args);
                }
            }
            
            throw new Exception($"Unknown expression type: {node.GetType()}");
        } else if (node is Identifier identifier) {
            return identifier.identifier;
        } else if (node is StringLiteral stringLiteral) {
            var sb = new StringBuilder();
            foreach (var stringLiteralContent in stringLiteral.contents) {
                if (stringLiteralContent is StringLiteral.Sub.Content subContent) {
                    sb.Append(subContent.value);
                } else if (stringLiteralContent is StringLiteral.Sub.Expression subExpression) {
                    sb.Append(expression(subExpression.expression));
                }
            }

            return sb.ToString();
        }

        throw new Exception($"Unknown expression type: {node.GetType()}");
    }

    private void enterScope() => scopes.Push(new Dictionary<string, object>());
    private void exitScope() => scopes.TryPop(out _);

    private object getVariable(string name) {
        foreach (var scope in scopes) {
            if (scope.TryGetValue(name, out var variable)) {
                return variable;
            }
        }

        throw new Exception($"Variable '{name}' not found");
    }

    private void setVariable(string name, object value) {
        var currentScope = scopes.Peek();
        currentScope[name] = value;
    }

    private void defineFunction(string name, Func<object[], object> func) {
        var currentScope = scopes.Peek();
        currentScope[name] = func;
    }

    private object callFunction(string name, object[] args) {
        foreach (var scope in scopes) {
            if (scope.TryGetValue(name, out var value) && value is Func<object[], object> func) {
                return func(args);
            }
        }

        throw new Exception($"Function '{name}' not found");
    }
}