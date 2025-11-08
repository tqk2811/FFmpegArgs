namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. life              |-&gt;V       Create life.
    /// </summary>
    public class LifeFilterGen : SourceToImageFilter
    {
        internal LifeFilterGen(IImageFilterGraph input) : base("life", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set source file
        /// </summary>
        public LifeFilterGen filename(String filename) => this.SetOption("filename", filename.ToString());
        /// <summary>
        ///  set video size
        /// </summary>
        public LifeFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public LifeFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set rule (default &quot;B3/S23&quot;)
        /// </summary>
        public LifeFilterGen rule(String rule) => this.SetOption("rule", rule.ToString());
        /// <summary>
        ///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
        /// </summary>
        public LifeFilterGen random_fill_ratio(double random_fill_ratio) => this.SetOptionRange("random_fill_ratio", random_fill_ratio, 0, 1);
        /// <summary>
        ///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
        /// </summary>
        public LifeFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio, 0, 1);
        /// <summary>
        ///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
        /// </summary>
        public LifeFilterGen random_seed(long random_seed) => this.SetOptionRange("random_seed", random_seed, -1, UINT32_MAX);
        /// <summary>
        ///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
        /// </summary>
        public LifeFilterGen seed(long seed) => this.SetOptionRange("seed", seed, -1, UINT32_MAX);
        /// <summary>
        ///  stitch boundaries (default true)
        /// </summary>
        public LifeFilterGen stitch(bool stitch) => this.SetOption("stitch", stitch.ToFFmpegFlag());
        /// <summary>
        ///  set mold speed for dead cells (from 0 to 255) (default 0)
        /// </summary>
        public LifeFilterGen mold(int mold) => this.SetOptionRange("mold", mold, 0, 255);
        /// <summary>
        ///  set life color (default &quot;white&quot;)
        /// </summary>
        public LifeFilterGen life_color(Color life_color) => this.SetOption("life_color", life_color.ToHexStringRGBA());
        /// <summary>
        ///  set death color (default &quot;black&quot;)
        /// </summary>
        public LifeFilterGen death_color(Color death_color) => this.SetOption("death_color", death_color.ToHexStringRGBA());
        /// <summary>
        ///  set mold color (default &quot;black&quot;)
        /// </summary>
        public LifeFilterGen mold_color(Color mold_color) => this.SetOption("mold_color", mold_color.ToHexStringRGBA());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Create life.
        /// </summary>
        public static LifeFilterGen LifeFilterGen(this IImageFilterGraph input) => new LifeFilterGen(input);
    }
}