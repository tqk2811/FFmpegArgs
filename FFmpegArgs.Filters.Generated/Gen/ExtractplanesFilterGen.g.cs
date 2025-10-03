namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... extractplanes     V-&gt;N       Extract planes as grayscale frames.
    /// </summary>
    public class ExtractplanesFilterGen : ImageToImageFilter
    {
        internal ExtractplanesFilterGen(ImageMap input, int outputCount) : base("extractplanes", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  set planes (default r)
        /// </summary>
        public ExtractplanesFilterGen planes(ExtractplanesFilterGenPlanes planes) => this.SetOption("planes", planes.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set planes (default r)
    /// </summary>
    public enum ExtractplanesFilterGenPlanes
    {
        /// <summary>
        /// y                            ..FV....... set luma plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("y")]
        y,
        /// <summary>
        /// u                            ..FV....... set u plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("u")]
        u,
        /// <summary>
        /// v                            ..FV....... set v plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("v")]
        v,
        /// <summary>
        /// r                            ..FV....... set red plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("r")]
        r,
        /// <summary>
        /// g                            ..FV....... set green plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("g")]
        g,
        /// <summary>
        /// b                            ..FV....... set blue plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("b")]
        b,
        /// <summary>
        /// a                            ..FV....... set alpha plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("a")]
        a
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Extract planes as grayscale frames.
        /// </summary>
        public static ExtractplanesFilterGen ExtractplanesFilterGen(this ImageMap input0, int outputCount) => new ExtractplanesFilterGen(input0, outputCount);
    }
}