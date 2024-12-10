using System.Collections.Immutable;

namespace Kotlin;

public abstract class Symbol(string name) {
    public string name { get; } = name;
}

public class ClassSymbol(
    string name,
    Dictionary<string, PropertySymbol> properties,
    Dictionary<string, FunctionSymbol> functions
) : Symbol(name) {
    public Dictionary<string, PropertySymbol> properties { get; } = properties;
    public Dictionary<string, FunctionSymbol> functions { get; } = functions;
}

public class FunctionSymbol(
    string name,
    ImmutableList<Parameter> parameters,
    Func<object[], object?> body
) : Symbol(name) {
    public ImmutableList<Parameter> parameters { get; } = parameters;
    public Func<object[], object?> body { get; } = body;

    public object? call(params object[] args) {
        if (args.Length != parameters.Count) {
            throw new Exception($"Function {name} expects {parameters.Count} arguments.");
        }
        
        return body(args);
    }
}

public class PropertySymbol(
    string name,
    Func<object?> getter,
    Func<object, object?> setter
) : Symbol(name) {
    public Func<object?> getter { get; } = getter;
    public Func<object, object?> setter { get; } = setter;
}

public class Parameter(string name, string type) {
    public string name { get; } = name;
    public string type { get; } = type;
}