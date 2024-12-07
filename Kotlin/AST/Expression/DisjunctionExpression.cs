using System.Text;

namespace Kotlin.AST.Expression;

public class DisjunctionExpression(
    ConjunctionExpression left,
    List<ConjunctionExpression> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(DisjunctionExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}