using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Autogens.Format
{
    internal static class FormatsGen
    {
        static Regex format_filter { get; } = new Regex("^ ([DEd ]{3}) (.*?) +(.*?)$");
        internal static void Gen(List<string> lines)
        {
            using StreamWriter DemuxingFileFormat = new StreamWriter(Path.Combine("FFmpegArgs.Cores", "Enums", $"DemuxingFileFormat.g.cs"), false);
            DemuxingFileFormat.WriteNameSpace("FFmpegArgs", "Cores", "Enums");
            DemuxingFileFormat.WriteLine("{");
            DemuxingFileFormat.WriteSummary();
            DemuxingFileFormat.WriteLine("public enum DemuxingFileFormat");
            DemuxingFileFormat.WriteLine("{");

            using StreamWriter MuxingFileFormat = new StreamWriter(Path.Combine("FFmpegArgs.Cores","Enums", $"MuxingFileFormat.g.cs"), false);
            MuxingFileFormat.WriteNameSpace("FFmpegArgs", "Cores", "Enums");
            MuxingFileFormat.WriteLine("{");
            MuxingFileFormat.WriteSummary();
            MuxingFileFormat.WriteLine("public enum MuxingFileFormat");
            MuxingFileFormat.WriteLine("{");


            foreach (var line in lines)
            {
                Match match = format_filter.Match(line);
                if(match.Success)
                {
                    if(match.Groups[1].Value.Contains("D"))
                    {
                        var split = match.Groups[2].Value.Split(',');
                        foreach(var item in split)
                        {
                            DemuxingFileFormat.WriteSummary(match.Groups[3].Value);
                            DemuxingFileFormat.WriteLine($"[Name(\"{item}\")]");
                            DemuxingFileFormat.WriteLine($"{item.FixNameRule()},");
                            DemuxingFileFormat.WriteLine();
                        }
                    }

                    if(match.Groups[1].Value.Contains("E"))
                    {
                        var split = match.Groups[2].Value.Split(',');
                        foreach (var item in split)
                        {
                            MuxingFileFormat.WriteSummary(match.Groups[3].Value);
                            MuxingFileFormat.WriteLine($"[Name(\"{item}\")]");
                            MuxingFileFormat.WriteLine($"{item.FixNameRule()},");
                            MuxingFileFormat.WriteLine();
                        }
                    }
                }
            }

            DemuxingFileFormat.WriteLine("}");
            DemuxingFileFormat.WriteLine("}");
            MuxingFileFormat.WriteLine("}");
            MuxingFileFormat.WriteLine("}");
        }
    }
}
