/*
 boxblur AVOptions:
   luma_radius       <string>     ..FV....... Radius of the luma blurring box (default "2")
   lr                <string>     ..FV....... Radius of the luma blurring box (default "2")
   luma_power        <int>        ..FV....... How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
   lp                <int>        ..FV....... How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
   chroma_radius     <string>     ..FV....... Radius of the chroma blurring box
   cr                <string>     ..FV....... Radius of the chroma blurring box
   chroma_power      <int>        ..FV....... How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
   cp                <int>        ..FV....... How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
   alpha_radius      <string>     ..FV....... Radius of the alpha blurring box
   ar                <string>     ..FV....... Radius of the alpha blurring box
   alpha_power       <int>        ..FV....... How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
   ap                <int>        ..FV....... How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.. boxblur           V->V       Blur the input.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#boxblur
    /// </summary>
    public class BoxBlurFilter : ImageToImageFilter, ITimelineSupport
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "w","h",
            "cw","ch",
            "hsub", "vsub"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal BoxBlurFilter(ImageMap imageMap) : base("boxblur", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
        /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
        /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
        /// </summary>
        /// <param name="lr"></param>
        /// <returns></returns>
        public BoxBlurFilter LumaRadius(ExpressionValue lr)
          => this.SetOption("lr", expression.Check(lr));
        /// <summary>
        /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
        /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
        /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
        /// </summary>
        /// <param name="cr"></param>
        /// <returns></returns>
        public BoxBlurFilter ChromaRadius(ExpressionValue cr)
          => this.SetOption("cr", expression.Check(cr));
        /// <summary>
        /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
        /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
        /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public BoxBlurFilter AlphaRadius(ExpressionValue ar)
          => this.SetOption("ar", expression.Check(ar));
        /// <summary>
        /// Specify how many times the boxblur filter is applied to the corresponding plane.<br></br>
        /// Default value for luma_power is 2. If not specified, chroma_power and alpha_power default to the corresponding value set for luma_power.<br></br>
        /// A value of 0 will disable the effect.<br>
        /// </br>(from 0 to INT_MAX) (default 2)
        /// </summary>
        /// <param name="lp"></param>
        /// <returns></returns>
        public BoxBlurFilter LumaPower(int lp)
          => this.SetOptionRange("lp", lp, 0, int.MaxValue);
        /// <summary>
        /// Specify how many times the boxblur filter is applied to the corresponding plane.<br></br>
        /// Default value for luma_power is 2. If not specified, chroma_power and alpha_power default to the corresponding value set for luma_power.<br></br>
        /// A value of 0 will disable the effect.<br>
        /// </br>(from -1 to INT_MAX) (default-1)
        /// </summary>
        /// <param name="cp"></param>
        /// <returns></returns>
        public BoxBlurFilter ChromaPower(int cp)
          => this.SetOptionRange("cp", cp, -1, int.MaxValue);
        /// <summary>
        /// Specify how many times the boxblur filter is applied to the corresponding plane.<br></br>
        /// Default value for luma_power is 2. If not specified, chroma_power and alpha_power default to the corresponding value set for luma_power.<br></br>
        /// A value of 0 will disable the effect.<br>
        /// </br>(from -1 to INT_MAX) (default-1)
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public BoxBlurFilter AlphaPower(int ap)
          => this.SetOptionRange("ap", ap, -1, int.MaxValue);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class BoxBlurFilterExtension
    {
        /// <summary>
        /// Apply a boxblur algorithm to the input video.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static BoxBlurFilter BoxBlurFilter(this ImageMap imageMap)
        {
            return new BoxBlurFilter(imageMap);
        }
    }
}
