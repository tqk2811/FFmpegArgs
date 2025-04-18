namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ..C crop              V->V       Crop the input video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#crop
    /// </summary>
    public class CropFilter : ImageToImageFilter, ICommandSupport
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "x", "y",
            "in_w","in_h", "iw", "ih",
            "out_w","out_h", "ow", "oh",
            "a", "sar", "dar", "hsub", "vsub",
            "n", "pos", "t"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal CropFilter(ImageMap imageMap) : base("crop", imageMap)
        {
            AddMapOut();
        }
        internal CropFilter(ImageMap imageMap,
            ExpressionValue x, ExpressionValue y,
            ExpressionValue w, ExpressionValue h) : this(imageMap)
        {
            this.SetOption("x", expression.Check(x));
            this.SetOption("y", expression.Check(y));
            this.SetOption("w", expression.Check(w));
            this.SetOption("h", expression.Check(h));
        }
        /// <summary>
        /// The horizontal position, in the input video, of the left edge of the output video. It defaults to (in_w-out_w)/2. This expression is evaluated per-frame.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public CropFilter X(ExpressionValue x) => this.SetOption("x", expression.Check(x));
        /// <summary>
        /// The vertical position, in the input video, of the top edge of the output video. It defaults to (in_h-out_h)/2. This expression is evaluated per-frame.
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public CropFilter Y(ExpressionValue y) => this.SetOption("y", expression.Check(y));
        /// <summary>
        /// The width of the output video. It defaults to iw. This expression is evaluated only once during the filter configuration, or when the ‘w’ or ‘out_w’ command is sent.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public CropFilter W(ExpressionValue w) => this.SetOption("w", expression.Check(w));
        /// <summary>
        /// The height of the output video. It defaults to ih. This expression is evaluated only once during the filter configuration, or when the ‘h’ or ‘out_h’ command is sent.
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public CropFilter H(ExpressionValue h) => this.SetOption("h", expression.Check(h));
        /// <summary>
        /// If set to 1 will force the output display aspect ratio to be the same of the input, by changing the output sample aspect ratio. It defaults to 0.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public CropFilter KeepAspect(bool flag) => this.SetOption("keep_aspect", flag.ToFFmpegFlag());
        /// <summary>
        /// Enable exact cropping. If enabled, subsampled videos will be cropped at exact width/height/x/y as specified and will not be rounded to nearest smaller value. It defaults to 0.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public CropFilter Exact(bool flag) => this.SetOption("exact", flag.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class CropFilterExtension
    {
        /// <summary>
        /// Crop the input video to given dimensions.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static CropFilter CropFilter(this ImageMap imageMap)
            => new CropFilter(imageMap);

        /// <summary>
        /// Crop the input video to given dimensions.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public static CropFilter CropFilter(this ImageMap imageMap,
            ExpressionValue x, ExpressionValue y,
            ExpressionValue w, ExpressionValue h)
            => new CropFilter(imageMap, x, y, w, h);
    }
}
