namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. perlin            |-&gt;V       Generate Perlin noise
    /// </summary>
    public class PerlinFilterGen : SourceToImageFilter
    {
        internal PerlinFilterGen(IImageFilterGraph input) : base("perlin", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;320x240&quot;)
        /// </summary>
        public PerlinFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public PerlinFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToStringInv());
        /// <summary>
        ///  set the number of components to use to generate the noise (from 1 to INT_MAX) (default 1)
        /// </summary>
        public PerlinFilterGen octaves(int octaves) => this.SetOptionRange("octaves", octaves, 1, INT_MAX);
        /// <summary>
        ///  set the octaves persistence (from 0 to DBL_MAX) (default 1)
        /// </summary>
        public PerlinFilterGen persistence(double persistence) => this.SetOptionRange("persistence", persistence, 0, DBL_MAX);
        /// <summary>
        ///  set x-scale factor (from 0 to DBL_MAX) (default 1)
        /// </summary>
        public PerlinFilterGen xscale(double xscale) => this.SetOptionRange("xscale", xscale, 0, DBL_MAX);
        /// <summary>
        ///  set y-scale factor (from 0 to DBL_MAX) (default 1)
        /// </summary>
        public PerlinFilterGen yscale(double yscale) => this.SetOptionRange("yscale", yscale, 0, DBL_MAX);
        /// <summary>
        ///  set t-scale factor (from 0 to DBL_MAX) (default 1)
        /// </summary>
        public PerlinFilterGen tscale(double tscale) => this.SetOptionRange("tscale", tscale, 0, DBL_MAX);
        /// <summary>
        ///  set random mode used to compute initial pattern (from 0 to 2) (default random)
        /// </summary>
        public PerlinFilterGen random_mode(PerlinFilterGenRandom_mode random_mode) => this.SetOption("random_mode", random_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the seed for filling the initial pattern (from 0 to UINT32_MAX) (default 0)
        /// </summary>
        public PerlinFilterGen random_seed(String random_seed) => this.SetOption("random_seed", random_seed.ToStringInv());
        /// <summary>
        ///  set the seed for filling the initial pattern (from 0 to UINT32_MAX) (default 0)
        /// </summary>
        public PerlinFilterGen seed(String seed) => this.SetOption("seed", seed.ToStringInv());
    }

    /// <summary>
    ///  set random mode used to compute initial pattern (from 0 to 2) (default random)
    /// </summary>
    public enum PerlinFilterGenRandom_mode
    {
        /// <summary>
        /// random          0            ..FV....... compute and use random seed
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("random")]
        random = 0,
        /// <summary>
        /// ken             1            ..FV....... use the predefined initial pattern defined by Ken Perlin in the original article
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ken")]
        ken = 1,
        /// <summary>
        /// seed            2            ..FV....... use the value specified by random_seed
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("seed")]
        seed = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate Perlin noise
        /// </summary>
        public static PerlinFilterGen PerlinFilterGen(this IImageFilterGraph input) => new PerlinFilterGen(input);
    }
}