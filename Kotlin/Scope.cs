namespace Kotlin;

public class Scope(Scope? parent) {
    private Dictionary<string, Symbol> symbols = new();
    public Scope? parent { get; } = parent;

    public void insert(Symbol symbol) {
        if (!symbols.TryAdd(symbol.name, symbol)) {
            throw new Exception($"Symbol {symbol.name} already exists");
        }
    }

    public Symbol? lookup(string name) {
        if (symbols.TryGetValue(name, out var symbol)) {
            return symbol;
        }
        
        return parent?.lookup(name);
    }
}