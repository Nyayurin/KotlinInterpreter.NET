using System.Text;

namespace Kotlin.AST.Expression;

public class EqualityExpression(
    ComparisonExpression left,
    List<(EqualityOperator, ComparisonExpression)> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(EqualityExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}

public abstract class EqualityOperator : Expression {
    public class Equal : EqualityOperator;
    public class NotEqual : EqualityOperator;
    public class HardEqual : EqualityOperator;
    public class HardNotEqual : EqualityOperator;
}