using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public class PrimaryConstructor(
    List<ClassValueParameter> classParameters
) : AstNode {
    public ImmutableList<ClassValueParameter> classParameters { get; } = classParameters.ToImmutableList();
    
    public override string ToString() => new StringBuilder()
        .Append("PrimaryConstructor(")
        .appendProperty(nameof(classParameters), classParameters)
        .Append(')')
        .ToString();
}