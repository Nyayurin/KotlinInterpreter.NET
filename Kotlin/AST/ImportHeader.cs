using System.Text;

namespace Kotlin.AST;

public abstract class ImportHeader : AstNode {
    public class Identifier(string identifier) : AstNode {
        public string identifier { get; } = identifier;

        public override string ToString() => new StringBuilder()
            .Append("ImportHeader.Identifier(")
            .appendProperty(nameof(identifier), identifier)
            .Append(')')
            .ToString();
    }

    public class Alias(string left, string right) : AstNode {
        public string left { get; } = left;
        public string right { get; } = right;

        public override string ToString() => new StringBuilder()
            .Append("ImportHeader.Alias(")
            .appendProperty(nameof(left), left)
            .Append(", ")
            .appendProperty(nameof(right), right)
            .Append(')')
            .ToString();
    }
}