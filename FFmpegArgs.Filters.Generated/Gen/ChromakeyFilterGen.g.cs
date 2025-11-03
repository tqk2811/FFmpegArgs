namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS chromakey         V-&gt;V       Turns a certain color into transparency. Operates on YUV colors.
    /// </summary>
    public class ChromakeyFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal ChromakeyFilterGen(ImageMap input) : base("chromakey", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the chromakey key color (default &quot;black&quot;)
        /// </summary>
        public ChromakeyFilterGen color(Color color) => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        ///  set the chromakey similarity value (from 1e-05 to 1) (default 0.01)
        /// </summary>
        public ChromakeyFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity, 1e-05, 1);
        /// <summary>
        ///  set the chromakey key blend value (from 0 to 1) (default 0)
        /// </summary>
        public ChromakeyFilterGen blend(float blend) => this.SetOptionRange("blend", blend, 0, 1);
        /// <summary>
        ///  color parameter is in yuv instead of rgb (default false)
        /// </summary>
        public ChromakeyFilterGen yuv(bool yuv) => this.SetOption("yuv", yuv.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Turns a certain color into transparency. Operates on YUV colors.
        /// </summary>
        public static ChromakeyFilterGen ChromakeyFilterGen(this ImageMap input0) => new ChromakeyFilterGen(input0);
    }
}