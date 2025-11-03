namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. setfield          V-&gt;V       Force field for the output video frame.
    /// </summary>
    public class SetfieldFilterGen : ImageToImageFilter
    {
        internal SetfieldFilterGen(ImageMap input) : base("setfield", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select interlace mode (from -1 to 2) (default auto)
        /// </summary>
        public SetfieldFilterGen mode(SetfieldFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  select interlace mode (from -1 to 2) (default auto)
    /// </summary>
    public enum SetfieldFilterGenMode
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same input field
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// bff             0            ..FV....... mark as bottom-field-first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bff")]
        bff = 0,
        /// <summary>
        /// tff             1            ..FV....... mark as top-field-first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tff")]
        tff = 1,
        /// <summary>
        /// prog            2            ..FV....... mark as progressive
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("prog")]
        prog = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Force field for the output video frame.
        /// </summary>
        public static SetfieldFilterGen SetfieldFilterGen(this ImageMap input0) => new SetfieldFilterGen(input0);
    }
}