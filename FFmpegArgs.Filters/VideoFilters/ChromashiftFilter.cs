using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC chromashift       V->V       Shift chroma.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#chromashift
    /// </summary>
    public class ChromashiftFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ChromashiftFilter(ImageMap imageMap) : base("chromashift", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set amount to shift chroma-blue horizontally.<br>
        /// </br>(from -255 to 255) (default 0)
        /// </summary>
        /// <param name="cbh"></param>
        /// <returns></returns>
        public ChromashiftFilter Cbh(int cbh)
          => this.SetOptionRange("cbh", cbh, -255, 255);
        /// <summary>
        /// Set amount to shift chroma-blue vertically.<br>
        /// </br>(from -255 to 255) (default 0)
        /// </summary>
        /// <param name="cbv"></param>
        /// <returns></returns>
        public ChromashiftFilter Cbv(int cbv)
          => this.SetOptionRange("cbv", cbv, -255, 255);
        /// <summary>
        /// Set amount to shift chroma-red horizontally.<br>
        /// </br>(from -255 to 255) (default 0)
        /// </summary>
        /// <param name="crh"></param>
        /// <returns></returns>
        public ChromashiftFilter Crh(int crh)
          => this.SetOptionRange("crh", crh, -255, 255);
        /// <summary>
        /// Set amount to shift chroma-red vertically.<br>
        /// </br>(from -255 to 255) (default 0)
        /// </summary>
        /// <param name="crv"></param>
        /// <returns></returns>
        public ChromashiftFilter Crv(int crv)
          => this.SetOptionRange("crv", crv, -255, 255);

        /// <summary>
        /// Set edge mode, can be smear, default, or warp.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public ChromashiftFilter Edge(ChromashiftEdgeMode mode)
          => this.SetOption("edge", mode.ToString().Substring(1));
    }

    public static class ChromashiftFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static ChromashiftFilter chromashiftFilter(this ImageMap imageMap)
          => new ChromashiftFilter(imageMap);
    }

    public enum ChromashiftEdgeMode
    {
        _smear,
        _default,
        _warp
    }
}
