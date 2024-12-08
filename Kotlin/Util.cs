using System.Collections.Immutable;
using System.Text;

namespace Kotlin;

public static class Util {
    public static StringBuilder appendProperty(this StringBuilder builder, string name, object value) => builder
        .Append(name).Append(": ").Append(value);

    public static StringBuilder appendList<T>(this StringBuilder builder, string name, ImmutableList<T> list) => builder
        .Append(name).Append(": [").Append(string.Join(", ", list.Select(o => o?.ToString()))).Append(']');
}