/*
convolve AVOptions:
  planes            <int>        ..FV....... set planes to convolve (from 0 to 15) (default 7)
  impulse           <int>        ..FV....... when to process impulses (from 0 to 1) (default all)
     first           0            ..FV....... process only first impulse, ignore rest
     all             1            ..FV....... process all impulses
  noise             <float>      ..FV....... set noise (from 0 to 1) (default 1e-07)
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. convolve          VV->V      Convolve first video stream with second video stream.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#convolve
    /// </summary>
    public class ConvolveFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, IFramesync
    {
        internal ConvolveFilter(ImageMap imageMap) : base("convolve", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set planes to convolve (from 0 to 15) (default 7)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public ConvolveFilter Planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
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
        public static ConvolveFilter ConvolveFilter(this ImageMap imageMap) => new ConvolveFilter(imageMap);
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
