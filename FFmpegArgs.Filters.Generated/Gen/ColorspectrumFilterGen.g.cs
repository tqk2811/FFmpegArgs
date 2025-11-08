namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. colorspectrum     |-&gt;V       Generate colors spectrum.
    /// </summary>
    public class ColorspectrumFilterGen : SourceToImageFilter
    {
        internal ColorspectrumFilterGen(IImageFilterGraph input) : base("colorspectrum", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;320x240&quot;)
        /// </summary>
        public ColorspectrumFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ColorspectrumFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToStringInv());
        /// <summary>
        ///  set video duration (default -0.000001)
        /// </summary>
        public ColorspectrumFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
        /// </summary>
        public ColorspectrumFilterGen sar(Rational sar) => this.SetOption("sar", sar.Check(0, INT_MAX));
        /// <summary>
        ///  set the color spectrum type (from 0 to 2) (default black)
        /// </summary>
        public ColorspectrumFilterGen type(ColorspectrumFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set the color spectrum type (from 0 to 2) (default black)
    /// </summary>
    public enum ColorspectrumFilterGenType
    {
        /// <summary>
        /// black           0            ..FV....... fade to black
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("black")]
        black = 0,
        /// <summary>
        /// white           1            ..FV....... fade to white
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("white")]
        white = 1,
        /// <summary>
        /// all             2            ..FV....... white to black
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate colors spectrum.
        /// </summary>
        public static ColorspectrumFilterGen ColorspectrumFilterGen(this IImageFilterGraph input) => new ColorspectrumFilterGen(input);
    }
}