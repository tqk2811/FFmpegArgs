using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FFmpegArgs.Autogens
{
    internal class FilterData
    {
        internal static Regex regex_DocLineMethod { get; } = new Regex("^([0-9A-z-+<>_-]+) +(|[0-9A-z<>-]+) +([.EDFVASXRBTP]{11})(.*?|)$");
        static Regex regex_DocLineMethodFromTo { get; } = new Regex("from ([0-9A-Z-+._e]+) to ([0-9A-Z-+._e]+)");

        internal FilterData(DocLine function)
        {
            this.Function = function;
            Match match_method = regex_DocLineMethod.Match(function.LineData);
            IsSuccess = match_method.Success;
            if (IsSuccess)
            {
                Name = match_method.Groups[1].Value;
                Type = match_method.Groups[2].Value;
                Flag = match_method.Groups[3].Value;
                Description = match_method.Groups[4].Value;
                Match match_fromto = regex_DocLineMethodFromTo.Match(Description);
                if(match_fromto.Success)
                {
                    Min = match_fromto.Groups[1].Value;
                    Max = match_fromto.Groups[2].Value;
                }
            }
        }
        public DocLine Function { get; }
        public bool IsSuccess { get; }
        public string Name { get; }
        public string Type { get; }
        public string Flag { get; }
        public string Description { get; }
        public string Min { get; }
        public string Max { get; }
    }

    internal class FilterFunction
    {
        private FilterFunction()
        {

        }
        public string ReturnTypeName { get; set; }
        public string FunctionName { get; set; }
        public string Description { get; set; }
        public string FunctionParamType { get; set; }
        public string FunctionBody { get; set; }
        public string EnumData { get; set; }

        public override string ToString()
        {
            return $"public {ReturnTypeName} {FunctionName}({FunctionParamType} {FunctionName}) {FunctionBody}";
        }

        internal static FilterFunction GetFilterFunction(FilterData filterData, string returnTypeName)
        {
            if(filterData.IsSuccess)
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
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(Extensions.ToFFmpegFlag)}());";
                        break;

                    case "<string>":
                        filterFunction.FunctionParamType = $"string";
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName});";
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
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(FilterExtensions.ToHexStringRGBA)}());";
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
                        filterFunction.FunctionParamType = nameof(AV_CH_LAYOUT);
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(FilterExtensions.GetAttribute)}<{nameof(NameAttribute)}>().{nameof(NameAttribute.Name)});";
                        break;

                    case "<sample_fmt>":
                        filterFunction.FunctionParamType = nameof(AVSampleFormat);
                        filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\",{filterFunction.FunctionName}.{nameof(FilterExtensions.GetAttribute)}<{nameof(NameAttribute)}>().{nameof(NameAttribute.Name)});";
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
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            foreach (var item in filterData.Function.ChildLines)
            {
                Match match_enum = FilterData.regex_DocLineMethod.Match(item.LineData);
                if (match_enum.Success)
                {
                    string enumName = match_enum.Groups[1].Value;
                    pairs[enumName.FixNameRule()] = enumName;
                }
                else Console.WriteLine($"enum {returnTypeName}{filterData.Name.UpperFirst()} error: {item.LineData}");
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"public enum {returnTypeName}{filterData.Name.UpperFirst()}\r\n{{");
            foreach (var item in pairs)
            {
                stringBuilder.AppendLine($"[Name(\"{item.Value}\")] {item.Key},");
            }
            stringBuilder.AppendLine($"}}");
            filterFunction.EnumData = stringBuilder.ToString();

            filterFunction.FunctionParamType = $"{returnTypeName}{filterData.Name.UpperFirst()}";
            filterFunction.FunctionBody = $"=> this.SetOption(\"{filterData.Name}\", {filterFunction.FunctionName}.{nameof(FilterExtensions.GetAttribute)}<{nameof(NameAttribute)}>().{nameof(NameAttribute.Name)});";
        }
    }

    internal static class FiltersGen
    {
        static readonly IEnumerable<string> _skip = new string[]
        {
            //"concat"
        };
        static readonly IEnumerable<string> _NameRule = new string[]
        {
            "float", "double", "short", "long", "int",
            "object", "out", "in", "base", "fixed",  "as", "new", "string", "if", "default"
        };
        static Regex regex_filter { get; } = new Regex("^([TSC.]{3}) +([a-z0-9_]+) +([AVN|]{1,}->[AVN|]{1,}) +(.+)$");
        //static Regex regex_DocLineMethodDefault { get; } = new Regex("default (.*?)(?=\\))");


        internal static string UpperFirst(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            if (int.TryParse(input.First().ToString(), out int r)) return $"_{input}";
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
        internal static string FixNameRule(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            input = input
                .Replace("-", "_")
                .Replace("(", "_")
                .Replace(")", "_")
                .Replace(".", "Dot")
                .Replace("+", "Plus")
                .Replace("<", "LessThan")
                .Replace(">", "GreaterThan");
            if (int.TryParse(input.First().ToString(), out int r)) return $"_{input}";
            if (_NameRule.Contains(input)) return $"_{input}";
            return input;
        }

        internal static StreamWriter WriteUsing(this StreamWriter streamWriter)
        {
            streamWriter.WriteLine("using System;");
            streamWriter.WriteLine("using System.Linq;");
            streamWriter.WriteLine("using System.Drawing;");
            streamWriter.WriteLine("using System.Collections.Generic;");
            streamWriter.WriteLine("using FFmpegArgs;");
            streamWriter.WriteLine("using FFmpegArgs.Cores;");
            streamWriter.WriteLine("using FFmpegArgs.Cores.Filters;");
            streamWriter.WriteLine("using FFmpegArgs.Cores.Maps;");
            streamWriter.WriteLine("using FFmpegArgs.Expressions;");
            streamWriter.WriteLine("using FFmpegArgs.Filters;");
            streamWriter.WriteLine("using FFmpegArgs.Filters.Enums;");
            return streamWriter;
        }
        internal static StreamWriter WriteNameSpace(this StreamWriter streamWriter, string child = null)
        {
            if (string.IsNullOrWhiteSpace(child)) streamWriter.WriteLine($"namespace FFmpegArgs.Filters.Autogens");
            else streamWriter.WriteLine($"namespace FFmpegArgs.Filters.Autogens.{child}");
            return streamWriter;
        }
        internal static StreamWriter WriteSummary(this StreamWriter streamWriter, params string[] summarys)
        {
            streamWriter.WriteLine("/// <summary>");
            foreach (var summary in summarys) streamWriter.WriteLine($"/// {summary}");
            streamWriter.WriteLine("/// </summary>");
            return streamWriter;
        }










        public static void Gen(List<string> filters, List<DocLine> docLines)
        {
            foreach (var filter in filters)
            {
                Match match = regex_filter.Match(filter);
                if (match.Success)
                {
                    string support = match.Groups[1].Value;
                    string name = match.Groups[2].Value;
                    string type = match.Groups[3].Value;
                    string description = match.Groups[4].Value;
                    DocLine docLine = docLines.FirstOrDefault(x => x.LineData.StartsWith($"{name} AVOptions:"));

                    if (docLine == null)
                    {
                        Console.WriteLine($"Filters.Gen not found ({name}):{filter}");
                        continue;
                    }

                    if (_skip.Contains(name))
                    {
                        Console.WriteLine($"Filters.Gen skip ({name}):{filter}");
                        continue;
                    }

                    TypeName typeName = GetFilterInheritance(type);
                    if (typeName == null)
                    {
                        Console.WriteLine($"Filters.Gen skip ({type}):{filter}");
                        continue;
                    }

                    var interfaces = GetFilterInterface(support).ToList();
                    interfaces.Insert(0, typeName.Inheritance);

                    string className = $"{name.UpperFirst()}FilterGen";
                    using StreamWriter streamWriter = new StreamWriter($"FFmpegArgs.Filters.Autogen\\{className}.g.cs", false);
                    streamWriter.WriteUsing();
                    streamWriter.WriteNameSpace();
                    streamWriter.WriteLine("{");
                    streamWriter.WriteLine($"public class {className} : {string.Join(",", interfaces)}");
                    streamWriter.WriteLine("{");
                    if (typeName.InputCount == 1)
                    {
                        streamWriter.WriteLine($"internal {className}({typeName.Input} input) : base(\"{name}\",input) {{ AddMapOut(); }}");
                    }
                    else
                    {
                        streamWriter.WriteLine($"internal {className}(params {typeName.Input}[] inputs) : base(\"{name}\",inputs) {{ AddMapOut(); }}");
                    }
                    List<string> enumDatas = new List<string>();


                    var filterFunctions = docLine.ChildLines
                        .Select(x => new FilterData(x))
                        .Where(x => x.IsSuccess)
                        .Select(x => FilterFunction.GetFilterFunction(x, className))
                        .Where(x => x != null)
                        .ToList();
                    //remove function alias (same description, and name start with)
                    var removes = filterFunctions
                        .GroupBy(x => x.Description)
                        .Where(x => x.Count() == 2)
                        .Select(x => x.OrderBy(y => y.FunctionName.Length))
                        .Where(x => x.Last().FunctionName.StartsWith(x.First().FunctionName))
                        .Select(x => x.First())
                        .ToList();

                    foreach (var filterFunction in filterFunctions.Except(removes))
                    {
                        streamWriter.WriteSummary(filterFunction.Description);
                        streamWriter.WriteLine(filterFunction);
                        if (!string.IsNullOrWhiteSpace(filterFunction.EnumData))
                            enumDatas.Add(filterFunction.EnumData);
                    }

                    streamWriter.WriteLine("}");

                    //Extensions
                    List<string> inputs = new List<string>();
                    List<string> paramsInput = new List<string>();
                    for (int i = 0; i < typeName.InputCount; i++)
                    {
                        inputs.Add($"{typeName.Input} input{i}");
                        paramsInput.Add($"input{i}");
                    }

                    streamWriter.WriteLine($"public static class {className}Extensions");
                    streamWriter.WriteLine("{");
                    //default extension
                    streamWriter.WriteSummary(description);
                    streamWriter.WriteLine($"public static {className} {className}(this {string.Join(", ", inputs)}) => new {className}({string.Join(", ", paramsInput)});");
                    streamWriter.WriteSummary(description);
                    //config extension
                    streamWriter.WriteLine($"public static {className} {className}(this {string.Join(", ", inputs)},{className}Config config)");
                    streamWriter.WriteLine("{");
                    streamWriter.WriteLine($"var result = new {className}({string.Join(", ", paramsInput)});");
                    foreach (var filterFunction in filterFunctions.Except(removes))
                    {
                        switch(filterFunction.FunctionParamType)
                        {
                            case "string":
                                streamWriter.WriteLine($"if(!string.{nameof(string.IsNullOrWhiteSpace)}(config?.{filterFunction.FunctionName})) result.{filterFunction.FunctionName}(config.{filterFunction.FunctionName});");
                                break;

                            case nameof(Rational)://class
                                streamWriter.WriteLine($"if(config?.{filterFunction.FunctionName} != null) result.{filterFunction.FunctionName}(config.{filterFunction.FunctionName});");
                                break;


                            default://struct
                                streamWriter.WriteLine($"if(config?.{filterFunction.FunctionName} != null) result.{filterFunction.FunctionName}(config.{filterFunction.FunctionName}.Value);");
                                break;
                        }
                        
                    }
                    if(interfaces.Contains(nameof(ITimelineSupport)))
                    {
                        streamWriter.WriteLine($"if(!string.{nameof(string.IsNullOrWhiteSpace)}(config?.{nameof(ITimelineSupport).Substring(1)})) result.{nameof(TimelineSupportExtension.Enable)}(config.{nameof(ITimelineSupport).Substring(1)});");
                    }
                    streamWriter.WriteLine("return result;");
                    streamWriter.WriteLine("}");
                    streamWriter.WriteLine("}");

                    //config class
                    var interfaceConfigs = new List<string>();
                    if (interfaces.Contains(nameof(ITimelineSupport)))
                    {
                        interfaceConfigs.Add(nameof(ITimelineSupportConfig));
                    }

                    streamWriter.WriteLine($"public class {className}Config");
                    if(interfaceConfigs.Count > 0) streamWriter.WriteLine(":" + string.Join(",", interfaceConfigs));
                    streamWriter.WriteLine("{");
                    foreach (var filterFunction in filterFunctions.Except(removes))
                    {
                        streamWriter.WriteSummary(filterFunction.Description);
                        switch (filterFunction.FunctionParamType)
                        {
                            case "string":
                            case nameof(Rational)://class
                                streamWriter.WriteLine($"public {filterFunction.FunctionParamType} {filterFunction.FunctionName} {{ get; set; }}"); 
                                break;


                            default://struct
                                streamWriter.WriteLine($"public {filterFunction.FunctionParamType}? {filterFunction.FunctionName} {{ get; set; }}"); 
                                break;
                        }
                        
                    }
                    if (interfaces.Contains(nameof(ITimelineSupport)))
                    {
                        streamWriter.WriteLine($"public string {nameof(ITimelineSupport).Substring(1)} {{ get; set; }}");
                    }
                    streamWriter.WriteLine("}");

                    //enum
                    enumDatas.ForEach(x => streamWriter.WriteLine(x));

                    streamWriter.WriteLine("}");
                }
                else
                {
                    Console.WriteLine($"Filters.Gen error:{filter}");
                }
            }
        }



        static TypeName GetFilterInheritance(string type)
        {
            if (type.Equals("V->V")) return new TypeName()
            {
                Inheritance = nameof(ImageToImageFilter),
                Input = nameof(ImageMap),
            };
            if (type.Equals("VV->V")) return new TypeName()
            {
                Inheritance = nameof(ImageToImageFilter),
                Input = nameof(ImageMap),
                InputCount = 2,
            };
            if (type.Equals("VVV->V")) return new TypeName()
            {
                Inheritance = nameof(ImageToImageFilter),
                Input = nameof(ImageMap),
                InputCount = 3,
            };
            if (type.Equals("VVVV->V")) return new TypeName()
            {
                Inheritance = nameof(ImageToImageFilter),
                Input = nameof(ImageMap),
                InputCount = 4,
            };
            if (type.Equals("|->V")) return new TypeName()
            {
                Inheritance = nameof(SourceImageFilter),
                Input = nameof(FilterGraph)
            };


            if (type.Equals("A->A")) return new TypeName()
            {
                Inheritance = nameof(AudioToAudioFilter),
                Input = nameof(AudioMap)
            };
            if (type.Equals("AA->A")) return new TypeName()
            {
                Inheritance = nameof(AudioToAudioFilter),
                Input = nameof(AudioMap),
                InputCount = 2,
            };
            if (type.Equals("|->A")) return new TypeName()
            {
                Inheritance = nameof(SourceAudioFilter),
                Input = nameof(FilterGraph)
            };


            //skip N->? , ?->N 
            return null;
        }

        static IEnumerable<string> GetFilterInterface(string support)
        {
            if (support[0] == 'T') yield return nameof(ITimelineSupport);
            if (support[1] == 'S') yield return nameof(ISliceThreading);
            if (support[2] == 'C') yield return nameof(ICommandSupport);
        }
    }



    class TypeName
    {
        public int InputCount { get; set; } = 1;
        public int OutputCount { get; set; } = 1;
        public string Inheritance { get; set; }
        public string Input { get; set; }
    }
}
