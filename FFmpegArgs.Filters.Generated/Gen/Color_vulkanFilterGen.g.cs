namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. color_vulkan      |-&gt;V       Generate a constant color (Vulkan)
    /// </summary>
    public class Color_vulkanFilterGen : SourceToImageFilter
    {
        internal Color_vulkanFilterGen(IImageFilterGraph input) : base("color_vulkan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set color (default &quot;black&quot;)
        /// </summary>
        public Color_vulkanFilterGen color(Color color) => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        ///  set video size (default &quot;1920x1080&quot;)
        /// </summary>
        public Color_vulkanFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set video rate (default &quot;60&quot;)
        /// </summary>
        public Color_vulkanFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set video duration (default -0.000001)
        /// </summary>
        public Color_vulkanFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
        /// </summary>
        public Color_vulkanFilterGen sar(Rational sar) => this.SetOption("sar", sar.Check(0, INT_MAX));
        /// <summary>
        ///  Output video format (software format of hardware frames)
        /// </summary>
        public Color_vulkanFilterGen format(String format) => this.SetOption("format", format.ToString());
        /// <summary>
        ///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
        /// </summary>
        public Color_vulkanFilterGen out_range(Color_vulkanFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
    /// </summary>
    public enum Color_vulkanFilterGenOut_range
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
        /// Generate a constant color (Vulkan)
        /// </summary>
        public static Color_vulkanFilterGen Color_vulkanFilterGen(this IImageFilterGraph input) => new Color_vulkanFilterGen(input);
    }
}