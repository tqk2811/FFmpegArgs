namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS maskedthreshold   VV-&gt;V      Pick pixels comparing absolute difference of two streams with threshold.
    /// </summary>
    public class MaskedthresholdFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal MaskedthresholdFilterGen(params ImageMap[] inputs) : base("maskedthreshold", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set threshold (from 0 to 65535) (default 1)
        /// </summary>
        public MaskedthresholdFilterGen threshold(int threshold) => this.SetOptionRange("threshold", threshold, 0, 65535);
        /// <summary>
        ///  set planes (from 0 to 15) (default 15)
        /// </summary>
        public MaskedthresholdFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        ///  set mode (from 0 to 1) (default abs)
        /// </summary>
        public MaskedthresholdFilterGen mode(MaskedthresholdFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set mode (from 0 to 1) (default abs)
    /// </summary>
    public enum MaskedthresholdFilterGenMode
    {
        /// <summary>
        /// abs             0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("abs")]
        abs = 0,
        /// <summary>
        /// diff            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("diff")]
        diff = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Pick pixels comparing absolute difference of two streams with threshold.
        /// </summary>
        public static MaskedthresholdFilterGen MaskedthresholdFilterGen(this ImageMap input0, ImageMap input1) => new MaskedthresholdFilterGen(input0, input1);
    }
}