using System.Text;

namespace Kotlin.AST.Expression;

public class InfixFunctionCallExpression(
    RangeExpression left,
    List<(string, RangeExpression)> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(RangeExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}