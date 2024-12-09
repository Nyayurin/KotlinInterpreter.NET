using System.Collections.Immutable;
using System.Globalization;
using Antlr4.Runtime.Tree;
using Kotlin.AST;
using Kotlin.AST.Expression;
using Kotlin.AST.Expression.Primary;
using BinaryExpression = Kotlin.AST.Expression.BinaryExpression;
using Expression = Kotlin.AST.Expression.Expression;

namespace Kotlin;

public class Visitor : KotlinParserBaseVisitor<AstNode> {
    public override AstNode VisitKotlinFile(KotlinParser.KotlinFileContext context) {
        return new KotlinFile(
            context.packageHeader().identifier()?.GetText(),
            visitImports(context.importList()),
            visitTopLevelDeclarations(context.topLevelObject())
        );
    }

    public override AstNode VisitScript(KotlinParser.ScriptContext context) {
        return new Script(
            context.packageHeader().identifier()?.GetText(),
            visitImports(context.importList()),
            visitStatements(context.statement())
        );
    }

    private ImmutableList<ImportHeader> visitImports(KotlinParser.ImportListContext context) {
        return context.importHeader()
            .Select(it => it.Accept(this))
            .Cast<ImportHeader>()
            .ToImmutableList();
    }

    private ImmutableList<Declaration> visitTopLevelDeclarations(KotlinParser.TopLevelObjectContext[] context) {
        return context
            .Select(it => it.Accept(this))
            .Cast<Declaration>()
            .ToImmutableList();
    }

    private ImmutableList<Statement> visitStatements(KotlinParser.StatementContext[] context) {
        return context
            .Select(it => it.Accept(this))
            .Cast<Statement>()
            .ToImmutableList();
    }

    public override AstNode VisitImportHeader(KotlinParser.ImportHeaderContext context) {
        if (context.importAlias() != null) {
            return new ImportHeader.Alias(
                left: context.identifier().GetText(),
                right: context.importAlias().simpleIdentifier().GetText()
            );
        }

        return new ImportHeader.Identifier(context.identifier().GetText() + (context.DOT() != null ? ".*" : ""));
    }

    public override AstNode VisitTypeAlias(KotlinParser.TypeAliasContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitDeclaration(KotlinParser.DeclarationContext context) {
        if (context.functionDeclaration() != null) {
            return context.functionDeclaration().Accept(this);
        }

        if (context.propertyDeclaration() != null) {
            return context.propertyDeclaration().Accept(this);
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitClassDeclaration(KotlinParser.ClassDeclarationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitPrimaryConstructor(KotlinParser.PrimaryConstructorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitClassBody(KotlinParser.ClassBodyContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitClassParameters(KotlinParser.ClassParametersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitClassParameter(KotlinParser.ClassParameterContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitDelegationSpecifiers(KotlinParser.DelegationSpecifiersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitDelegationSpecifier(KotlinParser.DelegationSpecifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitConstructorInvocation(KotlinParser.ConstructorInvocationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAnnotatedDelegationSpecifier(
        KotlinParser.AnnotatedDelegationSpecifierContext context
    ) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitExplicitDelegation(KotlinParser.ExplicitDelegationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeParameters(KotlinParser.TypeParametersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeParameter(KotlinParser.TypeParameterContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeConstraints(KotlinParser.TypeConstraintsContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeConstraint(KotlinParser.TypeConstraintContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitClassMemberDeclarations(KotlinParser.ClassMemberDeclarationsContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitClassMemberDeclaration(KotlinParser.ClassMemberDeclarationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAnonymousInitializer(KotlinParser.AnonymousInitializerContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitCompanionObject(KotlinParser.CompanionObjectContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFunctionValueParameters(KotlinParser.FunctionValueParametersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFunctionValueParameter(KotlinParser.FunctionValueParameterContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFunctionDeclaration(KotlinParser.FunctionDeclarationContext context) {
        return new FunctionDeclaration(
            name: context.simpleIdentifier().GetText(),
            valueParameters: new List<FunctionValueParameter>().ToImmutableList(),
            type: null,
            body: (Block)context.functionBody().Accept(this)
        );
    }

    public override AstNode VisitFunctionBody(KotlinParser.FunctionBodyContext context) {
        if (context.block() != null) {
            return context.block().Accept(this);
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitVariableDeclaration(KotlinParser.VariableDeclarationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitMultiVariableDeclaration(KotlinParser.MultiVariableDeclarationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitPropertyDeclaration(KotlinParser.PropertyDeclarationContext context) {
        if (context.variableDeclaration() != null) {
            return new PropertyDeclaration(
                mutable: context.VAR() != null,
                name: context.variableDeclaration().simpleIdentifier().GetText(),
                type: null,
                expression: (Expression)context.expression().Accept(this)
            );
        }

        throw new Exception("Unknown context");
    }

    private ImmutableList<string> visitVariableDeclarations(params KotlinParser.VariableDeclarationContext[] context) {
        return context
            .Select(it => it.simpleIdentifier().GetText())
            .ToImmutableList();
    }

    public override AstNode VisitPropertyDelegate(KotlinParser.PropertyDelegateContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitGetter(KotlinParser.GetterContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitSetter(KotlinParser.SetterContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitParametersWithOptionalType(KotlinParser.ParametersWithOptionalTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFunctionValueParameterWithOptionalType(
        KotlinParser.FunctionValueParameterWithOptionalTypeContext context
    ) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitParameterWithOptionalType(KotlinParser.ParameterWithOptionalTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitParameter(KotlinParser.ParameterContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitObjectDeclaration(KotlinParser.ObjectDeclarationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitSecondaryConstructor(KotlinParser.SecondaryConstructorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitConstructorDelegationCall(KotlinParser.ConstructorDelegationCallContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitEnumClassBody(KotlinParser.EnumClassBodyContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitEnumEntries(KotlinParser.EnumEntriesContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitEnumEntry(KotlinParser.EnumEntryContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitType(KotlinParser.TypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeReference(KotlinParser.TypeReferenceContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitNullableType(KotlinParser.NullableTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitQuest(KotlinParser.QuestContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitUserType(KotlinParser.UserTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitSimpleUserType(KotlinParser.SimpleUserTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeProjection(KotlinParser.TypeProjectionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeProjectionModifiers(KotlinParser.TypeProjectionModifiersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeProjectionModifier(KotlinParser.TypeProjectionModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFunctionType(KotlinParser.FunctionTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFunctionTypeParameters(KotlinParser.FunctionTypeParametersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitParenthesizedType(KotlinParser.ParenthesizedTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitReceiverType(KotlinParser.ReceiverTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitParenthesizedUserType(KotlinParser.ParenthesizedUserTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitDefinitelyNonNullableType(KotlinParser.DefinitelyNonNullableTypeContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitStatements(KotlinParser.StatementsContext context) {
        return new Statements(context.statement()
            .Select(it => (Statement)it.Accept(this))
            .ToImmutableList());
    }

    public override AstNode VisitStatement(KotlinParser.StatementContext context) {
        if (context.declaration() != null) {
            return new DeclarationStatement((Declaration)context.declaration().Accept(this));
        }

        if (context.assignment() != null) {
            return new AssignableExpression((PrefixUnaryExpression)context.assignment().Accept(this));
        }

        if (context.loopStatement() != null) {
            return context.loopStatement().Accept(this);
        }

        if (context.expression() != null) {
            return new ExpressionStatement((Expression)context.expression().Accept(this));
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitLabel(KotlinParser.LabelContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitControlStructureBody(KotlinParser.ControlStructureBodyContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitBlock(KotlinParser.BlockContext context) {
        return new Block((Statements)context.statements().Accept(this));
    }

    public override AstNode VisitLoopStatement(KotlinParser.LoopStatementContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitForStatement(KotlinParser.ForStatementContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitWhileStatement(KotlinParser.WhileStatementContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitDoWhileStatement(KotlinParser.DoWhileStatementContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAssignment(KotlinParser.AssignmentContext context) {
        if (context.directlyAssignableExpression() != null) {
            return new DirectlyAssignmentStatement(
                left: (DirectlyAssignableExpression)context.directlyAssignableExpression().Accept(this),
                expression: (Expression)context.expression().Accept(this)
            );
        }

        return new AssignmentStatement(
            left: (AssignableExpression)context.assignableExpression().Accept(this),
            op: (AssignmentAndOperator)context.assignmentAndOperator().Accept(this),
            expression: (Expression)context.expression().Accept(this)
        );
    }

    public override AstNode VisitSemi(KotlinParser.SemiContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitSemis(KotlinParser.SemisContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitExpression(KotlinParser.ExpressionContext context) {
        return context.disjunction().Accept(this);
    }

    public override AstNode VisitDisjunction(KotlinParser.DisjunctionContext context) {
        var sub = context.conjunction();

        return sub.Skip(1)
            .Aggregate((Expression)sub.First().Accept(this), (current, subContext) =>
                new BinaryExpression("||", current, (Expression)subContext.Accept(this))
            );
    }

    public override AstNode VisitConjunction(KotlinParser.ConjunctionContext context) {
        var sub = context.equality();

        return sub.Skip(1)
            .Aggregate((Expression)sub.First().Accept(this), (current, subContext) =>
                new BinaryExpression("&&", current, (Expression)subContext.Accept(this))
            );
    }

    public override AstNode VisitEquality(KotlinParser.EqualityContext context) {
        var sub = context.comparison().Skip(1).ToList();
        var expression = (Expression)context.comparison(0).Accept(this);

        for (var i = 0; i < sub.Count; i++) {
            expression = new BinaryExpression(
                op: context.equalityOperator(i).GetText(),
                left: expression,
                right: (Expression)sub[i].Accept(this)
            );
        }

        return expression;
    }

    public override AstNode VisitComparison(KotlinParser.ComparisonContext context) {
        var sub = context.genericCallLikeComparison().Skip(1).ToList();
        var expression = (Expression)context.genericCallLikeComparison(0).Accept(this);

        for (var i = 0; i < sub.Count; i++) {
            expression = new BinaryExpression(
                op: context.comparisonOperator(i).GetText(),
                left: expression,
                right: (Expression)sub[i].Accept(this)
            );
        }

        return expression;
    }

    public override AstNode VisitGenericCallLikeComparison(KotlinParser.GenericCallLikeComparisonContext context) {
        return context.callSuffix()
            .Aggregate((Expression)context.infixOperation().Accept(this), (current, callSuffixContext) =>
                new PostfixUnaryExpression((PostfixUnarySuffix)callSuffixContext.Accept(this), current)
            );
    }

    public override AstNode VisitInfixOperation(KotlinParser.InfixOperationContext context) {
        var sub = context.children.Skip(1).SkipWhile(tree => tree is ITerminalNode).ToList();
        var expression = (Expression)context.elvisExpression(0).Accept(this);

        for (var i = 0; i < sub.Count / 2; i++) {
            var op = sub[i * 2];
            expression = op switch {
                KotlinParser.InOperatorContext => new InfixOperationExpression.InOperator(left: expression,
                    right: (Expression)sub[i * 2 + 1].Accept(this)),
                KotlinParser.IsOperatorContext => new InfixOperationExpression.IsOperator(expression: expression,
                    type: (Expression)sub[i * 2 + 1].Accept(this)),
                _ => expression
            };
        }

        return expression;
    }

    public override AstNode VisitElvisExpression(KotlinParser.ElvisExpressionContext context) {
        var sub = context.infixFunctionCall();

        return sub.Skip(1)
            .Aggregate((Expression)sub.First().Accept(this), (current, subContext) =>
                new BinaryExpression("?:", current, (Expression)subContext.Accept(this))
            );
    }

    public override AstNode VisitElvis(KotlinParser.ElvisContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitInfixFunctionCall(KotlinParser.InfixFunctionCallContext context) {
        var sub = context.rangeExpression().Skip(1).ToList();
        var expression = (Expression)context.rangeExpression(0).Accept(this);

        for (var i = 0; i < sub.Count; i++) {
            expression = new InfixFunctionCallExpression(
                identifier: context.simpleIdentifier(i).GetText(),
                left: expression,
                right: (Expression)sub[i].Accept(this)
            );
        }

        return expression;
    }

    public override AstNode VisitRangeExpression(KotlinParser.RangeExpressionContext context) {
        var sub = context.additiveExpression().Skip(1).ToList();
        var expression = (Expression)context.additiveExpression(0).Accept(this);
        var op = context.children
            .Where(tree => tree is ITerminalNode node && node.Symbol.Type != KotlinParser.NL).ToList();

        for (var i = 0; i < sub.Count; i++) {
            expression = new BinaryExpression(
                op: op[i].GetText(),
                left: expression,
                right: (Expression)sub[i].Accept(this)
            );
        }

        return expression;
    }

    public override AstNode VisitAdditiveExpression(KotlinParser.AdditiveExpressionContext context) {
        var sub = context.multiplicativeExpression().Skip(1).ToList();
        var expression = (Expression)context.multiplicativeExpression(0).Accept(this);

        for (var i = 0; i < sub.Count; i++) {
            expression = new BinaryExpression(
                op: context.additiveOperator(i).GetText(),
                left: expression,
                right: (Expression)sub[i].Accept(this)
            );
        }

        return expression;
    }

    public override AstNode VisitMultiplicativeExpression(KotlinParser.MultiplicativeExpressionContext context) {
        var sub = context.asExpression().Skip(1).ToList();
        var expression = (Expression)context.asExpression(0).Accept(this);

        for (var i = 0; i < sub.Count; i++) {
            expression = new BinaryExpression(
                op: context.multiplicativeOperator(i).GetText(),
                left: expression,
                right: (Expression)sub[i].Accept(this)
            );
        }

        return expression;
    }

    public override AstNode VisitAsExpression(KotlinParser.AsExpressionContext context) {
        var sub = context.asOperator();
        var expression = (Expression)context.prefixUnaryExpression().Accept(this);

        for (var i = 0; i < sub.Length; i++) {
            if (sub[i].AS() != null) {
                expression = new AsExpression.As(expression, (Expression)context.type(i).Accept(this));
            }

            if (sub[i].AS_SAFE() != null) {
                expression = new AsExpression.AsSafe(expression, (Expression)context.type(i).Accept(this));
            }
        }

        return expression;
    }

    public override AstNode VisitPrefixUnaryExpression(KotlinParser.PrefixUnaryExpressionContext context) {
        return context.unaryPrefix()
            .Aggregate((Expression)context.postfixUnaryExpression().Accept(this), (current, subContext) =>
                new PrefixUnaryExpression((UnaryPrefix)subContext.Accept(this), current)
            );
    }

    public override AstNode VisitUnaryPrefix(KotlinParser.UnaryPrefixContext context) {
        if (context.annotation() != null) {
            return new UnaryPrefix.Annotation();
        }

        if (context.label() != null) {
            return new UnaryPrefix.Label();
        }

        if (context.prefixUnaryOperator() != null) {
            return new UnaryPrefix.Operator(context.prefixUnaryOperator().GetText());
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitPostfixUnaryExpression(KotlinParser.PostfixUnaryExpressionContext context) {
        return context.postfixUnarySuffix()
            .Aggregate((Expression)context.primaryExpression().Accept(this), (current, subContext) =>
                new PostfixUnaryExpression((PostfixUnarySuffix)subContext.Accept(this), current)
            );
    }

    public override AstNode VisitPostfixUnarySuffix(KotlinParser.PostfixUnarySuffixContext context) {
        if (context.postfixUnaryOperator() != null) {
            return new PostfixUnarySuffix.Operator();
        }

        if (context.typeArguments() != null) {
            return new PostfixUnarySuffix.TypeArguments();
        }

        if (context.callSuffix() != null) {
            return context.callSuffix().Accept(this);
        }

        if (context.indexingSuffix() != null) {
            return new PostfixUnarySuffix.IndexingSuffix();
        }

        if (context.navigationSuffix() != null) {
            return new PostfixUnarySuffix.NavigationSuffix();
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitDirectlyAssignableExpression(
        KotlinParser.DirectlyAssignableExpressionContext context
    ) {
        if (context.postfixUnaryExpression() != null) {
            return new DirectlyAssignableExpression.Suffix(
                expression: (PostfixUnaryExpression)context.postfixUnaryExpression().Accept(this),
                assignableSuffix: (AssignableSuffix)context.assignableSuffix().Accept(this)
            );
        }

        if (context.simpleIdentifier() != null) {
            return new DirectlyAssignableExpression.Identifier(context.simpleIdentifier().GetText());
        }

        if (context.parenthesizedDirectlyAssignableExpression() != null) {
            return context.parenthesizedDirectlyAssignableExpression().directlyAssignableExpression().Accept(this);
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitParenthesizedDirectlyAssignableExpression(
        KotlinParser.ParenthesizedDirectlyAssignableExpressionContext context
    ) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAssignableExpression(KotlinParser.AssignableExpressionContext context) {
        throw new Exception("Unknown context");
    }

    public AstNode visitParenthesizedAssignableExpression(
        KotlinParser.ParenthesizedAssignableExpressionContext context
    ) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAssignableSuffix(KotlinParser.AssignableSuffixContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitIndexingSuffix(KotlinParser.IndexingSuffixContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitNavigationSuffix(KotlinParser.NavigationSuffixContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitCallSuffix(KotlinParser.CallSuffixContext context) {
        return new PostfixUnarySuffix.CallSuffix((ValueArguments)context.valueArguments().Accept(this));
    }

    public override AstNode VisitAnnotatedLambda(KotlinParser.AnnotatedLambdaContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeArguments(KotlinParser.TypeArgumentsContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitValueArguments(KotlinParser.ValueArgumentsContext context) {
        return new ValueArguments(context.valueArgument()
            .Select(it => (ValueArgument)it.Accept(this))
            .ToImmutableList()
        );
    }

    public override AstNode VisitValueArgument(KotlinParser.ValueArgumentContext context) {
        return new ValueArgument((Expression)context.expression().Accept(this));
    }

    public override AstNode VisitPrimaryExpression(KotlinParser.PrimaryExpressionContext context) {
        if (context.parenthesizedExpression() != null) {
            return context.parenthesizedExpression().Accept(this);
        }

        if (context.simpleIdentifier() != null) {
            return new Identifier(context.simpleIdentifier().GetText());
        }

        if (context.literalConstant() != null) {
            return context.literalConstant().Accept(this);
        }

        if (context.stringLiteral() != null) {
            return context.stringLiteral().Accept(this);
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitParenthesizedExpression(KotlinParser.ParenthesizedExpressionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitCollectionLiteral(KotlinParser.CollectionLiteralContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitLiteralConstant(KotlinParser.LiteralConstantContext context) {
        if (context.BooleanLiteral() != null) {
            return new BooleanLiteral(bool.Parse(context.BooleanLiteral().GetText()));
        }

        if (context.IntegerLiteral() != null) {
            return new IntegerLiteral(int.Parse(context.IntegerLiteral().GetText()));
        }

        if (context.HexLiteral() != null) {
            return new LongLiteral(long.Parse(context.HexLiteral().GetText(), NumberStyles.HexNumber));
        }

        if (context.BinLiteral() != null) {
            return new LongLiteral(long.Parse(context.BinLiteral().GetText(), NumberStyles.BinaryNumber));
        }

        if (context.CharacterLiteral() != null) {
            return new CharacterLiteral(char.Parse(context.CharacterLiteral().GetText()));
        }

        if (context.RealLiteral() != null) {
            return new RealLiteral(double.Parse(context.RealLiteral().GetText()));
        }

        if (context.NullLiteral() != null) {
            return NullLiteral.INSTANCE;
        }

        if (context.LongLiteral() != null) {
            return new LongLiteral(long.Parse(context.LongLiteral().GetText()));
        }

        if (context.UnsignedLiteral() != null) {
            return new UnsignedLiteral(ulong.Parse(context.UnsignedLiteral().GetText()));
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitStringLiteral(KotlinParser.StringLiteralContext context) {
        if (context.lineStringLiteral() != null) {
            return context.lineStringLiteral().Accept(this);
        }

        if (context.multiLineStringLiteral() != null) {
            return context.multiLineStringLiteral().Accept(this);
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitLineStringLiteral(KotlinParser.LineStringLiteralContext context) {
        return new StringLiteral(context.children.Skip(1).SkipLast(1)
            .Select(tree => (StringLiteral.Sub)tree.Accept(this))
            .ToImmutableList());
    }

    public override AstNode VisitMultiLineStringLiteral(KotlinParser.MultiLineStringLiteralContext context) {
        return new StringLiteral(context.children.Skip(1).SkipLast(1)
            .Select(tree => {
                if (tree is ITerminalNode node && node.Symbol.Type == KotlinParser.MultiLineStringQuote) {
                    return new StringLiteral.Sub.Content("\"");
                }

                return (StringLiteral.Sub)tree.Accept(this);
            })
            .ToImmutableList());
    }

    public override AstNode VisitLineStringContent(KotlinParser.LineStringContentContext context) {
        if (context.LineStrText() != null) {
            return new StringLiteral.Sub.Content(context.LineStrText().GetText());
        }

        if (context.LineStrEscapedChar() != null) {
            var escapedChar = context.LineStrEscapedChar().GetText();
            if (escapedChar.StartsWith("\\u")) {
                return new StringLiteral.Sub.Content(((char)ushort.Parse(escapedChar[2..])).ToString());
            }

            return new StringLiteral.Sub.Content(escapedChar switch {
                "\\t" => "\t",
                "\\b" => "\b",
                "\\r" => "\r",
                "\\n" => "\n",
                "\\'" => "'",
                "\\\"" => "\"",
                @"\\" => "\\",
                "\\$" => "$",
                _ => throw new Exception()
            });
        }

        if (context.LineStrRef() != null) {
            return new StringLiteral.Sub.Expression(new Identifier(context.LineStrRef().GetText()[1..]));
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitLineStringExpression(KotlinParser.LineStringExpressionContext context) {
        return new StringLiteral.Sub.Expression((Expression)context.expression().Accept(this));
    }

    public override AstNode VisitMultiLineStringContent(KotlinParser.MultiLineStringContentContext context) {
        if (context.MultiLineStrText() != null) {
            return new StringLiteral.Sub.Content(context.MultiLineStrText().GetText());
        }

        if (context.MultiLineStrRef() != null) {
            return new StringLiteral.Sub.Expression(new Identifier(context.MultiLineStrRef().GetText()[1..]));
        }

        throw new Exception("Unknown context");
    }

    public override AstNode VisitMultiLineStringExpression(KotlinParser.MultiLineStringExpressionContext context) {
        return new StringLiteral.Sub.Expression((Expression)context.expression().Accept(this));
    }

    public override AstNode VisitLambdaLiteral(KotlinParser.LambdaLiteralContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitLambdaParameters(KotlinParser.LambdaParametersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitLambdaParameter(KotlinParser.LambdaParameterContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAnonymousFunction(KotlinParser.AnonymousFunctionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFunctionLiteral(KotlinParser.FunctionLiteralContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitObjectLiteral(KotlinParser.ObjectLiteralContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitThisExpression(KotlinParser.ThisExpressionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitSuperExpression(KotlinParser.SuperExpressionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitIfExpression(KotlinParser.IfExpressionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitWhenSubject(KotlinParser.WhenSubjectContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitWhenExpression(KotlinParser.WhenExpressionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitWhenEntry(KotlinParser.WhenEntryContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitWhenCondition(KotlinParser.WhenConditionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitRangeTest(KotlinParser.RangeTestContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeTest(KotlinParser.TypeTestContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTryExpression(KotlinParser.TryExpressionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitCatchBlock(KotlinParser.CatchBlockContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFinallyBlock(KotlinParser.FinallyBlockContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitJumpExpression(KotlinParser.JumpExpressionContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitCallableReference(KotlinParser.CallableReferenceContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAssignmentAndOperator(KotlinParser.AssignmentAndOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitEqualityOperator(KotlinParser.EqualityOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitComparisonOperator(KotlinParser.ComparisonOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitInOperator(KotlinParser.InOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitIsOperator(KotlinParser.IsOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAdditiveOperator(KotlinParser.AdditiveOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitMultiplicativeOperator(KotlinParser.MultiplicativeOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAsOperator(KotlinParser.AsOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitPrefixUnaryOperator(KotlinParser.PrefixUnaryOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitPostfixUnaryOperator(KotlinParser.PostfixUnaryOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitExcl(KotlinParser.ExclContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitMemberAccessOperator(KotlinParser.MemberAccessOperatorContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitSafeNav(KotlinParser.SafeNavContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitModifiers(KotlinParser.ModifiersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitParameterModifiers(KotlinParser.ParameterModifiersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitModifier(KotlinParser.ModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeModifiers(KotlinParser.TypeModifiersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeModifier(KotlinParser.TypeModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitClassModifier(KotlinParser.ClassModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitMemberModifier(KotlinParser.MemberModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitVisibilityModifier(KotlinParser.VisibilityModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitVarianceModifier(KotlinParser.VarianceModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeParameterModifiers(KotlinParser.TypeParameterModifiersContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitTypeParameterModifier(KotlinParser.TypeParameterModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitFunctionModifier(KotlinParser.FunctionModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitPropertyModifier(KotlinParser.PropertyModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitInheritanceModifier(KotlinParser.InheritanceModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitParameterModifier(KotlinParser.ParameterModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitReificationModifier(KotlinParser.ReificationModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitPlatformModifier(KotlinParser.PlatformModifierContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAnnotation(KotlinParser.AnnotationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitSingleAnnotation(KotlinParser.SingleAnnotationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitMultiAnnotation(KotlinParser.MultiAnnotationContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitAnnotationUseSiteTarget(KotlinParser.AnnotationUseSiteTargetContext context) {
        throw new Exception("Unknown context");
    }

    public override AstNode VisitSimpleIdentifier(KotlinParser.SimpleIdentifierContext context) {
        return new Identifier(context.GetText());
    }

    public override AstNode VisitIdentifier(KotlinParser.IdentifierContext context) {
        throw new Exception("Unknown context");
    }
}