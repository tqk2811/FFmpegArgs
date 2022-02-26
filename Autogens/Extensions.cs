using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autogens
{
    internal static class Extensions
    {
        internal static StreamWriter WriteSummary(this StreamWriter streamWriter, params string[] summarys)
        {
            streamWriter.WriteLine("/// <summary>");
            foreach (var summary in summarys) streamWriter.WriteLine($"/// {summary.FixSummaryRule()}");
            streamWriter.WriteLine("/// </summary>");
            return streamWriter;
        }
        internal static StringBuilder WriteSummary(this StringBuilder stringBuilder, params string[] summarys)
        {
            stringBuilder.AppendLine("/// <summary>");
            foreach (var summary in summarys) stringBuilder.AppendLine($"/// {summary.FixSummaryRule()}");
            stringBuilder.AppendLine("/// </summary>");
            return stringBuilder;
        }
        internal static StreamWriter WriteNameSpace(this StreamWriter streamWriter, params string[] names)
        {
            streamWriter.WriteLine($"namespace {string.Join(".", names)}");
            return streamWriter;
        }
        internal static StreamWriter WriteNameSpace(this StreamWriter streamWriter, string name)
        {
            streamWriter.WriteLine($"namespace {name}");
            return streamWriter;
        }
        internal static string UpperFirst(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            if (int.TryParse(input.First().ToString(), out int r)) return $"_{input}";
            return input.First().ToString().ToUpper() + input.Substring(1);
        }


        static readonly IEnumerable<string> _NameRule = new string[]
        {
            "float", "double", "short", "long", "int", "null",
            "object", "out", "in", "base", "fixed",  "as", "new", "string", "if", "default"
        };
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

        static readonly Dictionary<string, string> _SummaryRule = new Dictionary<string, string>()
        {
            { "&", "&amp;" }
        };
        internal static string FixSummaryRule(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            foreach (var item in _SummaryRule)
            {
                int index = 0;
                do
                {
                    index = input.IndexOf(item.Key, index);
                    if(index >= 0)
                    {
                        int valIndex = input.IndexOf(item.Value, index);
                        if (valIndex == index)
                        {
                            index++;
                            continue;
                        }
                        else
                        {
                            input = input.Substring(0, index) + item.Value + input.Substring(index + item.Key.Length);
                            index++;
                        }
                    }
                }
                while (index >= 0);
            }
            return input;
        }
    }
}
