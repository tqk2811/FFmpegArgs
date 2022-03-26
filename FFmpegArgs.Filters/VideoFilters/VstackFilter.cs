/*
vstack AVOptions:
  inputs            <int>        ..FV....... set number of inputs (from 2 to INT_MAX) (default 2)
  shortest          <boolean>    ..FV....... force termination when the shortest input terminates (default false)
*/
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// .S. vstack            N->V       Stack video inputs vertically.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#vstack
    /// </summary>
    public class VstackFilter : ImageToImageFilter, ISliceThreading
    {
        internal VstackFilter(ImageMap[] imageMaps) : base("vstack", imageMaps)
        {
            if (imageMaps.Length < 2)
                throw new ArgumentException("vstack: The number of input images must be at least 2");
            AddMapOut();
            this.SetOption("inputs", imageMaps.Length);
        }

        /// <summary>
        /// If set to 1, force the output to terminate when the shortest input terminates. Default value is 0.
        /// </summary>
        /// <param name="shortest"></param>
        /// <returns></returns>
        public VstackFilter Shortest(bool shortest)
            => this.SetOption("shortest", shortest.ToFFmpegFlag());

    }
    /// <summary>
    /// 
    /// </summary>
    public static class VstackFilterExtensions
    {
        /// <summary>
        /// Stack input videos vertically.<br>
        /// </br>All streams must be of same pixel format and of same height.<br>
        /// </br>Note that this filter is faster than using <see cref="OverlayFilter"/> and <see cref="PadFilter"/> filter to create same output.
        /// </summary>
        public static VstackFilter VstackFilter(this ImageMap imageMap, params ImageMap[] imageMaps)
          => new VstackFilter(new ImageMap[] { imageMap }.Concat(imageMaps).ToArray());
    }
}
