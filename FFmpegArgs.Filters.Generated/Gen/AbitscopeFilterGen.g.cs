namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. abitscope         A-&gt;V       Convert input audio to audio bit scope video output.
    /// </summary>
    public class AbitscopeFilterGen : AudioToImageFilter
    {
        internal AbitscopeFilterGen(AudioMap input) : base("abitscope", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public AbitscopeFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToStringInv());
        /// <summary>
        ///  set video size (default &quot;1024x256&quot;)
        /// </summary>
        public AbitscopeFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  set channels colors (default &quot;red|green|blue|yellow|orange|lime|pink|magenta|brown&quot;)
        /// </summary>
        public AbitscopeFilterGen colors(String colors) => this.SetOption("colors", colors.ToStringInv());
        /// <summary>
        ///  set output mode (from 0 to 1) (default bars)
        /// </summary>
        public AbitscopeFilterGen mode(AbitscopeFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set output mode (from 0 to 1) (default bars)
    /// </summary>
    public enum AbitscopeFilterGenMode
    {
        /// <summary>
        /// bars            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bars")]
        bars = 0,
        /// <summary>
        /// trace           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("trace")]
        trace = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to audio bit scope video output.
        /// </summary>
        public static AbitscopeFilterGen AbitscopeFilterGen(this AudioMap input0) => new AbitscopeFilterGen(input0);
    }
}