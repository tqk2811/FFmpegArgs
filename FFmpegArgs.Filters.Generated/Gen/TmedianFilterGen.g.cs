namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS tmedian           V-&gt;V       Pick median pixels from successive frames.
    /// </summary>
    public class TmedianFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal TmedianFilterGen(ImageMap input) : base("tmedian", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set median filter radius (from 1 to 127) (default 1)
        /// </summary>
        public TmedianFilterGen radius(int radius) => this.SetOptionRange("radius", radius, 1, 127);
        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 15)
        /// </summary>
        public TmedianFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        ///  set percentile (from 0 to 1) (default 0.5)
        /// </summary>
        public TmedianFilterGen percentile(float percentile) => this.SetOptionRange("percentile", percentile, 0, 1);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Pick median pixels from successive frames.
        /// </summary>
        public static TmedianFilterGen TmedianFilterGen(this ImageMap input0) => new TmedianFilterGen(input0);
    }
}