namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. scale             V-&gt;V       Scale the input video size and/or convert the image format.
    /// </summary>
    public class ScaleFilterGen : ImageToImageFilter
    {
        internal ScaleFilterGen(ImageMap input) : base("scale", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output video width
        /// </summary>
        public ScaleFilterGen width(String width) => this.SetOption("width", width.ToStringInv());
        /// <summary>
        ///  Output video height
        /// </summary>
        public ScaleFilterGen height(String height) => this.SetOption("height", height.ToStringInv());
        /// <summary>
        ///  Flags to pass to libswscale (default &quot;&quot;)
        /// </summary>
        public ScaleFilterGen flags(String flags) => this.SetOption("flags", flags.ToStringInv());
        /// <summary>
        ///  set interlacing (default false)
        /// </summary>
        public ScaleFilterGen interl(bool interl) => this.SetOption("interl", interl.ToFFmpegFlag());
        /// <summary>
        ///  set video size
        /// </summary>
        public ScaleFilterGen size(String size) => this.SetOption("size", size.ToStringInv());
        /// <summary>
        ///  set input YCbCr type (from -1 to 17) (default auto)
        /// </summary>
        public ScaleFilterGen in_color_matrix(ScaleFilterGenIn_color_matrix in_color_matrix) => this.SetOption("in_color_matrix", in_color_matrix.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output YCbCr type (from 0 to 17) (default 2)
        /// </summary>
        public ScaleFilterGen out_color_matrix(ScaleFilterGenOut_color_matrix out_color_matrix) => this.SetOption("out_color_matrix", out_color_matrix.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input color range (from 0 to 2) (default auto)
        /// </summary>
        public ScaleFilterGen in_range(ScaleFilterGenIn_range in_range) => this.SetOption("in_range", in_range.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output color range (from 0 to 2) (default auto)
        /// </summary>
        public ScaleFilterGen out_range(ScaleFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input chroma sample location (from 0 to 6) (default auto)
        /// </summary>
        public ScaleFilterGen in_chroma_loc(ScaleFilterGenIn_chroma_loc in_chroma_loc) => this.SetOption("in_chroma_loc", in_chroma_loc.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output chroma sample location (from 0 to 6) (default auto)
        /// </summary>
        public ScaleFilterGen out_chroma_loc(ScaleFilterGenOut_chroma_loc out_chroma_loc) => this.SetOption("out_chroma_loc", out_chroma_loc.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input primaries (from -1 to 22) (default auto)
        /// </summary>
        public ScaleFilterGen in_primaries(ScaleFilterGenIn_primaries in_primaries) => this.SetOption("in_primaries", in_primaries.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output primaries (from -1 to 22) (default auto)
        /// </summary>
        public ScaleFilterGen out_primaries(ScaleFilterGenOut_primaries out_primaries) => this.SetOption("out_primaries", out_primaries.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output color transfer (from -1 to 18) (default auto)
        /// </summary>
        public ScaleFilterGen in_transfer(ScaleFilterGenIn_transfer in_transfer) => this.SetOption("in_transfer", in_transfer.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output color transfer (from -1 to 18) (default auto)
        /// </summary>
        public ScaleFilterGen out_transfer(ScaleFilterGenOut_transfer out_transfer) => this.SetOption("out_transfer", out_transfer.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  input vertical chroma position in luma grid/256 (from -513 to 512) (default -513)
        /// </summary>
        public ScaleFilterGen in_v_chr_pos(int in_v_chr_pos) => this.SetOptionRange("in_v_chr_pos", in_v_chr_pos, -513, 512);
        /// <summary>
        ///  input horizontal chroma position in luma grid/256 (from -513 to 512) (default -513)
        /// </summary>
        public ScaleFilterGen in_h_chr_pos(int in_h_chr_pos) => this.SetOptionRange("in_h_chr_pos", in_h_chr_pos, -513, 512);
        /// <summary>
        ///  output vertical chroma position in luma grid/256 (from -513 to 512) (default -513)
        /// </summary>
        public ScaleFilterGen out_v_chr_pos(int out_v_chr_pos) => this.SetOptionRange("out_v_chr_pos", out_v_chr_pos, -513, 512);
        /// <summary>
        ///  output horizontal chroma position in luma grid/256 (from -513 to 512) (default -513)
        /// </summary>
        public ScaleFilterGen out_h_chr_pos(int out_h_chr_pos) => this.SetOptionRange("out_h_chr_pos", out_h_chr_pos, -513, 512);
        /// <summary>
        ///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
        /// </summary>
        public ScaleFilterGen force_original_aspect_ratio(ScaleFilterGenForce_original_aspect_ratio force_original_aspect_ratio) => this.SetOption("force_original_aspect_ratio", force_original_aspect_ratio.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
        /// </summary>
        public ScaleFilterGen force_divisible_by(int force_divisible_by) => this.SetOptionRange("force_divisible_by", force_divisible_by, 1, 256);
        /// <summary>
        ///  reset SAR to 1 and scale to square pixels if scaling proportionally (default false)
        /// </summary>
        public ScaleFilterGen reset_sar(bool reset_sar) => this.SetOption("reset_sar", reset_sar.ToFFmpegFlag());
        /// <summary>
        ///  Scaler param 0 (from -DBL_MAX to DBL_MAX) (default DBL_MAX)
        /// </summary>
        public ScaleFilterGen param0(double param0) => this.SetOptionRange("param0", param0, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  Scaler param 1 (from -DBL_MAX to DBL_MAX) (default DBL_MAX)
        /// </summary>
        public ScaleFilterGen param1(double param1) => this.SetOptionRange("param1", param1, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default init)
        /// </summary>
        public ScaleFilterGen eval(ScaleFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set input YCbCr type (from -1 to 17) (default auto)
    /// </summary>
    public enum ScaleFilterGenIn_color_matrix
    {
        /// <summary>
        /// auto            -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// bt601           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601")]
        bt601 = 5,
        /// <summary>
        /// bt470           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470")]
        bt470 = 5,
        /// <summary>
        /// smpte170m       5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 5,
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
        /// smpte240m       7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// bt2020          9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 9
    }

    /// <summary>
    ///  set output YCbCr type (from 0 to 17) (default 2)
    /// </summary>
    public enum ScaleFilterGenOut_color_matrix
    {
        /// <summary>
        /// auto            -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// bt601           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601")]
        bt601 = 5,
        /// <summary>
        /// bt470           5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470")]
        bt470 = 5,
        /// <summary>
        /// smpte170m       5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 5,
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
        /// smpte240m       7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// bt2020          9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 9
    }

    /// <summary>
    ///  set input color range (from 0 to 2) (default auto)
    /// </summary>
    public enum ScaleFilterGenIn_range
    {
        /// <summary>
        /// auto            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = 0,
        /// <summary>
        /// unknown         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 0,
        /// <summary>
        /// full            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 2,
        /// <summary>
        /// limited         1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 1,
        /// <summary>
        /// jpeg            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpeg")]
        jpeg = 2,
        /// <summary>
        /// mpeg            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg")]
        mpeg = 1,
        /// <summary>
        /// tv              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 1,
        /// <summary>
        /// pc              2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 2
    }

    /// <summary>
    ///  set output color range (from 0 to 2) (default auto)
    /// </summary>
    public enum ScaleFilterGenOut_range
    {
        /// <summary>
        /// auto            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = 0,
        /// <summary>
        /// unknown         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 0,
        /// <summary>
        /// full            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 2,
        /// <summary>
        /// limited         1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 1,
        /// <summary>
        /// jpeg            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpeg")]
        jpeg = 2,
        /// <summary>
        /// mpeg            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg")]
        mpeg = 1,
        /// <summary>
        /// tv              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 1,
        /// <summary>
        /// pc              2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 2
    }

    /// <summary>
    ///  set input chroma sample location (from 0 to 6) (default auto)
    /// </summary>
    public enum ScaleFilterGenIn_chroma_loc
    {
        /// <summary>
        /// auto            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = 0,
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

    /// <summary>
    ///  set output chroma sample location (from 0 to 6) (default auto)
    /// </summary>
    public enum ScaleFilterGenOut_chroma_loc
    {
        /// <summary>
        /// auto            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = 0,
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

    /// <summary>
    ///  set input primaries (from -1 to 22) (default auto)
    /// </summary>
    public enum ScaleFilterGenIn_primaries
    {
        /// <summary>
        /// auto            -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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
    ///  set output primaries (from -1 to 22) (default auto)
    /// </summary>
    public enum ScaleFilterGenOut_primaries
    {
        /// <summary>
        /// auto            -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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
    ///  set output color transfer (from -1 to 18) (default auto)
    /// </summary>
    public enum ScaleFilterGenIn_transfer
    {
        /// <summary>
        /// auto            -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// srgb            13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("srgb")]
        srgb = 13,
        /// <summary>
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// xvycc           11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xvycc")]
        xvycc = 11,
        /// <summary>
        /// bt1361e         12           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt1361e")]
        bt1361e = 12,
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
    ///  set output color transfer (from -1 to 18) (default auto)
    /// </summary>
    public enum ScaleFilterGenOut_transfer
    {
        /// <summary>
        /// auto            -1           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
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
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// srgb            13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("srgb")]
        srgb = 13,
        /// <summary>
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// xvycc           11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xvycc")]
        xvycc = 11,
        /// <summary>
        /// bt1361e         12           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt1361e")]
        bt1361e = 12,
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
    ///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
    /// </summary>
    public enum ScaleFilterGenForce_original_aspect_ratio
    {
        /// <summary>
        /// disable         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("disable")]
        disable = 0,
        /// <summary>
        /// decrease        1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("decrease")]
        decrease = 1,
        /// <summary>
        /// increase        2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("increase")]
        increase = 2
    }

    /// <summary>
    ///  specify when to evaluate expressions (from 0 to 1) (default init)
    /// </summary>
    public enum ScaleFilterGenEval
    {
        /// <summary>
        /// init            0            ..FV....... eval expressions once during initialization
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("init")]
        init = 0,
        /// <summary>
        /// frame           1            ..FV....... eval expressions during initialization and per-frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Scale the input video size and/or convert the image format.
        /// </summary>
        public static ScaleFilterGen ScaleFilterGen(this ImageMap input0) => new ScaleFilterGen(input0);
    }
}