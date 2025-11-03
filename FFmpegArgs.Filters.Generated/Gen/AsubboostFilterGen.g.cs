namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS asubboost         A-&gt;A       Boost subwoofer frequencies.
    /// </summary>
    public class AsubboostFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AsubboostFilterGen(AudioMap input) : base("asubboost", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set dry gain (from 0 to 1) (default 1)
        /// </summary>
        public AsubboostFilterGen dry(double dry) => this.SetOptionRange("dry", dry, 0, 1);
        /// <summary>
        ///  set wet gain (from 0 to 1) (default 1)
        /// </summary>
        public AsubboostFilterGen wet(double wet) => this.SetOptionRange("wet", wet, 0, 1);
        /// <summary>
        ///  set max boost (from 1 to 12) (default 2)
        /// </summary>
        public AsubboostFilterGen boost(double boost) => this.SetOptionRange("boost", boost, 1, 12);
        /// <summary>
        ///  set decay (from 0 to 1) (default 0)
        /// </summary>
        public AsubboostFilterGen decay(double decay) => this.SetOptionRange("decay", decay, 0, 1);
        /// <summary>
        ///  set feedback (from 0 to 1) (default 0.9)
        /// </summary>
        public AsubboostFilterGen feedback(double feedback) => this.SetOptionRange("feedback", feedback, 0, 1);
        /// <summary>
        ///  set cutoff (from 50 to 900) (default 100)
        /// </summary>
        public AsubboostFilterGen cutoff(double cutoff) => this.SetOptionRange("cutoff", cutoff, 50, 900);
        /// <summary>
        ///  set slope (from 0.0001 to 1) (default 0.5)
        /// </summary>
        public AsubboostFilterGen slope(double slope) => this.SetOptionRange("slope", slope, 0.0001, 1);
        /// <summary>
        ///  set delay (from 1 to 100) (default 20)
        /// </summary>
        public AsubboostFilterGen delay(double delay) => this.SetOptionRange("delay", delay, 1, 100);
        /// <summary>
        ///  set channels to filter (default &quot;all&quot;)
        /// </summary>
        public AsubboostFilterGen channels(String channels) => this.SetOption("channels", channels.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Boost subwoofer frequencies.
        /// </summary>
        public static AsubboostFilterGen AsubboostFilterGen(this AudioMap input0) => new AsubboostFilterGen(input0);
    }
}