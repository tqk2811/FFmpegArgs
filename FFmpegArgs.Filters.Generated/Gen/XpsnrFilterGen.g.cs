namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. xpsnr             VV-&gt;V      Calculate the extended perceptually weighted peak signal-to-noise ratio (XPSNR) between two video streams.
    /// </summary>
    public class XpsnrFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal XpsnrFilterGen(params ImageMap[] inputs) : base("xpsnr", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set file where to store per-frame XPSNR information
        /// </summary>
        public XpsnrFilterGen stats_file(String stats_file) => this.SetOption("stats_file", stats_file.ToString());
        /// <summary>
        ///  Set file where to store per-frame XPSNR information
        /// </summary>
        public XpsnrFilterGen f(String f) => this.SetOption("f", f.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Calculate the extended perceptually weighted peak signal-to-noise ratio (XPSNR) between two video streams.
        /// </summary>
        public static XpsnrFilterGen XpsnrFilterGen(this ImageMap input0, ImageMap input1) => new XpsnrFilterGen(input0, input1);
    }
}