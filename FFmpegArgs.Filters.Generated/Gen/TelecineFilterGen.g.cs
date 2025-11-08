namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. telecine          V-&gt;V       Apply a telecine pattern.
    /// </summary>
    public class TelecineFilterGen : ImageToImageFilter
    {
        internal TelecineFilterGen(ImageMap input) : base("telecine", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select first field (from 0 to 1) (default top)
        /// </summary>
        public TelecineFilterGen first_field(TelecineFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  pattern that describe for how many fields a frame is to be displayed (default &quot;23&quot;)
        /// </summary>
        public TelecineFilterGen pattern(String pattern) => this.SetOption("pattern", pattern.ToString());
    }

    /// <summary>
    ///  select first field (from 0 to 1) (default top)
    /// </summary>
    public enum TelecineFilterGenFirst_field
    {
        /// <summary>
        /// top             0            ..FV....... select top field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("top")]
        top = 0,
        /// <summary>
        /// t               0            ..FV....... select top field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("t")]
        t = 0,
        /// <summary>
        /// bottom          1            ..FV....... select bottom field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottom")]
        bottom = 1,
        /// <summary>
        /// b               1            ..FV....... select bottom field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("b")]
        b = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply a telecine pattern.
        /// </summary>
        public static TelecineFilterGen TelecineFilterGen(this ImageMap input0) => new TelecineFilterGen(input0);
    }
}