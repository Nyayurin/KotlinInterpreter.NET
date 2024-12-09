using System.Collections.Immutable;
using System.Text;

namespace Kotlin;

public static class Util {
    public static StringBuilder appendProperty(this StringBuilder builder, string name, object? value) {
        if (value?.GetType().IsGenericType == true &&
            value.GetType().GetGenericTypeDefinition() == typeof(ImmutableList<>)) {
            builder.Append(name).Append(": [");
            var remove = false;
            foreach (var item in (dynamic)value) {
                remove = true;
                builder.Append((object)item ?? "null").Append(", ");
            }

            if (remove) {
                builder.Remove(builder.Length - 2, 2);
            }

            return builder.Append(']');
        }

        return builder.Append(name).Append(": ").Append(value ?? "null");
    }
}