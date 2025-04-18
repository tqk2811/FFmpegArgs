/*
 overlay AVOptions:
   x                 <string>     ..FV....... set the x expression (default "0")
   y                 <string>     ..FV....... set the y expression (default "0")
   eof_action        <int>        ..FV....... Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
     repeat          0            ..FV....... Repeat the previous frame.
     endall          1            ..FV....... End both streams.
     pass            2            ..FV....... Pass through the main input.
   eval              <int>        ..FV....... specify when to evaluate expressions (from 0 to 1) (default frame)
     init            0            ..FV....... eval expressions once during initialization
     frame           1            ..FV....... eval expressions per-frame
   shortest          <boolean>    ..FV....... force termination when the shortest input terminates (default false)
   format            <int>        ..FV....... set output format (from 0 to 7) (default yuv420)
     yuv420          0            ..FV....... 
     yuv420p10       1            ..FV....... 
     yuv422          2            ..FV....... 
     yuv422p10       3            ..FV....... 
     yuv444          4            ..FV....... 
     rgb             5            ..FV....... 
     gbrp            6            ..FV....... 
     auto            7            ..FV....... 
   repeatlast        <boolean>    ..FV....... repeat overlay of the last overlay frame (default true)
   alpha             <int>        ..FV....... alpha format (from 0 to 1) (default straight)
     straight        0            ..FV....... 
     premultiplied   1            ..FV....... 
 */
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
        public OverlayFilter X(ExpressionValue x)
            => this.SetOption("x", expression.Check(x));
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public OverlayFilter Y(ExpressionValue y)
            => this.SetOption("y", expression.Check(y));
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
    /// <summary>
    /// 
    /// </summary>
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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}