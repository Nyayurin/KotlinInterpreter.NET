namespace Kotlin.AST;

public abstract class AssignmentAndOperator : AstNode {
    public class Add : AssignmentAndOperator {
        public static Add instance { get; } = new();
        private Add() { }
        public override string ToString() => nameof(Add);
    }

    public class Sub : AssignmentAndOperator {
        public static Sub instance { get; } = new();
        private Sub() { }
        public override string ToString() => nameof(Sub);
    }

    public class Multi : AssignmentAndOperator {
        public static Multi instance { get; } = new();
        private Multi() { }
        public override string ToString() => nameof(Multi);
    }

    public class Div : AssignmentAndOperator {
        public static Div instance { get; } = new();
        private Div() { }
        public override string ToString() => nameof(Div);
    }

    public class Mod : AssignmentAndOperator {
        public static Mod instance { get; } = new();
        private Mod() { }
        public override string ToString() => nameof(Mod);
    }
}