namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. showwavespic      A-&gt;V       Convert input audio to a video output single picture.
    /// </summary>
    public class ShowwavespicFilterGen : AudioToImageFilter
    {
        internal ShowwavespicFilterGen(AudioMap input) : base("showwavespic", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;600x240&quot;)
        /// </summary>
        public ShowwavespicFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  draw channels separately (default false)
        /// </summary>
        public ShowwavespicFilterGen split_channels(bool split_channels) => this.SetOption("split_channels", split_channels.ToFFmpegFlag());
        /// <summary>
        ///  set channels colors (default &quot;red|green|blue|yellow|orange|lime|pink|magenta|brown&quot;)
        /// </summary>
        public ShowwavespicFilterGen colors(String colors) => this.SetOption("colors", colors.ToStringInv());
        /// <summary>
        ///  set amplitude scale (from 0 to 3) (default lin)
        /// </summary>
        public ShowwavespicFilterGen scale(ShowwavespicFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set draw mode (from 0 to 1) (default scale)
        /// </summary>
        public ShowwavespicFilterGen draw(ShowwavespicFilterGenDraw draw) => this.SetOption("draw", draw.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set filter mode (from 0 to 1) (default average)
        /// </summary>
        public ShowwavespicFilterGen filter(ShowwavespicFilterGenFilter filter) => this.SetOption("filter", filter.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set amplitude scale (from 0 to 3) (default lin)
    /// </summary>
    public enum ShowwavespicFilterGenScale
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
        log = 1,
        /// <summary>
        /// sqrt            2            ..FV....... square root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sqrt")]
        sqrt = 2,
        /// <summary>
        /// cbrt            3            ..FV....... cubic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbrt")]
        cbrt = 3
    }

    /// <summary>
    ///  set draw mode (from 0 to 1) (default scale)
    /// </summary>
    public enum ShowwavespicFilterGenDraw
    {
        /// <summary>
        /// scale           0            ..FV....... scale pixel values for each drawn sample
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("scale")]
        scale = 0,
        /// <summary>
        /// full            1            ..FV....... draw every pixel for sample directly
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 1
    }

    /// <summary>
    ///  set filter mode (from 0 to 1) (default average)
    /// </summary>
    public enum ShowwavespicFilterGenFilter
    {
        /// <summary>
        /// average         0            ..FV....... use average samples
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 0,
        /// <summary>
        /// peak            1            ..FV....... use peak samples
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("peak")]
        peak = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to a video output single picture.
        /// </summary>
        public static ShowwavespicFilterGen ShowwavespicFilterGen(this AudioMap input0) => new ShowwavespicFilterGen(input0);
    }
}