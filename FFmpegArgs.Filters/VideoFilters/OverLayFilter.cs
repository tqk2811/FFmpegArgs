namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC overlay           VV->V      Overlay a video source on top of the input.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#overlay-1 
    /// </summary>
    public class OverlayFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport, IFramesync
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "main_w","W",
            "main_h","H",
            "overlay_w", "w",
            "overlay_h", "h",
            "x", "y",
            "hsub", "vsub",
            "n", "pos","t"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal OverlayFilter(ImageMap bottom, ImageMap top) : base("overlay", bottom, top)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public OverlayFilter X(string x)
            => this.X(x.Expression());
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public OverlayFilter X(Action<FFmpegExpression> x)
            => this.SetOption("x", x.Run(expression));
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public OverlayFilter Y(string y)
            => this.Y(y.Expression());
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public OverlayFilter Y(Action<FFmpegExpression> y)
            => this.SetOption("y", y.Run(expression));
        /// <summary>
        /// Set when the expressions for x, and y are evaluated.
        /// </summary>
        /// <param name="eval"></param>
        /// <returns></returns>
        public OverlayFilter Eval(OverlayEval eval)
          => this.SetOption("eval", eval.ToString().ToLower());
        /// <summary>
        /// Set the format for the output video.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public OverlayFilter Format(OverlayPixFmt format)
           => this.SetOption("format", format.ToString());
        /// <summary>
        /// Set format of alpha of the overlaid video, it can be straight or premultiplied. Default is straight.
        /// </summary>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public OverlayFilter Alpha(OverlayAlpha alpha)
          => this.SetOption("alpha", alpha.ToString().ToLower());
    }
    public static class OverlayFilterExtension
    {
        /// <summary>
        /// Overlay one video on top of another.<br>
        /// </br>It takes two inputs and has one output.The first input is the "main" video on which the second input is overlaid.
        /// </summary>
        /// <param name="second"></param>
        /// <param name="first"></param>
        /// <returns></returns>
        public static OverlayFilter OverlayFilter(this ImageMap first, ImageMap second)
            => new OverlayFilter(first, second);
        /// <summary>
        /// Overlay one video on top of another.<br>
        /// </br>It takes two inputs and has one output.The first input is the "main" video on which the second input is overlaid.
        /// </summary>
        /// <param name="second"></param>
        /// <param name="first"></param>
        /// <returns></returns>
        public static OverlayFilter OverlayFilterOn(this ImageMap second, ImageMap first)
            => new OverlayFilter(first, second);
    }
    public enum OverlayAlpha
    {
        Straight,
        Premultiplied
    }
    public enum OverlayPixFmt
    {
        /// <summary>
        /// force YUV420 output
        /// </summary>
        yuv420,
        /// <summary>
        /// force YUV420p10 output
        /// </summary>
        yuv420p10,
        /// <summary>
        /// force YUV422 output
        /// </summary>
        yuv422,
        /// <summary>
        /// force YUV422p10 output
        /// </summary>
        yuv422p10,
        /// <summary>
        /// force YUV444 output
        /// </summary>
        yuv444,
        /// <summary>
        /// force packed RGB output
        /// </summary>
        rgb,
        /// <summary>
        /// force planar RGB output
        /// </summary>
        gbrp,
        /// <summary>
        /// automatically pick format
        /// </summary>
        auto
    }
    /// <summary>
    /// Set when the expressions for x, and y are evaluated.
    /// </summary>
    public enum OverlayEval
    {
        /// <summary>
        /// only evaluate expressions once during the filter initialization or when a command is processed
        /// </summary>
        Init,
        /// <summary>
        /// evaluate expressions for each incoming frame
        /// </summary>
        Frame
    }
}