namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. vif               VV-&gt;V      Calculate the VIF between two video streams.
    /// </summary>
    public class VifFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal VifFilterGen(params ImageMap[] inputs) : base("vif", inputs)
        {
            AddMapOut();
        }
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Calculate the VIF between two video streams.
        /// </summary>
        public static VifFilterGen VifFilterGen(this ImageMap input0, ImageMap input1) => new VifFilterGen(input0, input1);
    }
}