using FFmpegArgs;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using FFmpegArgs.Cores.Interfaces;
namespace Autogens.Filter
{
    internal static class FiltersGen
    {
        const string _FilterNamespace = "FFmpegArgs.Filters.Generated";
        static readonly IEnumerable<string> _skip = new string[]
        {
            //"concat"
        };

        static Regex regex_filter { get; } = new Regex("^([TSC.]{3}) +([a-z0-9_]+) +([AVN|]{1,}->[AVN|]{1,}) +(.+)$");
        //static Regex regex_DocLineMethodDefault { get; } = new Regex("default (.*?)(?=\\))");



        private static StreamWriter WriteAutogensNameSpace(this StreamWriter streamWriter, string child = null)
        {
            if (string.IsNullOrWhiteSpace(child)) return streamWriter.WriteNameSpace(_FilterNamespace);
            else return streamWriter.WriteNameSpace($"{_FilterNamespace}.{child}");
        }

        public static void Gen(List<string> filters, List<DocLine> docLines)
        {
            var genDir = Path.Combine(_FilterNamespace, "Gen");
            Directory.CreateDirectory(genDir);
            foreach (var file in Directory.GetFiles(genDir, "*.g.cs"))
            {
                File.Delete(file);
            }

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
                    FilterTypeName typeName = GetFilterInheritance(type);
                    if (typeName == null)
                    {
                        Console.WriteLine($"Filters.Gen skip ({type}):{filter}");
                        continue;
                    }
                    var interfaces = GetFilterInterface(support).ToList();
                    interfaces.Insert(0, typeName.Inheritance);
                    string className = $"{name.UpperFirst()}FilterGen";
                    using StreamWriter streamWriter = new StreamWriter(Path.Combine(_FilterNamespace, "Gen", $"{className}.g.cs"), false);
                    streamWriter.WriteAutogensNameSpace();
                    streamWriter.WriteLine("{");
                    streamWriter.WriteSummary(filter);
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
                    streamWriter.WriteSummary();
                    streamWriter.WriteLine($"public static partial class FilterGeneratedExtensions");
                    streamWriter.WriteLine("{");
                    //default extension
                    streamWriter.WriteSummary(description);
                    streamWriter.WriteLine($"public static {className} {className}(this {string.Join(", ", inputs)}) => new {className}({string.Join(", ", paramsInput)});");
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

        static FilterTypeName GetFilterInheritance(string type)
        {
            if (type.Equals("V->V")) return new FilterTypeName()
            {
                Inheritance = nameof(ImageToImageFilter),
                Input = nameof(ImageMap),
            };
            if (type.Equals("VV->V")) return new FilterTypeName()
            {
                Inheritance = nameof(ImageToImageFilter),
                Input = nameof(ImageMap),
                InputCount = 2,
            };
            if (type.Equals("VVV->V")) return new FilterTypeName()
            {
                Inheritance = nameof(ImageToImageFilter),
                Input = nameof(ImageMap),
                InputCount = 3,
            };
            if (type.Equals("VVVV->V")) return new FilterTypeName()
            {
                Inheritance = nameof(ImageToImageFilter),
                Input = nameof(ImageMap),
                InputCount = 4,
            };
            if (type.Equals("|->V")) return new FilterTypeName()
            {
                Inheritance = nameof(SourceImageFilter),
                Input = nameof(IImageFilterGraph)
            };

            if (type.Equals("A->A")) return new FilterTypeName()
            {
                Inheritance = nameof(AudioToAudioFilter),
                Input = nameof(AudioMap)
            };
            if (type.Equals("AA->A")) return new FilterTypeName()
            {
                Inheritance = nameof(AudioToAudioFilter),
                Input = nameof(AudioMap),
                InputCount = 2,
            };
            if (type.Equals("|->A")) return new FilterTypeName()
            {
                Inheritance = nameof(SourceAudioFilter),
                Input = nameof(IAudioFilterGraph)
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
}
