namespace FFmpegArgs.Executes
{
    /// <summary>
    /// 
    /// </summary>
    public class RenderProgress
    {
        static readonly Regex regex
            = new Regex(@"frame= *(\d+) fps= *([0-9.]+).*?size= *(N\/A|[0-9.]+kB).*?time= *(\d+:\d{1,2}:\d{1,2}\.\d+).*?bitrate= *(N\/A|[0-9.]+kbits\/s).*?speed= *([0-9.]+)x");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="progress"></param>
        /// <returns></returns>
        public static RenderProgress FromProgressString(string progress)
        {
            if (!string.IsNullOrWhiteSpace(progress))
            {
                Match match = regex.Match(progress);
                if (match.Success && match.Groups.Count == 7)
                {
                    try
                    {
                        return new RenderProgress
                        {
                            Frame = int.Parse(match.Groups[1].Value),
                            Fps = double.Parse(match.Groups[2].Value),
                            Size = match.Groups[3].Value.Equals("N/A") ? double.NaN : double.Parse(match.Groups[3].Value.Replace("kB", string.Empty)),
                            Time = ParseDuration(match.Groups[4].Value),
                            Bitrate = match.Groups[5].Value.Equals("N/A") ? double.NaN : double.Parse(match.Groups[5].Value.Replace("kbits/s", string.Empty)),
                            Speed = float.Parse(match.Groups[6].Value)
                        };
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return null;
        }
        private static readonly Regex DurationRegex = new(@"^(\d+):(\d{1,2}):(\d{1,2})\.(\d{1,3})", RegexOptions.Compiled);
        //https://github.com/rosenbjerg/FFMpegCore/blob/943662aa15e8cf73dce0b1a8b93ffe8e8bae274b/FFMpegCore/FFProbe/MediaAnalysis.cs#L166
        private static TimeSpan ParseDuration(string duration)
        {
            if (!string.IsNullOrEmpty(duration))
            {
                var match = DurationRegex.Match(duration);
                if (match.Success)
                {
                    // ffmpeg may provide < 3-digit number of milliseconds (omitting trailing zeros), which won't simply parse correctly
                    // e.g. 00:12:02.11 -> 12 minutes 2 seconds and 110 milliseconds
                    var millisecondsPart = match.Groups[4].Value;
                    if (millisecondsPart.Length < 3)
                    {
                        millisecondsPart = millisecondsPart.PadRight(3, '0');
                    }

                    var hours = int.Parse(match.Groups[1].Value);
                    var minutes = int.Parse(match.Groups[2].Value);
                    var seconds = int.Parse(match.Groups[3].Value);
                    var milliseconds = int.Parse(millisecondsPart);
                    return new TimeSpan(0, hours, minutes, seconds, milliseconds);
                }
                else
                {
                    return TimeSpan.Zero;
                }
            }
            else
            {
                return TimeSpan.Zero;
            }
        }




        internal RenderProgress() { }
        /// <summary>
        /// Frame rendered
        /// </summary>
        public int Frame { get; private set; }

        /// <summary>
        /// frame per second rendered
        /// </summary>
        public double Fps { get; private set; }
        /// <summary>
        /// Size in kB
        /// </summary>
        public double Size { get; private set; }

        /// <summary>
        /// Time of video rendered
        /// </summary>
        public TimeSpan Time { get; private set; }
        /// <summary>
        /// kbits/s
        /// </summary>
        public double Bitrate { get; private set; }
        /// <summary>
        /// Speed render / speed video play 1x
        /// </summary>
        public float Speed { get; private set; }
    }
}
