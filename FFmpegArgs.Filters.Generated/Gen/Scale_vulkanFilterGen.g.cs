namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. scale_vulkan      V-&gt;V       Scale Vulkan frames
    /// </summary>
    public class Scale_vulkanFilterGen : ImageToImageFilter
    {
        internal Scale_vulkanFilterGen(ImageMap input) : base("scale_vulkan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output video width (default &quot;iw&quot;)
        /// </summary>
        public Scale_vulkanFilterGen w(String w) => this.SetOption("w", w.ToString());
        /// <summary>
        ///  Output video height (default &quot;ih&quot;)
        /// </summary>
        public Scale_vulkanFilterGen h(String h) => this.SetOption("h", h.ToString());
        /// <summary>
        ///  Scaler function (from 0 to 2) (default bilinear)
        /// </summary>
        public Scale_vulkanFilterGen scaler(Scale_vulkanFilterGenScaler scaler) => this.SetOption("scaler", scaler.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Debayer algorithm to use (from 0 to 2) (default bilinear_hq)
        /// </summary>
        public Scale_vulkanFilterGen debayer(Scale_vulkanFilterGenDebayer debayer) => this.SetOption("debayer", debayer.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Output video format (software format of hardware frames)
        /// </summary>
        public Scale_vulkanFilterGen format(String format) => this.SetOption("format", format.ToString());
        /// <summary>
        ///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
        /// </summary>
        public Scale_vulkanFilterGen out_range(Scale_vulkanFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  Scaler function (from 0 to 2) (default bilinear)
    /// </summary>
    public enum Scale_vulkanFilterGenScaler
    {
        /// <summary>
        /// bilinear        0            ..FV....... Bilinear interpolation (fastest)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear")]
        bilinear = 0,
        /// <summary>
        /// nearest         1            ..FV....... Nearest (useful for pixel art)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nearest")]
        nearest = 1
    }

    /// <summary>
    ///  Debayer algorithm to use (from 0 to 2) (default bilinear_hq)
    /// </summary>
    public enum Scale_vulkanFilterGenDebayer
    {
        /// <summary>
        /// bilinear        0            ..FV....... Bilinear debayering (fastest)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear")]
        bilinear = 0,
        /// <summary>
        /// bilinear_hq     1            ..FV....... Bilinear debayering (high quality)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear_hq")]
        bilinear_hq = 1
    }

    /// <summary>
    ///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
    /// </summary>
    public enum Scale_vulkanFilterGenOut_range
    {
        /// <summary>
        /// full            2            ..FV....... Full range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 2,
        /// <summary>
        /// limited         1            ..FV....... Limited range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 1,
        /// <summary>
        /// jpeg            2            ..FV....... Full range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpeg")]
        jpeg = 2,
        /// <summary>
        /// mpeg            1            ..FV....... Limited range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg")]
        mpeg = 1,
        /// <summary>
        /// tv              1            ..FV....... Limited range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 1,
        /// <summary>
        /// pc              2            ..FV....... Full range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Scale Vulkan frames
        /// </summary>
        public static Scale_vulkanFilterGen Scale_vulkanFilterGen(this ImageMap input0) => new Scale_vulkanFilterGen(input0);
    }
}