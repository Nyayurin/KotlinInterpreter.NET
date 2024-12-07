using System.Text;

namespace Kotlin.AST.Expression;

public class PrefixUnaryExpression(
    List<UnaryPrefix> prefixes,
    PostfixUnaryExpression expression
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(PrefixUnaryExpression))
        .Append('(')
        .appendList(nameof(prefixes), prefixes)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}

public abstract class UnaryPrefix : Expression {
    public class Annotation : UnaryPrefix {
        
    }

    public class Label : UnaryPrefix {
        
    }

    public class Operator : UnaryPrefix {
        
    }
}

public enum UnaryPrefixOperator {
    Increment,
    Decrement,
    Sub,
    Add,
    Excl
}