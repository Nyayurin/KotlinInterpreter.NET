using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST.Expression.Primary;

public class StringLiteral(ImmutableList<StringLiteral.Sub> contents) : PrimaryExpression {
    public ImmutableList<Sub> contents { get; } = contents;
    
    public override string ToString() => new StringBuilder()
        .Append(nameof(StringLiteral))
        .Append('(')
        .appendProperty(nameof(contents), contents)
        .Append(')')
        .ToString();
    
    public abstract class Sub : PrimaryExpression {
        public class Content(string value) : Sub {
            public string value { get; } = value;
            
            public override string ToString() => new StringBuilder()
                .Append(nameof(Content))
                .Append('(')
                .appendProperty(nameof(value), value)
                .Append(')')
                .ToString();
        }

        public class Expression(Kotlin.AST.Expression.Expression expression) : Sub {
            public Kotlin.AST.Expression.Expression expression { get; } = expression;
            
            public override string ToString() => new StringBuilder()
                .Append(nameof(Expression))
                .Append('(')
                .appendProperty(nameof(expression), expression)
                .Append(')')
                .ToString();
        }
    }
}