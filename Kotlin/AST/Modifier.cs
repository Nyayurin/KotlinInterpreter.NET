using System.Collections.Immutable;
using System.Text;

namespace Kotlin.AST;

public abstract class Modifier : AstNode;

public abstract class ClassModifier : Modifier {
    public class Enum : ClassModifier {
        public static Enum instance { get; } = new();
        private Enum() { }
        public override string ToString() => "ClassModifier.Enum";
    }

    public class Sealed : ClassModifier {
        public static Sealed instance { get; } = new();
        private Sealed() { }
        public override string ToString() => "ClassModifier.Sealed";
    }

    public class Annotation : ClassModifier {
        public static Annotation instance { get; } = new();
        private Annotation() { }
        public override string ToString() => "ClassModifier.Annotation";
    }

    public class Data : ClassModifier {
        public static Data instance { get; } = new();
        private Data() { }
        public override string ToString() => "ClassModifier.Data";
    }

    public class Inner : ClassModifier {
        public static Inner instance { get; } = new();
        private Inner() { }
        public override string ToString() => "ClassModifier.Inner";
    }

    public class Value : ClassModifier {
        public static Value instance { get; } = new();
        private Value() { }
        public override string ToString() => "ClassModifier.Value";
    }
}

public abstract class MemberModifier : Modifier {
    public class Override : MemberModifier {
        public static Override instance { get; } = new();
        private Override() { }
        public override string ToString() => "MemberModifier.Override";
    }

    public class LateInit : MemberModifier {
        public static LateInit instance { get; } = new();
        private LateInit() { }
        public override string ToString() => "MemberModifier.LateInit";
    }
}

public abstract class VisibleModifier : Modifier {
    public class Public : VisibleModifier {
        public static Public instance { get; } = new();
        private Public() { }
        public override string ToString() => "VisibleModifier.Public";
    }

    public class Private : VisibleModifier {
        public static Private instance { get; } = new();
        private Private() { }
        public override string ToString() => "VisibleModifier.Private";
    }

    public class Internal : VisibleModifier {
        public static Internal instance { get; } = new();
        private Internal() { }
        public override string ToString() => "VisibleModifier.Internal";
    }

    public class Protected : VisibleModifier {
        public static Protected instance { get; } = new();
        private Protected() { }
        public override string ToString() => "VisibleModifier.Protected";
    }
}

public abstract class FunctionModifier : Modifier {
    public class TailRec : FunctionModifier {
        public static TailRec instance { get; } = new();
        private TailRec() { }
        public override string ToString() => "FunctionModifier.TailRec";
    }

    public class Operator : FunctionModifier {
        public static Operator instance { get; } = new();
        private Operator() { }
        public override string ToString() => "FunctionModifier.Operator";
    }

    public class Infix : FunctionModifier {
        public static Infix instance { get; } = new();
        private Infix() { }
        public override string ToString() => "FunctionModifier.Infix";
    }

    public class Inline : FunctionModifier {
        public static Inline instance { get; } = new();
        private Inline() { }
        public override string ToString() => "FunctionModifier.Inline";
    }

    public class External : FunctionModifier {
        public static External instance { get; } = new();
        private External() { }
        public override string ToString() => "FunctionModifier.External";
    }

    public class Suspend : FunctionModifier {
        public static Suspend instance { get; } = new();
        private Suspend() { }
        public override string ToString() => "FunctionModifier.Suspend";
    }
}

public abstract class PropertyModifier : Modifier {
    public class Const : PropertyModifier {
        public static Const instance { get; } = new();
        private Const() { }
        public override string ToString() => "PropertyModifier.Const";
    }
}

public abstract class InheritanceModifier : Modifier {
    public class Abstract : InheritanceModifier {
        public static Abstract instance { get; } = new();
        private Abstract() { }
        public override string ToString() => "InheritanceModifier.Abstract";
    }

    public class Final : InheritanceModifier {
        public static Final instance { get; } = new();
        private Final() { }
        public override string ToString() => "InheritanceModifier.Final";
    }

    public class Open : InheritanceModifier {
        public static Open instance { get; } = new();
        private Open() { }
        public override string ToString() => "InheritanceModifier.Open";
    }
}

public abstract class ParameterModifier : Modifier {
    public class Vararg : ParameterModifier {
        public static Vararg instance { get; } = new();
        private Vararg() { }
        public override string ToString() => "ParameterModifier.Vararg";
    }

    public class NoInline : ParameterModifier {
        public static NoInline instance { get; } = new();
        private NoInline() { }
        public override string ToString() => "ParameterModifier.NoInline";
    }

    public class CrossInline : ParameterModifier {
        public static CrossInline instance { get; } = new();
        private CrossInline() { }
        public override string ToString() => "ParameterModifier.CrossInline";
    }
}

public abstract class PlatformModifier : Modifier {
    public class Expect : PlatformModifier {
        public static Expect instance { get; } = new();
        private Expect() { }
        public override string ToString() => "PlatformModifier.Expect";
    }

    public class Actual : PlatformModifier {
        public static Actual instance { get; } = new();
        private Actual() { }
        public override string ToString() => "PlatformModifier.Actual";
    }
}