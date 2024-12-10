using System.Text;

namespace Kotlin.AST.Expression;

public class BinaryExpression(
    string op,
    Expression left,
    Expression right
) : Expression {
    public readonly string op = op;
    public readonly Expression left = left;
    public readonly Expression right = right;

    public override string ToString() => new StringBuilder()
        .Append("BinaryExpression(")
        .appendProperty(nameof(op), op)
        .Append(", ")
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendProperty(nameof(right), right)
        .Append(')')
        .ToString();
}