namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. hwmap             V-&gt;V       Map hardware frames
    /// </summary>
    public class HwmapFilterGen : ImageToImageFilter
    {
        internal HwmapFilterGen(ImageMap input) : base("hwmap", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Frame mapping mode (default read+write)
        /// </summary>
        public HwmapFilterGen mode(HwmapFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Derive a new device of this type
        /// </summary>
        public HwmapFilterGen derive_device(String derive_device) => this.SetOption("derive_device", derive_device.ToStringInv());
        /// <summary>
        ///  Map in reverse (create and allocate in the sink) (from 0 to 1) (default 0)
        /// </summary>
        public HwmapFilterGen reverse(int reverse) => this.SetOptionRange("reverse", reverse, 0, 1);
    }

    /// <summary>
    ///  Frame mapping mode (default read+write)
    /// </summary>
    public enum HwmapFilterGenMode
    {
        /// <summary>
        /// read                         ..FV....... Mapping should be readable
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("read")]
        read,
        /// <summary>
        /// write                        ..FV....... Mapping should be writeable
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("write")]
        write,
        /// <summary>
        /// overwrite                    ..FV....... Mapping will always overwrite the entire frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("overwrite")]
        overwrite,
        /// <summary>
        /// direct                       ..FV....... Mapping should not involve any copying
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("direct")]
        direct
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Map hardware frames
        /// </summary>
        public static HwmapFilterGen HwmapFilterGen(this ImageMap input0) => new HwmapFilterGen(input0);
    }
}