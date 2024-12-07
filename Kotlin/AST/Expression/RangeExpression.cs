using System.Text;

namespace Kotlin.AST.Expression;

public class RangeExpression(
    AdditiveExpression left,
    List<(RangeExpression.RangeOperator, AdditiveExpression)> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(RangeExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
    
    public enum RangeOperator {
        Range,
        RangeUtil
    }
}