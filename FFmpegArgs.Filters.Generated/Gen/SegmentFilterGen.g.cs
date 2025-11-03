namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. segment           V-&gt;N       Segment video stream.
    /// </summary>
    public class SegmentFilterGen : ImageToImageFilter
    {
        internal SegmentFilterGen(ImageMap input, int outputCount) : base("segment", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  timestamps of input at which to split input
        /// </summary>
        public SegmentFilterGen timestamps(String timestamps) => this.SetOption("timestamps", timestamps.ToStringInv());
        /// <summary>
        ///  frames at which to split input
        /// </summary>
        public SegmentFilterGen frames(String frames) => this.SetOption("frames", frames.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Segment video stream.
        /// </summary>
        public static SegmentFilterGen SegmentFilterGen(this ImageMap input0, int outputCount) => new SegmentFilterGen(input0, outputCount);
    }
}