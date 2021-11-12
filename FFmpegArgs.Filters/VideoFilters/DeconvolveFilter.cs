using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. deconvolve        VV->V      Deconvolve first video stream with second video stream.<br></br>
    /// 
    /// </summary>
    public class DeconvolveFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, IFramesync
    {
        internal DeconvolveFilter(ImageMap imageMap, int planes) : base("deconvolve", imageMap)
        {
            AddMapOut();
            this.SetOptionRange("planes", planes, 0, int.MaxValue);
        }

        /// <summary>
        /// Set which impulse video frames will be processed, can be first or all. Default is all.
        /// </summary>
        /// <param name="impulse"></param>
        /// <returns></returns>
        public DeconvolveFilter Impulse(int impulse)
            => this.SetOptionRange("impulse", impulse, 0, int.MaxValue);

        /// <summary>
        /// Set noise when doing divisions. Default is 0.0000001. Useful when width and height are not same and not power of 2 or if stream prior to convolving had noise.
        /// </summary>
        /// <param name="noise"></param>
        /// <returns></returns>
        public DeconvolveFilter Noise(decimal noise)
            => this.SetOptionRange("noise", noise, decimal.MinValue, decimal.MaxValue);

    }

    public static class DeconvolveFilterExtensions
    {
        /// <summary>
        /// Apply 2D deconvolution of video stream in frequency domain using second stream as impulse.
        /// </summary>
        public static DeconvolveFilter DeconvolveFilter(this ImageMap imageMap, int planes)
          => new DeconvolveFilter(imageMap, planes);
    }
}
