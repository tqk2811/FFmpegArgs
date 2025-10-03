namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... framepack         VV-&gt;V      Generate a frame packed stereoscopic video.
    /// </summary>
    public class FramepackFilterGen : ImageToImageFilter
    {
        internal FramepackFilterGen(params ImageMap[] inputs) : base("framepack", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Frame pack output format (from 0 to INT_MAX) (default sbs)
        /// </summary>
        public FramepackFilterGen format(FramepackFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  Frame pack output format (from 0 to INT_MAX) (default sbs)
    /// </summary>
    public enum FramepackFilterGenFormat
    {
        /// <summary>
        /// sbs             1            ..FV....... Views are packed next to each other
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbs")]
        sbs = 1,
        /// <summary>
        /// tab             2            ..FV....... Views are packed on top of each other
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tab")]
        tab = 2,
        /// <summary>
        /// frameseq        3            ..FV....... Views are one after the other
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frameseq")]
        frameseq = 3,
        /// <summary>
        /// lines           6            ..FV....... Views are interleaved by lines
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lines")]
        lines = 6,
        /// <summary>
        /// columns         7            ..FV....... Views are interleaved by columns
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("columns")]
        columns = 7
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate a frame packed stereoscopic video.
        /// </summary>
        public static FramepackFilterGen FramepackFilterGen(this ImageMap input0, ImageMap input1) => new FramepackFilterGen(input0, input1);
    }
}