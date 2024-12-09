using System.Text;

namespace Kotlin.AST.Expression;

public class PostfixUnaryExpression(
    PostfixUnarySuffix op,
    Expression expression
) : Expression {
    public readonly PostfixUnarySuffix op = op;
    public readonly Expression expression = expression;

    public override string ToString() => new StringBuilder()
        .Append(nameof(PostfixUnaryExpression))
        .Append('(')
        .appendProperty(nameof(op), op)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}

public abstract class PostfixUnarySuffix : Expression {
    public class Operator : PostfixUnarySuffix;

    public class TypeArguments : PostfixUnarySuffix;

    public class CallSuffix(ValueArguments valueArguments) : PostfixUnarySuffix {
        public ValueArguments valueArguments { get; } = valueArguments;
        
        public override string ToString() => new StringBuilder()
            .Append(nameof(CallSuffix))
            .Append('(')
            .appendProperty(nameof(valueArguments), valueArguments)
            .Append(')')
            .ToString();
    }
    
    public class IndexingSuffix : PostfixUnarySuffix;
    
    public class NavigationSuffix : PostfixUnarySuffix;
}