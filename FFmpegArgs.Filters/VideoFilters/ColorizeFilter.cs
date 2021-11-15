using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC colorize          V->V       Overlay a solid color on the video stream.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colorize
    /// </summary>
    public class ColorizeFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ColorizeFilter(ImageMap imageMap) : base("colorize", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the color hue. Allowed range is from 0 to 360. Default value is 0.
        /// </summary>
        /// <param name="hue"></param>
        /// <returns></returns>
        public ColorizeFilter Hue(float hue)
          => this.SetOptionRange("hue", hue, 0, 360);

        /// <summary>
        /// Set the color saturation. Allowed range is from 0 to 1. Default value is 0.5.
        /// </summary>
        /// <param name="saturation"></param>
        /// <returns></returns>
        public ColorizeFilter Saturation(float saturation)
          => this.SetOptionRange("saturation", saturation, 0, 1);

        /// <summary>
        /// Set the color lightness. Allowed range is from 0 to 1. Default value is 0.5.
        /// </summary>
        /// <param name="lightness"></param>
        /// <returns></returns>
        public ColorizeFilter Lightness(float lightness)
          => this.SetOptionRange("lightness", lightness, 0, 1);

        /// <summary>
        /// Set the mix of source lightness. By default is set to 1.0. Allowed range is from 0.0 to 1.0.
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public ColorizeFilter Mix(float mix)
          => this.SetOptionRange("mix", mix, 0, 1);
    }

    public static class ColorizeFilterExtensions
    {
        /// <summary>
        /// Overlay a solid color on the video stream.
        /// </summary>
        public static ColorizeFilter ColorizeFilter(this ImageMap imageMap)
          => new ColorizeFilter(imageMap);
    }
}
