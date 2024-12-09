using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST.Expression;

public class ValueArguments(ImmutableList<ValueArgument> arguments) : Expression {
    public ImmutableList<ValueArgument> arguments { get; } = arguments;

    public override string ToString() => new StringBuilder()
        .Append(nameof(ValueArguments))
        .Append('(')
        .appendProperty(nameof(arguments), arguments)
        .Append(')')
        .ToString();
}