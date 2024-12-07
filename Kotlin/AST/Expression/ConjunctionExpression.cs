using System.Text;

namespace Kotlin.AST.Expression;

public class ConjunctionExpression(
    EqualityExpression left,
    List<EqualityExpression> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(ConjunctionExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}