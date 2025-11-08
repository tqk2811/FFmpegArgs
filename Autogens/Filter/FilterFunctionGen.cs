using FFmpegArgs;
using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Attributes;
using FFmpegArgs.Cores.Enums;
using FFmpegArgs.Cores.Utils;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Expressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Autogens.Filter
{
    internal static class FilterFunctionGen
    {
        //public <returnTypeName> <functionName>(<paramType> <paramName>) => this.SetOptionRange("<filterData.Name>",<paramName>, filterData.Min, filterData.Max);
        static MethodDeclarationSyntax GenMethodSetOptionRange(this MethodDeclarationSyntax method, string paramName, string paramType, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(IdentifierName(paramType)))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOptionRange))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                            {
                                        Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(filterData.Name))),
                                        Argument(IdentifierName(paramName)),
                                        Argument(IdentifierName(filterData.Min)),
                                        Argument(IdentifierName(filterData.Max))
                            }))
                        )
                    )
                )
               .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        //public <returnTypeName> <functionName>(bool <paramName>) => this.SetOption("<filterData.Name>", <paramName>.ToFFmpegFlag());
        static MethodDeclarationSyntax GenMethodSetOption_Boolean(this MethodDeclarationSyntax method, string paramName, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(PredefinedType(Token(SyntaxKind.BoolKeyword))))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOption))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                            {
                                Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(filterData.Name))),
                                Argument(InvocationExpression(MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName(paramName),
                                        IdentifierName(nameof(UtilsExtension.ToFFmpegFlag))
                                )))
                            }))
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        //public <returnTypeName> <functionName>(Size <paramName>) => this.SetOption("<filterData.Name>", $"{<paramName>}.Widthx{<paramName>}.Height");
        static MethodDeclarationSyntax GenMethodSetOption_Size(this MethodDeclarationSyntax method, string paramName, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(IdentifierName(nameof(System.Drawing.Size))))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOption))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                        {
                            Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(filterData.Name))),
                            Argument(InterpolatedStringExpression(Token(SyntaxKind.InterpolatedStringStartToken))
                                .WithContents(List(new InterpolatedStringContentSyntax[]
                                {
                                    // {<functionName>.Width}
                                    Interpolation(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, IdentifierName(paramName), IdentifierName(nameof(System.Drawing.Size.Width)))),
                                    // x
                                    InterpolatedStringText().WithTextToken(Token(TriviaList(),SyntaxKind.InterpolatedStringTextToken, "x", "x", TriviaList())),
                                    // {<functionName>.Height}
                                    Interpolation(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,IdentifierName(paramName),IdentifierName(nameof(System.Drawing.Size.Height))))
                                }))
                            )
                        })))
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        //public <returnTypeName> <functionName>(Timespan <paramName>) => this.SetOptionRange("<filterData.Name>", <paramName>,Timespan.Zero,Timespan.MaxValue);
        static MethodDeclarationSyntax GenMethodSetOption_Timespan(this MethodDeclarationSyntax method, string paramName, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(IdentifierName(nameof(System.TimeSpan))))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOptionRange))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                        {
                            Argument(LiteralExpression(SyntaxKind.StringLiteralExpression,Literal(filterData.Name))),
                            Argument(IdentifierName(paramName)),
                            Argument(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,IdentifierName(nameof(TimeSpan)),IdentifierName(nameof(TimeSpan.Zero)))),
                            Argument(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,IdentifierName(nameof(TimeSpan)),IdentifierName(nameof(TimeSpan.MaxValue))))
                        })))
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        //public <returnTypeName> <functionName>(Color <paramName>) => this.SetOption("<filterData.Name>", <paramName>.ToHexStringRGBA());
        static MethodDeclarationSyntax GenMethodSetOption_Color(this MethodDeclarationSyntax method, string paramName, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(IdentifierName(nameof(System.Drawing.Color))))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOption))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                            {
                                Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(filterData.Name))),
                                Argument(InvocationExpression(MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName(paramName),
                                        IdentifierName(nameof(UtilsExtension.ToHexStringRGBA))
                                )))
                            }))
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        //public <returnTypeName> <functionName>(T <paramName>) => this.SetOption("<filterData.Name>", <paramName>.ToString());
        static MethodDeclarationSyntax GenMethodSetOption_ToString<T>(this MethodDeclarationSyntax method, string paramName, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(IdentifierName(typeof(T).Name)))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOption))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                            {
                                Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(filterData.Name))),
                                Argument(InvocationExpression(MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName(paramName),
                                        IdentifierName(nameof(Object.ToString))
                                )))
                            }))
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        //public <returnTypeName> <functionName>(Rational <paramName>) => this.SetOption("<filterData.Name>", <paramName>.Check(min,max));
        static MethodDeclarationSyntax GenMethodSetOption_RationalCheck(this MethodDeclarationSyntax method, string paramName, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(IdentifierName(nameof(Rational))))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOption))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                            {
                                Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(filterData.Name))),
                                Argument(
                                    InvocationExpression(MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            IdentifierName(paramName),
                                            IdentifierName(nameof(Rational.Check))
                                        )
                                    )
                                    .WithArgumentList(ArgumentList(SeparatedList(new[]
                                    {
                                        Argument(IdentifierName(filterData.Min)),
                                        Argument(IdentifierName(filterData.Max))
                                    })))
                                )
                            }))
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        //public <returnTypeName> <functionName>(T <paramName>) => this.SetOption("<filterData.Name>", <paramName>.GetEnumAttribute<NameAttribute>().Name);
        static MethodDeclarationSyntax GenMethodSetOption_EnumNameAttribute<T>(this MethodDeclarationSyntax method, string paramName, FilterData filterData) where T : Enum
            => GenMethodSetOption_EnumNameAttribute(method, typeof(T).Name, paramName, filterData);
        static MethodDeclarationSyntax GenMethodSetOption_EnumNameAttribute(this MethodDeclarationSyntax method, string typeName, string paramName, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(IdentifierName(typeName)))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOption))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                            {
                                Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(filterData.Name))),
                                // <paramName>.GetEnumAttribute<NameAttribute>().Name
                                Argument(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName(paramName),
                                                GenericName(Identifier(nameof(AttributeExtensions.GetEnumAttribute)))
                                                    .WithTypeArgumentList(
                                                        TypeArgumentList(SingletonSeparatedList<TypeSyntax>(IdentifierName(nameof(NameAttribute))))
                                                    )
                                            )
                                        ),
                                        IdentifierName(nameof(NameAttribute.Name))
                                    )
                                )
                            }))
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        //public <returnTypeName> <functionName>(ExpressionValue <paramName>) => this.SetOption("<filterData.Name>", (string)<paramName>);
        static MethodDeclarationSyntax GenMethodSetOption_ExpressionValue(this MethodDeclarationSyntax method, string paramName, FilterData filterData)
        {
            return method.WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier(paramName)).WithType(IdentifierName(nameof(ExpressionValue))))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(nameof(BaseOptionExtension.SetOption))))
                        .WithArgumentList(ArgumentList(SeparatedList(new[]
                            {
                                Argument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(filterData.Name))),
                                Argument(CastExpression(PredefinedType(Token(SyntaxKind.StringKeyword)),IdentifierName(paramName)))
                            }))
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        internal static (MethodDeclarationSyntax?, EnumDeclarationSyntax?) GenMethodDeclarationSyntax(FilterData filterData, string returnTypeName)
        {
            EnumDeclarationSyntax? enumDeclarationSyntax = null;

            string functionName = filterData.Name.FixNameRule();
            string paramName = functionName;
            MethodDeclarationSyntax method = MethodDeclaration(IdentifierName(returnTypeName), Identifier(functionName))
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithLeadingTrivia(TriviaList(
                    Comment("/// <summary>"),
                    Comment($"/// {filterData.Description.FixSummaryRule()}"),
                    Comment("/// </summary>")
                ));
            switch (filterData.Type)
            {
                case "<double>":
                    method = method.GenMethodSetOptionRange(paramName, "double", filterData);
                    break;
                case "<int>":
                    if (filterData.Function.ChildLines.Count == 0)
                    {
                        method = method.GenMethodSetOptionRange(paramName, "int", filterData);
                    }
                    else
                    {
                        (string? enumTypeName, enumDeclarationSyntax) = GenEnum(filterData, returnTypeName);
                        if (enumDeclarationSyntax is null || string.IsNullOrWhiteSpace(enumTypeName))
                        {
                            method = method.GenMethodSetOption_ToString<string>(paramName, filterData);
                        }
                        else
                        {
                            method = method.GenMethodSetOption_EnumNameAttribute(enumTypeName, paramName, filterData);
                        }
                    }
                    break;
                case "<flags>":
                    {
                        (string? enumTypeName, enumDeclarationSyntax) = GenEnum(filterData, returnTypeName);
                        if (enumDeclarationSyntax is null || string.IsNullOrWhiteSpace(enumTypeName))
                        {
                            method = method.GenMethodSetOption_ToString<string>(paramName, filterData);
                        }
                        else
                        {
                            method = method.GenMethodSetOption_EnumNameAttribute(enumTypeName, paramName, filterData);
                        }
                    }
                    break;
                case "<int64>":
                    method = method.GenMethodSetOptionRange(paramName, "long", filterData);
                    break;
                case "<float>":
                    method = method.GenMethodSetOptionRange(paramName, "float", filterData);
                    break;
                case "<boolean>":
                    method = method.GenMethodSetOption_Boolean(paramName, filterData);
                    break;
                case "<image_size>":
                    method = method.GenMethodSetOption_Size(paramName, filterData);
                    break;
                case "<duration>":
                    method = method.GenMethodSetOption_Timespan(paramName, filterData);
                    break;
                case "<color>":
                    method = method.GenMethodSetOption_Color(paramName, filterData);
                    break;
                case "<pix_fmt>":
                    method = method.GenMethodSetOption_ToString<PixFmt>(paramName, filterData);
                    break;
                case "<video_rate>":
                    method = method.GenMethodSetOption_ToString<Rational>(paramName, filterData);
                    break;
                case "<rational>":
                    method = method.GenMethodSetOption_RationalCheck(paramName, filterData);
                    break;
                case "<channel_layout>":
                    method = method.GenMethodSetOption_EnumNameAttribute<ChannelLayout>(paramName, filterData);
                    break;
                case "<sample_fmt>":
                    method = method.GenMethodSetOption_EnumNameAttribute<AVSampleFormat>(paramName, filterData);
                    break;
                case "<string>":
                    if (filterData.Description.Contains("expression", StringComparison.OrdinalIgnoreCase) ||
                       paramName.EndsWith("expr", StringComparison.OrdinalIgnoreCase)
                       )
                    {
                        method = method.GenMethodSetOption_ExpressionValue(paramName, filterData);
                    }
                    else
                    {
                        method = method.GenMethodSetOption_ToString<string>(paramName, filterData);
                    }
                    break;
                //dictionary
                //binary
                default:
                    method = method.GenMethodSetOption_ToString<string>(paramName, filterData);
                    Console.WriteLine($"{returnTypeName}: function error: {filterData.Function.LineData}");
                    break;
            }


            return (method, enumDeclarationSyntax);
        }


        static (string?, EnumDeclarationSyntax?) GenEnum(FilterData filterData, string returnTypeName)
        {
            Dictionary<string, Match> pairs = new Dictionary<string, Match>();
            foreach (var item in filterData.Function.ChildLines)
            {
                Match match_enum = FilterData.regex_DocLineMethod.Match(item.LineData);
                if (match_enum.Success)
                {
                    string fieldName = match_enum.Groups[1].Value;
                    pairs[fieldName.FixNameRule()] = match_enum;
                }
                else Console.WriteLine($"enum {returnTypeName}{filterData.Name.UpperFirst()} error: {item.LineData}");
            }

            var enumMembers = new List<EnumMemberDeclarationSyntax>();
            foreach (var item in pairs)
            {
                // Attributes
                var attributes = new List<AttributeListSyntax>
                {
                    AttributeList(SingletonSeparatedList(
                        Attribute(IdentifierName(typeof(NameAttribute).FullName!))
                            .WithArgumentList(AttributeArgumentList(SingletonSeparatedList(
                                AttributeArgument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(item.Value.Groups[1].Value)))
                            )))
                    ))
                };
                var member = EnumMemberDeclaration(Identifier(item.Key))
                    .WithAttributeLists(List(attributes))
                    .WithLeadingTrivia(TriviaList(
                        Comment("/// <summary>"),
                        Comment($"/// {item.Value.Groups[0].Value.FixSummaryRule()}"),
                        Comment("/// </summary>")
                    ));
                if (int.TryParse(item.Value.Groups[2].Value, out int val))
                {
                    member = member.WithEqualsValue(EqualsValueClause(LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(val))));
                }
                enumMembers.Add(member);
            }
            if (!enumMembers.Any())
                return (null, null);

            string enumName = $"{returnTypeName}{filterData.Name.UpperFirst()}";
            EnumDeclarationSyntax enumDeclarationSyntax = EnumDeclaration(enumName)
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithMembers(SeparatedList(enumMembers))
                .WithLeadingTrivia(TriviaList(
                    Comment("/// <summary>"),
                    Comment($"/// {filterData.Description.FixSummaryRule()}"),
                    Comment("/// </summary>")
                ));


            return (enumName, enumDeclarationSyntax);
        }

    }
}
