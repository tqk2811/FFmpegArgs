namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. fieldhint         V-&gt;V       Field matching using hints.
    /// </summary>
    public class FieldhintFilterGen : ImageToImageFilter
    {
        internal FieldhintFilterGen(ImageMap input) : base("fieldhint", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set hint file
        /// </summary>
        public FieldhintFilterGen hint(String hint) => this.SetOption("hint", hint.ToStringInv());
        /// <summary>
        ///  set hint mode (from 0 to 2) (default absolute)
        /// </summary>
        public FieldhintFilterGen mode(FieldhintFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set hint mode (from 0 to 2) (default absolute)
    /// </summary>
    public enum FieldhintFilterGenMode
    {
        /// <summary>
        /// absolute        0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("absolute")]
        absolute = 0,
        /// <summary>
        /// relative        1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("relative")]
        relative = 1,
        /// <summary>
        /// pattern         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pattern")]
        pattern = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Field matching using hints.
        /// </summary>
        public static FieldhintFilterGen FieldhintFilterGen(this ImageMap input0) => new FieldhintFilterGen(input0);
    }
}