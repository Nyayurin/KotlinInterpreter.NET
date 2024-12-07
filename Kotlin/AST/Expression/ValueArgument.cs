using System.Text;

namespace Kotlin.AST.Expression;

public class ValueArgument(Expression expression) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(ValueArgument))
        .Append('(')
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}