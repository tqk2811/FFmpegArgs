namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... rgbtestsrc        |-&gt;V       Generate RGB test pattern.
    /// </summary>
    public class RgbtestsrcFilterGen : SourceToImageFilter
    {
        internal RgbtestsrcFilterGen(IImageFilterGraph input) : base("rgbtestsrc", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;320x240&quot;)
        /// </summary>
        public RgbtestsrcFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public RgbtestsrcFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set video duration (default -0.000001)
        /// </summary>
        public RgbtestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
        /// </summary>
        public RgbtestsrcFilterGen sar(Rational sar) => this.SetOption("sar", sar.Check(0, INT_MAX));
        /// <summary>
        ///  set complement colors (default false)
        /// </summary>
        public RgbtestsrcFilterGen complement(bool complement) => this.SetOption("complement", complement.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate RGB test pattern.
        /// </summary>
        public static RgbtestsrcFilterGen RgbtestsrcFilterGen(this IImageFilterGraph input) => new RgbtestsrcFilterGen(input);
    }
}