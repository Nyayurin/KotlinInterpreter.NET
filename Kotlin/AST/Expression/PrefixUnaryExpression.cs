using System.Text;

namespace Kotlin.AST.Expression;

public class PrefixUnaryExpression(
    UnaryPrefix op,
    Expression expression
) : Expression {
    public readonly UnaryPrefix op = op;
    public readonly Expression expression = expression;

    public override string ToString() => new StringBuilder()
        .Append(nameof(PrefixUnaryExpression))
        .Append('(')
        .appendProperty(nameof(op), op)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}

public abstract class UnaryPrefix : Expression {
    public class Annotation : UnaryPrefix {
        public override string ToString() => new StringBuilder()
            .Append(nameof(Annotation))
            .Append('(')
            .Append(')')
            .ToString();
    }

    public class Label : UnaryPrefix {
        public override string ToString() => new StringBuilder()
            .Append(nameof(Label))
            .Append('(')
            .Append(')')
            .ToString();
    }

    public class Operator(string op) : UnaryPrefix {
        public override string ToString() => new StringBuilder()
            .Append(nameof(Operator))
            .Append('(')
            .appendProperty(nameof(op), op)
            .Append(')')
            .ToString();
    }
}