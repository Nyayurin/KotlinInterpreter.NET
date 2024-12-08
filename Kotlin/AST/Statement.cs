using System.Text;

namespace Kotlin.AST;

public abstract class Statement : AstNode;

public class DeclarationStatement(Declaration declaration) : Statement { }

public class AssignmentStatement : Statement { }

public class LoopStatement : Statement { }

public class ExpressionStatement(Expression.Expression expression) : Statement {
    public Expression.Expression expression { get; } = expression;

    public override string ToString() => new StringBuilder()
        .Append(nameof(ExpressionStatement))
        .Append('(')
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}