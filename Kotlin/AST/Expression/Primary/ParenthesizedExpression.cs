using System.Text;

namespace Kotlin.AST.Expression.Primary;

public class ParenthesizedExpression(Expression expression) : PrimaryExpression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(ParenthesizedExpression))
        .Append('(')
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}