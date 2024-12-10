using System.Text;

namespace Kotlin.AST.Expression.Primary;

public abstract class LiteralConstant : PrimaryExpression;

public class BooleanLiteral(bool value) : LiteralConstant {
    public bool value { get; } = value;
    
    public override string ToString() => new StringBuilder()
        .Append("BooleanLiteral(")
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class IntegerLiteral(int value) : LiteralConstant {
    public int value { get; } = value;

    public override string ToString() => new StringBuilder()
        .Append("IntegerLiteral(")
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class CharacterLiteral(char value) : LiteralConstant {
    public char value { get; } = value;

    public override string ToString() => new StringBuilder()
        .Append("CharacterLiteral(")
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class RealLiteral(double value) : LiteralConstant {
    public double value { get; } = value;

    public override string ToString() => new StringBuilder()
        .Append("RealLiteral(")
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class NullLiteral : LiteralConstant {
    public static readonly NullLiteral INSTANCE = new();
    private NullLiteral() { }
    public override string ToString() => "NullLiteral";
}

public class LongLiteral(long value) : LiteralConstant {
    public long value { get; } = value;

    public override string ToString() => new StringBuilder()
        .Append("LongLiteral(")
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}

public class UnsignedLiteral(ulong value) : LiteralConstant {
    public ulong value { get; } = value;

    public override string ToString() => new StringBuilder()
        .Append("UnsignedLiteral(")
        .appendProperty(nameof(value), value)
        .Append(')')
        .ToString();
}