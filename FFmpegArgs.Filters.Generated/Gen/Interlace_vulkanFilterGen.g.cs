namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. interlace_vulkan  V-&gt;V       Convert progressive video into interlaced.
    /// </summary>
    public class Interlace_vulkanFilterGen : ImageToImageFilter
    {
        internal Interlace_vulkanFilterGen(ImageMap input) : base("interlace_vulkan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  scanning mode (from 0 to 1) (default tff)
        /// </summary>
        public Interlace_vulkanFilterGen scan(Interlace_vulkanFilterGenScan scan) => this.SetOption("scan", scan.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set vertical low-pass filter (from 0 to 2) (default linear)
        /// </summary>
        public Interlace_vulkanFilterGen lowpass(Interlace_vulkanFilterGenLowpass lowpass) => this.SetOption("lowpass", lowpass.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  scanning mode (from 0 to 1) (default tff)
    /// </summary>
    public enum Interlace_vulkanFilterGenScan
    {
        /// <summary>
        /// tff             0            ..FV....... top field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tff")]
        tff = 0,
        /// <summary>
        /// bff             1            ..FV....... bottom field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bff")]
        bff = 1
    }

    /// <summary>
    ///  set vertical low-pass filter (from 0 to 2) (default linear)
    /// </summary>
    public enum Interlace_vulkanFilterGenLowpass
    {
        /// <summary>
        /// off             0            ..FV....... disable vertical low-pass filter
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("off")]
        off = 0,
        /// <summary>
        /// linear          1            ..FV....... linear vertical low-pass filter
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 1,
        /// <summary>
        /// complex         2            ..FV....... complex vertical low-pass filter
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("complex")]
        complex = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert progressive video into interlaced.
        /// </summary>
        public static Interlace_vulkanFilterGen Interlace_vulkanFilterGen(this ImageMap input0) => new Interlace_vulkanFilterGen(input0);
    }
}