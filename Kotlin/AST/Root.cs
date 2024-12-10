using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public class KotlinFile(
    string? package,
    List<ImportHeader> imports,
    List<Declaration> declarations
) : AstNode {
    public string? package { get; } = package;
    public ImmutableList<ImportHeader> imports { get; } = imports.ToImmutableList();
    public ImmutableList<Declaration> declarations { get; } = declarations.ToImmutableList();

    public override string ToString() => new StringBuilder()
        .Append("KotlinFile(")
        .appendProperty(nameof(package), package)
        .Append(", ")
        .appendProperty(nameof(imports), imports)
        .Append(", ")
        .appendProperty(nameof(declarations), declarations)
        .Append(')')
        .ToString();
}

public class Script(
    string? package,
    List<ImportHeader> imports,
    List<Statement> statements
) : AstNode {
    public string? package { get; } = package;
    public ImmutableList<ImportHeader> imports { get; } = imports.ToImmutableList();
    public ImmutableList<Statement> statements { get; } = statements.ToImmutableList();

    public override string ToString() => new StringBuilder()
        .Append("Script(")
        .appendProperty(nameof(package), package)
        .Append(", ")
        .appendProperty(nameof(imports), imports)
        .Append(", ")
        .appendProperty(nameof(statements), statements)
        .Append(')')
        .ToString();
}