using System.Text;

namespace Kotlin.AST.Expression;

public class AdditiveExpression(
    MultiplicativeExpression left,
    List<(AdditiveOperator, MultiplicativeExpression)> right
) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(AdditiveExpression))
        .Append('(')
        .appendProperty(nameof(left), left)
        .Append(", ")
        .appendList(nameof(right), right)
        .Append(')')
        .ToString();
}

public abstract class AdditiveOperator : Expression {
    public class Add : AdditiveOperator { }

    public class Sub : AdditiveOperator { }
}