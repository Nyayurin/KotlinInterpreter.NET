namespace Kotlin.AST;

public abstract class AnnotationUseSiteTarget : AstNode {
    public class Field : AnnotationUseSiteTarget {
        public static Field instance { get; } = new();
        private Field() { }
        public override string ToString() => nameof(Field);
    }

    public class Property : AnnotationUseSiteTarget {
        public static Property instance { get; } = new();
        private Property() { }
        public override string ToString() => nameof(Property);
    }

    public class Get : AnnotationUseSiteTarget {
        public static Get instance { get; } = new();
        private Get() { }
        public override string ToString() => nameof(Get);
    }

    public class Set : AnnotationUseSiteTarget {
        public static Set instance { get; } = new();
        private Set() { }
        public override string ToString() => nameof(Set);
    }

    public class Receiver : AnnotationUseSiteTarget {
        public static Receiver instance { get; } = new();
        private Receiver() { }
        public override string ToString() => nameof(Receiver);
    }

    public class Param : AnnotationUseSiteTarget {
        public static Param instance { get; } = new();
        private Param() { }
        public override string ToString() => nameof(Param);
    }

    public class SetParam : AnnotationUseSiteTarget {
        public static SetParam instance { get; } = new();
        private SetParam() { }
        public override string ToString() => nameof(SetParam);
    }

    public class Delegate : AnnotationUseSiteTarget {
        public static Delegate instance { get; } = new();
        private Delegate() { }
        public override string ToString() => nameof(Delegate);
    }
}