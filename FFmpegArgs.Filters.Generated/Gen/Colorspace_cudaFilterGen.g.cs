namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. colorspace_cuda   V-&gt;V       CUDA accelerated video color converter
    /// </summary>
    public class Colorspace_cudaFilterGen : ImageToImageFilter
    {
        internal Colorspace_cudaFilterGen(ImageMap input) : base("colorspace_cuda", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output video range (from 0 to 2) (default 0)
        /// </summary>
        public Colorspace_cudaFilterGen range(Colorspace_cudaFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  Output video range (from 0 to 2) (default 0)
    /// </summary>
    public enum Colorspace_cudaFilterGenRange
    {
        /// <summary>
        /// tv              1            ..FV....... Limited range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 1,
        /// <summary>
        /// mpeg            1            ..FV....... Limited range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg")]
        mpeg = 1,
        /// <summary>
        /// pc              2            ..FV....... Full range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 2,
        /// <summary>
        /// jpeg            2            ..FV....... Full range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpeg")]
        jpeg = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// CUDA accelerated video color converter
        /// </summary>
        public static Colorspace_cudaFilterGen Colorspace_cudaFilterGen(this ImageMap input0) => new Colorspace_cudaFilterGen(input0);
    }
}