using System.Text;

namespace Kotlin.AST.Expression;

public class PrefixUnaryExpression(
    UnaryPrefix op,
    Expression expression
) : Expression {
    public readonly UnaryPrefix op = op;
    public readonly Expression expression = expression;

    public override string ToString() => new StringBuilder()
        .Append("PrefixUnaryExpression(")
        .appendProperty(nameof(op), op)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}

public abstract class UnaryPrefix : Expression {
    public class Annotation : UnaryPrefix {
        public override string ToString() => new StringBuilder()
            .Append("UnaryPrefix.Annotation(")
            .Append(')')
            .ToString();
    }

    public class Label : UnaryPrefix {
        public override string ToString() => new StringBuilder()
            .Append("UnaryPrefix.Label(")
            .Append(')')
            .ToString();
    }

    public class Operator(string op) : UnaryPrefix {
        public override string ToString() => new StringBuilder()
            .Append("UnaryPrefix.Operator(")
            .appendProperty(nameof(op), op)
            .Append(')')
            .ToString();
    }
}