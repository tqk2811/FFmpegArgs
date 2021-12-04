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
        internal ColorKeyFilter(ImageMap imageMap) : base("colorkey", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the color for which alpha will be set to 0 (full transparency). 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public ColorKeyFilter Color(Color color)
          => this.SetOption("color", color.ToHexStringRGBA());


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
          => new ColorKeyFilter(parent).Color(color);

        /// <summary>
        /// RGB colorspace color keying.
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static ColorKeyFilter ColorKeyFilter(this ImageMap parent)
          => new ColorKeyFilter(parent);

        /// <summary>
        /// RGB colorspace color keying.
        /// </summary>
        public static ColorKeyFilter ColorKeyFilter(this ImageMap input0, ColorkeyFilterConfig config)
        {
            var result = new ColorKeyFilter(input0);
            if (config?.Color != null) result.Color(config.Color.Value);
            if (config?.Similarity != null) result.Similarity(config.Similarity.Value);
            if (config?.Blend != null) result.Blend(config.Blend.Value);
            if (!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
            return result;
        }
    }

    public class ColorkeyFilterConfig : ITimelineSupportConfig
    {
        /// <summary>
        ///  set the colorkey key color (default "black")
        /// </summary>
        public Color? Color { get; set; }
        /// <summary>
        ///  set the colorkey similarity value (from 0.01 to 1) (default 0.01)
        /// </summary>
        public float? Similarity { get; set; }
        /// <summary>
        ///  set the colorkey key blend value (from 0 to 1) (default 0)
        /// </summary>
        public float? Blend { get; set; }
        public string TimelineSupport { get; set; }
    }
}
