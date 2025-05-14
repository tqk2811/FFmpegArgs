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

namespace Autogens.Format
{
    internal static class FormatsGen
    {
        static Regex format_filter { get; } = new Regex("^ ([DEd ]{3}) (.*?) +(.*?)$");
        internal static void Gen(List<string> lines)
        {
            var demuxingEnumMembers = new List<EnumMemberDeclarationSyntax>();
            var muxingEnumMembers = new List<EnumMemberDeclarationSyntax>();
            foreach (string line in lines)
            {
                Match match = format_filter.Match(line);
                if (!match.Success) continue;

                string flag = match.Groups[1].Value;
                string description = match.Groups[3].Value;

                foreach (char c in flag)
                {
                    List<EnumMemberDeclarationSyntax>? enumMembers = c switch
                    {
                        'D' => demuxingEnumMembers,
                        'E' => muxingEnumMembers,
                        _ => null,
                    };
                    if (enumMembers is not null)
                    {
                        var split = match.Groups[2].Value.Split(',');
                        foreach (var item in split)
                        {
                            string name = item.FixNameRule();

                            // Attributes
                            var attributes = new List<AttributeListSyntax>
                            {
                                AttributeList(SingletonSeparatedList(
                                    Attribute(IdentifierName(typeof(NameAttribute).FullName!))
                                        .WithArgumentList(AttributeArgumentList(SingletonSeparatedList(
                                            AttributeArgument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(item)))
                                        )))
                                ))
                            };

                            var trivia = TriviaList(
                                Comment("/// <summary>"),
                                Comment($"/// {description}"),
                                Comment("/// </summary>")
                            );

                            var member = EnumMemberDeclaration(Identifier(name))
                                .WithAttributeLists(List(attributes))
                                .WithLeadingTrivia(trivia);

                            enumMembers.Add(member);
                        }
                    }
                }
            }

            {
                var demuxingEnumDecl = EnumDeclaration("DemuxingFileFormat")
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                    .WithMembers(SeparatedList(demuxingEnumMembers))
                    .WithLeadingTrivia(TriviaList(
                        Comment("/// <summary>"),
                        Comment("/// </summary>")
                    ));
                var demuxingNamespaceDecl = NamespaceDeclaration(ParseName("FFmpegArgs.Cores.Enums"))
                    .WithMembers(SingletonList<MemberDeclarationSyntax>(demuxingEnumDecl))
                    .NormalizeWhitespace();

                var demuxingCompilationUnit = CompilationUnit()
                    //.WithUsings(List(new[] { UsingDirective(ParseName("System")) }))
                    .WithMembers(SingletonList<MemberDeclarationSyntax>(demuxingNamespaceDecl))
                    .NormalizeWhitespace();

                File.WriteAllText(Path.Combine("FFmpegArgs.Cores", "Enums", "DemuxingFileFormat.g.cs"), demuxingCompilationUnit.ToFullString(), Encoding.UTF8);
            }

            {
                var muxingEnumDecl = EnumDeclaration("MuxingFileFormat")
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithMembers(SeparatedList(muxingEnumMembers))
                .WithLeadingTrivia(TriviaList(
                    Comment("/// <summary>"),
                    Comment("/// </summary>")
                ));
                var muxingNamespaceDecl = NamespaceDeclaration(ParseName("FFmpegArgs.Cores.Enums"))
                    .WithMembers(SingletonList<MemberDeclarationSyntax>(muxingEnumDecl))
                    .NormalizeWhitespace();

                // Unit
                var muxingCompilationUnit = CompilationUnit()
                    //.WithUsings(List(new[] { UsingDirective(ParseName("System")) }))
                    .WithMembers(SingletonList<MemberDeclarationSyntax>(muxingNamespaceDecl))
                    .NormalizeWhitespace();

                File.WriteAllText(Path.Combine("FFmpegArgs.Cores", "Enums", "MuxingFileFormat.g.cs"), muxingCompilationUnit.ToFullString(), Encoding.UTF8);
            }
        }
    }
}
