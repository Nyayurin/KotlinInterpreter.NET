using System.Text;

namespace Kotlin.AST.Expression;

public class ComparisonExpression(
    GenericCallLikeComparisonExpression left,
    List<(ComparisonOperator, GenericCallLikeComparisonExpression)> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(ComparisonExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}

public abstract class ComparisonOperator : Expression {
    public class Less : ComparisonOperator {
        
    }

    public class LessOrEqual : ComparisonOperator {
        
    }

    public class Greater : ComparisonOperator {
        
    }

    public class GreaterOrEqual : ComparisonOperator {
        
    }
}