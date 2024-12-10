using System.Text;

namespace Kotlin.AST;

public abstract class Statement : AstNode;

public class DeclarationStatement(Declaration declaration) : Statement {
    public Declaration declaration { get; } = declaration;

    public override string ToString() => new StringBuilder()
        .Append("DeclarationStatement(")
        .appendProperty(nameof(declaration), declaration)
        .Append(')')
        .ToString();
}

public class DirectlyAssignmentStatement(
    DirectlyAssignableExpression left,
    Expression.Expression expression
) : Statement {
    public DirectlyAssignableExpression left { get; } = left;
    public Expression.Expression expression { get; } = expression;
    
    public override string ToString() => new StringBuilder()
        .Append("DirectlyAssignmentStatement(")
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}

public class AssignmentStatement(
    AssignableExpression left,
    AssignmentAndOperator op,
    Expression.Expression expression
) : Statement {
    public AssignableExpression left { get; } = left;
    public AssignmentAndOperator op { get; } = op;
    public Expression.Expression expression { get; } = expression;
    
    public override string ToString() => new StringBuilder()
        .Append("AssignmentStatement(")
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendProperty(nameof(op), op)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}

public abstract class LoopStatement : Statement {
    public class For : LoopStatement {
        
    }
    public class While : LoopStatement {
        
    }
    public class DoWhile : LoopStatement {
        
    }
}

public class ExpressionStatement(Expression.Expression expression) : Statement {
    public Expression.Expression expression { get; } = expression;

    public override string ToString() => new StringBuilder()
        .Append("ExpressionStatement(")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}