using System.Text;

namespace Kotlin.AST;

public class Statements(List<Statement> statements) : AstNode {
    public override string ToString() => new StringBuilder()
        .Append(nameof(Statements))
        .Append('(')
        .appendList(nameof(statements), statements)
        .Append(')')
        .ToString();
}