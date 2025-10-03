namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. fieldorder        V-&gt;V       Set the field order.
    /// </summary>
    public class FieldorderFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal FieldorderFilterGen(ImageMap input) : base("fieldorder", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  output field order (from 0 to 1) (default tff)
        /// </summary>
        public FieldorderFilterGen order(FieldorderFilterGenOrder order) => this.SetOption("order", order.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  output field order (from 0 to 1) (default tff)
    /// </summary>
    public enum FieldorderFilterGenOrder
    {
        /// <summary>
        /// bff             0            ..FV....... bottom field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bff")]
        bff = 0,
        /// <summary>
        /// tff             1            ..FV....... top field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tff")]
        tff = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Set the field order.
        /// </summary>
        public static FieldorderFilterGen FieldorderFilterGen(this ImageMap input0) => new FieldorderFilterGen(input0);
    }
}