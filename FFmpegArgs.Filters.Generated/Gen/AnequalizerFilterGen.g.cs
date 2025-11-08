namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS anequalizer       A-&gt;N       Apply high-order audio parametric multi band equalizer.
    /// </summary>
    public class AnequalizerFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AnequalizerFilterGen(AudioMap input, int outputCount) : base("anequalizer", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  (default &quot;&quot;)
        /// </summary>
        public AnequalizerFilterGen _params(String _params) => this.SetOption("params", _params.ToStringInv());
        /// <summary>
        ///  draw frequency response curves (default false)
        /// </summary>
        public AnequalizerFilterGen curves(bool curves) => this.SetOption("curves", curves.ToFFmpegFlag());
        /// <summary>
        ///  set video size (default &quot;hd720&quot;)
        /// </summary>
        public AnequalizerFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set max gain (from -900 to 900) (default 60)
        /// </summary>
        public AnequalizerFilterGen mgain(double mgain) => this.SetOptionRange("mgain", mgain, -900, 900);
        /// <summary>
        ///  set frequency scale (from 0 to 1) (default log)
        /// </summary>
        public AnequalizerFilterGen fscale(AnequalizerFilterGenFscale fscale) => this.SetOption("fscale", fscale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set channels curves colors (default &quot;red|green|blue|yellow|orange|lime|pink|magenta|brown&quot;)
        /// </summary>
        public AnequalizerFilterGen colors(String colors) => this.SetOption("colors", colors.ToStringInv());
    }

    /// <summary>
    ///  set frequency scale (from 0 to 1) (default log)
    /// </summary>
    public enum AnequalizerFilterGenFscale
    {
        /// <summary>
        /// lin             0            ..FV....... linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lin")]
        lin = 0,
        /// <summary>
        /// log             1            ..FV....... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply high-order audio parametric multi band equalizer.
        /// </summary>
        public static AnequalizerFilterGen AnequalizerFilterGen(this AudioMap input0, int outputCount) => new AnequalizerFilterGen(input0, outputCount);
    }
}