using System.Text;
using Kotlin.AST.Expression.Primary;

namespace Kotlin.AST.Expression;

public class PostfixUnaryExpression(PrimaryExpression expression, List<PostfixUnarySuffix> suffixes) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(PostfixUnaryExpression))
        .Append('(')
        .appendProperty(nameof(expression), expression)
        .Append(", ")
        .appendList(nameof(suffixes), suffixes)
        .Append(')')
        .ToString();
}

public abstract class PostfixUnarySuffix : Expression {
    public class Operator : PostfixUnarySuffix;

    public class TypeArguments : PostfixUnarySuffix;

    public class CallSuffix(ValueArguments valueArguments) : PostfixUnarySuffix {
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