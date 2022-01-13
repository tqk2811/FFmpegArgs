namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC colorcontrast     V->V       Adjust color contrast between RGB components.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colorcontrast
    /// </summary>
    public class ColorcontrastFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ColorcontrastFilter(ImageMap imageMap) : base("colorcontrast", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the red-cyan contrast. Defaults is 0.0. Allowed range is from -1.0 to 1.0.
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public ColorcontrastFilter RedCyan(float rc)
          => this.SetOptionRange("rc", rc, -1.0f, 1.0f);
        /// <summary>
        /// Set the green-magenta contrast. Defaults is 0.0. Allowed range is from -1.0 to 1.0.
        /// </summary>
        /// <param name="gm"></param>
        /// <returns></returns>
        public ColorcontrastFilter GreenMagenta(float gm)
          => this.SetOptionRange("gm", gm, -1.0f, 1.0f);
        /// <summary>
        /// Set the blue-yellow contrast. Defaults is 0.0. Allowed range is from -1.0 to 1.0.
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public ColorcontrastFilter BlueYellow(float by)
          => this.SetOptionRange("by", by, -1.0f, 1.0f);
        /// <summary>
        /// Set the weight of <see cref="RedCyan"/> option value. Default value is 0.0. Allowed range is from 0.0 to 1.0. If all weights are 0.0 filtering is disabled.
        /// </summary>
        /// <param name="rcw"></param>
        /// <returns></returns>
        public ColorcontrastFilter RedCyanWeight(float rcw)
          => this.SetOptionRange("rcw", rcw, 0.0f, 1.0f);
        /// <summary>
        /// Set the weight of <see cref="GreenMagenta"/> by option value. Default value is 0.0. Allowed range is from 0.0 to 1.0. If all weights are 0.0 filtering is disabled.
        /// </summary>
        /// <param name="gmw"></param>
        /// <returns></returns>
        public ColorcontrastFilter GreenMagentaWeight(float gmw)
          => this.SetOptionRange("gmw", gmw, 0.0f, 1.0f);
        /// <summary>
        /// Set the weight of <see cref="BlueYellow"/> by option value. Default value is 0.0. Allowed range is from 0.0 to 1.0. If all weights are 0.0 filtering is disabled.
        /// </summary>
        /// <param name="byw"></param>
        /// <returns></returns>
        public ColorcontrastFilter BlueYellowWeight(float byw)
          => this.SetOptionRange("byw", byw, 0.0f, 1.0f);
        /// <summary>
        /// Set the amount of preserving lightness. Default value is 0.0. Allowed range is from 0.0 to 1.0.
        /// </summary>
        /// <param name="pl"></param>
        /// <returns></returns>
        public ColorcontrastFilter PreservingLightness(float pl)
          => this.SetOptionRange("pl", pl, 0.0f, 1.0f);
    }
    public static class ColorcontrastFilterExtensions
    {
        /// <summary>
        /// Adjust color contrast between RGB components.
        /// </summary>
        public static ColorcontrastFilter ColorcontrastFilter(this ImageMap imageMap)
          => new ColorcontrastFilter(imageMap);
    }
}
