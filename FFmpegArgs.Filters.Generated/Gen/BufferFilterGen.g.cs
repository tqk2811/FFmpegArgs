namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. buffer            |-&gt;V       Buffer video frames, and make them accessible to the filterchain.
    /// </summary>
    public class BufferFilterGen : SourceToImageFilter
    {
        internal BufferFilterGen(IImageFilterGraph input) : base("buffer", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  (from 0 to INT_MAX) (default 0)
        /// </summary>
        public BufferFilterGen width(int width) => this.SetOptionRange("width", width, 0, INT_MAX);
        /// <summary>
        /// 
        /// </summary>
        public BufferFilterGen video_size(Size video_size) => this.SetOption("video_size", $"{video_size.Width}x{video_size.Height}");
        /// <summary>
        ///  (from 0 to INT_MAX) (default 0)
        /// </summary>
        public BufferFilterGen height(int height) => this.SetOptionRange("height", height, 0, INT_MAX);
        /// <summary>
        ///  (default none)
        /// </summary>
        public BufferFilterGen pix_fmt(PixFmt pix_fmt) => this.SetOption("pix_fmt", pix_fmt.ToStringInv());
        /// <summary>
        ///  sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        public BufferFilterGen sar(Rational sar) => this.SetOption("sar", sar.Check(0, DBL_MAX));
        /// <summary>
        ///  sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        public BufferFilterGen pixel_aspect(Rational pixel_aspect) => this.SetOption("pixel_aspect", pixel_aspect.Check(0, DBL_MAX));
        /// <summary>
        ///  (from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        public BufferFilterGen time_base(Rational time_base) => this.SetOption("time_base", time_base.Check(0, DBL_MAX));
        /// <summary>
        ///  (from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        public BufferFilterGen frame_rate(Rational frame_rate) => this.SetOption("frame_rate", frame_rate.Check(0, DBL_MAX));
        /// <summary>
        ///  select colorspace (from 0 to 17) (default unknown)
        /// </summary>
        public BufferFilterGen colorspace(BufferFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  select color range (from 0 to 2) (default unspecified)
        /// </summary>
        public BufferFilterGen range(BufferFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  select colorspace (from 0 to 17) (default unknown)
    /// </summary>
    public enum BufferFilterGenColorspace
    {
        /// <summary>
        /// gbr             0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gbr")]
        gbr = 0,
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
        /// <summary>
        /// fcc             4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fcc")]
        fcc = 4,
        /// <summary>
        /// bt470bg         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 5,
        /// <summary>
        /// smpte170m       6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 6,
        /// <summary>
        /// smpte240m       7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// ycgco           8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ycgco")]
        ycgco = 8,
        /// <summary>
        /// ycgco-re        16           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ycgco-re")]
        ycgco_re = 16,
        /// <summary>
        /// ycgco-ro        17           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ycgco-ro")]
        ycgco_ro = 17,
        /// <summary>
        /// bt2020nc        9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020nc")]
        bt2020nc = 9,
        /// <summary>
        /// bt2020c         10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020c")]
        bt2020c = 10,
        /// <summary>
        /// smpte2085       11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte2085")]
        smpte2085 = 11,
        /// <summary>
        /// chroma-derived-nc 12           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("chroma-derived-nc")]
        chroma_derived_nc = 12,
        /// <summary>
        /// chroma-derived-c 13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("chroma-derived-c")]
        chroma_derived_c = 13,
        /// <summary>
        /// ictcp           14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ictcp")]
        ictcp = 14,
        /// <summary>
        /// ipt-c2          15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ipt-c2")]
        ipt_c2 = 15
    }

    /// <summary>
    ///  select color range (from 0 to 2) (default unspecified)
    /// </summary>
    public enum BufferFilterGenRange
    {
        /// <summary>
        /// unspecified     0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 0,
        /// <summary>
        /// unknown         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 0,
        /// <summary>
        /// limited         1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 1,
        /// <summary>
        /// tv              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 1,
        /// <summary>
        /// mpeg            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg")]
        mpeg = 1,
        /// <summary>
        /// full            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 2,
        /// <summary>
        /// pc              2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 2,
        /// <summary>
        /// jpeg            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpeg")]
        jpeg = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Buffer video frames, and make them accessible to the filterchain.
        /// </summary>
        public static BufferFilterGen BufferFilterGen(this IImageFilterGraph input) => new BufferFilterGen(input);
    }
}