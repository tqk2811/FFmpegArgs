namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... detelecine        V-&gt;V       Apply an inverse telecine pattern.
    /// </summary>
    public class DetelecineFilterGen : ImageToImageFilter
    {
        internal DetelecineFilterGen(ImageMap input) : base("detelecine", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select first field (from 0 to 1) (default top)
        /// </summary>
        public DetelecineFilterGen first_field(DetelecineFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  pattern that describe for how many fields a frame is to be displayed (default &quot;23&quot;)
        /// </summary>
        public DetelecineFilterGen pattern(String pattern) => this.SetOption("pattern", pattern.ToString());
        /// <summary>
        ///  position of first frame with respect to the pattern if stream is cut (from 0 to 13) (default 0)
        /// </summary>
        public DetelecineFilterGen start_frame(int start_frame) => this.SetOptionRange("start_frame", start_frame, 0, 13);
    }

    /// <summary>
    ///  select first field (from 0 to 1) (default top)
    /// </summary>
    public enum DetelecineFilterGenFirst_field
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
        /// Apply an inverse telecine pattern.
        /// </summary>
        public static DetelecineFilterGen DetelecineFilterGen(this ImageMap input0) => new DetelecineFilterGen(input0);
    }
}