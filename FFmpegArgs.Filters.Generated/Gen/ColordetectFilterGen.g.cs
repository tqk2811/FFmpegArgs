namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S colordetect       V-&gt;V       Detect video color properties.
    /// </summary>
    public class ColordetectFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal ColordetectFilterGen(ImageMap input) : base("colordetect", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Image properties to detect (default color_range+alpha_mode+all)
        /// </summary>
        public ColordetectFilterGen mode(ColordetectFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  Image properties to detect (default color_range+alpha_mode+all)
    /// </summary>
    public enum ColordetectFilterGenMode
    {
        /// <summary>
        /// color_range                  ..FV....... Detect (YUV) color range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("color_range")]
        color_range,
        /// <summary>
        /// alpha_mode                   ..FV....... Detect alpha mode
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("alpha_mode")]
        alpha_mode,
        /// <summary>
        /// all                          ..FV....... Detect all supported properties
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Detect video color properties.
        /// </summary>
        public static ColordetectFilterGen ColordetectFilterGen(this ImageMap input0) => new ColordetectFilterGen(input0);
    }
}