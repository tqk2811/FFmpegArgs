namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ..C lv2               N-&gt;A       Apply LV2 effect.
    /// </summary>
    public class Lv2FilterGen : AudioToAudioFilter, ICommandSupport
    {
        internal Lv2FilterGen(params AudioMap[] inputs) : base("lv2", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set plugin uri
        /// </summary>
        public Lv2FilterGen plugin(String plugin) => this.SetOption("plugin", plugin.ToString());
        /// <summary>
        ///  set plugin options
        /// </summary>
        public Lv2FilterGen controls(String controls) => this.SetOption("controls", controls.ToString());
        /// <summary>
        ///  set sample rate (from 1 to INT_MAX) (default 44100)
        /// </summary>
        public Lv2FilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate, 1, INT_MAX);
        /// <summary>
        ///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
        /// </summary>
        public Lv2FilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples, 1, INT_MAX);
        /// <summary>
        ///  set audio duration (default -0.000001)
        /// </summary>
        public Lv2FilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply LV2 effect.
        /// </summary>
        public static Lv2FilterGen Lv2FilterGen(this AudioMap input) => new Lv2FilterGen(input);
    }
}