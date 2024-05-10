using FFmpegArgs.Cores.Attributes;
using FFmpegArgs.Cores.Enums;
using FFmpegArgs.Cores.Utils;
using FFmpegArgs.Filters;
using FFmpegArgs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using FFmpegArgs.Filters.Expressions;
namespace Autogens.Filter
{
    internal class FilterFunction
    {
        private FilterFunction()
        {
        }
        public string ReturnTypeName { get; private set; }
        public string FunctionName { get; private set; }
        public string Description { get; private set; }
        public string FunctionParamType { get; private set; }
        public string FunctionBody { get; private set; }
        public string EnumData { get; private set; }
        public override string ToString()
        {
            return $"public {ReturnTypeName} {FunctionName}({FunctionParamType} {FunctionName}) {FunctionBody}";
        }
        internal static FilterFunction GetFilterFunction(FilterData filterData, string returnTypeName)
        {
            if (filterData.IsSuccess)
            {
                FilterFunction filterFunction = new FilterFunction();
                filterFunction.ReturnTypeName = returnTypeName;
                filterFunction.FunctionName = filterData.Name.FixNameRule();
                filterFunction.Description = filterData.Description;
                switch (filterData.Type)
                {
                    case "<double>":
                        filterFunction.FunctionParamType = $"double";
                        filterFunction.FunctionBody = $"=> this.SetOptionRange(\"{filterData.Name}\", {filterFunction.FunctionName},{filterData.Min},{filterData.Max});";
                        break;
                    case "<int>":
                        if (filterData.Function.ChildLines.Count == 0)
                        {
                            filterFunction.FunctionParamType = $"int";
                            filterFunction.FunctionBody = $"=> this.SetOptionRange(\"{filterData.Name}\", {filterFunction.FunctionName},{filterData.Min},{filterData.Max});";
                        }
                        else WriteFunctionWithEnum(filterFunction, filterData, returnTypeName);
                        break;
                    case "<flags>":
                        WriteFunctionWithEnum(filterFunction, filterData, returnTypeName);
                        break;
                    case "<int64>":
                        filterFunction.FunctionParamType = $"long";
                        filterFunction.FunctionBody = $"=> this.SetOptionRange(\"{filterData.Name}\", {filterFunction.FunctionName},{filterData.Min},{filterData.Max});";
                        break;
                    case "<float>":
                        filterFunction.FunctionParamType = $"float";
                        filterFunction.FunctionBody = $"=> this.SetOptionRange(\"{filterData.Name}\", {filterFunction.FunctionName},{filterData.Min},{filterData.Max});";
                        break;
                    case "<boolean>":
                        filterFunction.FunctionParamType = $"bool";
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(UtilsExtension.ToFFmpegFlag)}());";
                        break;
                    case "<image_size>":
                        filterFunction.FunctionParamType = $"Size";
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",$\"{{{filterFunction.FunctionName}.Width}}x{{{filterFunction.FunctionName}.Height}}\");";
                        break;
                    case "<duration>":
                        filterFunction.FunctionParamType = $"TimeSpan";
                        filterFunction.FunctionBody = $"=> this.SetOptionRange(\"{filterData.Name}\",{filterFunction.FunctionName},TimeSpan.Zero,TimeSpan.MaxValue);";
                        break;
                    case "<color>":
                        filterFunction.FunctionParamType = $"Color";
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(UtilsExtension.ToHexStringRGBA)}());";
                        break;
                    case "<pix_fmt>":
                        filterFunction.FunctionParamType = nameof(PixFmt);
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.ToString());";
                        break;
                    case "<video_rate>":
                        filterFunction.FunctionParamType = nameof(Rational);
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName});";
                        break;
                    case "<rational>":
                        filterFunction.FunctionParamType = nameof(Rational);
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(Rational.Check)}({filterData.Min},{filterData.Max}));";
                        break;
                    case "<channel_layout>":
                        filterFunction.FunctionParamType = nameof(ChannelLayout);
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(AttributeExtensions.GetEnumAttribute)}<{nameof(NameAttribute)}>().{nameof(NameAttribute.Name)});";
                        break;
                    case "<sample_fmt>":
                        filterFunction.FunctionParamType = nameof(AVSampleFormat);
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(AttributeExtensions.GetEnumAttribute)}<{nameof(NameAttribute)}>().{nameof(NameAttribute.Name)});";
                        break;
                    case "<string>":
                        if (filterFunction.Description.Contains("expression", StringComparison.OrdinalIgnoreCase) ||
                           filterFunction.FunctionName.EndsWith("expr", StringComparison.OrdinalIgnoreCase))
                        {
                            filterFunction.FunctionParamType = nameof(ExpressionValue);
                            filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",(string){filterFunction.FunctionName});";
                        }
                        else
                        {
                            filterFunction.FunctionParamType = $"string";
                            filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName});";
                        }
                        break;
                    //dictionary
                    //binary
                    default:
                        filterFunction.FunctionParamType = $"string";
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName});";
                        Console.WriteLine($"{returnTypeName}: function error: {filterData.Function.LineData}");
                        break;
                }
                return filterFunction;
            }
            else Console.WriteLine($"{returnTypeName}: function error: {filterData.Function.LineData}");
            return null;
        }
        static void WriteFunctionWithEnum(FilterFunction filterFunction, FilterData filterData, string returnTypeName)
        {
            Dictionary<string, (string, string)> pairs = new Dictionary<string, (string, string)>();
            foreach (var item in filterData.Function.ChildLines)
            {
                Match match_enum = FilterData.regex_DocLineMethod.Match(item.LineData);
                if (match_enum.Success)
                {
                    string enumName = match_enum.Groups[1].Value;
                    pairs[enumName.FixNameRule()] = (enumName, item.LineData);
                }
                else Console.WriteLine($"enum {returnTypeName}{filterData.Name.UpperFirst()} error: {item.LineData}");
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.WriteSummary(filterFunction.Description);
            stringBuilder.AppendLine($"public enum {returnTypeName}{filterData.Name.UpperFirst()}\r\n{{");
            foreach (var item in pairs)
            {
                stringBuilder.WriteSummary(item.Value.Item2);
                stringBuilder.AppendLine($"[Name(\"{item.Value.Item1}\")] {item.Key},");
            }
            stringBuilder.AppendLine($"}}");
            filterFunction.EnumData = stringBuilder.ToString();
            filterFunction.FunctionParamType = $"{returnTypeName}{filterData.Name.UpperFirst()}";
            filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\", {filterFunction.FunctionName}.{nameof(AttributeExtensions.GetEnumAttribute)}<{nameof(NameAttribute)}>().{nameof(NameAttribute.Name)});";
        }
    }
}
