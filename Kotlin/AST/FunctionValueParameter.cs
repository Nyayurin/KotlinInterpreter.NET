using System.Text;

namespace Kotlin.AST;

public class FunctionValueParameter(
    Parameter parameter,
    Expression.Expression? expression
) : AstNode {
    public Parameter parameter { get; } = parameter;
    public Expression.Expression? expression { get; } = expression;
    
    public override string ToString() => new StringBuilder()
        .Append(nameof(FunctionValueParameter))
        .Append('(')
        .appendProperty(nameof(parameter), parameter)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}