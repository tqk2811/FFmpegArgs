/*
zoompan AVOptions:
  zoom              <string>     ..FV....... set the zoom expression (default "1")
  z                 <string>     ..FV....... set the zoom expression (default "1")
  x                 <string>     ..FV....... set the x expression (default "0")
  y                 <string>     ..FV....... set the y expression (default "0")
  d                 <string>     ..FV....... set the duration expression (default "90")
  s                 <image_size> ..FV....... set the output image size (default "hd720")
  fps               <video_rate> ..FV....... set the output framerate (default "25")
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... zoompan           V->V       Apply Zoom & Pan effect.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#zoompan
    /// </summary>
    public class ZoompanFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "in_w", "iw",
            "in_h", "ih",
            "out_w", "ow",
            "out_h","oh",
            "in", "on",
            "in_time", "it",
            "out_time", "time","ot",
            "x", "y",
            "px","py",
            "zoom",
            "pzoom",
            "duration",
            "pduration",
            "a",
            "sar",
            "dar"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal ZoompanFilter(ImageMap imageMap) : base("zoompan", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the zoom expression. Range is 1-10. Default is 1.
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public ZoompanFilter Zoom(ExpressionValue z) => this.SetOption("z", expression.Check(z));
        /// <summary>
        /// Set the x and y expression. Default is 0.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ZoompanFilter X(ExpressionValue x) => this.SetOption("x", expression.Check(x));
        /// <summary>
        /// Set the x and y expression. Default is 0.
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public ZoompanFilter Y(ExpressionValue y) => this.SetOption("y", expression.Check(y));
        /// <summary>
        /// Set the duration expression in number of frames. This sets for how many number of frames effect will last for single input image. Default is 90.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public ZoompanFilter D(ExpressionValue d) => this.SetOption("d", expression.Check(d));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public ZoompanFilter D(TimeSpan d) => this.SetOptionRange("d", d, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Set the output image size
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public ZoompanFilter S(Size s) => this.SetOption("s", $"{s.Width}x{s.Height}");
        /// <summary>
        /// Set the output frame rate, default is ’25’.
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public ZoompanFilter Fps(Rational fps) => this.SetOption("fps", fps);
        /// <summary>
        /// Set the output frame rate, default is ’25’.
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public ZoompanFilter Fps(int fps) => this.SetOptionRange("fps", fps, 1, INT_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ZoompanFilterExtensions
    {
        /// <summary>
        /// Apply Zoom & Pan effect.
        /// </summary>
        public static ZoompanFilter ZoompanFilter(this ImageMap imageMap)
          => new ZoompanFilter(imageMap);
    }
}
