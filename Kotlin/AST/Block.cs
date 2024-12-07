using System.Text;

namespace Kotlin.AST;

public class Block(Statements statements) : AstNode {
    public override string ToString() => new StringBuilder()
        .Append(nameof(Block))
        .Append('(')
        .appendProperty(nameof(statements), statements)
        .Append(')')
        .ToString();
}