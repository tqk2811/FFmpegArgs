namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. openclsrc         |-&gt;V       Generate video using an OpenCL program
    /// </summary>
    public class OpenclsrcFilterGen : SourceToImageFilter
    {
        internal OpenclsrcFilterGen(IImageFilterGraph input) : base("openclsrc", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  OpenCL program source file
        /// </summary>
        public OpenclsrcFilterGen source(String source) => this.SetOption("source", source.ToStringInv());
        /// <summary>
        ///  Kernel name in program
        /// </summary>
        public OpenclsrcFilterGen kernel(String kernel) => this.SetOption("kernel", kernel.ToStringInv());
        /// <summary>
        ///  Video size
        /// </summary>
        public OpenclsrcFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  Video format (default none)
        /// </summary>
        public OpenclsrcFilterGen format(PixFmt format) => this.SetOption("format", format.ToStringInv());
        /// <summary>
        ///  Video frame rate (default &quot;25&quot;)
        /// </summary>
        public OpenclsrcFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate video using an OpenCL program
        /// </summary>
        public static OpenclsrcFilterGen OpenclsrcFilterGen(this IImageFilterGraph input) => new OpenclsrcFilterGen(input);
    }
}