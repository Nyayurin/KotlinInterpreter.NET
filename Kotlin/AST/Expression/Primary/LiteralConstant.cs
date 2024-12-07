using System.Text;

namespace Kotlin.AST.Expression.Primary;

public abstract class LiteralConstant : PrimaryExpression;

public class BooleanLiteral(bool value) : LiteralConstant {
    public override string ToString() => new StringBuilder()
        .Append(nameof(BooleanLiteral))
        .Append('(')
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class IntegerLiteral(int value) : LiteralConstant {
    public override string ToString() => new StringBuilder()
        .Append(nameof(IntegerLiteral))
        .Append('(')
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class CharacterLiteral(char value) : LiteralConstant {
    public override string ToString() => new StringBuilder()
        .Append(nameof(CharacterLiteral))
        .Append('(')
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class RealLiteral(double value) : LiteralConstant {
    public override string ToString() => new StringBuilder()
        .Append(nameof(RealLiteral))
        .Append('(')
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class NullLiteral : LiteralConstant {
    public static readonly NullLiteral INSTANCE = new();
    private NullLiteral() { }
    public override string ToString() => nameof(NullLiteral);
}

public class LongLiteral(long value) : LiteralConstant {
    public override string ToString() => new StringBuilder()
        .Append(nameof(LongLiteral))
        .Append('(')
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class UnsignedLiteral(ulong value) : LiteralConstant {
    public override string ToString() => new StringBuilder()
        .Append(nameof(UnsignedLiteral))
        .Append('(')
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}