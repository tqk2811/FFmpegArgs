namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS xcorrelate        VV-&gt;V      Cross-correlate first video stream with second video stream.
    /// </summary>
    public class XcorrelateFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal XcorrelateFilterGen(params ImageMap[] inputs) : base("xcorrelate", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set planes to cross-correlate (from 0 to 15) (default 7)
        /// </summary>
        public XcorrelateFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        ///  when to process secondary frame (from 0 to 1) (default all)
        /// </summary>
        public XcorrelateFilterGen secondary(XcorrelateFilterGenSecondary secondary) => this.SetOption("secondary", secondary.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  when to process secondary frame (from 0 to 1) (default all)
    /// </summary>
    public enum XcorrelateFilterGenSecondary
    {
        /// <summary>
        /// first           0            ..FV....... process only first secondary frame, ignore rest
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("first")]
        first = 0,
        /// <summary>
        /// all             1            ..FV....... process all secondary frames
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Cross-correlate first video stream with second video stream.
        /// </summary>
        public static XcorrelateFilterGen XcorrelateFilterGen(this ImageMap input0, ImageMap input1) => new XcorrelateFilterGen(input0, input1);
    }
}