using System.Text;

namespace Kotlin.AST.Expression;

public class InfixFunctionCallExpression(
    string identifier,
    Expression left,
    Expression right
) : Expression {
    public string identifier { get; } = identifier;
    public Expression left { get; } = left;
    public Expression right { get; } = right;
    
    public override string ToString() => new StringBuilder()
        .Append("InfixFunctionCallExpression(")
        .appendProperty(nameof(identifier), identifier)
        .Append(", ")
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendProperty(nameof(right), right)
        .Append(')')
        .ToString();
}