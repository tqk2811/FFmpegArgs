using System;
using System.Text.RegularExpressions;

namespace FFmpegArgs.Executes
{
    public class RenderProgress
    {
        static readonly Regex regex
            = new Regex(@"frame= *(\d+) fps= *([0-9.]+).*?size= *([0-9.]+)kB time= *(\d{2}:\d{2}:\d{2}.\d+) bitrate= *([0-9.]+)kbits\/s speed= *([0-9.]+)x");
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
                        Size = double.Parse(match.Groups[3].Value),
                        Time = TimeSpan.Parse(match.Groups[4].Value),
                        Bitrate = double.Parse(match.Groups[5].Value),
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
