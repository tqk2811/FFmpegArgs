namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. vpp_amf           V-&gt;V       AMF video scaling and format conversion
    /// </summary>
    public class Vpp_amfFilterGen : ImageToImageFilter
    {
        internal Vpp_amfFilterGen(ImageMap input) : base("vpp_amf", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output video width (default &quot;iw&quot;)
        /// </summary>
        public Vpp_amfFilterGen w(String w) => this.SetOption("w", w.ToStringInv());
        /// <summary>
        ///  Output video height (default &quot;ih&quot;)
        /// </summary>
        public Vpp_amfFilterGen h(String h) => this.SetOption("h", h.ToStringInv());
        /// <summary>
        ///  Output pixel format (default &quot;same&quot;)
        /// </summary>
        public Vpp_amfFilterGen format(String format) => this.SetOption("format", format.ToStringInv());
        /// <summary>
        ///  Scale type (from 0 to 1) (default bilinear)
        /// </summary>
        public Vpp_amfFilterGen scale_type(Vpp_amfFilterGenScale_type scale_type) => this.SetOption("scale_type", scale_type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Color profile (from -1 to 8) (default -1)
        /// </summary>
        public Vpp_amfFilterGen color_profile(Vpp_amfFilterGenColor_profile color_profile) => this.SetOption("color_profile", color_profile.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Color range (from 0 to 2) (default 0)
        /// </summary>
        public Vpp_amfFilterGen color_range(Vpp_amfFilterGenColor_range color_range) => this.SetOption("color_range", color_range.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Output color primaries (from 0 to 22) (default 0)
        /// </summary>
        public Vpp_amfFilterGen primaries(Vpp_amfFilterGenPrimaries primaries) => this.SetOption("primaries", primaries.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Output transfer characteristics (from 0 to 18) (default 0)
        /// </summary>
        public Vpp_amfFilterGen trc(Vpp_amfFilterGenTrc trc) => this.SetOption("trc", trc.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
        /// </summary>
        public Vpp_amfFilterGen force_original_aspect_ratio(Vpp_amfFilterGenForce_original_aspect_ratio force_original_aspect_ratio) => this.SetOption("force_original_aspect_ratio", force_original_aspect_ratio.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
        /// </summary>
        public Vpp_amfFilterGen force_divisible_by(int force_divisible_by) => this.SetOptionRange("force_divisible_by", force_divisible_by, 1, 256);
        /// <summary>
        ///  reset SAR to 1 and scale to square pixels if scaling proportionally (default false)
        /// </summary>
        public Vpp_amfFilterGen reset_sar(bool reset_sar) => this.SetOption("reset_sar", reset_sar.ToFFmpegFlag());
    }

    /// <summary>
    ///  Scale type (from 0 to 1) (default bilinear)
    /// </summary>
    public enum Vpp_amfFilterGenScale_type
    {
        /// <summary>
        /// bilinear        0            ..FV....... Bilinear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear")]
        bilinear = 0,
        /// <summary>
        /// bicubic         1            ..FV....... Bicubic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bicubic")]
        bicubic = 1
    }

    /// <summary>
    ///  Color profile (from -1 to 8) (default -1)
    /// </summary>
    public enum Vpp_amfFilterGenColor_profile
    {
        /// <summary>
        /// bt601           0            ..FV....... BT.601
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt601")]
        bt601 = 0,
        /// <summary>
        /// bt709           1            ..FV....... BT.709
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// bt2020          2            ..FV....... BT.2020
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 2
    }

    /// <summary>
    ///  Color range (from 0 to 2) (default 0)
    /// </summary>
    public enum Vpp_amfFilterGenColor_range
    {
        /// <summary>
        /// studio          1            ..FV....... Studio
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("studio")]
        studio = 1,
        /// <summary>
        /// full            2            ..FV....... Full
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 2
    }

    /// <summary>
    ///  Output color primaries (from 0 to 22) (default 0)
    /// </summary>
    public enum Vpp_amfFilterGenPrimaries
    {
        /// <summary>
        /// bt709           1            ..FV....... BT.709
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// bt470m          4            ..FV....... BT.470M
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 4,
        /// <summary>
        /// bt470bg         5            ..FV....... BT.470BG
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 5,
        /// <summary>
        /// smpte170m       6            ..FV....... SMPTE170M
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 6,
        /// <summary>
        /// smpte240m       7            ..FV....... SMPTE240M
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// film            8            ..FV....... FILM
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("film")]
        film = 8,
        /// <summary>
        /// bt2020          9            ..FV....... BT2020
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 9,
        /// <summary>
        /// smpte428        10           ..FV....... SMPTE428
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte428")]
        smpte428 = 10,
        /// <summary>
        /// smpte431        11           ..FV....... SMPTE431
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte431")]
        smpte431 = 11,
        /// <summary>
        /// smpte432        12           ..FV....... SMPTE432
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte432")]
        smpte432 = 12,
        /// <summary>
        /// jedec-p22       22           ..FV....... JEDEC_P22
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jedec-p22")]
        jedec_p22 = 22
    }

    /// <summary>
    ///  Output transfer characteristics (from 0 to 18) (default 0)
    /// </summary>
    public enum Vpp_amfFilterGenTrc
    {
        /// <summary>
        /// bt709           1            ..FV....... BT.709
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// gamma22         4            ..FV....... GAMMA22
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gamma22")]
        gamma22 = 4,
        /// <summary>
        /// gamma28         5            ..FV....... GAMMA28
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gamma28")]
        gamma28 = 5,
        /// <summary>
        /// smpte170m       6            ..FV....... SMPTE170M
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 6,
        /// <summary>
        /// smpte240m       7            ..FV....... SMPTE240M
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// linear          8            ..FV....... Linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 8,
        /// <summary>
        /// log             9            ..FV....... LOG
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 9,
        /// <summary>
        /// log-sqrt        10           ..FV....... LOG_SQRT
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log-sqrt")]
        log_sqrt = 10,
        /// <summary>
        /// iec61966-2-4    11           ..FV....... IEC61966_2_4
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// bt1361-ecg      12           ..FV....... BT1361_ECG
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt1361-ecg")]
        bt1361_ecg = 12,
        /// <summary>
        /// iec61966-2-1    13           ..FV....... IEC61966_2_1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// bt2020-10       14           ..FV....... BT.2020_10
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-10")]
        bt2020_10 = 14,
        /// <summary>
        /// bt2020-12       15           ..FV....... BT.2020-12
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-12")]
        bt2020_12 = 15,
        /// <summary>
        /// smpte2084       16           ..FV....... SMPTE2084
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte2084")]
        smpte2084 = 16,
        /// <summary>
        /// smpte428        17           ..FV....... SMPTE428
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte428")]
        smpte428 = 17,
        /// <summary>
        /// arib-std-b67    18           ..FV....... ARIB_STD_B67
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arib-std-b67")]
        arib_std_b67 = 18
    }

    /// <summary>
    ///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
    /// </summary>
    public enum Vpp_amfFilterGenForce_original_aspect_ratio
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

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// AMF video scaling and format conversion
        /// </summary>
        public static Vpp_amfFilterGen Vpp_amfFilterGen(this ImageMap input0) => new Vpp_amfFilterGen(input0);
    }
}