namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... aformat           A-&gt;A       Convert the input audio to one of the specified formats.
    /// </summary>
    public class AformatFilterGen : AudioToAudioFilter
    {
        internal AformatFilterGen(AudioMap input) : base("aformat", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  A &#39;|&#39;-separated list of sample formats.
        /// </summary>
        public AformatFilterGen sample_fmts(String sample_fmts) => this.SetOption("sample_fmts", sample_fmts.ToString());
        /// <summary>
        ///  A &#39;|&#39;-separated list of sample formats.
        /// </summary>
        public AformatFilterGen f(String f) => this.SetOption("f", f.ToString());
        /// <summary>
        ///  A &#39;|&#39;-separated list of sample rates.
        /// </summary>
        public AformatFilterGen sample_rates(String sample_rates) => this.SetOption("sample_rates", sample_rates.ToString());
        /// <summary>
        ///  A &#39;|&#39;-separated list of sample rates.
        /// </summary>
        public AformatFilterGen r(String r) => this.SetOption("r", r.ToString());
        /// <summary>
        ///  A &#39;|&#39;-separated list of channel layouts.
        /// </summary>
        public AformatFilterGen channel_layouts(String channel_layouts) => this.SetOption("channel_layouts", channel_layouts.ToString());
        /// <summary>
        ///  A &#39;|&#39;-separated list of channel layouts.
        /// </summary>
        public AformatFilterGen cl(String cl) => this.SetOption("cl", cl.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert the input audio to one of the specified formats.
        /// </summary>
        public static AformatFilterGen AformatFilterGen(this AudioMap input0) => new AformatFilterGen(input0);
    }
}