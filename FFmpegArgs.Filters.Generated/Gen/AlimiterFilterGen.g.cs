namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. alimiter          A-&gt;A       Audio lookahead limiter.
    /// </summary>
    public class AlimiterFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal AlimiterFilterGen(AudioMap input) : base("alimiter", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set input level (from 0.015625 to 64) (default 1)
        /// </summary>
        public AlimiterFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in, 0.015625, 64);
        /// <summary>
        ///  set output level (from 0.015625 to 64) (default 1)
        /// </summary>
        public AlimiterFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out, 0.015625, 64);
        /// <summary>
        ///  set limit (from 0.0625 to 1) (default 1)
        /// </summary>
        public AlimiterFilterGen limit(double limit) => this.SetOptionRange("limit", limit, 0.0625, 1);
        /// <summary>
        ///  set attack (from 0.1 to 80) (default 5)
        /// </summary>
        public AlimiterFilterGen attack(double attack) => this.SetOptionRange("attack", attack, 0.1, 80);
        /// <summary>
        ///  set release (from 1 to 8000) (default 50)
        /// </summary>
        public AlimiterFilterGen release(double release) => this.SetOptionRange("release", release, 1, 8000);
        /// <summary>
        ///  enable asc (default false)
        /// </summary>
        public AlimiterFilterGen asc(bool asc) => this.SetOption("asc", asc.ToFFmpegFlag());
        /// <summary>
        ///  set asc level (from 0 to 1) (default 0.5)
        /// </summary>
        public AlimiterFilterGen asc_level(double asc_level) => this.SetOptionRange("asc_level", asc_level, 0, 1);
        /// <summary>
        ///  auto level (default true)
        /// </summary>
        public AlimiterFilterGen level(bool level) => this.SetOption("level", level.ToFFmpegFlag());
        /// <summary>
        ///  compensate delay (default false)
        /// </summary>
        public AlimiterFilterGen latency(bool latency) => this.SetOption("latency", latency.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Audio lookahead limiter.
        /// </summary>
        public static AlimiterFilterGen AlimiterFilterGen(this AudioMap input0) => new AlimiterFilterGen(input0);
    }
}