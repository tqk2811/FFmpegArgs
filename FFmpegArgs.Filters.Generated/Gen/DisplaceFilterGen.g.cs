namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS displace          VVV-&gt;V     Displace pixels.
    /// </summary>
    public class DisplaceFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal DisplaceFilterGen(params ImageMap[] inputs) : base("displace", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set edge mode (from 0 to 3) (default smear)
        /// </summary>
        public DisplaceFilterGen edge(DisplaceFilterGenEdge edge) => this.SetOption("edge", edge.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set edge mode (from 0 to 3) (default smear)
    /// </summary>
    public enum DisplaceFilterGenEdge
    {
        /// <summary>
        /// blank           0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blank")]
        blank = 0,
        /// <summary>
        /// smear           1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smear")]
        smear = 1,
        /// <summary>
        /// wrap            2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wrap")]
        wrap = 2,
        /// <summary>
        /// mirror          3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mirror")]
        mirror = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Displace pixels.
        /// </summary>
        public static DisplaceFilterGen DisplaceFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new DisplaceFilterGen(input0, input1, input2);
    }
}