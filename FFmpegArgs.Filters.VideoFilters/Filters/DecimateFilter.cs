namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... decimate          N->V       Decimate frames (post field matching filter).<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#decimate-1
    /// </summary>
    public class DecimateFilter : ImageToImageFilter
    {
        internal DecimateFilter(ImageMap imageMap) : base("decimate", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the number of frames from which one will be dropped. Setting this to N means one frame in every batch of N frames will be dropped. (from 2 to 25) (default 5)
        /// </summary>
        /// <param name="cycle"></param>
        /// <returns></returns>
        public DecimateFilter Cycle(int cycle)
            => this.SetOptionRange("cycle", cycle, 2, 25);
        /// <summary>
        /// Set the threshold for duplicate detection. If the difference metric for a frame is less than or equal to this value, then it is declared as duplicate. (from 0 to 100) (default 1.1)
        /// </summary>
        /// <param name="dupthresh"></param>
        /// <returns></returns>
        public DecimateFilter Dupthresh(double dupthresh)
            => this.SetOptionRange("dupthresh", dupthresh, 0, 100);
        /// <summary>
        /// Set scene change threshold. (from 0 to 100) (default 1.1)
        /// </summary>
        /// <param name="scthresh"></param>
        /// <returns></returns>
        public DecimateFilter Scthresh(double scthresh)
            => this.SetOptionRange("scthresh", scthresh, 0, 100);
        /// <summary>
        /// Set the size of the x and y-axis blocks used during metric calculations. Larger blocks give better noise suppression, but also give worse detection of small movements. Must be a power of two. Default is 32.
        /// </summary>
        /// <param name="blockx"></param>
        /// <returns></returns>
        public DecimateFilter Blockx(int blockx)
            => this.SetOptionRange("blockx", blockx.EnsureEven(), 0, int.MaxValue);
        /// <summary>
        /// Set the size of the x and y-axis blocks used during metric calculations. Larger blocks give better noise suppression, but also give worse detection of small movements. Must be a power of two. Default is 32.
        /// </summary>
        /// <param name="blocky"></param>
        /// <returns></returns>
        public DecimateFilter Blocky(int blocky)
            => this.SetOptionRange("blocky", blocky.EnsureEven(), 0, int.MaxValue);
        /// <summary>
        /// Mark main input as a pre-processed input and activate clean source input stream. This allows the input to be pre-processed with various filters to help the metrics calculation while keeping the frame selection lossless. When set to 1, the first stream is for the pre-processed input, and the second stream is the clean source from where the kept frames are chosen. Default is 0.
        /// </summary>
        /// <param name="ppsrc"></param>
        /// <returns></returns>
        public DecimateFilter Ppsrc(bool ppsrc)
            => this.SetOption("ppsrc", ppsrc.ToFFmpegFlag());
        /// <summary>
        /// Set whether or not chroma is considered in the metric calculations. Default is 1.
        /// </summary>
        /// <param name="chroma"></param>
        /// <returns></returns>
        public DecimateFilter Chroma(bool chroma)
            => this.SetOption("chroma", chroma.ToFFmpegFlag());
    }
    public static class DecimateFilterExtensions
    {
        /// <summary>
        /// Drop duplicated frames at regular intervals.
        /// </summary>
        public static DecimateFilter DecimateFilter(this ImageMap imageMap)
          => new DecimateFilter(imageMap);
    }
}
