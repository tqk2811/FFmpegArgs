/*
colorhold AVOptions:
  color             <color>      ..FV.....T. set the colorhold key color (default "black")
  similarity        <float>      ..FV.....T. set the colorhold similarity value (from 0.01 to 1) (default 0.01)
  blend             <float>      ..FV.....T. set the colorhold blend value (from 0 to 1) (default 0)
*/
using FFmpegArgs.Cores.Maps;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC colorhold         V->V       Turns a certain color range into gray. Operates on RGB colors.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colorhold
    /// </summary>
    public class ColorholdFilter : ImageToImageFilter
    {
        internal ColorholdFilter(ImageMap imageMap) : base("colorhold", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// The color which will not be replaced with neutral gray.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ColorholdFilter Color(Color color) => this.SetOption("color", color.ToHexStringRGBA());

        /// <summary>
        /// Similarity percentage with the key color.<br></br>
        /// 0.01 matches only the exact key color, while 1.0 matches everything. (from 0.01 to 1) (default 0.01)
        /// </summary>
        /// <param name="similarity"></param>
        /// <returns></returns>
        public ColorholdFilter Similarity(float similarity)
          => this.SetOptionRange("similarity", similarity, 0.01f, 1);

        /// <summary>
        /// Blend percentage.<br>
        /// </br>0.0 makes pixels fully gray.<br>
        /// </br>Higher values result in semi-transparent pixels, with a higher transparency the more similar the pixels color is to the key color.
        /// </summary>
        /// <param name="blend"></param>
        /// <returns></returns>
        public ColorholdFilter Blend(float blend)
          => this.SetOptionRange("blend", blend, 0, 1);

    }

    public static class ColorholdFilterExtensions
    {
        /// <summary>
        /// Remove all color information for all RGB colors except for certain one.
        /// </summary>
        public static ColorholdFilter ColorholdFilter(this ImageMap imageMap)
          => new ColorholdFilter(imageMap);
    }
}
