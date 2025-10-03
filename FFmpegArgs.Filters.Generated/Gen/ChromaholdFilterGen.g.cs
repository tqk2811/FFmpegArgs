namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC chromahold        V-&gt;V       Turns a certain color range into gray.
    /// </summary>
    public class ChromaholdFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ChromaholdFilterGen(ImageMap input) : base("chromahold", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the chromahold key color (default &quot;black&quot;)
        /// </summary>
        public ChromaholdFilterGen color(Color color) => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        ///  set the chromahold similarity value (from 1e-05 to 1) (default 0.01)
        /// </summary>
        public ChromaholdFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity, 1e-05, 1);
        /// <summary>
        ///  set the chromahold blend value (from 0 to 1) (default 0)
        /// </summary>
        public ChromaholdFilterGen blend(float blend) => this.SetOptionRange("blend", blend, 0, 1);
        /// <summary>
        ///  color parameter is in yuv instead of rgb (default false)
        /// </summary>
        public ChromaholdFilterGen yuv(bool yuv) => this.SetOption("yuv", yuv.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Turns a certain color range into gray.
        /// </summary>
        public static ChromaholdFilterGen ChromaholdFilterGen(this ImageMap input0) => new ChromaholdFilterGen(input0);
    }
}