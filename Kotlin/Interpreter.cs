using System.Text;
using Kotlin.AST;
using Kotlin.AST.Expression;
using Kotlin.AST.Expression.Primary;

namespace Kotlin;

public class Interpreter {
    private readonly Stack<Dictionary<string, object?>> scopes = new();

    public void run(AstNode node) {
        if (node is KotlinFile kotlinFileNode) {
            kotlinFile(kotlinFileNode);
        }
    }

    private void kotlinFile(KotlinFile node) {
        enterScope();
        stdlib();
        foreach (var declarationNode in node.declarations) {
            declaration(declarationNode);
        }

        callFunction("main", []);
        exitScope();
    }

    private void stdlib() {
        defineFunction("println", args => {
            Console.WriteLine(args[0]);
            return null;
        });
        defineFunction("print", args => {
            Console.Write(args[0]);
            return null;
        });
        defineFunction("readln", _ => Console.ReadLine());
    }

    private void declaration(Declaration node) {
        if (node is FunctionDeclaration functionDeclarationNode) {
            functionDeclaration(functionDeclarationNode);
        } else if (node is PropertyDeclaration propertyDeclarationNode) {
            propertyDeclaration(propertyDeclarationNode);
        } else {
            throw new Exception($"Unknown declaration type: {node.GetType()}");
        }
    }

    private void functionDeclaration(FunctionDeclaration node) {
        defineFunction(node.name, block(node.body));
    }

    private void propertyDeclaration(PropertyDeclaration node) {
        setVariable(node.name, expression(node.expression));
    }

    private Func<object[], object?> block(Block node) {
        return objects => {
            foreach (var statement in node.statements.statements) {
                switch (statement) {
                    case DeclarationStatement declarationStatementNode:
                        declarationStatement(declarationStatementNode);
                        break;
                    case AssignmentStatement assignmentStatementNode:
                    case DirectlyAssignmentStatement directlyAssignmentStatementNode:
                        throw new Exception($"Unknown statement type: {statement.GetType()}");
                    case ExpressionStatement expressionStatementNode:
                        expression(expressionStatementNode.expression);
                        break;
                    case LoopStatement.DoWhile doWhileNode:
                    case LoopStatement.For forNode:
                    case LoopStatement.While whileNode:
                    case LoopStatement loopStatementNode:
                    default:
                        throw new Exception($"Unknown statement type: {statement.GetType()}");
                }
            }

            return null;
        };
    }

    private void declarationStatement(DeclarationStatement node) {
        declaration(node.declaration);
    }

    private void directlyAssignmentStatement(DirectlyAssignmentStatement node) {
        switch (node.left) {
            case DirectlyAssignableExpression.Identifier identifier:
                var value = expression(node.expression);
                setVariable(identifier.identifier, value);
                break;
            case DirectlyAssignableExpression.Suffix suffix:
            default:
                throw new Exception($"Unknown expression type: {node.GetType()}");
        }
    }

    private void assignmentStatement(AssignmentStatement node) {
        switch (node.op) {
            case AssignmentAndOperator.Add add:
            case AssignmentAndOperator.Div div:
            case AssignmentAndOperator.Mod mod:
            case AssignmentAndOperator.Multi multi:
            case AssignmentAndOperator.Sub sub:
            default:
                throw new Exception($"Unknown expression type: {node.GetType()}");
        }
    }

    private object? expression(Expression node) {
        if (node is PostfixUnaryExpression postfixUnaryExpression) {
            if (postfixUnaryExpression.op is PostfixUnarySuffix.CallSuffix callSuffix) {
                var args = callSuffix.valueArguments.arguments
                    .Select(argument => expression(argument.expression))
                    .Where(o => o != null)
                    .Cast<object>()
                    .ToArray();
                if (postfixUnaryExpression.expression is Identifier identifier) {
                    return callFunction(identifier.identifier, args);
                }
            }

            throw new Exception($"Unknown expression type: {node.GetType()}");
        } else if (node is Identifier identifier) {
            return getVariable(identifier.identifier);
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
        } else if (node is LiteralConstant literalConstant) {
            switch (literalConstant) {
                case BooleanLiteral booleanLiteral:
                    return booleanLiteral.value;
                case IntegerLiteral integerLiteral:
                    return integerLiteral.value;
                case CharacterLiteral characterLiteral:
                    return characterLiteral.value;
                case RealLiteral realLiteral:
                    return realLiteral.value;
                case NullLiteral:
                    return null;
                case LongLiteral longLiteral:
                    return longLiteral.value;
                case UnsignedLiteral unsignedLiteral:
                    return unsignedLiteral.value;
            }
        }

        throw new Exception($"Unknown expression type: {node.GetType()}");
    }

    private void enterScope() => scopes.Push(new Dictionary<string, object?>());
    private void exitScope() => scopes.TryPop(out _);

    private object? getVariable(string name) {
        foreach (var scope in scopes) {
            if (scope.TryGetValue(name, out var variable)) {
                return variable;
            }
        }

        throw new Exception($"Variable '{name}' not found");
    }

    private void setVariable(string name, object? value) {
        var currentScope = scopes.Peek();
        currentScope[name] = value;
    }

    private void defineFunction(string name, Func<object[], object?> func) {
        var currentScope = scopes.Peek();
        currentScope[name] = func;
    }

    private object? callFunction(string name, object[] args) {
        foreach (var scope in scopes) {
            if (scope.TryGetValue(name, out var value) && value is Func<object[], object?> func) {
                return func(args);
            }
        }

        throw new Exception($"Function '{name}' not found");
    }
}