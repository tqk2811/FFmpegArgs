namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// .S. sierpinski        |->V       Render a Sierpinski fractal.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#sierpinski
    /// </summary>
    public class SierpinskiFilter : SourceToImageFilter, ISliceThreading
    {
        internal SierpinskiFilter(IImageFilterGraph filterGraph) : base("sierpinski", filterGraph)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set frame size. For the syntax of this option.<br>
        /// </br> Default value is "640x480".
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public SierpinskiFilter Size(Size size)
          => this.SetOption("s", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        /// Set frame size. For the syntax of this option.<br>
        /// </br> Default value is "640x480".
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public SierpinskiFilter Size(VideoSizeUtils size)
          => this.SetOption("s", size.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        /// Set frame rate, expressed as number of frames per second. Default value is "25".
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public SierpinskiFilter Rate(int r)
          => this.SetOptionRange("r", r, 1, int.MaxValue);
        /// <summary>
        /// Set seed which is used for random panning.
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public SierpinskiFilter Seed(int seed)
          => this.SetOption("seed", (uint)seed);
        /// <summary>
        /// Set max jump for single pan destination. Allowed range is from 1 to 10000.
        /// </summary>
        /// <param name="jump"></param>
        /// <returns></returns>
        public SierpinskiFilter Jump(int jump)
          => this.SetOptionRange("jump", jump, 1, 10000);
        /// <summary>
        /// Set fractal type, can be default carpet or triangle.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public SierpinskiFilter Type(SierpinskiType type)
          => this.SetOption("type", type);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SierpinskiFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static SierpinskiFilter SierpinskiFilter(this IImageFilterGraph filterGraph)
          => new SierpinskiFilter(filterGraph);
    }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum SierpinskiType
    {
        carpet,
        triangle
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
