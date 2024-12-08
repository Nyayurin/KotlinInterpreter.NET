using System.Text;

namespace Kotlin.AST.Expression;

public abstract class InfixOperationExpression : Expression {
    public class InOperator(
        Expression left,
        Expression right
    ) : InfixOperationExpression {
        public readonly Expression left = left;
        public readonly Expression right = right;

        public override string ToString() => new StringBuilder()
            .Append(nameof(InOperator))
            .Append('(')
            .appendProperty(nameof(left), left)
            .Append(", ")
            .appendProperty(nameof(right), right)
            .Append(')')
            .ToString();
    }

    public class IsOperator(
        Expression expression,
        Expression type
    ) : InfixOperationExpression {
        public readonly Expression expression = expression;
        public readonly Expression type = type;
        
        public override string ToString() => new StringBuilder()
            .Append(nameof(IsOperator))
            .Append('(')
            .appendProperty(nameof(expression), expression)
            .Append(", ")
            .appendProperty(nameof(type), type)
            .Append(')')
            .ToString();
    }
}