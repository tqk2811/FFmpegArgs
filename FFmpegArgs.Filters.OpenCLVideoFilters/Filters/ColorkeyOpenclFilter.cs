/*
colorkey_opencl AVOptions:
   color             <color>      ..FV....... set the colorkey key color (default "black")
   similarity        <float>      ..FV....... set the colorkey similarity value (from 0.01 to 1) (default 0.01)
   blend             <float>      ..FV....... set the colorkey key blend value (from 0 to 1) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... colorkey_opencl   V->V       Turns a certain color into transparency. Operates on RGB colors.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colorkey_005fopencl
    /// </summary>
    public class ColorkeyOpenclFilter : ImageToImageFilter
    {
        internal ColorkeyOpenclFilter(ImageMap imageMap) : base("colorkey_opencl", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// The color which will be replaced with transparency.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ColorkeyOpenclFilter Color(Color color)
            => this.SetOption("color", color.ToHexStringRGBA());

        /// <summary>
        /// Similarity percentage with the key color.<br>
        /// </br>0.01 matches only the exact key color, while 1.0 matches everything. (from 0.01 to 1) (default 0.01)
        /// </summary>
        /// <param name="similarity"></param>
        /// <returns></returns>
        public ColorkeyOpenclFilter Similarity(float similarity)
            => this.SetOptionRange("similarity", similarity, 0.01, 1);

        /// <summary>
        /// Blend percentage.<br>
        /// </br>0.0 makes pixels either fully transparent, or not transparent at all.<br>
        /// </br>Higher values result in semi-transparent pixels, with a higher transparency the more similar the pixels color is to the key color.<br>
        /// </br>(from 0 to 1) (default 0)
        /// </summary>
        /// <param name="blend"></param>
        /// <returns></returns>
        public ColorkeyOpenclFilter Blend(float blend)
            => this.SetOptionRange("blend", blend, 0, 1);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ColorkeyOpenclFilterExtensions
    {
        /// <summary>
        /// RGB colorspace color keying.
        /// </summary>
        public static ColorkeyOpenclFilter ColorkeyOpenclFilter(this ImageMap imageMap)
          => new ColorkeyOpenclFilter(imageMap);
    }
}
