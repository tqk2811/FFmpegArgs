namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. colormatrix       V-&gt;V       Convert color matrix.
    /// </summary>
    public class ColormatrixFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal ColormatrixFilterGen(ImageMap input) : base("colormatrix", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set source color matrix (from -1 to 4) (default -1)
        /// </summary>
        public ColormatrixFilterGen src(ColormatrixFilterGenSrc src) => this.SetOption("src", src.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set destination color matrix (from -1 to 4) (default -1)
        /// </summary>
        public ColormatrixFilterGen dst(ColormatrixFilterGenDst dst) => this.SetOption("dst", dst.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set source color matrix (from -1 to 4) (default -1)
    /// </summary>
    public enum ColormatrixFilterGenSrc
    {
        /// <summary>
        /// bt709           0            ..FV....... set BT.709 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 0,
        /// <summary>
        /// fcc             1            ..FV....... set FCC colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fcc")]
        fcc = 1,
        /// <summary>
        /// bt601           2            ..FV....... set BT.601 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601")]
        bt601 = 2,
        /// <summary>
        /// bt470           2            ..FV....... set BT.470 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470")]
        bt470 = 2,
        /// <summary>
        /// bt470bg         2            ..FV....... set BT.470 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 2,
        /// <summary>
        /// smpte170m       2            ..FV....... set SMTPE-170M colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 2,
        /// <summary>
        /// smpte240m       3            ..FV....... set SMPTE-240M colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 3,
        /// <summary>
        /// bt2020          4            ..FV....... set BT.2020 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 4
    }

    /// <summary>
    ///  set destination color matrix (from -1 to 4) (default -1)
    /// </summary>
    public enum ColormatrixFilterGenDst
    {
        /// <summary>
        /// bt709           0            ..FV....... set BT.709 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 0,
        /// <summary>
        /// fcc             1            ..FV....... set FCC colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fcc")]
        fcc = 1,
        /// <summary>
        /// bt601           2            ..FV....... set BT.601 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601")]
        bt601 = 2,
        /// <summary>
        /// bt470           2            ..FV....... set BT.470 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470")]
        bt470 = 2,
        /// <summary>
        /// bt470bg         2            ..FV....... set BT.470 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 2,
        /// <summary>
        /// smpte170m       2            ..FV....... set SMTPE-170M colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 2,
        /// <summary>
        /// smpte240m       3            ..FV....... set SMPTE-240M colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 3,
        /// <summary>
        /// bt2020          4            ..FV....... set BT.2020 colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 4
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert color matrix.
        /// </summary>
        public static ColormatrixFilterGen ColormatrixFilterGen(this ImageMap input0) => new ColormatrixFilterGen(input0);
    }
}