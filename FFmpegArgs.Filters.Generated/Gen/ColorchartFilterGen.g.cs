namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. colorchart        |-&gt;V       Generate color checker chart.
    /// </summary>
    public class ColorchartFilterGen : SourceToImageFilter
    {
        internal ColorchartFilterGen(IImageFilterGraph input) : base("colorchart", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ColorchartFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToStringInv());
        /// <summary>
        ///  set video duration (default -0.000001)
        /// </summary>
        public ColorchartFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
        /// </summary>
        public ColorchartFilterGen sar(Rational sar) => this.SetOption("sar", sar.Check(0, INT_MAX));
        /// <summary>
        ///  set the single patch size (default &quot;64x64&quot;)
        /// </summary>
        public ColorchartFilterGen patch_size(Size patch_size) => this.SetOption("patch_size", $"{patch_size.Width}x{patch_size.Height}");
        /// <summary>
        ///  set the color checker chart preset (from 0 to 1) (default reference)
        /// </summary>
        public ColorchartFilterGen preset(ColorchartFilterGenPreset preset) => this.SetOption("preset", preset.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set the color checker chart preset (from 0 to 1) (default reference)
    /// </summary>
    public enum ColorchartFilterGenPreset
    {
        /// <summary>
        /// reference       0            ..FV....... reference
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reference")]
        reference = 0,
        /// <summary>
        /// skintones       1            ..FV....... skintones
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("skintones")]
        skintones = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate color checker chart.
        /// </summary>
        public static ColorchartFilterGen ColorchartFilterGen(this IImageFilterGraph input) => new ColorchartFilterGen(input);
    }
}