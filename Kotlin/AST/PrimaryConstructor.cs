using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public class PrimaryConstructor(
    ImmutableList<string> modifiers
    // ImmutableList<ClassParameter> classParameters
) : AstNode {
    public ImmutableList<string> modifiers { get; } = modifiers;
    // public ImmutableList<ClassParameter> classParameters { get; } = classParameters;
    
    public override string ToString() => new StringBuilder()
        .Append(nameof(PrimaryConstructor))
        .Append('(')
        .appendProperty(nameof(modifiers), modifiers)
        .Append(", ")
        // .appendProperty(nameof(classParameters), classParameters)
        .Append(')')
        .ToString();
}