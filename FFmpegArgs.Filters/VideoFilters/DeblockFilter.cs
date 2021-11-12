using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.C deblock           V->V       Deblock video<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#deblock
    /// </summary>
    public class DeblockFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        internal DeblockFilter(ImageMap imageMap) : base("deblock", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set filter type, can be weak or strong. Default is strong. This controls what kind of deblocking is applied.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public DeblockFilter Filter(DeblockFilterType type)
            => this.SetOption("filter", type);

        /// <summary>
        /// Set size of block, allowed range is from 4 to 512. Default is 8.
        /// </summary>
        /// <param name="block"></param>
        /// <returns></returns>
        public DeblockFilter Block(int block)
            => this.SetOptionRange("block", block, 4, 512);

        /// <summary>
        /// Set blocking detection thresholds. Allowed range is 0 to 1. Defaults are: 0.098 for alpha and 0.05 for the rest. Using higher threshold gives more deblocking strength. Setting alpha controls threshold detection at exact edge of block. Remaining options controls threshold detection near the edge. Each one for below/above or left/right. Setting any of those to 0 disables deblocking.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public DeblockFilter BlockingDetectionThresholds(DeblockName name, float val)
            => this.SetOptionRange(name.ToString(), val, 0, 1);

        /// <summary>
        /// Set planes to filter. Default is to filter all available planes.
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public DeblockFilter Planes(int planes)
            => this.SetOptionRange("planes", planes, 0, int.MaxValue);
    }

    public static class DeblockFilterExtensions
    {
        /// <summary>
        /// Remove blocking artifacts from input video.
        /// </summary>
        public static DeblockFilter DeblockFilter(this ImageMap imageMap)
          => new DeblockFilter(imageMap);
    }

    public enum DeblockFilterType
    {
        weak,
        strong
    }

    public enum DeblockName
    {
        alpha,
        beta,
        gamma,
        delta
    }
}
