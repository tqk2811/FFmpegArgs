namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... atrim             A-&gt;A       Pick one continuous section from the input, drop the rest.
    /// </summary>
    public class AtrimFilterGen : AudioToAudioFilter
    {
        internal AtrimFilterGen(AudioMap input) : base("atrim", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Timestamp of the first frame that should be passed (default INT64_MAX)
        /// </summary>
        public AtrimFilterGen starti(TimeSpan starti) => this.SetOptionRange("starti", starti, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  Timestamp of the first frame that should be dropped again (default INT64_MAX)
        /// </summary>
        public AtrimFilterGen endi(TimeSpan endi) => this.SetOptionRange("endi", endi, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  Timestamp of the first frame that should be  passed (from I64_MIN to I64_MAX) (default I64_MIN)
        /// </summary>
        public AtrimFilterGen start_pts(long start_pts) => this.SetOptionRange("start_pts", start_pts, I64_MIN, I64_MAX);
        /// <summary>
        ///  Timestamp of the first frame that should be dropped again (from I64_MIN to I64_MAX) (default I64_MIN)
        /// </summary>
        public AtrimFilterGen end_pts(long end_pts) => this.SetOptionRange("end_pts", end_pts, I64_MIN, I64_MAX);
        /// <summary>
        ///  Maximum duration of the output (default 0)
        /// </summary>
        public AtrimFilterGen durationi(TimeSpan durationi) => this.SetOptionRange("durationi", durationi, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  Number of the first audio sample that should be passed to the output (from -1 to I64_MAX) (default -1)
        /// </summary>
        public AtrimFilterGen start_sample(long start_sample) => this.SetOptionRange("start_sample", start_sample, -1, I64_MAX);
        /// <summary>
        ///  Number of the first audio sample that should be dropped again (from 0 to I64_MAX) (default I64_MAX)
        /// </summary>
        public AtrimFilterGen end_sample(long end_sample) => this.SetOptionRange("end_sample", end_sample, 0, I64_MAX);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Pick one continuous section from the input, drop the rest.
        /// </summary>
        public static AtrimFilterGen AtrimFilterGen(this AudioMap input0) => new AtrimFilterGen(input0);
    }
}