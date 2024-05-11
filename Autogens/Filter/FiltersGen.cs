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
                        Console.WriteLine($"{"Filters.Gen not found",-40}: {filter}");
                        continue;
                    }
                    if (_skip.Contains(name))
                    {
                        Console.WriteLine($"{"Filters.Gen skip",-40}: {filter}");
                        continue;
                    }
                    FilterTypeName typeName = GetFilterTypeName(type);
                    if (typeName == null)
                    {
                        Console.WriteLine($"{"Filters.Gen can't get FilterTypeName",-40}: {filter}");
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
                    streamWriter.WriteLine($"internal {className}({string.Join(", ", typeName.CtorArgs)}) " +
                        $": base(\"{name}\",{typeName.CtorArgsInheritance}) " +
                        $"{{ {typeName.CtorBody} }}");
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
                        if (filterFunction.IsObsolete)
                            streamWriter.WriteLine("[Obsolete]");
                        streamWriter.WriteLine(filterFunction);
                        if (!string.IsNullOrWhiteSpace(filterFunction.EnumData))
                            enumDatas.Add(filterFunction.EnumData);
                    }
                    streamWriter.WriteLine("}");
                    //Extensions
                    streamWriter.WriteSummary();
                    streamWriter.WriteLine($"public static partial class FilterGeneratedExtensions");
                    streamWriter.WriteLine("{");
                    //default extension
                    streamWriter.WriteSummary(description);
                    streamWriter.WriteLine($"public static {className} {className}(this {string.Join(", ", typeName.ExtensionArgs)}) " +
                        $"=> new {className}({string.Join(", ", typeName.ExtensionParams)});");
                    streamWriter.WriteLine("}");
                    //enum
                    enumDatas.ForEach(x => streamWriter.WriteLine(x));
                    streamWriter.WriteLine("}");
                }
                else
                {
                    Console.WriteLine($"{"Filters.Gen error",-40}:{filter}");
                }
            }
        }

        static readonly Regex regex_parseTypeConvert = new Regex("(\\||N|V+|A+)->(\\||N|V+|A+)");
        static FilterTypeName GetFilterTypeName(string type)
        {
            Match match = regex_parseTypeConvert.Match(type);
            if (match.Success &&
                !type.Contains("N->N", StringComparison.OrdinalIgnoreCase) && //ignore N->N
                !type.Contains("|->N", StringComparison.OrdinalIgnoreCase) && //ignore |->N
                !type.Contains("->|", StringComparison.OrdinalIgnoreCase)//ignore ->|
                )
            {
                string from = match.Groups[1].Value;
                string to = match.Groups[2].Value;
                int InputCount = from.Count(x => x == 'A' || x == 'V');// 'N' or '|' result count 0
                int OutputCount = to.Count(x => x == 'A' || x == 'V');// 'N' result count 0
                string InType = from[0] switch
                {
                    '|' => "Source",
                    'A' => "Audio",
                    'V' => "Image",
                    _ => string.Empty,// N
                };
                string OutType = to[0] switch
                {
                    'V' => "Image",
                    'A' => "Audio",
                    _ => string.Empty,// N
                };
                if (string.IsNullOrWhiteSpace(InType)) InType = OutType;
                if (string.IsNullOrWhiteSpace(OutType)) OutType = InType;


                FilterTypeName filterTypeName = new FilterTypeName();
                switch (from[0])
                {
                    case '|'://InType = OutType
                        filterTypeName.Inheritance = $"{InType}To{OutType}Filter";
                        filterTypeName.CtorArgs.Add($"I{OutType}FilterGraph input");
                        filterTypeName.CtorArgsInheritance = $"input";
                        filterTypeName.ExtensionArgs.Add($"I{OutType}FilterGraph input0");
                        filterTypeName.ExtensionParams.Add($"input0");
                        break;

                    case 'N'://InType = OutType
                        filterTypeName.Inheritance = $"{InType}To{OutType}Filter";
                        filterTypeName.CtorArgs.Add($"params {InType}Map[] inputs");
                        filterTypeName.CtorArgsInheritance = $"inputs";
                        filterTypeName.ExtensionArgs.Add($"IEnumerable<{InType}Map> inputs");
                        filterTypeName.ExtensionParams.Add($"inputs.ToArray()");
                        break;

                    case 'A'://InputCount > 0
                    case 'V':
                        filterTypeName.Inheritance = $"{InType}To{OutType}Filter";
                        if (InputCount == 1)
                        {
                            filterTypeName.CtorArgs.Add($"{InType}Map input");
                            filterTypeName.CtorArgsInheritance = $"input";
                        }
                        else
                        {
                            filterTypeName.CtorArgs.Add($"params {InType}Map[] inputs");
                            filterTypeName.CtorArgsInheritance = $"inputs";
                        }
                        for (int i = 0; i < InputCount; i++)
                        {
                            filterTypeName.ExtensionArgs.Add($"{InType}Map input{i}");
                            filterTypeName.ExtensionParams.Add($"input{i}");
                        }
                        break;
                }
                switch (OutputCount)
                {
                    case 0://N
                        filterTypeName.CtorArgs.Insert(0, $"int outputCount");
                        filterTypeName.CtorBody = "AddMultiMapOut(outputCount);";
                        filterTypeName.ExtensionArgs.Add($"int outputCount");
                        filterTypeName.ExtensionParams.Insert(0, $"outputCount");
                        break;
                    case 1:
                        filterTypeName.CtorBody = "AddMapOut();";
                        break;
                    default:
                        filterTypeName.CtorBody = $"AddMultiMapOut({OutputCount});";
                        break;
                }
                return filterTypeName;




                //filterTypeName.Inheritance = $"{InType}{OutType}Filter";


                //if (type.Contains('A'))
                //{
                //}
                //else if (type.Contains('V'))
                //{
                //    int InputCount = from.Count(x => x == 'V');// 'N' or '|' result count 0
                //    int OutputCount = to.Count(x => x == 'V');// 'N' result count 0
                //    switch (from[0])
                //    {
                //        case '|':
                //            filterTypeName.Inheritance = nameof(SourceImageFilter);
                //            filterTypeName.CtorArgs.Add($"{nameof(IImageFilterGraph)} input");
                //            filterTypeName.CtorArgsInheritance = $"input";
                //            filterTypeName.ExtensionArgs.Add($"{nameof(IImageFilterGraph)} input0");
                //            filterTypeName.ExtensionParams.Add($"input0");
                //            break;

                //        case 'N':
                //            filterTypeName.Inheritance = nameof(ImageToImageFilter);
                //            filterTypeName.CtorArgs.Add($"params {nameof(ImageMap)}[] inputs");
                //            filterTypeName.CtorArgsInheritance = $"inputs";
                //            filterTypeName.ExtensionArgs.Add($"IEnumerable<{nameof(ImageMap)}> inputs");
                //            filterTypeName.ExtensionParams.Add($"inputs.ToArray()");
                //            break;

                //        case 'V'://InputCount > 0
                //            filterTypeName.Inheritance = nameof(ImageToImageFilter);
                //            if (InputCount == 1)
                //            {
                //                filterTypeName.CtorArgs.Add($"{nameof(ImageMap)} input");
                //                filterTypeName.CtorArgsInheritance = $"input";
                //            }
                //            else
                //            {
                //                filterTypeName.CtorArgs.Add($"params {nameof(ImageMap)}[] inputs");
                //                filterTypeName.CtorArgsInheritance = $"inputs";
                //            }
                //            for (int i = 0; i < InputCount; i++)
                //            {
                //                filterTypeName.ExtensionArgs.Add($"{nameof(ImageMap)} input{i}");
                //                filterTypeName.ExtensionParams.Add($"input{i}");
                //            }
                //            break;
                //    }
                //    switch (OutputCount)
                //    {
                //        case 0://N
                //            filterTypeName.CtorArgs.Insert(0, $"int outputCount");
                //            filterTypeName.CtorBody = "AddMultiMapOut(outputCount);";
                //            filterTypeName.ExtensionArgs.Add($"int outputCount");
                //            filterTypeName.ExtensionParams.Insert(0, $"outputCount");
                //            break;
                //        case 1:
                //            filterTypeName.CtorBody = "AddMapOut();";
                //            break;
                //        default:
                //            filterTypeName.CtorBody = $"AddMultiMapOut({OutputCount});";
                //            break;
                //    }
                //    return filterTypeName;
                //}
            }
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
