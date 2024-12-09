using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public class KotlinFile(
    string? package,
    ImmutableList<ImportHeader> imports,
    ImmutableList<Declaration> declarations
) : AstNode {
    public string? package { get; } = package;
    public ImmutableList<ImportHeader> imports { get; } = imports;
    public ImmutableList<Declaration> declarations { get; } = declarations;

    public override string ToString() => new StringBuilder()
        .Append(nameof(KotlinFile))
        .Append('(')
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
    ImmutableList<ImportHeader> imports,
    ImmutableList<Statement> statements
) : AstNode {
    public string? package { get; } = package;
    public ImmutableList<ImportHeader> imports { get; } = imports;
    public ImmutableList<Statement> statements { get; } = statements;

    public override string ToString() => new StringBuilder()
        .Append(nameof(Script))
        .Append('(')
        .appendProperty(nameof(package), package)
        .Append(", ")
        .appendProperty(nameof(imports), imports)
        .Append(", ")
        .appendProperty(nameof(statements), statements)
        .Append(')')
        .ToString();
}