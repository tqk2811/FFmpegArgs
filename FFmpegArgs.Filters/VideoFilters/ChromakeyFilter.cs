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
        internal ChromakeyFilter(Color color, ImageMap imageMap) : base("chromakey", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Similarity percentage with the key color.<br></br>
        /// 0.01 matches only the exact key color, while 1.0 matches everything.
        /// </summary>
        /// <param name="similarity"></param>
        /// <returns></returns>
        public ChromakeyFilter Similarity(float similarity)
          => this.SetOptionRange("similarity", similarity, 0, 1);

        /// <summary>
        /// Blend percentage.<br></br>
        /// 0.0 makes pixels either fully transparent, or not transparent at all.<br></br>
        /// Higher values result in semi-transparent pixels, with a higher transparency the more similar the pixels color is to the key color.
        /// </summary>
        /// <param name="blend"></param>
        /// <returns></returns>
        public ChromakeyFilter Blend(float blend)
          => this.SetOptionRange("blend", blend, 0, 1);

        /// <summary>
        /// Signals that the color passed is already in YUV instead of RGB.<br></br>
        /// Literal colors like "green" or "red" don’t make sense with this enabled anymore.This can be used to pass exact YUV values as hexadecimal numbers.
        /// </summary>
        /// <param name="yuv"></param>
        /// <returns></returns>
        public ChromakeyFilter YUV(string yuv)
          => this.SetOption("yuv", yuv);
    }

    public static class ChromakeyFilterExtensions
    {
        /// <summary>
        /// YUV colorspace color/chroma keying.
        /// </summary>
        /// <param name="color">The color which will be replaced with transparency.</param>
        public static ChromakeyFilter ChromakeyFilter(this ImageMap imageMap, Color color)
          => new ChromakeyFilter(color, imageMap);
    }
}
