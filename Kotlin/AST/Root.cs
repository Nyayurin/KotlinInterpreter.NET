using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public class KotlinFile(ImmutableList<Declaration> topLevelObjects) : AstNode {
    public ImmutableList<Declaration> topLevelObjects { get; } = topLevelObjects;

    public override string ToString() => new StringBuilder()
        .Append(nameof(KotlinFile))
        .Append('(')
        .appendList(nameof(topLevelObjects), topLevelObjects)
        .Append(')')
        .ToString();
}