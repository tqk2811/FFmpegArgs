namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC limitdiff         N-&gt;V       Apply filtering with limiting difference.
    /// </summary>
    public class LimitdiffFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal LimitdiffFilterGen(params ImageMap[] inputs) : base("limitdiff", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the threshold (from 0 to 1) (default 0.00392157)
        /// </summary>
        public LimitdiffFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold, 0, 1);
        /// <summary>
        ///  set the elasticity (from 0 to 10) (default 2)
        /// </summary>
        public LimitdiffFilterGen elasticity(float elasticity) => this.SetOptionRange("elasticity", elasticity, 0, 10);
        /// <summary>
        ///  enable reference stream (default false)
        /// </summary>
        public LimitdiffFilterGen reference(bool reference) => this.SetOption("reference", reference.ToFFmpegFlag());
        /// <summary>
        ///  set the planes to filter (from 0 to 15) (default 15)
        /// </summary>
        public LimitdiffFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply filtering with limiting difference.
        /// </summary>
        public static LimitdiffFilterGen LimitdiffFilterGen(this ImageMap input) => new LimitdiffFilterGen(input);
    }
}