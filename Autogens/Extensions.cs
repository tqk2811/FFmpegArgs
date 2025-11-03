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
        internal static string XmlEscape(this string input)
        {
            return System.Security.SecurityElement.Escape(input);
        }
        internal static StreamWriter WriteSummary(this StreamWriter streamWriter, params string[] summarys)
        {
            streamWriter.WriteLine("/// <summary>");
            foreach (var summary in summarys) streamWriter.WriteLine(Inv($"/// {summary.FixSummaryRule()}"));
            streamWriter.WriteLine("/// </summary>");
            return streamWriter;
        }
        internal static StringBuilder WriteSummary(this StringBuilder stringBuilder, params string[] summarys)
        {
            stringBuilder.AppendLine("/// <summary>");
            foreach (var summary in summarys) stringBuilder.AppendLine(Inv($"/// {summary.FixSummaryRule()}"));
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
            return input.First().ToString().ToUpperInvariant() + input.Substring(1);
        }


        static readonly IEnumerable<string> _NameRule = new string[]
        {
            "float", "double", "short", "long", "int", "null",
            "object", "out", "in", "base", "fixed",  "as", "new", "string", "if", "default", "params", "ref", "using", "switch",
            "async", "await", "true", "false",
        };
        internal static string FixNameRule(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            input = input
                .ReplaceOrd("-", "_")
                .ReplaceOrd("(", "_")
                .ReplaceOrd(")", "_")
                .ReplaceOrd(".", "Dot")
                .ReplaceOrd("+", "Plus")
                .ReplaceOrd("<", "LessThan")
                .ReplaceOrd(">", "GreaterThan")
                .ReplaceOrd("&", "_And_")
                .ReplaceOrd(" ", "_")
                ;
            if (int.TryParse(input.First().ToString(), out int r)) return $"_{input}";
            if (_NameRule.Contains(input)) return $"_{input}";
            return input;
        }
         
        internal static string FixSummaryRule(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            input = System.Web.HttpUtility.HtmlEncode(input);
            return input;
        }
    }
}
