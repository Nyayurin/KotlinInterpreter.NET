using System.Text;

namespace Kotlin.AST.Expression.Primary;

public class Identifier(string identifier) : PrimaryExpression {
    public string identifier { get; } = identifier;
    
    public override string ToString() => new StringBuilder()
        .Append("Identifier(")
        .appendProperty(nameof(identifier), identifier)
        .Append(')')
        .ToString();
}