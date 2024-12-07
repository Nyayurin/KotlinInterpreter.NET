using System.Text;

namespace Kotlin.AST.Expression;

public class ValueArguments(List<ValueArgument> arguments) : Expression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(ValueArguments))
        .Append('(')
        .appendList(nameof(arguments), arguments)
        .Append(')')
        .ToString();
}