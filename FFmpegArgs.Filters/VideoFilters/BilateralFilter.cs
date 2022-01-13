namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.C bilateral         V->V       Apply Bilateral filter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#bilateral
    /// </summary>
    public class BilateralFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        internal BilateralFilter(ImageMap imageMap) : base("bilateral", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set sigma of gaussian function to calculate spatial weight. Allowed range is 0 to 512. Default is 0.1.
        /// </summary>
        /// <param name="sigmaS"></param>
        /// <returns></returns>
        public BilateralFilter SigmaS(float sigmaS)
          => this.SetOptionRange("sigmaS", sigmaS, 0, 512);
        /// <summary>
        /// Set sigma of gaussian function to calculate range weight. Allowed range is 0 to 1. Default is 0.1.
        /// </summary>
        /// <param name="sigmaR"></param>
        /// <returns></returns>
        public BilateralFilter SigmaR(float sigmaR)
          => this.SetOptionRange("sigmaR", sigmaR, 0, 1);
        /// <summary>
        /// Set planes to filter. Default is first only.<br></br>
        /// ..FV.....T. set planes to filter (from 0 to 15) (default 1)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public BilateralFilter Planes(int planes)
          => this.SetOptionRange("planes", planes, 0, 15);
    }
    public static class BilateralFilterExtensions
    {
        /// <summary>
        /// Apply bilateral filter, spatial smoothing while preserving edges.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static BilateralFilter BilateralFilter(this ImageMap imageMap)
          => new BilateralFilter(imageMap);
    }
}
