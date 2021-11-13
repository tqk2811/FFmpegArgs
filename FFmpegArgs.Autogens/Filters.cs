using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FFmpegArgs.Autogens
{
    internal static class Filters
    {
        static readonly IEnumerable<string> _skip = new string[]
        {
            "concat"
        };
        static readonly IEnumerable<string> _NameRule = new string[]
        {
            "float", "double", "short", "long", "int",
            "object", "out", "in", "base", "fixed",  "as", "new", "string", "if", "default"
        };
        static Regex regex_filter = new Regex("^([TSC.]{3}) +([a-z0-9_]+) +([AVN|]{1,}->[AVN|]{1,}) +(.+)$");
        static Regex regex_DocLineMethod = new Regex("^([0-9A-z-+<>_-]+) +(|[0-9A-z<>-]+) +([.EDFVASXRBTP]{11})(.*?|)$");
        static Regex regex_DocLineMethodFromTo = new Regex("from ([0-9A-Z-+._e]+) to ([0-9A-Z-+._e]+)");
        static Regex regex_DocLineMethodDefault = new Regex("default (.*?)(?=\\))");


        static string UpperFirst(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            if (int.TryParse(input.First().ToString(), out int r)) return $"_{input}";
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
        static string FixNameRule(this string input)
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

        static StreamWriter WriteUsing(this StreamWriter streamWriter)
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
        static StreamWriter WriteNameSpace(this StreamWriter streamWriter, string child = null)
        {
            if (string.IsNullOrWhiteSpace(child)) streamWriter.WriteLine($"namespace FFmpegArgs.Filters.Autogens");
            else streamWriter.WriteLine($"namespace FFmpegArgs.Filters.Autogens.{child}");
            return streamWriter;
        }

        static StreamWriter WriteFunction(this StreamWriter streamWriter, DocLine function, string className, out string enumData)
        {
            enumData = null;
            Match match_method = regex_DocLineMethod.Match(function.LineData);
            if (match_method.Success)
            {
                string name = match_method.Groups[1].Value;
                string type = match_method.Groups[2].Value;
                string flag = match_method.Groups[3].Value;
                string description = match_method.Groups[4].Value;


                Match match_fromto = regex_DocLineMethodFromTo.Match(description);
                //Match match_default = regex_DocLineMethodDefault.Match(description);

                string param = string.Empty;
                string body = string.Empty;
                switch (type)
                {
                    case "<double>":
                        param = $"double {name.FixNameRule()}";
                        body = $"=> this.SetOptionRange(\"{name}\", {name.FixNameRule()},{match_fromto.Groups[1].Value},{match_fromto.Groups[2].Value});";
                        break;

                    case "<int>":
                        if (function.ChildLines.Count == 0)
                        {
                            param = $"int {name.FixNameRule()}";
                            body = $"=> this.SetOptionRange(\"{name}\", {name.FixNameRule()},{match_fromto.Groups[1].Value},{match_fromto.Groups[2].Value});";
                        }
                        else
                        {
                            Dictionary<string, string> pairs = new Dictionary<string, string>();
                            foreach (var item in function.ChildLines)
                            {
                                Match match_enum = regex_DocLineMethod.Match(item.LineData);
                                if (match_enum.Success)
                                {
                                    string enumName = match_enum.Groups[1].Value;
                                    pairs[enumName.FixNameRule()] = enumName;
                                    //stringBuilder.AppendLine($"[Name(\"{enumName}\")] {enumName.FixNameRule()},");
                                }
                                else Console.WriteLine($"enum {className}{name.UpperFirst()} error: {item.LineData}");
                            }

                            StringBuilder stringBuilder = new StringBuilder();
                            stringBuilder.AppendLine($"public enum {className}{name.UpperFirst()}\r\n{{");
                            foreach (var item in pairs)
                            {
                                stringBuilder.AppendLine($"[Name(\"{item.Value}\")] {item.Key},");
                            }
                            stringBuilder.AppendLine($"}}");
                            enumData = stringBuilder.ToString();

                            param = $"{className}{name.UpperFirst()} {name.FixNameRule()}";
                            body = $"=> this.SetOption(\"{name}\", {name.FixNameRule()}.GetAttribute<NameAttribute>().Name);";
                        }
                        break;

                    case "<int64>":
                        param = $"long {name.FixNameRule()}";
                        body = $"=> this.SetOptionRange(\"{name}\", {name.FixNameRule()},{match_fromto.Groups[1].Value},{match_fromto.Groups[2].Value});";
                        break;

                    case "<float>":
                        param = $"float {name.FixNameRule()}";
                        body = $"=> this.SetOptionRange(\"{name}\", {name.FixNameRule()},{match_fromto.Groups[1].Value},{match_fromto.Groups[2].Value});";
                        break;

                    case "<boolean>":
                        param = $"bool flag";
                        body = $"=> this.SetOption(\"{name}\",flag.ToFFmpegFlag());";
                        break;

                    case "<string>":
                        param = $"string {name.FixNameRule()}";
                        body = $"=> this.SetOption(\"{name}\",{name.FixNameRule()});";
                        break;

                    case "<video_rate>"://string and int
                        //string
                        param = $"string r";
                        body = $"=> this.SetOption(\"{name}\", r);";

                        streamWriter.WriteSummary(description);
                        streamWriter.WriteLine($"public {className} {name.UpperFirst()}({param}) {body}");

                        //int
                        param = $"int r";
                        body = $"=> this.SetOptionRange(\"{name}\", r, 1, int.MaxValue);";
                        break;

                    case "<image_size>":
                        param = $"Size size";
                        body = $"=> this.SetOption(\"{name}\",$\"{{size.Width}}x{{size.Height}}\");";
                        break;

                    case "<duration>":
                        param = $"TimeSpan {name.FixNameRule()}";
                        body = $"=> this.SetOptionRange(\"{name}\",{name.FixNameRule()},TimeSpan.Zero,TimeSpan.MaxValue);";
                        break;

                    case "<color>":
                        param = $"Color {name.FixNameRule()}";
                        body = $"=> this.SetOption(\"{name}\",{name.FixNameRule()}.ToHexStringRGBA());";
                        break;

                    case "<pix_fmt>":
                        param = $"PixFmt {name.FixNameRule()}";
                        body = $"=> this.SetOption(\"{name}\",{name.FixNameRule()}.ToString());";
                        break;

                    case "<rational>":
                        param = $"string {name.FixNameRule()}";
                        body = $"=> this.SetOption(\"{name}\",{name.FixNameRule()});";
                        break;

                    case "<flags>":
                        {
                            Dictionary<string, string> pairs = new Dictionary<string, string>();
                            foreach (var item in function.ChildLines)
                            {
                                Match match_enum = regex_DocLineMethod.Match(item.LineData);
                                if (match_enum.Success)
                                {
                                    string enumName = match_enum.Groups[1].Value;
                                    pairs[enumName.FixNameRule()] = enumName;
                                }
                                else Console.WriteLine($"enum {className}{name.UpperFirst()} error: {item.LineData}");
                            }

                            StringBuilder stringBuilder = new StringBuilder();
                            stringBuilder.AppendLine($"public enum {className}{name.UpperFirst()}\r\n{{");
                            foreach (var item in pairs)
                            {
                                stringBuilder.AppendLine($"[Name(\"{item.Value}\")] {item.Key},");
                            }
                            stringBuilder.AppendLine($"}}");
                            enumData = stringBuilder.ToString();

                            param = $"{className}{name.UpperFirst()} {name.FixNameRule()}";
                            body = $"=> this.SetOption(\"{name}\", {name.FixNameRule()}.GetAttribute<NameAttribute>().Name);";
                        }
                        break;

                    case "<channel_layout>":
                        param = $"AV_CH_LAYOUT {name.FixNameRule()}";
                        body = $"=> this.SetOption(\"{name}\",{name.FixNameRule()}.GetAttribute<NameAttribute>().Name);";
                        break;

                    case "<sample_fmt>":
                        param = $"AVSampleFormat {name.FixNameRule()}";
                        body = $"=> this.SetOption(\"{name}\",{name.FixNameRule()}.GetAttribute<NameAttribute>().Name);";
                        break;

                    //flags
                    //dictionary
                    //binary
                    default:
                        param = $"string {name.FixNameRule()}";
                        body = $"=> this.SetOption(\"{name}\",{name.FixNameRule()});";
                        Console.WriteLine($"{className}: function error: {function.LineData}");
                        break;
                }
                streamWriter.WriteSummary(description);
                streamWriter.WriteLine($"public {className} {name.FixNameRule()}({param}) {body}");
            }
            else Console.WriteLine($"{className}: function error: {function.LineData}");
            return streamWriter;
        }

        static StreamWriter WriteSummary(this StreamWriter streamWriter, params string[] summarys)
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
                    streamWriter.WriteLine($"internal {className}({typeName.Input} input) : base(\"{name}\",input) {{ AddMapOut(); }}");
                    List<string> enumDatas = new List<string>();
                    foreach (var func in docLine.ChildLines)
                    {
                        streamWriter.WriteFunction(func, className, out string enumData);
                        if (!string.IsNullOrWhiteSpace(enumData)) enumDatas.Add(enumData);
                    }
                    streamWriter.WriteLine("}");

                    //Extensions
                    streamWriter.WriteLine($"public static class {className}Extensions");
                    streamWriter.WriteLine("{");
                    streamWriter.WriteSummary(description);
                    streamWriter.WriteLine($"public static {className} {className}(this {typeName.Input} input) => new {className}(input);");
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
                Input = nameof(ImageMap)
            };
            if (type.Equals("A->A")) return new TypeName()
            {
                Inheritance = nameof(AudioToAudioFilter),
                Input = nameof(AudioMap)
            };
            if (type.Equals("|->V")) return new TypeName()
            {
                Inheritance = nameof(SourceImageFilter),
                Input = nameof(FilterGraph)
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
        public string Inheritance { get; set; }
        public string Input { get; set; }
    }
}
