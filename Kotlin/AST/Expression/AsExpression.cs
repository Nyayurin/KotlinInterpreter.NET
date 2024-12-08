using System.Text;

namespace Kotlin.AST.Expression;

public abstract class AsExpression : Expression {
    public class As(Expression left, Expression type) : AsExpression {
        public readonly Expression left = left;
        public readonly Expression type = type;
        
        public override string ToString() => new StringBuilder()
            .Append(nameof(As))
            .Append('(')
            .appendProperty(nameof(left), left)
            .Append(", ")
            .appendProperty(nameof(type), type)
            .Append(')')
            .ToString();
    }
    
    public class AsSafe(Expression left, Expression type) : AsExpression {
        public readonly Expression left = left;
        public readonly Expression type = type;
        
        public override string ToString() => new StringBuilder()
            .Append(nameof(AsSafe))
            .Append('(')
            .appendProperty(nameof(left), left)
            .Append(", ")
            .appendProperty(nameof(type), type)
            .Append(')')
            .ToString();
    }
}