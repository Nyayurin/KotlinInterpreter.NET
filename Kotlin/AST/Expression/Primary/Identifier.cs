﻿using System.Text;

namespace Kotlin.AST.Expression.Primary;

public class Identifier(string identifier) : PrimaryExpression {
    public override string ToString() => new StringBuilder()
        .Append(nameof(Identifier))
        .Append('(')
        .appendProperty(nameof(identifier), identifier)
        .Append(')')
        .ToString();
}