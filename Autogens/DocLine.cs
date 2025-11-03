using System;
using System.Collections.Generic;
using System.Linq;
namespace Autogens
{
    internal class DocLine
    {
        public string LineData { get; set; }
        public List<DocLine> ChildLines { get; } = new List<DocLine>();
        public override string ToString()
        {
            return LineData;
        }
        public static List<DocLine> GetDocLine(List<string> lines)
        {
            List<DocLine> docLines = new List<DocLine>();
            foreach (var line in lines.Where(x => !string.IsNullOrWhiteSpace(x)))
            {
                if (line.StartsWithOrd("     "))
                {
                    docLines.LastOrDefault()
                        ?.ChildLines?.LastOrDefault()
                        ?.ChildLines?.Add(new DocLine() { LineData = line.Trim() });
                }
                else if (line.StartsWithOrd("  "))
                {
                    docLines.LastOrDefault()
                        ?.ChildLines?.Add(new DocLine() { LineData = line.Trim() });
                }
                else
                {
                    if (line.StartsWithOrd(" ")) Console.WriteLine(Inv($"Error line: {line}"));
                    else docLines.Add(new DocLine() { LineData = line.Trim() });
                }
            }
            return docLines;
        }
    }
}
