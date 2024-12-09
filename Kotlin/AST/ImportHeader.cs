using System.Text;

namespace Kotlin.AST;

public abstract class ImportHeader : AstNode {
    public class Identifier(string identifier) : AstNode {
        public string identifier { get; } = identifier;

        public override string ToString() => new StringBuilder()
            .Append(nameof(Identifier))
            .Append('(')
            .appendProperty(nameof(identifier), identifier)
            .Append(')')
            .ToString();
    }

    public class Alias(string left, string right) : AstNode {
        public string left { get; } = left;
        public string right { get; } = right;

        public override string ToString() => new StringBuilder()
            .Append(nameof(Alias))
            .Append('(')
            .appendProperty(nameof(left), left)
            .Append(", ")
            .appendProperty(nameof(right), right)
            .Append(')')
            .ToString();
    }
}