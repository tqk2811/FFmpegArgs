using System;
using System.Text.RegularExpressions;

namespace FFmpegArgs.Executes
{
    public class RenderProgress
    {
        static readonly Regex regex
            = new Regex(@"frame= *(\d+) fps= *([0-9.]+).*?size= *(N\/A|[0-9.]+kB).*?time= *(\d{2}:\d{2}:\d{2}\.\d+).*?bitrate= *(N\/A|[0-9.]+kbits\/s).*?speed= *([0-9.]+)x");
        public static RenderProgress FromProgressString(string progress)
        {
            if(!string.IsNullOrWhiteSpace(progress))
            {
                Match match = regex.Match(progress);
                if (match.Success && match.Groups.Count == 7)
                {
                    return new RenderProgress
                    {
                        Frame = int.Parse(match.Groups[1].Value),
                        Fps = double.Parse(match.Groups[2].Value),
                        Size = match.Groups[3].Value.Equals("N/A") ? double.NaN : double.Parse(match.Groups[3].Value.Replace("kB",string.Empty)),
                        Time = TimeSpan.Parse(match.Groups[4].Value),
                        Bitrate = match.Groups[5].Value.Equals("N/A") ? double.NaN : double.Parse(match.Groups[5].Value.Replace("kbits/s", string.Empty)),
                        Speed = float.Parse(match.Groups[6].Value)
                    };
                }
            }
            return null;
        }

        internal RenderProgress() { }

        public int Frame { get; private set; }

        public double Fps { get; private set; }

        /// <summary>
        /// Size in kB
        /// </summary>
        public double Size { get; private set; }

        public TimeSpan Time { get; private set; }

        /// <summary>
        /// kbits/s
        /// </summary>
        public double Bitrate { get; private set; }

        public float Speed { get; private set; }

    }
}
