﻿using Antlr4.Runtime.Misc;
using DotNetLisp.Antlr.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Tree;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace DotNetLisp.Parser
{
    public partial class ParseExpressionVisitor : DotNetLispBaseVisitor<CSharpSyntaxNode>
    {
        private readonly string ClassName;
        private readonly string NamespaceName;

        public ParseExpressionVisitor(string namespaceName, string className) :base()
        {
            this.NamespaceName = namespaceName;
            this.ClassName = className;
        }

        public override CSharpSyntaxNode VisitFile([NotNull] DotNetLispParser.FileContext context)
        {
            var children = context.form().Select(f => this.Visit(f)).ToArray();
            var members = children.OfType<MemberDeclarationSyntax>().ToList();
            var expressions = children.OfType<ExpressionSyntax>().ToArray();

            if(expressions.Any())
            {
                int finalElement = expressions.Length - 1;
                var statements = expressions
                    .Select((expression, index) =>
                                index == finalElement ?
                                ReturnStatement(expression as ExpressionSyntax) :
                                ExpressionStatement(expression as ExpressionSyntax) as StatementSyntax)
                    .ToArray();
                // make a Program class that has a "Run" method, and embed our program expression inside it.
                members.Add(
                    MethodDeclaration(ParseTypeName("System.Object"), "Run")
                           .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
                           .WithBody(Block(statements))
                );
            }

            var @class = CompilationUnit()
                .AddMembers(NamespaceDeclaration(IdentifierName(NamespaceName))
                    .AddMembers(ClassDeclaration(ClassName)
                        .AddMembers(members.ToArray())));

            return @class;
        }
    }
}
