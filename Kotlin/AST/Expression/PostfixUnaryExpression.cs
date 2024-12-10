using System.Text;

namespace Kotlin.AST.Expression;

public class PostfixUnaryExpression(
    PostfixUnarySuffix op,
    Expression expression
) : Expression {
    public readonly PostfixUnarySuffix op = op;
    public readonly Expression expression = expression;

    public override string ToString() => new StringBuilder()
        .Append("PostfixUnaryExpression(")
        .appendProperty(nameof(op), op)
        .Append(", ")
        .appendProperty(nameof(expression), expression)
        .Append(')')
        .ToString();
}

public abstract class PostfixUnarySuffix : Expression {
    public class Operator : PostfixUnarySuffix;

    public class TypeArguments : PostfixUnarySuffix;

    public class CallSuffix(List<ValueArgument> valueArguments) : PostfixUnarySuffix {
        public List<ValueArgument> valueArguments { get; } = valueArguments;

        public override string ToString() => new StringBuilder()
            .Append("PostfixUnarySuffix.CallSuffix(")
            .appendProperty(nameof(valueArguments), valueArguments)
            .Append(')')
            .ToString();
    }

    public class IndexingSuffix : PostfixUnarySuffix;

    public abstract class NavigationSuffix : PostfixUnarySuffix {
        public abstract class Navigation : PostfixUnarySuffix {
            public class Identifier(string identifier) : Navigation {
                public string identifier { get; } = identifier;

                public override string ToString() => new StringBuilder()
                    .Append("PostfixUnarySuffix.NavigationSuffix.Identifier(")
                    .appendProperty(nameof(identifier), identifier)
                    .Append(')')
                    .ToString();
            }

            public class Expression(Kotlin.AST.Expression.Expression expression) : Navigation {
                public Kotlin.AST.Expression.Expression expression { get; } = expression;

                public override string ToString() => new StringBuilder()
                    .Append("PostfixUnarySuffix.NavigationSuffix.Expression(")
                    .appendProperty(nameof(expression), expression)
                    .Append(')')
                    .ToString();
            }
        }

        public abstract class SafeNavigation : PostfixUnarySuffix {
            public class Identifier(string identifier) : Navigation {
                public string identifier { get; } = identifier;

                public override string ToString() => new StringBuilder()
                    .Append("PostfixUnarySuffix.SafeNavigation.Identifier(")
                    .appendProperty(nameof(identifier), identifier)
                    .Append(')')
                    .ToString();
            }

            public class Expression(Kotlin.AST.Expression.Expression expression) : Navigation {
                public Kotlin.AST.Expression.Expression expression { get; } = expression;

                public override string ToString() => new StringBuilder()
                    .Append("PostfixUnarySuffix.SafeNavigation.Expression(")
                    .appendProperty(nameof(expression), expression)
                    .Append(')')
                    .ToString();
            }
        }

        public abstract class Quote : PostfixUnarySuffix {
            public class Identifier(string identifier) : Navigation {
                public string identifier { get; } = identifier;

                public override string ToString() => new StringBuilder()
                    .Append("PostfixUnarySuffix.Quote.Identifier(")
                    .appendProperty(nameof(identifier), identifier)
                    .Append(')')
                    .ToString();
            }

            public class Expression(Kotlin.AST.Expression.Expression expression) : Navigation {
                public Kotlin.AST.Expression.Expression expression { get; } = expression;

                public override string ToString() => new StringBuilder()
                    .Append("PostfixUnarySuffix.Quote.Expression(")
                    .appendProperty(nameof(expression), expression)
                    .Append(')')
                    .ToString();
            }

            public class Class : Navigation {
                public static Class instance { get; } = new();
                private Class() { }
                public override string ToString() => "PostfixUnarySuffix.Quote.Class";
            }
        }
    }
}