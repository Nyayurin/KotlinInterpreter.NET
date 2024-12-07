﻿using System.Globalization;
using System.Security.AccessControl;
using Antlr4.Runtime.Tree;
using Kotlin.AST;
using Kotlin.AST.Expression;
using Kotlin.AST.Expression.Primary;

namespace Kotlin;

public class KotlinParserBaseVisitor : AbstractParseTreeVisitor<AstNode>, IKotlinParserVisitor<AstNode> {
    public AstNode visitKotlinFile(KotlinParser.KotlinFileContext context) {
        return new KotlinFile(context.topLevelObject()
            .Select(it => (Declaration)it.Accept(this))
            .ToList());
    }

    public AstNode visitScript(KotlinParser.ScriptContext context) {
        return VisitChildren(context);
    }

    public AstNode visitShebangLine(KotlinParser.ShebangLineContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFileAnnotation(KotlinParser.FileAnnotationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitPackageHeader(KotlinParser.PackageHeaderContext context) {
        return VisitChildren(context);
    }

    public AstNode visitImportList(KotlinParser.ImportListContext context) {
        return VisitChildren(context);
    }

    public AstNode visitImportHeader(KotlinParser.ImportHeaderContext context) {
        return VisitChildren(context);
    }

    public AstNode visitImportAlias(KotlinParser.ImportAliasContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTopLevelObject(KotlinParser.TopLevelObjectContext context) {
        return context.declaration().Accept(this);
    }

    public AstNode visitTypeAlias(KotlinParser.TypeAliasContext context) {
        return VisitChildren(context);
    }

    public AstNode visitDeclaration(KotlinParser.DeclarationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitClassDeclaration(KotlinParser.ClassDeclarationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitPrimaryConstructor(KotlinParser.PrimaryConstructorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitClassBody(KotlinParser.ClassBodyContext context) {
        return VisitChildren(context);
    }

    public AstNode visitClassParameters(KotlinParser.ClassParametersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitClassParameter(KotlinParser.ClassParameterContext context) {
        return VisitChildren(context);
    }

    public AstNode visitDelegationSpecifiers(KotlinParser.DelegationSpecifiersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitDelegationSpecifier(KotlinParser.DelegationSpecifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitConstructorInvocation(KotlinParser.ConstructorInvocationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAnnotatedDelegationSpecifier(KotlinParser.AnnotatedDelegationSpecifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitExplicitDelegation(KotlinParser.ExplicitDelegationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeParameters(KotlinParser.TypeParametersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeParameter(KotlinParser.TypeParameterContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeConstraints(KotlinParser.TypeConstraintsContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeConstraint(KotlinParser.TypeConstraintContext context) {
        return VisitChildren(context);
    }

    public AstNode visitClassMemberDeclarations(KotlinParser.ClassMemberDeclarationsContext context) {
        return VisitChildren(context);
    }

    public AstNode visitClassMemberDeclaration(KotlinParser.ClassMemberDeclarationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAnonymousInitializer(KotlinParser.AnonymousInitializerContext context) {
        return VisitChildren(context);
    }

    public AstNode visitCompanionObject(KotlinParser.CompanionObjectContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFunctionValueParameters(KotlinParser.FunctionValueParametersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFunctionValueParameter(KotlinParser.FunctionValueParameterContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFunctionDeclaration(KotlinParser.FunctionDeclarationContext context) {
        return new FunctionDeclaration(
            name: context.simpleIdentifier().GetText(),
            body: (Block)context.functionBody().Accept(this)
        );
    }

    public AstNode visitFunctionBody(KotlinParser.FunctionBodyContext context) {
        if (context.block() != null) {
            return context.block().Accept(this);
        }

        return VisitChildren(context);
    }

    public AstNode visitVariableDeclaration(KotlinParser.VariableDeclarationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitMultiVariableDeclaration(KotlinParser.MultiVariableDeclarationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitPropertyDeclaration(KotlinParser.PropertyDeclarationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitPropertyDelegate(KotlinParser.PropertyDelegateContext context) {
        return VisitChildren(context);
    }

    public AstNode visitGetter(KotlinParser.GetterContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSetter(KotlinParser.SetterContext context) {
        return VisitChildren(context);
    }

    public AstNode visitParametersWithOptionalType(KotlinParser.ParametersWithOptionalTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFunctionValueParameterWithOptionalType(
        KotlinParser.FunctionValueParameterWithOptionalTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitParameterWithOptionalType(KotlinParser.ParameterWithOptionalTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitParameter(KotlinParser.ParameterContext context) {
        return VisitChildren(context);
    }

    public AstNode visitObjectDeclaration(KotlinParser.ObjectDeclarationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSecondaryConstructor(KotlinParser.SecondaryConstructorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitConstructorDelegationCall(KotlinParser.ConstructorDelegationCallContext context) {
        return VisitChildren(context);
    }

    public AstNode visitEnumClassBody(KotlinParser.EnumClassBodyContext context) {
        return VisitChildren(context);
    }

    public AstNode visitEnumEntries(KotlinParser.EnumEntriesContext context) {
        return VisitChildren(context);
    }

    public AstNode visitEnumEntry(KotlinParser.EnumEntryContext context) {
        return VisitChildren(context);
    }

    public AstNode visitType(KotlinParser.TypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeReference(KotlinParser.TypeReferenceContext context) {
        return VisitChildren(context);
    }

    public AstNode visitNullableType(KotlinParser.NullableTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitQuest(KotlinParser.QuestContext context) {
        return VisitChildren(context);
    }

    public AstNode visitUserType(KotlinParser.UserTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSimpleUserType(KotlinParser.SimpleUserTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeProjection(KotlinParser.TypeProjectionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeProjectionModifiers(KotlinParser.TypeProjectionModifiersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeProjectionModifier(KotlinParser.TypeProjectionModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFunctionType(KotlinParser.FunctionTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFunctionTypeParameters(KotlinParser.FunctionTypeParametersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitParenthesizedType(KotlinParser.ParenthesizedTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitReceiverType(KotlinParser.ReceiverTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitParenthesizedUserType(KotlinParser.ParenthesizedUserTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitDefinitelyNonNullableType(KotlinParser.DefinitelyNonNullableTypeContext context) {
        return VisitChildren(context);
    }

    public AstNode visitStatements(KotlinParser.StatementsContext context) {
        return new Statements(context.statement()
            .Select(it => (Statement)it.Accept(this))
            .ToList());
    }

    public AstNode visitStatement(KotlinParser.StatementContext context) {
        if (context.expression() != null) {
            return new ExpressionStatement((Expression)context.expression().Accept(this));
        }

        return VisitChildren(context);
    }

    public AstNode visitLabel(KotlinParser.LabelContext context) {
        return VisitChildren(context);
    }

    public AstNode visitControlStructureBody(KotlinParser.ControlStructureBodyContext context) {
        return VisitChildren(context);
    }

    public AstNode visitBlock(KotlinParser.BlockContext context) {
        return new Block((Statements)context.statements().Accept(this));
    }

    public AstNode visitLoopStatement(KotlinParser.LoopStatementContext context) {
        return VisitChildren(context);
    }

    public AstNode visitForStatement(KotlinParser.ForStatementContext context) {
        return VisitChildren(context);
    }

    public AstNode visitWhileStatement(KotlinParser.WhileStatementContext context) {
        return VisitChildren(context);
    }

    public AstNode visitDoWhileStatement(KotlinParser.DoWhileStatementContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAssignment(KotlinParser.AssignmentContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSemi(KotlinParser.SemiContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSemis(KotlinParser.SemisContext context) {
        return VisitChildren(context);
    }

    public AstNode visitExpression(KotlinParser.ExpressionContext context) {
        return context.disjunction().Accept(this);
    }

    public AstNode visitDisjunction(KotlinParser.DisjunctionContext context) {
        return new DisjunctionExpression(
            left: (ConjunctionExpression)context.conjunction(0).Accept(this),
            right: context.conjunction().Skip(1)
                .Select(it => (ConjunctionExpression)it.Accept(this))
                .ToList()
        );
    }

    public AstNode visitConjunction(KotlinParser.ConjunctionContext context) {
        return new ConjunctionExpression(
            left: (EqualityExpression)context.equality(0).Accept(this),
            right: context.equality().Skip(1)
                .Select(it => (EqualityExpression)it.Accept(this))
                .ToList()
        );
    }

    public AstNode visitEquality(KotlinParser.EqualityContext context) {
        return new EqualityExpression(
            left: (ComparisonExpression)context.comparison(0).Accept(this),
            right: context.comparison().Skip(1)
                .Select((it, index) => (
                    (EqualityOperator)context.equalityOperator(index).Accept(this),
                    (ComparisonExpression)it.Accept(this)
                ))
                .ToList()
        );
    }

    public AstNode visitComparison(KotlinParser.ComparisonContext context) {
        return new ComparisonExpression(
            left: (GenericCallLikeComparisonExpression)context.genericCallLikeComparison(0).Accept(this),
            right: context.genericCallLikeComparison().Skip(1)
                .Select((it, index) => (
                    (ComparisonOperator)context.comparisonOperator(index).Accept(this),
                    (GenericCallLikeComparisonExpression)it.Accept(this)
                ))
                .ToList()
        );
    }

    public AstNode visitGenericCallLikeComparison(KotlinParser.GenericCallLikeComparisonContext context) {
        return new GenericCallLikeComparisonExpression(
            left: (InfixOperationExpression)context.infixOperation().Accept(this),
            right: context.callSuffix()
                .Select(it => (PostfixUnarySuffix.CallSuffix)it.Accept(this))
                .ToList()
        );
    }

    public AstNode visitInfixOperation(KotlinParser.InfixOperationContext context) {
        return new InfixOperationExpression(
            left: (ElvisExpression)context.elvisExpression(0).Accept(this),
            right: context.elvisExpression().Skip(1)
                .Select(it => new InfixOperationExpression.Sub.Elvis((ElvisExpression)it.Accept(this)))
                .Cast<InfixOperationExpression.Sub>()
                .ToList()
        );
    }

    public AstNode visitElvisExpression(KotlinParser.ElvisExpressionContext context) {
        return new ElvisExpression(
            left: (InfixFunctionCallExpression)context.infixFunctionCall(0).Accept(this),
            right: context.infixFunctionCall().Skip(1)
                .Select(it => (InfixFunctionCallExpression)it.Accept(this))
                .ToList()
        );
    }

    public AstNode visitElvis(KotlinParser.ElvisContext context) {
        return VisitChildren(context);
    }

    public AstNode visitInfixFunctionCall(KotlinParser.InfixFunctionCallContext context) {
        return new InfixFunctionCallExpression(
            left: (RangeExpression)context.rangeExpression(0).Accept(this),
            right: context.rangeExpression().Skip(1)
                .Select((it, index) => (
                    context.simpleIdentifier(index).GetText(), (RangeExpression)it.Accept(this))
                )
                .ToList()
        );
    }

    public AstNode visitRangeExpression(KotlinParser.RangeExpressionContext context) {
        var operators = context.children
            .Where(tree => tree is ITerminalNode node && node.Symbol.Type == KotlinParser.NL)
            .Cast<ITerminalNode>()
            .ToList();
        return new RangeExpression(
            left: (AdditiveExpression)context.additiveExpression(0).Accept(this),
            right: context.additiveExpression().Skip(1)
                .Select((it, index) => (
                    operators[index].Symbol.Type == KotlinParser.RANGE
                        ? RangeExpression.RangeOperator.Range
                        : RangeExpression.RangeOperator.RangeUtil,
                    (AdditiveExpression)it.Accept(this))
                )
                .ToList()
        );
    }

    public AstNode visitAdditiveExpression(KotlinParser.AdditiveExpressionContext context) {
        return new AdditiveExpression(
            left: (MultiplicativeExpression)context.multiplicativeExpression(0).Accept(this),
            right: context.multiplicativeExpression().Skip(1)
                .Select((it, index) => (
                    (AdditiveOperator)context.additiveOperator(index).Accept(this),
                    (MultiplicativeExpression)it.Accept(this))
                )
                .ToList()
        );
    }

    public AstNode visitMultiplicativeExpression(KotlinParser.MultiplicativeExpressionContext context) {
        return new MultiplicativeExpression(
            left: (AsExpression)context.asExpression(0).Accept(this),
            right: context.asExpression().Skip(1)
                .Select((it, index) => (
                    (MultiplicativeOperator)context.multiplicativeOperator(index).Accept(this),
                    (AsExpression)it.Accept(this))
                )
                .ToList()
        );
    }

    public AstNode visitAsExpression(KotlinParser.AsExpressionContext context) {
        return new AsExpression(
            left: (PrefixUnaryExpression)context.prefixUnaryExpression().Accept(this),
            right: context.type()
                .Select((it, index) => (
                    (AsOperator)context.asOperator(index).Accept(this),
                    (Type)it.Accept(this).GetType())
                )
                .ToList()
        );
    }

    public AstNode visitPrefixUnaryExpression(KotlinParser.PrefixUnaryExpressionContext context) {
        return new PrefixUnaryExpression(
            prefixes: context.unaryPrefix()
                .Select(it => (UnaryPrefix)it.Accept(this))
                .ToList(),
            expression: (PostfixUnaryExpression)context.postfixUnaryExpression().Accept(this)
        );
    }

    public AstNode visitUnaryPrefix(KotlinParser.UnaryPrefixContext context) {
        if (context.annotation() != null) {
            return new UnaryPrefix.Annotation();
        }

        if (context.label() != null) {
            return new UnaryPrefix.Label();
        }

        if (context.prefixUnaryOperator() != null) {
            return new UnaryPrefix.Operator();
        }

        return VisitChildren(context);
    }

    public AstNode visitPostfixUnaryExpression(KotlinParser.PostfixUnaryExpressionContext context) {
        return new PostfixUnaryExpression(
            expression: (PrimaryExpression)context.primaryExpression().Accept(this),
            suffixes: context.postfixUnarySuffix()
                .Select(it => (PostfixUnarySuffix)it.Accept(this))
                .ToList()
        );
    }

    public AstNode visitPostfixUnarySuffix(KotlinParser.PostfixUnarySuffixContext context) {
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

        return VisitChildren(context);
    }

    public AstNode visitDirectlyAssignableExpression(KotlinParser.DirectlyAssignableExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitParenthesizedDirectlyAssignableExpression(
        KotlinParser.ParenthesizedDirectlyAssignableExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAssignableExpression(KotlinParser.AssignableExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode
        visitParenthesizedAssignableExpression(KotlinParser.ParenthesizedAssignableExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAssignableSuffix(KotlinParser.AssignableSuffixContext context) {
        return VisitChildren(context);
    }

    public AstNode visitIndexingSuffix(KotlinParser.IndexingSuffixContext context) {
        return VisitChildren(context);
    }

    public AstNode visitNavigationSuffix(KotlinParser.NavigationSuffixContext context) {
        return VisitChildren(context);
    }

    public AstNode visitCallSuffix(KotlinParser.CallSuffixContext context) {
        return new PostfixUnarySuffix.CallSuffix((ValueArguments)context.valueArguments().Accept(this));
    }

    public AstNode visitAnnotatedLambda(KotlinParser.AnnotatedLambdaContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeArguments(KotlinParser.TypeArgumentsContext context) {
        return VisitChildren(context);
    }

    public AstNode visitValueArguments(KotlinParser.ValueArgumentsContext context) {
        return new ValueArguments(context.valueArgument()
            .Select(it => (ValueArgument)it.Accept(this))
            .ToList()
        );
    }

    public AstNode visitValueArgument(KotlinParser.ValueArgumentContext context) {
        return new ValueArgument((Expression)context.expression().Accept(this));
    }

    public AstNode visitPrimaryExpression(KotlinParser.PrimaryExpressionContext context) {
        if (context.parenthesizedExpression() != null) {
            return new ParenthesizedExpression((Expression)context.parenthesizedExpression().Accept(this));
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
        
        return VisitChildren(context);
    }

    public AstNode visitParenthesizedExpression(KotlinParser.ParenthesizedExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitCollectionLiteral(KotlinParser.CollectionLiteralContext context) {
        return VisitChildren(context);
    }

    public AstNode visitLiteralConstant(KotlinParser.LiteralConstantContext context) {
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

        return VisitChildren(context);
    }

    public AstNode visitStringLiteral(KotlinParser.StringLiteralContext context) {
        if (context.lineStringLiteral() != null) {
            return context.lineStringLiteral().Accept(this);
        }

        if (context.multiLineStringLiteral() != null) {
            return context.multiLineStringLiteral().Accept(this);
        }

        return VisitChildren(context);
    }

    public AstNode visitLineStringLiteral(KotlinParser.LineStringLiteralContext context) {
        return new StringLiteral(context.children.Skip(1).SkipLast(1)
            .Select(tree => (StringLiteral.Sub)tree.Accept(this))
            .ToList());
    }

    public AstNode visitMultiLineStringLiteral(KotlinParser.MultiLineStringLiteralContext context) {
        return new StringLiteral(context.children.Skip(1).SkipLast(1)
            .Select(tree => {
                if (tree is ITerminalNode node && node.Symbol.Type == KotlinParser.MultiLineStringQuote) {
                    return new StringLiteral.Sub.Content("\"");
                }

                return (StringLiteral.Sub)tree.Accept(this);
            })
            .ToList());
    }

    public AstNode visitLineStringContent(KotlinParser.LineStringContentContext context) {
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

        return VisitChildren(context);
    }

    public AstNode visitLineStringExpression(KotlinParser.LineStringExpressionContext context) {
        return new StringLiteral.Sub.Expression((Expression)context.expression().Accept(this));
    }

    public AstNode visitMultiLineStringContent(KotlinParser.MultiLineStringContentContext context) {
        if (context.MultiLineStrText() != null) {
            return new StringLiteral.Sub.Content(context.MultiLineStrText().GetText());
        }

        if (context.MultiLineStrRef() != null) {
            return new StringLiteral.Sub.Expression(new Identifier(context.MultiLineStrRef().GetText()[1..]));
        }

        return VisitChildren(context);
    }

    public AstNode visitMultiLineStringExpression(KotlinParser.MultiLineStringExpressionContext context) {
        return new StringLiteral.Sub.Expression((Expression)context.expression().Accept(this));
    }

    public AstNode visitLambdaLiteral(KotlinParser.LambdaLiteralContext context) {
        return VisitChildren(context);
    }

    public AstNode visitLambdaParameters(KotlinParser.LambdaParametersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitLambdaParameter(KotlinParser.LambdaParameterContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAnonymousFunction(KotlinParser.AnonymousFunctionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFunctionLiteral(KotlinParser.FunctionLiteralContext context) {
        return VisitChildren(context);
    }

    public AstNode visitObjectLiteral(KotlinParser.ObjectLiteralContext context) {
        return VisitChildren(context);
    }

    public AstNode visitThisExpression(KotlinParser.ThisExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSuperExpression(KotlinParser.SuperExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitIfExpression(KotlinParser.IfExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitWhenSubject(KotlinParser.WhenSubjectContext context) {
        return VisitChildren(context);
    }

    public AstNode visitWhenExpression(KotlinParser.WhenExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitWhenEntry(KotlinParser.WhenEntryContext context) {
        return VisitChildren(context);
    }

    public AstNode visitWhenCondition(KotlinParser.WhenConditionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitRangeTest(KotlinParser.RangeTestContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeTest(KotlinParser.TypeTestContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTryExpression(KotlinParser.TryExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitCatchBlock(KotlinParser.CatchBlockContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFinallyBlock(KotlinParser.FinallyBlockContext context) {
        return VisitChildren(context);
    }

    public AstNode visitJumpExpression(KotlinParser.JumpExpressionContext context) {
        return VisitChildren(context);
    }

    public AstNode visitCallableReference(KotlinParser.CallableReferenceContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAssignmentAndOperator(KotlinParser.AssignmentAndOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitEqualityOperator(KotlinParser.EqualityOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitComparisonOperator(KotlinParser.ComparisonOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitInOperator(KotlinParser.InOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitIsOperator(KotlinParser.IsOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAdditiveOperator(KotlinParser.AdditiveOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitMultiplicativeOperator(KotlinParser.MultiplicativeOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAsOperator(KotlinParser.AsOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitPrefixUnaryOperator(KotlinParser.PrefixUnaryOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitPostfixUnaryOperator(KotlinParser.PostfixUnaryOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitExcl(KotlinParser.ExclContext context) {
        return VisitChildren(context);
    }

    public AstNode visitMemberAccessOperator(KotlinParser.MemberAccessOperatorContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSafeNav(KotlinParser.SafeNavContext context) {
        return VisitChildren(context);
    }

    public AstNode visitModifiers(KotlinParser.ModifiersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitParameterModifiers(KotlinParser.ParameterModifiersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitModifier(KotlinParser.ModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeModifiers(KotlinParser.TypeModifiersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeModifier(KotlinParser.TypeModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitClassModifier(KotlinParser.ClassModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitMemberModifier(KotlinParser.MemberModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitVisibilityModifier(KotlinParser.VisibilityModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitVarianceModifier(KotlinParser.VarianceModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeParameterModifiers(KotlinParser.TypeParameterModifiersContext context) {
        return VisitChildren(context);
    }

    public AstNode visitTypeParameterModifier(KotlinParser.TypeParameterModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitFunctionModifier(KotlinParser.FunctionModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitPropertyModifier(KotlinParser.PropertyModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitInheritanceModifier(KotlinParser.InheritanceModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitParameterModifier(KotlinParser.ParameterModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitReificationModifier(KotlinParser.ReificationModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitPlatformModifier(KotlinParser.PlatformModifierContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAnnotation(KotlinParser.AnnotationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSingleAnnotation(KotlinParser.SingleAnnotationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitMultiAnnotation(KotlinParser.MultiAnnotationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitAnnotationUseSiteTarget(KotlinParser.AnnotationUseSiteTargetContext context) {
        return VisitChildren(context);
    }

    public AstNode visitUnescapedAnnotation(KotlinParser.UnescapedAnnotationContext context) {
        return VisitChildren(context);
    }

    public AstNode visitSimpleIdentifier(KotlinParser.SimpleIdentifierContext context) =>
        new Identifier(context.GetText());

    public AstNode visitIdentifier(KotlinParser.IdentifierContext context) {
        return VisitChildren(context);
    }
}