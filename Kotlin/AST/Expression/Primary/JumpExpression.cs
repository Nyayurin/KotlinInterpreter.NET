using System.Text;

namespace Kotlin.AST.Expression.Primary;

public abstract class JumpExpression : PrimaryExpression {
    public class Throw(Expression expression) : JumpExpression {
        public Expression expression { get; } = expression;

        public override string ToString() => new StringBuilder()
            .Append("JumpExpression.Throw(")
            .appendProperty(nameof(expression), expression)
            .Append(')')
            .ToString();
    }

    public class Return(Expression? expression) : JumpExpression {
        public Expression? expression { get; } = expression;

        public override string ToString() => new StringBuilder()
            .Append("JumpExpression.Return(")
            .appendProperty(nameof(expression), expression)
            .Append(')')
            .ToString();
    }

    public class ReturnAt(Expression? expression) : JumpExpression {
        public Expression? expression { get; } = expression;

        public override string ToString() => new StringBuilder()
            .Append("JumpExpression.ReturnAt(")
            .appendProperty(nameof(expression), expression)
            .Append(')')
            .ToString();
    }

    public class Continue : JumpExpression {
        public static Continue instance { get; } = new();
        private Continue() { }
        public override string ToString() => "JumpExpression.Continue";
    }

    public class ContinueAt : JumpExpression {
        public static ContinueAt instance { get; } = new();
        private ContinueAt() { }
        public override string ToString() => "JumpExpression.ContinueAt";
    }

    public class Break : JumpExpression {
        public static Break instance { get; } = new();
        private Break() { }
        public override string ToString() => "JumpExpression.Break";
    }

    public class BreakAt : JumpExpression {
        public static BreakAt instance { get; } = new();
        private BreakAt() { }
        public override string ToString() => "JumpExpression.BreakAt";
    }
}