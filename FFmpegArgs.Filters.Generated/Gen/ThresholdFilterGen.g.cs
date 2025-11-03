namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS threshold         VVVV-&gt;V    Threshold first video stream using other video streams.
    /// </summary>
    public class ThresholdFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal ThresholdFilterGen(params ImageMap[] inputs) : base("threshold", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 15)
        /// </summary>
        public ThresholdFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Threshold first video stream using other video streams.
        /// </summary>
        public static ThresholdFilterGen ThresholdFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2, ImageMap input3) => new ThresholdFilterGen(input0, input1, input2, input3);
    }
}