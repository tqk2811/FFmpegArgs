using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC colorcorrect      V->V       Adjust color white balance selectively for blacks and whites.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colorcorrect
    /// </summary>
    public class ColorcorrectFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ColorcorrectFilter(ImageMap imageMap) : base("colorcorrect", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the red shadow spot. Allowed range is from -1.0 to 1.0. Default value is 0.
        /// </summary>
        /// <param name="rl"></param>
        /// <returns></returns>
        public ColorcorrectFilter RL(float rl)
          => this.SetOptionRange("rl", rl, -1.0f, 1.0f);

        /// <summary>
        /// Set the blue shadow spot. Allowed range is from -1.0 to 1.0. Default value is 0.
        /// </summary>
        /// <param name="bl"></param>
        /// <returns></returns>
        public ColorcorrectFilter BL(float bl)
         => this.SetOptionRange("bl", bl, -1.0f, 1.0f);

        /// <summary>
        /// Set the red highlight spot. Allowed range is from -1.0 to 1.0. Default value is 0.
        /// </summary>
        /// <param name="rh"></param>
        /// <returns></returns>
        public ColorcorrectFilter RH(float rh)
         => this.SetOptionRange("rh", rh, -1.0f, 1.0f);

        /// <summary>
        /// Set the red highlight spot. Allowed range is from -1.0 to 1.0. Default value is 0.
        /// </summary>
        /// <param name="bh"></param>
        /// <returns></returns>
        public ColorcorrectFilter BH(float bh)
         => this.SetOptionRange("bh", bh, -1.0f, 1.0f);

        /// <summary>
        /// Set the amount of saturation. Allowed range is from -3.0 to 3.0. Default value is 1.
        /// </summary>
        /// <param name="saturation"></param>
        /// <returns></returns>
        public ColorcorrectFilter Saturation(float saturation)
          => this.SetOptionRange("saturation", saturation, -3.0f, 3.0f);

        /// <summary>
        /// If set to anything other than manual it will analyze every frame and use derived parameters for filtering output frame.<br></br>
        /// Default value is manual.
        /// </summary>
        /// <param name="analyze"></param>
        /// <returns></returns>
        public ColorcorrectFilter Analyze(ColorcorrectAnalyze analyze)
          => this.SetOption("analyze", analyze);
    }

    public static class ColorcorrectFilterExtensions
    {
        /// <summary>
        /// Adjust color white balance selectively for blacks and whites. This filter operates in YUV colorspace.
        /// </summary>
        public static ColorcorrectFilter ColorcorrectFilter(this ImageMap imageMap)
          => new ColorcorrectFilter(imageMap);
    }

    public enum ColorcorrectAnalyze
    {
        manual,
        average,
        minmax,
        median
    }
}
