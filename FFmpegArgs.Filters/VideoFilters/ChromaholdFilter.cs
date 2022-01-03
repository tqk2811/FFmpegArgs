/*
chromahold AVOptions:
  color             <color>      ..FV.....T. set the chromahold key color (default "black")
  similarity        <float>      ..FV.....T. set the chromahold similarity value (from 0.01 to 1) (default 0.01)
  blend             <float>      ..FV.....T. set the chromahold blend value (from 0 to 1) (default 0)
  yuv               <boolean>    ..FV.....T. color parameter is in yuv instead of rgb (default false)
 */
using FFmpegArgs.Cores.Maps;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC chromahold        V->V       Turns a certain color range into gray.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#chromahold
    /// </summary>
    public class ChromaholdFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ChromaholdFilter(ImageMap imageMap) : base("chromahold", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// The color which will not be replaced with neutral chroma.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ChromaholdFilter Color(Color color)
          => this.SetOption("color", color.ToHexStringRGBA());

        /// <summary>
        /// Similarity percentage with the above color. 0.01 matches only the exact key color, while 1.0 matches everything.
        /// </summary>
        /// <param name="similarity"></param>
        /// <returns></returns>
        public ChromaholdFilter Similarity(float similarity)
          => this.SetOptionRange("similarity", similarity, 0.01f, 1);

        /// <summary>
        /// Blend percentage. 0.0 makes pixels either fully gray, or not gray at all. Higher values result in more preserved color.
        /// </summary>
        /// <param name="blend"></param>
        /// <returns></returns>
        public ChromaholdFilter Blend(float blend)
          => this.SetOptionRange("blend", blend, 0, 1);

        /// <summary>
        /// Signals that the color passed is already in YUV instead of RGB.<br></br>
        /// Literal colors like "green" or "red" don’t make sense with this enabled anymore.This can be used to pass exact YUV values as hexadecimal numbers.
        /// </summary>
        /// <param name="yuv"></param>
        /// <returns></returns>
        public ChromaholdFilter YUV(bool yuv)
          => this.SetOption("yuv", yuv.ToFFmpegFlag());
    }

    public static class ChromaholdFilterExtensions
    {
        /// <summary>
        /// Remove all color information for all colors except for certain one.
        /// </summary>
        public static ChromaholdFilter ChromaholdFilter(this ImageMap imageMap) => new ChromaholdFilter(imageMap);
    }
}
