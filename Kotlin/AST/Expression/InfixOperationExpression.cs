using System.Text;

namespace Kotlin.AST.Expression;

public class InfixOperationExpression(
    ElvisExpression left,
    List<InfixOperationExpression.Sub> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(InfixOperationExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
    
    public abstract class Sub {
        public class Elvis(ElvisExpression expression) : Sub { }

        public class Type : Sub { }
    }
}