using System.Text;

namespace Kotlin.AST;

public class KotlinFile(List<Declaration> topLevelObjects) : AstNode {
    public override string ToString() => new StringBuilder()
        .Append(nameof(KotlinFile))
        .Append('(')
        .appendList(nameof(topLevelObjects), topLevelObjects)
        .Append(')')
        .ToString();
}