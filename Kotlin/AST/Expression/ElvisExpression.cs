using System.Text;

namespace Kotlin.AST.Expression;

public class ElvisExpression(
    InfixFunctionCallExpression left,
    List<InfixFunctionCallExpression> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(ElvisExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}