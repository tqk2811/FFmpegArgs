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
        internal ChromaholdFilter(Color color, ImageMap imageMap) : base("chromahold", imageMap)
        {
            AddMapOut();
            this.SetOption("color", color.ToHexStringRGBA());
        }

        /// <summary>
        /// Similarity percentage with the above color. 0.01 matches only the exact key color, while 1.0 matches everything.
        /// </summary>
        /// <param name="similarity"></param>
        /// <returns></returns>
        public ChromaholdFilter Similarity(float similarity)
          => this.SetOptionRange("similarity", similarity, 0, 1);

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
        public ChromaholdFilter YUV(string yuv)
          => this.SetOption("yuv", yuv);
    }

    public static class ChromaholdFilterExtensions
    {
        /// <summary>
        /// Remove all color information for all colors except for certain one.
        /// </summary>
        /// <param name="color">The color which will not be replaced with neutral chroma.</param>
        public static ChromaholdFilter ChromaholdFilter(this ImageMap imageMap, Color color)
          => new ChromaholdFilter(color, imageMap);
    }
}
