using System.Text;

namespace Kotlin.AST.Expression;

public class ValueArgument(Expression expression) : Expression {
    public Expression expression { get; } = expression;
    
    public override string ToString() => new StringBuilder()
        .Append("ValueArgument(")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}