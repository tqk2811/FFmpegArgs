namespace FFmpegArgs.Executes
{
    /// <summary>
    /// 
    /// </summary>
    public class RenderProgress
    {
        static readonly Regex regex
            = new Regex(@"(|frame= *(\d+) fps= *([0-9.]+).*?)size= *(N\/A|[0-9.]+kB|[0-9.]+KiB).*?time= *(\d+:\d{1,2}:\d{1,2}\.\d+).*?bitrate= *(N\/A|[0-9.]+kbits\/s).*?speed= *([0-9.]+)x");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="progress"></param>
        /// <returns></returns>
        public static RenderProgress? FromProgressString(string? progress)
        {
            if (!string.IsNullOrWhiteSpace(progress))
            {
                Match match = regex.Match(progress);
                if (match.Success && match.Groups.Count == 8)
                {
                    try
                    {
                        RenderProgress renderProgress = new RenderProgress
                        {
                            Size = match.Groups[4].Value.EqualsOrd("N/A") ? double.NaN : ParseDouble(match.Groups[4].Value.ReplaceOrd("kB", string.Empty).ReplaceOrd("KiB", string.Empty)),
                            Time = ParseDuration(match.Groups[5].Value),
                            Bitrate = match.Groups[6].Value.EqualsOrd("N/A") ? double.NaN : ParseDouble(match.Groups[6].Value.ReplaceOrd("kbits/s", string.Empty)),
                            Speed = ParseSingle(match.Groups[7].Value)
                        };
                        if (match.Groups[2].Success && !string.IsNullOrWhiteSpace(match.Groups[2].Value))
                            renderProgress.Frame = ParseInt32(match.Groups[2].Value);
                        if (match.Groups[3].Success && !string.IsNullOrWhiteSpace(match.Groups[3].Value))
                            renderProgress.Fps = ParseDouble(match.Groups[3].Value);
                        return renderProgress;
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

                    var hours = ParseInt32(match.Groups[1].Value);
                    var minutes = ParseInt32(match.Groups[2].Value);
                    var seconds = ParseInt32(match.Groups[3].Value);
                    var milliseconds = ParseInt32(millisecondsPart);
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
        public int? Frame { get; private set; }

        /// <summary>
        /// frame per second rendered
        /// </summary>
        public double? Fps { get; private set; }
        /// <summary>
        /// Size in KiB
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
