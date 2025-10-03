namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... afdelaysrc        |-&gt;A       Generate a Fractional delay FIR coefficients.
    /// </summary>
    public class AfdelaysrcFilterGen : SourceToAudioFilter
    {
        internal AfdelaysrcFilterGen(IAudioFilterGraph input) : base("afdelaysrc", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set fractional delay (from 0 to 32767) (default 0)
        /// </summary>
        public AfdelaysrcFilterGen delay(double delay) => this.SetOptionRange("delay", delay, 0, 32767);
        /// <summary>
        ///  set sample rate (from 1 to INT_MAX) (default 44100)
        /// </summary>
        public AfdelaysrcFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate, 1, INT_MAX);
        /// <summary>
        ///  set sample rate (from 1 to INT_MAX) (default 44100)
        /// </summary>
        public AfdelaysrcFilterGen r(int r) => this.SetOptionRange("r", r, 1, INT_MAX);
        /// <summary>
        ///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
        /// </summary>
        public AfdelaysrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples, 1, INT_MAX);
        /// <summary>
        ///  set number of taps for delay filter (from 0 to 32768) (default 0)
        /// </summary>
        public AfdelaysrcFilterGen taps(int taps) => this.SetOptionRange("taps", taps, 0, 32768);
        /// <summary>
        ///  set channel layout (default &quot;stereo&quot;)
        /// </summary>
        public AfdelaysrcFilterGen channel_layout(ChannelLayout channel_layout) => this.SetOption("channel_layout", channel_layout.GetEnumAttribute<NameAttribute>().Name);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate a Fractional delay FIR coefficients.
        /// </summary>
        public static AfdelaysrcFilterGen AfdelaysrcFilterGen(this IAudioFilterGraph input) => new AfdelaysrcFilterGen(input);
    }
}