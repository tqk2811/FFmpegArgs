namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. aloop             A-&gt;A       Loop audio samples.
    /// </summary>
    public class AloopFilterGen : AudioToAudioFilter
    {
        internal AloopFilterGen(AudioMap input) : base("aloop", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  number of loops (from -1 to INT_MAX) (default 0)
        /// </summary>
        public AloopFilterGen loop(int loop) => this.SetOptionRange("loop", loop, -1, INT_MAX);
        /// <summary>
        ///  max number of samples to loop (from 0 to INT_MAX) (default 0)
        /// </summary>
        public AloopFilterGen size(long size) => this.SetOptionRange("size", size, 0, INT_MAX);
        /// <summary>
        ///  set the loop start sample (from -1 to I64_MAX) (default 0)
        /// </summary>
        public AloopFilterGen start(long start) => this.SetOptionRange("start", start, -1, I64_MAX);
        /// <summary>
        ///  set the loop start time (default INT64_MAX)
        /// </summary>
        public AloopFilterGen time(TimeSpan time) => this.SetOptionRange("time", time, TimeSpan.Zero, TimeSpan.MaxValue);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Loop audio samples.
        /// </summary>
        public static AloopFilterGen AloopFilterGen(this AudioMap input0) => new AloopFilterGen(input0);
    }
}