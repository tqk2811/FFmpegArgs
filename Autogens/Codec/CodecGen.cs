using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Autogens.Codec
{
    internal static class CodecGen
    {
        static readonly Regex regex_parse = new Regex("^ ([.DEVASDTILS]{6}) (.*?) +(.*?)$");


        internal static void Gen(List<string> lines)
        {
            using StreamWriter codecs = new StreamWriter(Path.Combine("FFmpegArgs.Cores", "Enums", $"Codecs.g.cs"), false);
            codecs.WriteNameSpace("FFmpegArgs", "Cores", "Enums");
            codecs.WriteLine("{");
            codecs.WriteSummary();
            codecs.WriteLine("public enum Codecs");
            codecs.WriteLine("{");

            foreach (var line in lines.Skip(12))
            {
                Match match = regex_parse.Match(line);
                if (match.Success)
                {
                    codecs.WriteSummary(match.Groups[3].Value);
                    codecs.Write($"[Name(\"{match.Groups[2].Value}\")]");
                    codecs.WriteLine($"{match.Groups[2].Value.FixNameRule()},");
                    codecs.WriteLine();
                }
            }

            codecs.WriteLine("}");
            codecs.WriteLine("}");
        }
    }
}
