/*
boxblur_opencl AVOptions:
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
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... boxblur_opencl    V->V       Apply boxblur filter to input video<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#boxblur_005fopencl
    /// </summary>
    public class BoxblurOpenclFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new string[]
        {
            "w","h","cw","ch","hsub","vsub"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal BoxblurOpenclFilter(ImageMap imageMap) : base("boxblur_opencl", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Radius of the luma blurring box (default "2")
        /// </summary>
        /// <param name="luma_radius"></param>
        /// <returns></returns>
        public BoxblurOpenclFilter LumaRadius(ExpressionValue luma_radius)
            => this.SetOption("lr", expression.Check(luma_radius));
        /// <summary>
        /// Radius of the chroma blurring box
        /// </summary>
        /// <param name="chroma_radius"></param>
        /// <returns></returns>
        public BoxblurOpenclFilter ChromaRadius(ExpressionValue chroma_radius)
            => this.SetOption("cr", expression.Check(chroma_radius));
        /// <summary>
        /// Radius of the alpha blurring box
        /// </summary>
        /// <param name="alpha_radius"></param>
        /// <returns></returns>
        public BoxblurOpenclFilter AlphaRadius(ExpressionValue alpha_radius)
            => this.SetOption("ar", expression.Check(alpha_radius));


        /// <summary>
        /// How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
        /// </summary>
        /// <param name="luma_power"></param>
        /// <returns></returns>
        public BoxblurOpenclFilter LumaPower(int luma_power)
            => this.SetOptionRange("lp", luma_power, 0, INT_MAX);
        /// <summary>
        /// How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="chroma_power"></param>
        /// <returns></returns>
        public BoxblurOpenclFilter ChromaPower(int chroma_power)
            => this.SetOptionRange("cp", chroma_power, -1, INT_MAX);
        /// <summary>
        /// How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="alpha_power"></param>
        /// <returns></returns>
        public BoxblurOpenclFilter AlphaPower(int alpha_power)
            => this.SetOptionRange("ap", alpha_power, -1, INT_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class BoxblurOpenclFilterExtensions
    {
        /// <summary>
        /// Apply a boxblur algorithm to the input video.
        /// </summary>
        public static BoxblurOpenclFilter BoxblurOpenclFilter(this ImageMap imageMap)
          => new BoxblurOpenclFilter(imageMap);
    }
}
