namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... frei0r_src        |-&gt;V       Generate a frei0r source.
    /// </summary>
    public class Frei0r_srcFilterGen : SourceToImageFilter
    {
        internal Frei0r_srcFilterGen(IImageFilterGraph input) : base("frei0r_src", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Dimensions of the generated video. (default &quot;320x240&quot;)
        /// </summary>
        public Frei0r_srcFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  (default &quot;25&quot;)
        /// </summary>
        public Frei0r_srcFilterGen framerate(Rational framerate) => this.SetOption("framerate", framerate.ToString());
        /// <summary>
        /// 
        /// </summary>
        public Frei0r_srcFilterGen filter_name(String filter_name) => this.SetOption("filter_name", filter_name.ToString());
        /// <summary>
        /// 
        /// </summary>
        public Frei0r_srcFilterGen filter_params(String filter_params) => this.SetOption("filter_params", filter_params.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate a frei0r source.
        /// </summary>
        public static Frei0r_srcFilterGen Frei0r_srcFilterGen(this IImageFilterGraph input) => new Frei0r_srcFilterGen(input);
    }
}