namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC multiply          VV-&gt;V      Multiply first video stream with second video stream.
    /// </summary>
    public class MultiplyFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal MultiplyFilterGen(params ImageMap[] inputs) : base("multiply", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set scale (from 0 to 9) (default 1)
        /// </summary>
        public MultiplyFilterGen scale(float scale) => this.SetOptionRange("scale", scale, 0, 9);
        /// <summary>
        ///  set offset (from -1 to 1) (default 0.5)
        /// </summary>
        public MultiplyFilterGen offset(float offset) => this.SetOptionRange("offset", offset, -1, 1);
        /// <summary>
        ///  set planes (default F)
        /// </summary>
        public MultiplyFilterGen planes(String planes) => this.SetOption("planes", planes.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Multiply first video stream with second video stream.
        /// </summary>
        public static MultiplyFilterGen MultiplyFilterGen(this ImageMap input0, ImageMap input1) => new MultiplyFilterGen(input0, input1);
    }
}