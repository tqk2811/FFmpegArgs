namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. setparams         V-&gt;V       Force field, or color property for the output video frame.
    /// </summary>
    public class SetparamsFilterGen : ImageToImageFilter
    {
        internal SetparamsFilterGen(ImageMap input) : base("setparams", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select interlace mode (from -1 to 2) (default auto)
        /// </summary>
        public SetparamsFilterGen field_mode(SetparamsFilterGenField_mode field_mode) => this.SetOption("field_mode", field_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  select color range (from -1 to 2) (default auto)
        /// </summary>
        public SetparamsFilterGen range(SetparamsFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  select color primaries (from -1 to 22) (default auto)
        /// </summary>
        public SetparamsFilterGen color_primaries(SetparamsFilterGenColor_primaries color_primaries) => this.SetOption("color_primaries", color_primaries.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  select color transfer (from -1 to 18) (default auto)
        /// </summary>
        public SetparamsFilterGen color_trc(SetparamsFilterGenColor_trc color_trc) => this.SetOption("color_trc", color_trc.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  select colorspace (from -1 to 17) (default auto)
        /// </summary>
        public SetparamsFilterGen colorspace(SetparamsFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  select chroma sample location (from -1 to 6) (default auto)
        /// </summary>
        public SetparamsFilterGen chroma_location(SetparamsFilterGenChroma_location chroma_location) => this.SetOption("chroma_location", chroma_location.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  select interlace mode (from -1 to 2) (default auto)
    /// </summary>
    public enum SetparamsFilterGenField_mode
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

    /// <summary>
    ///  select color range (from -1 to 2) (default auto)
    /// </summary>
    public enum SetparamsFilterGenRange
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same color range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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

    /// <summary>
    ///  select color primaries (from -1 to 22) (default auto)
    /// </summary>
    public enum SetparamsFilterGenColor_primaries
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same color primaries
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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
        /// bt470m          4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 4,
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
        /// film            8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("film")]
        film = 8,
        /// <summary>
        /// bt2020          9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 9,
        /// <summary>
        /// smpte428        10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte428")]
        smpte428 = 10,
        /// <summary>
        /// smpte431        11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte431")]
        smpte431 = 11,
        /// <summary>
        /// smpte432        12           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte432")]
        smpte432 = 12,
        /// <summary>
        /// jedec-p22       22           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jedec-p22")]
        jedec_p22 = 22,
        /// <summary>
        /// ebu3213         22           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ebu3213")]
        ebu3213 = 22
    }

    /// <summary>
    ///  select color transfer (from -1 to 18) (default auto)
    /// </summary>
    public enum SetparamsFilterGenColor_trc
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same color transfer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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
        /// bt470m          4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 4,
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
        /// linear          8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 8,
        /// <summary>
        /// log100          9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log100")]
        log100 = 9,
        /// <summary>
        /// log316          10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log316")]
        log316 = 10,
        /// <summary>
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// bt1361e         12           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt1361e")]
        bt1361e = 12,
        /// <summary>
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// bt2020-10       14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-10")]
        bt2020_10 = 14,
        /// <summary>
        /// bt2020-12       15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-12")]
        bt2020_12 = 15,
        /// <summary>
        /// smpte2084       16           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte2084")]
        smpte2084 = 16,
        /// <summary>
        /// smpte428        17           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte428")]
        smpte428 = 17,
        /// <summary>
        /// arib-std-b67    18           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arib-std-b67")]
        arib_std_b67 = 18
    }

    /// <summary>
    ///  select colorspace (from -1 to 17) (default auto)
    /// </summary>
    public enum SetparamsFilterGenColorspace
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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
    ///  select chroma sample location (from -1 to 6) (default auto)
    /// </summary>
    public enum SetparamsFilterGenChroma_location
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same chroma location
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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
        /// left            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("left")]
        left = 1,
        /// <summary>
        /// center          2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("center")]
        center = 2,
        /// <summary>
        /// topleft         3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("topleft")]
        topleft = 3,
        /// <summary>
        /// top             4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("top")]
        top = 4,
        /// <summary>
        /// bottomleft      5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottomleft")]
        bottomleft = 5,
        /// <summary>
        /// bottom          6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottom")]
        bottom = 6
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Force field, or color property for the output video frame.
        /// </summary>
        public static SetparamsFilterGen SetparamsFilterGen(this ImageMap input0) => new SetparamsFilterGen(input0);
    }
}