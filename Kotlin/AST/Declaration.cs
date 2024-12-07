using System.Text;

namespace Kotlin.AST;

public abstract class Declaration : AstNode;

public class ClassDeclaration : Declaration;

public class ObjectDeclaration : Declaration;

public class FunctionDeclaration(string name, Block body) : Declaration {
    public override string ToString() => new StringBuilder()
        .Append(nameof(FunctionDeclaration))
        .Append('(')
        .appendProperty(nameof(name), name)
        .Append(", ")
        .appendProperty(nameof(body), body)
        .Append(')')
        .ToString();
}

public class PropertyDeclaration : Declaration;

public class TypeAlias : Declaration;