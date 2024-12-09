using System.Text;

namespace Kotlin.AST;

public abstract class ClassMemberDeclaration : AstNode {
    public class Declaration(Kotlin.AST.Declaration declaration) : ClassMemberDeclaration {
        public Kotlin.AST.Declaration declaration { get; } = declaration;

        public override string ToString() => new StringBuilder()
            .Append(nameof(ClassMemberDeclaration))
            .Append('(')
            .appendProperty(nameof(declaration), declaration)
            .Append(')')
            .ToString();
    }
}