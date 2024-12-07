using System.Text;

namespace Kotlin.AST.Expression;

public class MultiplicativeExpression(
    AsExpression left,
    List<(MultiplicativeOperator, AsExpression)> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(MultiplicativeExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}

public abstract class MultiplicativeOperator : Expression {
    public class Multiply : MultiplicativeOperator { }

    public class Divide : MultiplicativeOperator { }

    public class Mod : MultiplicativeOperator { }
}