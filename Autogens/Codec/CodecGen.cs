using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using FFmpegArgs.Cores.Attributes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Autogens.Codec
{
    internal static class CodecGen
    {
        static readonly Regex regex_parse = new Regex("^ ([.DEVASDTILS]{6}) (.*?) +(.*?)$");
        internal static void Gen(List<string> lines)
        {
            var enumMembers = new List<EnumMemberDeclarationSyntax>();
            foreach (string line in lines.Skip(12))
            {
                Match match = regex_parse.Match(line);
                if (!match.Success)
                    continue;

                string codecFlag = match.Groups[1].Value;
                string originalName = match.Groups[2].Value;
                string name = originalName.FixNameRule();
                string description = match.Groups[3].Value;

                // Attributes
                var attributes = new List<AttributeListSyntax>
                {
                    AttributeList(SingletonSeparatedList(
                        Attribute(IdentifierName(typeof(CodecFlagAttribute).FullName!))
                            .WithArgumentList(AttributeArgumentList(SingletonSeparatedList(
                                AttributeArgument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(codecFlag)))
                            )))
                    )),
                    AttributeList(SingletonSeparatedList(
                        Attribute(IdentifierName(typeof(NameAttribute).FullName!))
                            .WithArgumentList(AttributeArgumentList(SingletonSeparatedList(
                                AttributeArgument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(originalName)))
                            )))
                    ))
                };
                var trivia = TriviaList(
                    Comment("/// <summary>"),
                    Comment($"/// {description.XmlEscape()}"),
                    Comment("/// </summary>")
                );

                var member = EnumMemberDeclaration(Identifier(name))
                    .WithAttributeLists(List(attributes))
                    .WithLeadingTrivia(trivia);

                enumMembers.Add(member);
            }


            // Enum declaration
            var enumDecl = EnumDeclaration("Codecs")
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithMembers(SeparatedList(enumMembers))
                .WithLeadingTrivia(TriviaList(
                    Comment("/// <summary>"),
                    Comment("/// </summary>")
                ));
            var ns = NamespaceDeclaration(ParseName("FFmpegArgs.Cores.Enums"))
                .WithMembers(SingletonList<MemberDeclarationSyntax>(enumDecl))
                .NormalizeWhitespace();

            // Unit
            var compilationUnit = CompilationUnit()
                //.WithUsings(List(new[] { UsingDirective(ParseName("System")) }))
                .WithMembers(SingletonList<MemberDeclarationSyntax>(ns))
                .NormalizeWhitespace();

            File.WriteAllText(Path.Combine("FFmpegArgs.Cores", "Enums", "Codecs.g.cs"), compilationUnit.ToFullString(),Encoding.UTF8);
        }
    }
}
