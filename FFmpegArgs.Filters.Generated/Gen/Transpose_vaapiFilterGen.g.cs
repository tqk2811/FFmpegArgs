namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. transpose_vaapi   V-&gt;V       VAAPI VPP for transpose
    /// </summary>
    public class Transpose_vaapiFilterGen : ImageToImageFilter
    {
        internal Transpose_vaapiFilterGen(ImageMap input) : base("transpose_vaapi", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set transpose direction (from 0 to 6) (default cclock_flip)
        /// </summary>
        public Transpose_vaapiFilterGen dir(Transpose_vaapiFilterGenDir dir) => this.SetOption("dir", dir.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
        /// </summary>
        public Transpose_vaapiFilterGen passthrough(Transpose_vaapiFilterGenPassthrough passthrough) => this.SetOption("passthrough", passthrough.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set transpose direction (from 0 to 6) (default cclock_flip)
    /// </summary>
    public enum Transpose_vaapiFilterGenDir
    {
        /// <summary>
        /// cclock_flip     0            ..FV....... rotate counter-clockwise with vertical flip
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cclock_flip")]
        cclock_flip = 0,
        /// <summary>
        /// clock           1            ..FV....... rotate clockwise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clock")]
        clock = 1,
        /// <summary>
        /// cclock          2            ..FV....... rotate counter-clockwise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cclock")]
        cclock = 2,
        /// <summary>
        /// clock_flip      3            ..FV....... rotate clockwise with vertical flip
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clock_flip")]
        clock_flip = 3,
        /// <summary>
        /// reversal        4            ..FV....... rotate by half-turn
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reversal")]
        reversal = 4,
        /// <summary>
        /// hflip           5            ..FV....... flip horizontally
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hflip")]
        hflip = 5,
        /// <summary>
        /// vflip           6            ..FV....... flip vertically
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vflip")]
        vflip = 6
    }

    /// <summary>
    ///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
    /// </summary>
    public enum Transpose_vaapiFilterGenPassthrough
    {
        /// <summary>
        /// none            0            ..FV....... always apply transposition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// portrait        2            ..FV....... preserve portrait geometry
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("portrait")]
        portrait = 2,
        /// <summary>
        /// landscape       1            ..FV....... preserve landscape geometry
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("landscape")]
        landscape = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// VAAPI VPP for transpose
        /// </summary>
        public static Transpose_vaapiFilterGen Transpose_vaapiFilterGen(this ImageMap input0) => new Transpose_vaapiFilterGen(input0);
    }
}