using System.Text;

namespace Kotlin.AST.Expression;

public class AsExpression(
    PrefixUnaryExpression left,
    List<(AsOperator, Type)> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(AsExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}

public abstract class AsOperator : Expression {
    public class As : AsOperator { }

    public class AsSafe : AsOperator { }
}