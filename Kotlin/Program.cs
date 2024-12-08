using System.Text;
using Antlr4.Runtime;

namespace Kotlin;

public static class Program {
    public static void Main(string[] args) {
        var stream = CharStreams.fromPath(args[0], Encoding.UTF8);
        var lexer = new KotlinLexer(stream);
        var tokens = new CommonTokenStream(lexer);
        var parser = new KotlinParser(tokens);
        var file = parser.kotlinFile();
        var visitor = new KotlinParserBaseVisitor();
        var root = visitor.visitKotlinFile(file);
        // Console.WriteLine(root);
        var interpreter = new Interpreter();
        interpreter.run(root);
    }
}