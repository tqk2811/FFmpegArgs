namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S zscale            V-&gt;V       Apply resizing, colorspace and bit depth conversion.
    /// </summary>
    public class ZscaleFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal ZscaleFilterGen(ImageMap input) : base("zscale", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output video width
        /// </summary>
        public ZscaleFilterGen width(String width) => this.SetOption("width", width.ToStringInv());
        /// <summary>
        ///  Output video height
        /// </summary>
        public ZscaleFilterGen height(String height) => this.SetOption("height", height.ToStringInv());
        /// <summary>
        ///  set video size
        /// </summary>
        public ZscaleFilterGen size(String size) => this.SetOption("size", size.ToStringInv());
        /// <summary>
        ///  set dither type (from 0 to 3) (default none)
        /// </summary>
        public ZscaleFilterGen dither(ZscaleFilterGenDither dither) => this.SetOption("dither", dither.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set filter type (from 0 to 5) (default bilinear)
        /// </summary>
        public ZscaleFilterGen filter(ZscaleFilterGenFilter filter) => this.SetOption("filter", filter.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set color range (from -1 to 1) (default input)
        /// </summary>
        public ZscaleFilterGen out_range(ZscaleFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set color range (from -1 to 1) (default input)
        /// </summary>
        public ZscaleFilterGen range(ZscaleFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set color range (from -1 to 1) (default input)
        /// </summary>
        public ZscaleFilterGen r(ZscaleFilterGenR r) => this.SetOption("r", r.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set color primaries (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen primaries(ZscaleFilterGenPrimaries primaries) => this.SetOption("primaries", primaries.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set transfer characteristic (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen transfer(ZscaleFilterGenTransfer transfer) => this.SetOption("transfer", transfer.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set colorspace matrix (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen matrix(ZscaleFilterGenMatrix matrix) => this.SetOption("matrix", matrix.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input color range (from -1 to 1) (default input)
        /// </summary>
        public ZscaleFilterGen in_range(ZscaleFilterGenIn_range in_range) => this.SetOption("in_range", in_range.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input color range (from -1 to 1) (default input)
        /// </summary>
        public ZscaleFilterGen rangein(ZscaleFilterGenRangein rangein) => this.SetOption("rangein", rangein.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input color range (from -1 to 1) (default input)
        /// </summary>
        public ZscaleFilterGen rin(ZscaleFilterGenRin rin) => this.SetOption("rin", rin.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input color primaries (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen primariesin(ZscaleFilterGenPrimariesin primariesin) => this.SetOption("primariesin", primariesin.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input color primaries (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen pin(ZscaleFilterGenPin pin) => this.SetOption("pin", pin.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input transfer characteristic (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen transferin(ZscaleFilterGenTransferin transferin) => this.SetOption("transferin", transferin.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input transfer characteristic (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen tin(ZscaleFilterGenTin tin) => this.SetOption("tin", tin.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input colorspace matrix (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen matrixin(ZscaleFilterGenMatrixin matrixin) => this.SetOption("matrixin", matrixin.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input colorspace matrix (from -1 to INT_MAX) (default input)
        /// </summary>
        public ZscaleFilterGen min(ZscaleFilterGenMin min) => this.SetOption("min", min.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output chroma location (from -1 to 5) (default input)
        /// </summary>
        public ZscaleFilterGen chromal(ZscaleFilterGenChromal chromal) => this.SetOption("chromal", chromal.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input chroma location (from -1 to 5) (default input)
        /// </summary>
        public ZscaleFilterGen chromalin(ZscaleFilterGenChromalin chromalin) => this.SetOption("chromalin", chromalin.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input chroma location (from -1 to 5) (default input)
        /// </summary>
        public ZscaleFilterGen cin(ZscaleFilterGenCin cin) => this.SetOption("cin", cin.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set nominal peak luminance (from 0 to DBL_MAX) (default nan)
        /// </summary>
        public ZscaleFilterGen npl(double npl) => this.SetOptionRange("npl", npl, 0, DBL_MAX);
        /// <summary>
        ///  allow approximate gamma (default true)
        /// </summary>
        public ZscaleFilterGen agamma(bool agamma) => this.SetOption("agamma", agamma.ToFFmpegFlag());
        /// <summary>
        ///  parameter A, which is parameter &quot;b&quot; for bicubic, and the number of filter taps for lanczos (from -DBL_MAX to DBL_MAX) (default nan)
        /// </summary>
        public ZscaleFilterGen param_a(double param_a) => this.SetOptionRange("param_a", param_a, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  parameter B, which is parameter &quot;c&quot; for bicubic (from -DBL_MAX to DBL_MAX) (default nan)
        /// </summary>
        public ZscaleFilterGen param_b(double param_b) => this.SetOptionRange("param_b", param_b, -DBL_MAX, DBL_MAX);
    }

    /// <summary>
    ///  set dither type (from 0 to 3) (default none)
    /// </summary>
    public enum ZscaleFilterGenDither
    {
        /// <summary>
        /// none            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// ordered         1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ordered")]
        ordered = 1,
        /// <summary>
        /// random          2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("random")]
        random = 2,
        /// <summary>
        /// error_diffusion 3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("error_diffusion")]
        error_diffusion = 3
    }

    /// <summary>
    ///  set filter type (from 0 to 5) (default bilinear)
    /// </summary>
    public enum ZscaleFilterGenFilter
    {
        /// <summary>
        /// point           0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("point")]
        point = 0,
        /// <summary>
        /// bilinear        1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear")]
        bilinear = 1,
        /// <summary>
        /// bicubic         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bicubic")]
        bicubic = 2,
        /// <summary>
        /// spline16        3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("spline16")]
        spline16 = 3,
        /// <summary>
        /// spline36        4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("spline36")]
        spline36 = 4,
        /// <summary>
        /// lanczos         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lanczos")]
        lanczos = 5
    }

    /// <summary>
    ///  set color range (from -1 to 1) (default input)
    /// </summary>
    public enum ZscaleFilterGenOut_range
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// limited         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 0,
        /// <summary>
        /// full            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 1,
        /// <summary>
        /// unknown         -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = -1,
        /// <summary>
        /// tv              0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 0,
        /// <summary>
        /// pc              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 1
    }

    /// <summary>
    ///  set color range (from -1 to 1) (default input)
    /// </summary>
    public enum ZscaleFilterGenRange
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// limited         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 0,
        /// <summary>
        /// full            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 1,
        /// <summary>
        /// unknown         -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = -1,
        /// <summary>
        /// tv              0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 0,
        /// <summary>
        /// pc              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 1
    }

    /// <summary>
    ///  set color range (from -1 to 1) (default input)
    /// </summary>
    public enum ZscaleFilterGenR
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// limited         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 0,
        /// <summary>
        /// full            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 1,
        /// <summary>
        /// unknown         -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = -1,
        /// <summary>
        /// tv              0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 0,
        /// <summary>
        /// pc              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 1
    }

    /// <summary>
    ///  set color primaries (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenPrimaries
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 170m            6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("170m")]
        _170m = 6,
        /// <summary>
        /// 240m            7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("240m")]
        _240m = 7,
        /// <summary>
        /// 2020            9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020")]
        _2020 = 9,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
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
    ///  set transfer characteristic (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenTransfer
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 601             6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("601")]
        _601 = 6,
        /// <summary>
        /// linear          8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 8,
        /// <summary>
        /// 2020_10         14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_10")]
        _2020_10 = 14,
        /// <summary>
        /// 2020_12         15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_12")]
        _2020_12 = 15,
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
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
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
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// arib-std-b67    18           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arib-std-b67")]
        arib_std_b67 = 18
    }

    /// <summary>
    ///  set colorspace matrix (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenMatrix
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 470bg           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("470bg")]
        _470bg = 5,
        /// <summary>
        /// 170m            6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("170m")]
        _170m = 6,
        /// <summary>
        /// 2020_ncl        9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_ncl")]
        _2020_ncl = 9,
        /// <summary>
        /// 2020_cl         10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_cl")]
        _2020_cl = 10,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
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
        ictcp = 14
    }

    /// <summary>
    ///  set input color range (from -1 to 1) (default input)
    /// </summary>
    public enum ZscaleFilterGenIn_range
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// limited         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 0,
        /// <summary>
        /// full            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 1,
        /// <summary>
        /// unknown         -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = -1,
        /// <summary>
        /// tv              0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 0,
        /// <summary>
        /// pc              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 1
    }

    /// <summary>
    ///  set input color range (from -1 to 1) (default input)
    /// </summary>
    public enum ZscaleFilterGenRangein
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// limited         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 0,
        /// <summary>
        /// full            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 1,
        /// <summary>
        /// unknown         -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = -1,
        /// <summary>
        /// tv              0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 0,
        /// <summary>
        /// pc              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 1
    }

    /// <summary>
    ///  set input color range (from -1 to 1) (default input)
    /// </summary>
    public enum ZscaleFilterGenRin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// limited         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 0,
        /// <summary>
        /// full            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 1,
        /// <summary>
        /// unknown         -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = -1,
        /// <summary>
        /// tv              0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 0,
        /// <summary>
        /// pc              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 1
    }

    /// <summary>
    ///  set input color primaries (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenPrimariesin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 170m            6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("170m")]
        _170m = 6,
        /// <summary>
        /// 240m            7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("240m")]
        _240m = 7,
        /// <summary>
        /// 2020            9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020")]
        _2020 = 9,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
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
    ///  set input color primaries (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenPin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 170m            6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("170m")]
        _170m = 6,
        /// <summary>
        /// 240m            7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("240m")]
        _240m = 7,
        /// <summary>
        /// 2020            9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020")]
        _2020 = 9,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
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
    ///  set input transfer characteristic (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenTransferin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 601             6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("601")]
        _601 = 6,
        /// <summary>
        /// linear          8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 8,
        /// <summary>
        /// 2020_10         14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_10")]
        _2020_10 = 14,
        /// <summary>
        /// 2020_12         15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_12")]
        _2020_12 = 15,
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
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
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
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// arib-std-b67    18           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arib-std-b67")]
        arib_std_b67 = 18
    }

    /// <summary>
    ///  set input transfer characteristic (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenTin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 601             6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("601")]
        _601 = 6,
        /// <summary>
        /// linear          8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 8,
        /// <summary>
        /// 2020_10         14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_10")]
        _2020_10 = 14,
        /// <summary>
        /// 2020_12         15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_12")]
        _2020_12 = 15,
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
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
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
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// arib-std-b67    18           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arib-std-b67")]
        arib_std_b67 = 18
    }

    /// <summary>
    ///  set input colorspace matrix (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenMatrixin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 470bg           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("470bg")]
        _470bg = 5,
        /// <summary>
        /// 170m            6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("170m")]
        _170m = 6,
        /// <summary>
        /// 2020_ncl        9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_ncl")]
        _2020_ncl = 9,
        /// <summary>
        /// 2020_cl         10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_cl")]
        _2020_cl = 10,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
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
        ictcp = 14
    }

    /// <summary>
    ///  set input colorspace matrix (from -1 to INT_MAX) (default input)
    /// </summary>
    public enum ZscaleFilterGenMin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// 709             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("709")]
        _709 = 1,
        /// <summary>
        /// unspecified     2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// 470bg           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("470bg")]
        _470bg = 5,
        /// <summary>
        /// 170m            6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("170m")]
        _170m = 6,
        /// <summary>
        /// 2020_ncl        9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_ncl")]
        _2020_ncl = 9,
        /// <summary>
        /// 2020_cl         10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2020_cl")]
        _2020_cl = 10,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
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
        ictcp = 14
    }

    /// <summary>
    ///  set output chroma location (from -1 to 5) (default input)
    /// </summary>
    public enum ZscaleFilterGenChromal
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// left            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("left")]
        left = 0,
        /// <summary>
        /// center          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("center")]
        center = 1,
        /// <summary>
        /// topleft         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("topleft")]
        topleft = 2,
        /// <summary>
        /// top             3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("top")]
        top = 3,
        /// <summary>
        /// bottomleft      4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottomleft")]
        bottomleft = 4,
        /// <summary>
        /// bottom          5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottom")]
        bottom = 5
    }

    /// <summary>
    ///  set input chroma location (from -1 to 5) (default input)
    /// </summary>
    public enum ZscaleFilterGenChromalin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// left            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("left")]
        left = 0,
        /// <summary>
        /// center          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("center")]
        center = 1,
        /// <summary>
        /// topleft         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("topleft")]
        topleft = 2,
        /// <summary>
        /// top             3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("top")]
        top = 3,
        /// <summary>
        /// bottomleft      4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottomleft")]
        bottomleft = 4,
        /// <summary>
        /// bottom          5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottom")]
        bottom = 5
    }

    /// <summary>
    ///  set input chroma location (from -1 to 5) (default input)
    /// </summary>
    public enum ZscaleFilterGenCin
    {
        /// <summary>
        /// input           -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = -1,
        /// <summary>
        /// left            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("left")]
        left = 0,
        /// <summary>
        /// center          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("center")]
        center = 1,
        /// <summary>
        /// topleft         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("topleft")]
        topleft = 2,
        /// <summary>
        /// top             3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("top")]
        top = 3,
        /// <summary>
        /// bottomleft      4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottomleft")]
        bottomleft = 4,
        /// <summary>
        /// bottom          5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottom")]
        bottom = 5
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply resizing, colorspace and bit depth conversion.
        /// </summary>
        public static ZscaleFilterGen ZscaleFilterGen(this ImageMap input0) => new ZscaleFilterGen(input0);
    }
}