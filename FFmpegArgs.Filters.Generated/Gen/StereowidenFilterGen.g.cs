namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. stereowiden       A-&gt;A       Apply stereo widening effect.
    /// </summary>
    public class StereowidenFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal StereowidenFilterGen(AudioMap input) : base("stereowiden", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set delay time (from 1 to 100) (default 20)
        /// </summary>
        public StereowidenFilterGen delay(float delay) => this.SetOptionRange("delay", delay, 1, 100);
        /// <summary>
        ///  set feedback gain (from 0 to 0.9) (default 0.3)
        /// </summary>
        public StereowidenFilterGen feedback(float feedback) => this.SetOptionRange("feedback", feedback, 0, 0.9);
        /// <summary>
        ///  set cross feed (from 0 to 0.8) (default 0.3)
        /// </summary>
        public StereowidenFilterGen crossfeed(float crossfeed) => this.SetOptionRange("crossfeed", crossfeed, 0, 0.8);
        /// <summary>
        ///  set dry-mix (from 0 to 1) (default 0.8)
        /// </summary>
        public StereowidenFilterGen drymix(float drymix) => this.SetOptionRange("drymix", drymix, 0, 1);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply stereo widening effect.
        /// </summary>
        public static StereowidenFilterGen StereowidenFilterGen(this AudioMap input0) => new StereowidenFilterGen(input0);
    }
}