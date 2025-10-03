namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC tmix              V-&gt;V       Mix successive video frames.
    /// </summary>
    public class TmixFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal TmixFilterGen(ImageMap input) : base("tmix", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set number of successive frames to mix (from 1 to 1024) (default 3)
        /// </summary>
        public TmixFilterGen frames(int frames) => this.SetOptionRange("frames", frames, 1, 1024);
        /// <summary>
        ///  set weight for each frame (default &quot;1 1 1&quot;)
        /// </summary>
        public TmixFilterGen weights(String weights) => this.SetOption("weights", weights.ToString());
        /// <summary>
        ///  set scale (from 0 to 32767) (default 0)
        /// </summary>
        public TmixFilterGen scale(float scale) => this.SetOptionRange("scale", scale, 0, 32767);
        /// <summary>
        ///  set what planes to filter (default F)
        /// </summary>
        public TmixFilterGen planes(String planes) => this.SetOption("planes", planes.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Mix successive video frames.
        /// </summary>
        public static TmixFilterGen TmixFilterGen(this ImageMap input0) => new TmixFilterGen(input0);
    }
}