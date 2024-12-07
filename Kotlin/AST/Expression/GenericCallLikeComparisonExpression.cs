using System.Text;

namespace Kotlin.AST.Expression;

public class GenericCallLikeComparisonExpression(
    InfixOperationExpression left,
    List<PostfixUnarySuffix.CallSuffix> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(GenericCallLikeComparisonExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}