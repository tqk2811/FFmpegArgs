using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. convolve          VV->V      Convolve first video stream with second video stream.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#convolve
    /// </summary>
    public class ConvolveFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, IFramesync
    {
        internal ConvolveFilter(int plane, ImageMap imageMap) : base("convolve", imageMap)
        {
            AddMapOut();
            this.SetOptionRange("planes", plane, 0, 15);
        }

        /// <summary>
        /// Set which impulse video frames will be processed, can be first or all. Default is all.
        /// </summary>
        /// <param name="impulse"></param>
        /// <returns></returns>
        public ConvolveFilter Impulse(ConvolveImpulse impulse)
            => this.SetOption("impulse", impulse);

        /// <summary>
        /// set noise (from 0 to 1) (default 1e-07)
        /// </summary>
        /// <param name="noise"></param>
        /// <returns></returns>
        public ConvolveFilter Noise(float noise)
            => this.SetOptionRange("noise", noise, 0, 1);

    }

    public static class ConvolveFilterExtensions
    {
        /// <summary>
        /// Apply 2D convolution of video stream in frequency domain using second stream as impulse.
        /// </summary>
        /// <param name="plane">set planes to convolve (from 0 to 15) (default 7)</param>
        public static ConvolveFilter ConvolveFilter(this ImageMap imageMap, int plane)
          => new ConvolveFilter(plane, imageMap);
    }

    public enum ConvolveImpulse
    {
        /// <summary>
        /// process only first impulse, ignore rest
        /// </summary>
        first,
        /// <summary>
        /// process all impulses
        /// </summary>
        all
    }
}
