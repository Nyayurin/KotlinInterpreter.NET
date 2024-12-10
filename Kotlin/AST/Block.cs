using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public class Block(List<Statement> statements) : AstNode {
    public ImmutableList<Statement> statements { get; } = statements.ToImmutableList();
    
    public override string ToString() => new StringBuilder()
        .Append("Block(")
        .appendProperty(nameof(statements), statements)
        .Append(')')
        .ToString();
}