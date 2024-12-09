using System.Text;
using Kotlin.AST.Expression;

namespace Kotlin.AST;

public class AssignableExpression(PrefixUnaryExpression expression) : AstNode {
    public PrefixUnaryExpression expression { get; } = expression;
        
    public override string ToString() => new StringBuilder()
        .Append(nameof(AssignableExpression))
        .Append('(')
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}