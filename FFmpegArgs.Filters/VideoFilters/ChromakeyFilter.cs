/*
chromakey AVOptions:
  color             <color>      ..FV.....T. set the chromakey key color (default "black")
  similarity        <float>      ..FV.....T. set the chromakey similarity value (from 0.01 to 1) (default 0.01)
  blend             <float>      ..FV.....T. set the chromakey key blend value (from 0 to 1) (default 0)
  yuv               <boolean>    ..FV.....T. color parameter is in yuv instead of rgb (default false)
 */
using FFmpegArgs.Cores.Maps;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC chromakey         V->V       Turns a certain color into transparency. Operates on YUV colors.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#chromakey
    /// </summary>
    public class ChromakeyFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ChromakeyFilter(ImageMap imageMap) : base("chromakey", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// The color which will be replaced with transparency.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ChromakeyFilter Color(Color color) => this.SetOption("color", color.ToHexStringRGBA());


        /// <summary>
        /// Similarity percentage with the key color.<br></br>
        /// 0.01 matches only the exact key color, while 1.0 matches everything.<br></br>
        /// (from 0.01 to 1) (default 0.01)
        /// </summary>
        /// <param name="similarity"></param>
        /// <returns></returns>
        public ChromakeyFilter Similarity(float similarity) => this.SetOptionRange("similarity", similarity, 0.01f, 1);

        /// <summary>
        /// Blend percentage.<br></br>
        /// 0.0 makes pixels either fully transparent, or not transparent at all.<br></br>
        /// Higher values result in semi-transparent pixels, with a higher transparency the more similar the pixels color is to the key color.<br></br>
        /// (from 0 to 1) (default 0)
        /// </summary>
        /// <param name="blend"></param>
        /// <returns></returns>
        public ChromakeyFilter Blend(float blend) => this.SetOptionRange("blend", blend, 0, 1);

        /// <summary>
        /// Signals that the color passed is already in YUV instead of RGB.<br></br>
        /// Literal colors like "green" or "red" don’t make sense with this enabled anymore.This can be used to pass exact YUV values as hexadecimal numbers.
        /// </summary>
        /// <param name="yuv"></param>
        /// <returns></returns>
        public ChromakeyFilter YUV(bool yuv) => this.SetOption("yuv", yuv.ToFFmpegFlag());
    }

    public static class ChromakeyFilterExtensions
    {
        /// <summary>
        /// YUV colorspace color/chroma keying.
        /// </summary>
        public static ChromakeyFilter ChromakeyFilter(this ImageMap imageMap) => new ChromakeyFilter(imageMap);
    }
}
