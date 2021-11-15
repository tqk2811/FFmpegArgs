using FFmpegArgs.Cores.Maps;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC colorkey          V->V       Turns a certain color into transparency. Operates on RGB colors.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colorkey
    /// </summary>
    public class ColorKeyFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ColorKeyFilter(Color color, ImageMap imageMap) : base("colorkey", imageMap)
        {
            AddMapOut();
            this.SetOption("color", color.ToHexStringRGB());
        }

        /// <summary>
        /// Similarity percentage with the key color.<br></br>
        /// 0.01 matches only the exact key color, while 1.0 matches everything. (from 0.01 to 1) (default 0.01)
        /// </summary>
        /// <param name="similarity"></param>
        /// <returns></returns>
        public ColorKeyFilter Similarity(float similarity)
          => this.SetOptionRange("similarity", similarity, 0.01, 1);

        /// <summary>
        /// Blend percentage.<br>
        /// </br>0.0 makes pixels either fully transparent, or not transparent at all.<br>
        /// </br>Higher values result in semi-transparent pixels, with a higher transparency the more similar the pixels color is to the key color.
        /// </summary>
        /// <param name="blend"></param>
        /// <returns></returns>
        public ColorKeyFilter Blend(float blend)
          => this.SetOptionRange("blend", blend, 0, 1);
    }

    public static class ColorKeyFilterExtension
    {
        /// <summary>
        /// RGB colorspace color keying.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="color">The color which will be replaced with transparency.</param>
        /// <returns></returns>
        public static ColorKeyFilter ColorKeyFilter(this ImageMap parent, Color color)
          => new ColorKeyFilter(color, parent);
    }
}
