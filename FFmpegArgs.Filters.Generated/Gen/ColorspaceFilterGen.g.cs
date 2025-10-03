namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. colorspace        V-&gt;V       Convert between colorspaces.
    /// </summary>
    public class ColorspaceFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal ColorspaceFilterGen(ImageMap input) : base("colorspace", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set all color properties together (from 0 to 8) (default 0)
        /// </summary>
        public ColorspaceFilterGen all(ColorspaceFilterGenAll all) => this.SetOption("all", all.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Output colorspace (from 0 to 14) (default 2)
        /// </summary>
        public ColorspaceFilterGen space(ColorspaceFilterGenSpace space) => this.SetOption("space", space.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Output color range (from 0 to 2) (default 0)
        /// </summary>
        public ColorspaceFilterGen range(ColorspaceFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Output color primaries (from 0 to 22) (default 2)
        /// </summary>
        public ColorspaceFilterGen primaries(ColorspaceFilterGenPrimaries primaries) => this.SetOption("primaries", primaries.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Output transfer characteristics (from 0 to 18) (default 2)
        /// </summary>
        public ColorspaceFilterGen trc(ColorspaceFilterGenTrc trc) => this.SetOption("trc", trc.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Output pixel format (from -1 to 161) (default -1)
        /// </summary>
        public ColorspaceFilterGen format(ColorspaceFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Ignore primary chromaticity and gamma correction (default false)
        /// </summary>
        public ColorspaceFilterGen fast(bool fast) => this.SetOption("fast", fast.ToFFmpegFlag());
        /// <summary>
        ///  Dithering mode (from 0 to 1) (default none)
        /// </summary>
        public ColorspaceFilterGen dither(ColorspaceFilterGenDither dither) => this.SetOption("dither", dither.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Whitepoint adaptation method (from 0 to 2) (default bradford)
        /// </summary>
        public ColorspaceFilterGen wpadapt(ColorspaceFilterGenWpadapt wpadapt) => this.SetOption("wpadapt", wpadapt.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Set all input color properties together (from 0 to 8) (default 0)
        /// </summary>
        public ColorspaceFilterGen iall(ColorspaceFilterGenIall iall) => this.SetOption("iall", iall.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Input colorspace (from 0 to 22) (default 2)
        /// </summary>
        public ColorspaceFilterGen ispace(ColorspaceFilterGenIspace ispace) => this.SetOption("ispace", ispace.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Input color range (from 0 to 2) (default 0)
        /// </summary>
        public ColorspaceFilterGen irange(ColorspaceFilterGenIrange irange) => this.SetOption("irange", irange.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Input color primaries (from 0 to 22) (default 2)
        /// </summary>
        public ColorspaceFilterGen iprimaries(ColorspaceFilterGenIprimaries iprimaries) => this.SetOption("iprimaries", iprimaries.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Input transfer characteristics (from 0 to 18) (default 2)
        /// </summary>
        public ColorspaceFilterGen itrc(ColorspaceFilterGenItrc itrc) => this.SetOption("itrc", itrc.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  Set all color properties together (from 0 to 8) (default 0)
    /// </summary>
    public enum ColorspaceFilterGenAll
    {
        /// <summary>
        /// bt470m          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 1,
        /// <summary>
        /// bt470bg         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 2,
        /// <summary>
        /// bt601-6-525     3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601-6-525")]
        bt601_6_525 = 3,
        /// <summary>
        /// bt601-6-625     4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601-6-625")]
        bt601_6_625 = 4,
        /// <summary>
        /// bt709           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 5,
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
        /// bt2020          8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 8
    }

    /// <summary>
    ///  Output colorspace (from 0 to 14) (default 2)
    /// </summary>
    public enum ColorspaceFilterGenSpace
    {
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
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
        /// gbr             0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gbr")]
        gbr = 0,
        /// <summary>
        /// bt2020nc        9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020nc")]
        bt2020nc = 9,
        /// <summary>
        /// bt2020ncl       9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020ncl")]
        bt2020ncl = 9
    }

    /// <summary>
    ///  Output color range (from 0 to 2) (default 0)
    /// </summary>
    public enum ColorspaceFilterGenRange
    {
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
    ///  Output color primaries (from 0 to 22) (default 2)
    /// </summary>
    public enum ColorspaceFilterGenPrimaries
    {
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
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
        /// smpte428        10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte428")]
        smpte428 = 10,
        /// <summary>
        /// film            8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("film")]
        film = 8,
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
        /// bt2020          9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 9,
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
    ///  Output transfer characteristics (from 0 to 18) (default 2)
    /// </summary>
    public enum ColorspaceFilterGenTrc
    {
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// bt470m          4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 4,
        /// <summary>
        /// gamma22         4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gamma22")]
        gamma22 = 4,
        /// <summary>
        /// bt470bg         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 5,
        /// <summary>
        /// gamma28         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gamma28")]
        gamma28 = 5,
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
        /// srgb            13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("srgb")]
        srgb = 13,
        /// <summary>
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// xvycc           11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xvycc")]
        xvycc = 11,
        /// <summary>
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// bt2020-10       14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-10")]
        bt2020_10 = 14,
        /// <summary>
        /// bt2020-12       15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-12")]
        bt2020_12 = 15
    }

    /// <summary>
    ///  Output pixel format (from -1 to 161) (default -1)
    /// </summary>
    public enum ColorspaceFilterGenFormat
    {
        /// <summary>
        /// yuv420p         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv420p")]
        yuv420p = 0,
        /// <summary>
        /// yuv420p10       62           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv420p10")]
        yuv420p10 = 62,
        /// <summary>
        /// yuv420p12       123          ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv420p12")]
        yuv420p12 = 123,
        /// <summary>
        /// yuv422p         4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv422p")]
        yuv422p = 4,
        /// <summary>
        /// yuv422p10       64           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv422p10")]
        yuv422p10 = 64,
        /// <summary>
        /// yuv422p12       127          ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv422p12")]
        yuv422p12 = 127,
        /// <summary>
        /// yuv444p         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv444p")]
        yuv444p = 5,
        /// <summary>
        /// yuv444p10       68           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv444p10")]
        yuv444p10 = 68,
        /// <summary>
        /// yuv444p12       131          ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv444p12")]
        yuv444p12 = 131
    }

    /// <summary>
    ///  Dithering mode (from 0 to 1) (default none)
    /// </summary>
    public enum ColorspaceFilterGenDither
    {
        /// <summary>
        /// none            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// fsb             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fsb")]
        fsb = 1
    }

    /// <summary>
    ///  Whitepoint adaptation method (from 0 to 2) (default bradford)
    /// </summary>
    public enum ColorspaceFilterGenWpadapt
    {
        /// <summary>
        /// bradford        0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bradford")]
        bradford = 0,
        /// <summary>
        /// vonkries        1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vonkries")]
        vonkries = 1,
        /// <summary>
        /// identity        2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("identity")]
        identity = 2
    }

    /// <summary>
    ///  Set all input color properties together (from 0 to 8) (default 0)
    /// </summary>
    public enum ColorspaceFilterGenIall
    {
        /// <summary>
        /// bt470m          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 1,
        /// <summary>
        /// bt470bg         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 2,
        /// <summary>
        /// bt601-6-525     3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601-6-525")]
        bt601_6_525 = 3,
        /// <summary>
        /// bt601-6-625     4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601-6-625")]
        bt601_6_625 = 4,
        /// <summary>
        /// bt709           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 5,
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
        /// bt2020          8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 8
    }

    /// <summary>
    ///  Input colorspace (from 0 to 22) (default 2)
    /// </summary>
    public enum ColorspaceFilterGenIspace
    {
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
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
        /// gbr             0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gbr")]
        gbr = 0,
        /// <summary>
        /// bt2020nc        9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020nc")]
        bt2020nc = 9,
        /// <summary>
        /// bt2020ncl       9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020ncl")]
        bt2020ncl = 9
    }

    /// <summary>
    ///  Input color range (from 0 to 2) (default 0)
    /// </summary>
    public enum ColorspaceFilterGenIrange
    {
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
    ///  Input color primaries (from 0 to 22) (default 2)
    /// </summary>
    public enum ColorspaceFilterGenIprimaries
    {
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
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
        /// smpte428        10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte428")]
        smpte428 = 10,
        /// <summary>
        /// film            8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("film")]
        film = 8,
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
        /// bt2020          9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 9,
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
    ///  Input transfer characteristics (from 0 to 18) (default 2)
    /// </summary>
    public enum ColorspaceFilterGenItrc
    {
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// bt470m          4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 4,
        /// <summary>
        /// gamma22         4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gamma22")]
        gamma22 = 4,
        /// <summary>
        /// bt470bg         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 5,
        /// <summary>
        /// gamma28         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gamma28")]
        gamma28 = 5,
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
        /// srgb            13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("srgb")]
        srgb = 13,
        /// <summary>
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// xvycc           11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xvycc")]
        xvycc = 11,
        /// <summary>
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// bt2020-10       14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-10")]
        bt2020_10 = 14,
        /// <summary>
        /// bt2020-12       15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-12")]
        bt2020_12 = 15
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert between colorspaces.
        /// </summary>
        public static ColorspaceFilterGen ColorspaceFilterGen(this ImageMap input0) => new ColorspaceFilterGen(input0);
    }
}