namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    ///  T.C hue               V->V       Adjust the hue and saturation of the input video.<br>
    /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#hue"/>
    /// </summary>
    public class HueFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "n", "pts", "r", "t", "tb"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal HueFilter(ImageMap imageMap) : base("hue", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Note: h and H are mutually exclusive, and can’t be specified at the same time.
        /// </summary>
        /// <param name="h">Specify the hue angle as a number of degrees. It accepts an expression, and defaults to "0".</param>
        /// <returns></returns>
        public HueFilter h(ExpressionValue h) => this.SetOption("h", expression.Check(h));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">Specify the saturation in the [-10,10] range. It accepts an expression and defaults to "1".</param>
        /// <returns></returns>
        public HueFilter S(ExpressionValue s) => this.SetOption("s", expression.Check(s));
        /// <summary>
        /// Note: h and H are mutually exclusive, and can’t be specified at the same time.
        /// </summary>
        /// <param name="H">Specify the hue angle as a number of radians. It accepts an expression, and defaults to "0".</param>
        /// <returns></returns>
        public HueFilter H(ExpressionValue H) => this.SetOption("H", expression.Check(H));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b">Region distance in pixels from the top edge of the frame.</param>
        /// <returns></returns>
        public HueFilter b(ExpressionValue b) => this.SetOption("b", expression.Check(b));
    }
    /// <summary>
    /// 
    /// </summary>
    public static class HueFilterExtensions
    {
        /// <summary>
        /// Mark a region of interest in a video frame.<br></br>
        /// The frame data is passed through unchanged, but metadata is attached to the frame indicating regions of interest which can affect the behaviour of later encoding.Multiple regions can be marked by applying the filter multiple times.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static HueFilter HueFilter(this ImageMap imageMap)
          => new HueFilter(imageMap);
    }
}
