namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... transpose_vulkan  V-&gt;V       Transpose Vulkan Filter
    /// </summary>
    public class Transpose_vulkanFilterGen : ImageToImageFilter
    {
        internal Transpose_vulkanFilterGen(ImageMap input) : base("transpose_vulkan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set transpose direction (from 0 to 7) (default cclock_flip)
        /// </summary>
        public Transpose_vulkanFilterGen dir(Transpose_vulkanFilterGenDir dir) => this.SetOption("dir", dir.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
        /// </summary>
        public Transpose_vulkanFilterGen passthrough(Transpose_vulkanFilterGenPassthrough passthrough) => this.SetOption("passthrough", passthrough.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set transpose direction (from 0 to 7) (default cclock_flip)
    /// </summary>
    public enum Transpose_vulkanFilterGenDir
    {
        /// <summary>
        /// cclock_flip     0            ..FV....... rotate counter-clockwise with vertical flip
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cclock_flip")]
        cclock_flip = 0,
        /// <summary>
        /// clock           1            ..FV....... rotate clockwise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clock")]
        clock = 1,
        /// <summary>
        /// cclock          2            ..FV....... rotate counter-clockwise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cclock")]
        cclock = 2,
        /// <summary>
        /// clock_flip      3            ..FV....... rotate clockwise with vertical flip
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clock_flip")]
        clock_flip = 3
    }

    /// <summary>
    ///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
    /// </summary>
    public enum Transpose_vulkanFilterGenPassthrough
    {
        /// <summary>
        /// none            0            ..FV....... always apply transposition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// portrait        2            ..FV....... preserve portrait geometry
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("portrait")]
        portrait = 2,
        /// <summary>
        /// landscape       1            ..FV....... preserve landscape geometry
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("landscape")]
        landscape = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Transpose Vulkan Filter
        /// </summary>
        public static Transpose_vulkanFilterGen Transpose_vulkanFilterGen(this ImageMap input0) => new Transpose_vulkanFilterGen(input0);
    }
}