using System.Text;

namespace Kotlin.AST;

public class Parameter(
    string name,
    string type
) : AstNode {
    public string name { get; } = name;
    public string type { get; } = type;
    
    public override string ToString() => new StringBuilder()
        .Append("Parameter(")
        .appendProperty(nameof(name), name)
        .Append(", ")
        .appendProperty(nameof(type), type)
        .Append(')')
        .ToString();
}