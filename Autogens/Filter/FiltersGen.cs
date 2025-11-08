using FFmpegArgs.Cores.Attributes;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Interfaces;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.BaseFilters;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Autogens.Filter
{
    internal static class FiltersGen
    {
        static readonly IEnumerable<string> _skip = new string[]
        {
            //"concat"
        };
        static Regex regex_filter { get; } = new Regex("^([TS.]{2}) +([a-z0-9_]+) +([AVN|]{1,}->[AVN|]{1,}) +(.+)$");
        static readonly Regex regex_parseTypeConvert = new Regex("(\\||N|V+|A+)->(\\||N|V+|A+)");



        public static void Gen(List<string> filters, List<DocLine> docLines)
        {
            var genDir = Path.Combine("FFmpegArgs.Filters.Generated", "Gen");
            Directory.CreateDirectory(genDir);
            //foreach (var file in Directory.GetFiles(genDir, "*.g.cs"))
            //{
            //    File.Delete(file);
            //}

            foreach (var filter in filters)
            {
                Match match = regex_filter.Match(filter);
                if (match.Success)
                {
                    string support = match.Groups[1].Value;
                    string name = match.Groups[2].Value;
                    string type = match.Groups[3].Value;
                    string description = match.Groups[4].Value;
                    DocLine? docLine = docLines.FirstOrDefault(x => x.LineData.StartsWith($"{name} AVOptions:"));
                    if (docLine is null)
                    {
                        Console.WriteLine($"{"Filters.Gen not found",-40}: {filter}");
                        continue;
                    }
                    if (_skip.Contains(name))
                    {
                        Console.WriteLine($"{"Filters.Gen skip",-40}: {filter}");
                        continue;
                    }
                    Match match_type = regex_parseTypeConvert.Match(type);
                    if (!match.Success ||
                        type.Contains("N->N", StringComparison.OrdinalIgnoreCase) || //ignore N->N
                        type.Contains("|->N", StringComparison.OrdinalIgnoreCase) || //ignore |->N
                        type.Contains("->|", StringComparison.OrdinalIgnoreCase)//ignore ->|
                        )
                    {
                        Console.WriteLine($"{"Filters.Gen can't get FilterTypeName",-40}: {filter}");
                        continue;
                    }
                    string className = $"{name.UpperFirst()}FilterGen";

                    string inSymbols = match_type.Groups[1].Value;
                    string outSymbols = match_type.Groups[2].Value;
                    int InputCount = inSymbols.Count(x => x == 'A' || x == 'V');// 'N' or '|' result count 0
                    int OutputCount = outSymbols.Count(x => x == 'A' || x == 'V');// 'N' result count 0
                    string inSymbol = inSymbols[0] switch
                    {
                        '|' => "|",
                        'A' => "A",
                        'V' => "V",
                        _ => string.Empty,// N is multi input, type same output
                    };
                    string outSymbol = outSymbols[0] switch
                    {
                        'V' => "V",
                        'A' => "A",
                        _ => string.Empty,// N is multi output, type same input
                    };
                    //replace N
                    if (string.IsNullOrWhiteSpace(inSymbol)) inSymbol = outSymbol;
                    if (string.IsNullOrWhiteSpace(outSymbol)) outSymbol = inSymbol;


                    Type inheritClass = $"{inSymbol}->{outSymbol}" switch
                    {
                        "A->A" => typeof(AudioToAudioFilter),
                        "A->V" => typeof(AudioToImageFilter),

                        "V->A" => typeof(ImageToAudioFilter),
                        "V->V" => typeof(ImageToImageFilter),

                        "|->A" => typeof(SourceToAudioFilter),
                        "|->V" => typeof(SourceToImageFilter),

                        //VideoToVideoFilter concat filter

                        _ => throw new InvalidOperationException(),
                    };
                    IEnumerable<Type> inheritInterfaces = GetFilterInterface(support);


                    Type inputType = inSymbol switch
                    {
                        "A" => typeof(AudioMap),//InputCount == 1 ? typeof(AudioMap) : typeof(AudioMap[]),
                        "V" => typeof(ImageMap),//InputCount == 1 ? typeof(ImageMap) : typeof(ImageMap[]),
                        "|" => outSymbol switch
                        {
                            "A" => typeof(IAudioFilterGraph),
                            "V" => typeof(IImageFilterGraph),
                            _ => throw new InvalidOperationException(),
                        },
                        _ => throw new InvalidOperationException(),
                    };


                    List<MemberDeclarationSyntax> namespaceMembers = new();

                    //gen class, enums
                    {
                        List<FilterData> filterFunctions = docLine.ChildLines
                            .Select(x => FilterData.Create(x))
                            .Where(x => x is not null)
                            .ToList()!;
                        //remove function alias(same description, and name start with)
                        var removes = filterFunctions
                            .GroupBy(x => x.Description)
                            .Where(x => x.Count() == 2)
                            .Select(x => x.OrderBy(y => y.Name.Length))
                            .Where(x => x.Last().Name.StartsWith(x.First().Name))
                            .Select(x => x.First())
                            .ToList();

                        var classMembers = new List<MemberDeclarationSyntax>();
                        //ctor method
                        {
                            List<ParameterSyntax> parameters = new List<ParameterSyntax>();
                            string paramName;
                            if (InputCount == 1) //A-> or V->
                            {
                                paramName = "input";
                                ParameterSyntax parameterSyntax = Parameter(Identifier(paramName))
                                    .WithType(IdentifierName(inputType.Name));
                                parameters.Add(parameterSyntax);
                            }
                            else//0 or >=2
                            {
                                if (inputType.IsInterface)// |->
                                {
                                    paramName = "input";
                                    ParameterSyntax parameterSyntax = Parameter(Identifier(paramName))
                                        .WithType(IdentifierName(inputType.Name));
                                    parameters.Add(parameterSyntax);
                                }
                                else//AA-> or AAA-> or VV-> ....
                                {
                                    paramName = "inputs";
                                    ParameterSyntax parameterSyntax = Parameter(Identifier(paramName))
                                        .WithType(ArrayType(IdentifierName(inputType.Name))
                                            .WithRankSpecifiers(SingletonList(ArrayRankSpecifier(SingletonSeparatedList<ExpressionSyntax>(OmittedArraySizeExpression()))))
                                        )
                                        .WithModifiers(TokenList(Token(SyntaxKind.ParamsKeyword)));
                                    parameters.Add(parameterSyntax);
                                }
                            }

                            if (OutputCount == 0)
                            {
                                ParameterSyntax parameterSyntax = Parameter(Identifier("outputCount"))
                                    .WithType(IdentifierName("int"));
                                parameters.Add(parameterSyntax);
                            }
                            ExpressionStatementSyntax ctorBody = OutputCount switch
                            {
                                //N
                                0 => ExpressionStatement(
                                        InvocationExpression(IdentifierName("AddMultiMapOut"))
                                        .WithArgumentList(
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(IdentifierName("outputCount"))
                                                )
                                            )
                                        )
                                    ),

                                1 => ExpressionStatement(InvocationExpression(IdentifierName("AddMapOut"))),

                                _ => ExpressionStatement(
                                        InvocationExpression(IdentifierName("AddMultiMapOut"))
                                        .WithArgumentList(
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(OutputCount)))
                                                )
                                            )
                                        )
                                    ),
                            };

                            var ctorDecl = ConstructorDeclaration(Identifier(className))
                                .WithModifiers(TokenList(Token(SyntaxKind.InternalKeyword)))
                                .WithParameterList(ParameterList(SeparatedList(parameters)))
                                .WithInitializer(
                                    ConstructorInitializer(
                                        SyntaxKind.BaseConstructorInitializer,
                                        ArgumentList(
                                            SeparatedList<ArgumentSyntax>(
                                                new SyntaxNodeOrToken[]{
                                                    Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(name))),
                                                    Token(SyntaxKind.CommaToken),
                                                    Argument(IdentifierName(paramName))
                                                }
                                            )
                                        )
                                    )
                                )
                                .WithBody(Block(SingletonList<StatementSyntax>(ctorBody)))
                                ;
                            classMembers.Add(ctorDecl);
                        }


                        var enums = new List<EnumDeclarationSyntax>();
                        foreach (var filterData in filterFunctions.Except(removes))
                        {
                            (MethodDeclarationSyntax? methodDeclarationSyntax, EnumDeclarationSyntax? enumDeclarationSyntax)
                                = FilterFunctionGen.GenMethodDeclarationSyntax(filterData, className);
                            if (methodDeclarationSyntax is not null)
                                classMembers.Add(methodDeclarationSyntax);
                            if (enumDeclarationSyntax is not null)
                                enums.Add(enumDeclarationSyntax);
                        }

                        List<SimpleBaseTypeSyntax> inherits =
                        [
                            SimpleBaseType(IdentifierName(inheritClass.Name)),
                            .. inheritInterfaces.Select(x => SimpleBaseType(IdentifierName(x.Name))),
                        ];

                        var classDecl = ClassDeclaration(className)
                            .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                            .WithMembers(List<MemberDeclarationSyntax>(classMembers))
                            .WithBaseList(BaseList(SeparatedList<BaseTypeSyntax>(inherits)))
                            .WithLeadingTrivia(TriviaList(
                                Comment("/// <summary>"),
                                Comment($"/// {match.Value.FixSummaryRule()}"),
                                Comment("/// </summary>")
                            ));

                        namespaceMembers.Add(classDecl);
                        namespaceMembers.AddRange(enums);
                    }

                    //extension
                    {
                        var methods = new List<MethodDeclarationSyntax>();

                        {
                            List<ParameterSyntax> parameters = new List<ParameterSyntax>();
                            List<ArgumentSyntax> arguments = new List<ArgumentSyntax>();

                            if (InputCount == 0)// |->
                            {
                                ParameterSyntax parameterSyntax = Parameter(Identifier("input"))
                                    .WithType(IdentifierName(inputType.Name))
                                    .WithModifiers(TokenList(Token(SyntaxKind.ThisKeyword)));
                                parameters.Add(parameterSyntax);

                                arguments.Add(Argument(IdentifierName("input")));
                            }
                            else
                            {
                                for (int i = 0; i < InputCount; i++)
                                {
                                    ParameterSyntax parameterSyntax = Parameter(Identifier($"input{i}"))
                                        .WithType(IdentifierName(inputType.Name));
                                    if (i == 0)
                                        parameterSyntax = parameterSyntax.WithModifiers(TokenList(Token(SyntaxKind.ThisKeyword)));
                                    parameters.Add(parameterSyntax);

                                    arguments.Add(Argument(IdentifierName($"input{i}")));
                                }
                            }

                            if (OutputCount == 0)
                            {
                                ParameterSyntax parameterSyntax = Parameter(Identifier("outputCount"))
                                    .WithType(IdentifierName("int"));
                                parameters.Add(parameterSyntax);

                                arguments.Add(Argument(IdentifierName($"outputCount")));
                            }


                            var methodDecl = MethodDeclaration(IdentifierName(className), Identifier(className))
                                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)))
                                    .WithLeadingTrivia(TriviaList(
                                        Comment("/// <summary>"),
                                        Comment($"/// {description.FixSummaryRule()}"),
                                        Comment("/// </summary>")
                                    ))
                                    .WithParameterList(ParameterList(SeparatedList(parameters)))
                                    .WithExpressionBody(
                                        ArrowExpressionClause(
                                            ObjectCreationExpression(IdentifierName(className))
                                            .WithArgumentList(ArgumentList(SeparatedList(arguments)))
                                        )
                                    )
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
                            methods.Add(methodDecl);
                        }


                        var extensionDecl = ClassDeclaration($"FilterGeneratedExtensions")
                            .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword), Token(SyntaxKind.PartialKeyword)))
                            .WithMembers(List<MemberDeclarationSyntax>(methods))
                                ;
                        namespaceMembers.Add(extensionDecl);
                    }

                    var namespaceDecl = NamespaceDeclaration(ParseName("FFmpegArgs.Filters.Generated"))
                        .WithMembers(List<MemberDeclarationSyntax>(namespaceMembers))
                        .NormalizeWhitespace();

                    var compilationUnit = CompilationUnit()
                        //.WithUsings(List(new[] { UsingDirective(ParseName("System")) }))
                        .WithMembers(SingletonList<MemberDeclarationSyntax>(namespaceDecl))
                        .NormalizeWhitespace();
                    string code = compilationUnit.ToFullString();
                    File.WriteAllText(Path.Combine(genDir, $"{className}.g.cs"), code, Encoding.UTF8);
                }
            }
        }

        static IEnumerable<Type> GetFilterInterface(string support)
        {
            if (support[0] == 'T') yield return typeof(ITimelineSupport);
            if (support[1] == 'S') yield return typeof(ISliceThreading);
            //if (support[2] == 'C') yield return typeof(ICommandSupport);
        }
    }
}
