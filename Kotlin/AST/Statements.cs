using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public class Statements(ImmutableList<Statement> statements) : AstNode {
    public ImmutableList<Statement> statements { get; } = statements;
    
    public override string ToString() => new StringBuilder()
        .Append(nameof(Statements))
        .Append('(')
        .appendList(nameof(statements), statements)
        .Append(')')
        .ToString();
}