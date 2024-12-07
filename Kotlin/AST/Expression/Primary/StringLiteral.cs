using System.Text;

namespace Kotlin.AST.Expression.Primary;

public class StringLiteral(List<StringLiteral.Sub> contents) : PrimaryExpression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(StringLiteral))
        .Append('(')
        .appendList(nameof(contents), contents)
        .Append(')')
        .ToString();
    
    public abstract class Sub : PrimaryExpression {
        public class Content(string value) : Sub {
            public override string ToString() => new StringBuilder()
                .Append(nameof(Content))
                .Append('(')
                .appendProperty(nameof(value), value)
                .Append(')')
                .ToString();
        }

        public class Expression(Kotlin.AST.Expression.Expression expression) : Sub {
            public override string ToString() => new StringBuilder()
                .Append(nameof(Expression))
                .Append('(')
                .appendProperty(nameof(expression), expression)
                .Append(')')
                .ToString();
        }
    }
}