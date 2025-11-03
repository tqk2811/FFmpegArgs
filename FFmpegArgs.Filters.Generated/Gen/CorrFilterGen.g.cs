namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS corr              VV-&gt;V      Calculate the correlation between two video streams.
    /// </summary>
    public class CorrFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal CorrFilterGen(params ImageMap[] inputs) : base("corr", inputs)
        {
            AddMapOut();
        }
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Calculate the correlation between two video streams.
        /// </summary>
        public static CorrFilterGen CorrFilterGen(this ImageMap input0, ImageMap input1) => new CorrFilterGen(input0, input1);
    }
}