using System.Text;
using Kotlin.AST.Expression;

namespace Kotlin.AST;

public abstract class DirectlyAssignableExpression : AstNode {
    public class Suffix(
        PostfixUnaryExpression expression,
        AssignableSuffix assignableSuffix
    ) : DirectlyAssignableExpression {
        public PostfixUnaryExpression expression { get; } = expression;
        public AssignableSuffix assignableSuffix { get; } = assignableSuffix;
        
        public override string ToString() => new StringBuilder()
            .Append(nameof(Suffix))
            .Append('(')
            .appendProperty(nameof(expression), expression)
            .Append(", ")
            .appendProperty(nameof(assignableSuffix), assignableSuffix)
            .Append(')')
            .ToString();
    }

    public class Identifier(string identifier) : DirectlyAssignableExpression {
        public string identifier { get; } = identifier;
        
        public override string ToString() => new StringBuilder()
            .Append(nameof(Identifier))
            .Append('(')
            .appendProperty(nameof(identifier), identifier)
            .Append(')')
            .ToString();
    }
}