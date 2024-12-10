using System.Text;

namespace Kotlin.AST;

public class ClassValueParameter(
    bool mutable,
    Parameter parameter,
    Expression.Expression? expression
) : AstNode {
    public bool mutable { get; } = mutable;
    public Parameter parameter { get; } = parameter;
    public Expression.Expression? expression { get; } = expression;
    
    public override string ToString() => new StringBuilder()
        .Append("ClassValueParameter(")
        .appendProperty(nameof(mutable), mutable)
        .Append(", ")
        .appendProperty(nameof(parameter), parameter)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}