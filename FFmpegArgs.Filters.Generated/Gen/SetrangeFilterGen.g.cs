namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... setrange          V-&gt;V       Force color range for the output video frame.
    /// </summary>
    public class SetrangeFilterGen : ImageToImageFilter
    {
        internal SetrangeFilterGen(ImageMap input) : base("setrange", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select color range (from -1 to 2) (default auto)
        /// </summary>
        public SetrangeFilterGen range(SetrangeFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  select color range (from -1 to 2) (default auto)
    /// </summary>
    public enum SetrangeFilterGenRange
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same color range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// unspecified     0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 0,
        /// <summary>
        /// unknown         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 0,
        /// <summary>
        /// limited         1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 1,
        /// <summary>
        /// tv              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 1,
        /// <summary>
        /// mpeg            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg")]
        mpeg = 1,
        /// <summary>
        /// full            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 2,
        /// <summary>
        /// pc              2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 2,
        /// <summary>
        /// jpeg            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpeg")]
        jpeg = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Force color range for the output video frame.
        /// </summary>
        public static SetrangeFilterGen SetrangeFilterGen(this ImageMap input0) => new SetrangeFilterGen(input0);
    }
}