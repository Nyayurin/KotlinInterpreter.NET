using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public abstract class Declaration : AstNode;

public class ClassDeclaration(
    string name,
    PrimaryConstructor? primaryConstructor,
    List<ClassMemberDeclaration> body
) : Declaration {
    public string name { get; } = name;
    public PrimaryConstructor? primaryConstructor { get; } = primaryConstructor;
    public ImmutableList<ClassMemberDeclaration> body { get; } = body.ToImmutableList();

    public override string ToString() => new StringBuilder()
        .Append("ClassDeclaration(")
        .appendProperty(nameof(name), name)
        .Append(", ")
        .appendProperty(nameof(primaryConstructor), primaryConstructor)
        .Append(", ")
        .appendProperty(nameof(body), body)
        .Append(')')
        .ToString();
}

public class FunctionDeclaration(
    string name,
    List<FunctionValueParameter> valueParameters,
    string? type,
    Block body
) : Declaration {
    public string name { get; } = name;
    public ImmutableList<FunctionValueParameter> valueParameters { get; } = valueParameters.ToImmutableList();
    public string? type { get; } = type;
    public Block body { get; } = body;

    public override string ToString() => new StringBuilder()
        .Append("FunctionDeclaration(")
        .appendProperty(nameof(name), name)
        .Append(", ")
        .appendProperty(nameof(valueParameters), valueParameters)
        .Append(", ")
        .appendProperty(nameof(type), type)
        .Append(", ")
        .appendProperty(nameof(body), body)
        .Append(')')
        .ToString();
}

public class PropertyDeclaration(
    bool mutable,
    string name,
    string? type,
    Expression.Expression expression
) : Declaration {
    public bool mutable { get; } = mutable;
    public string name { get; } = name;
    public string? type { get; } = type;
    public Expression.Expression expression { get; } = expression;

    public override string ToString() => new StringBuilder()
        .Append("PropertyDeclaration(")
        .appendProperty(nameof(mutable), mutable)
        .Append(", ")
        .appendProperty(nameof(name), name)
        .Append(", ")
        .appendProperty(nameof(type), type)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}