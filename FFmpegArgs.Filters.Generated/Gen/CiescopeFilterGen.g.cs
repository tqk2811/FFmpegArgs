namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... ciescope          V-&gt;V       Video CIE scope.
    /// </summary>
    public class CiescopeFilterGen : ImageToImageFilter
    {
        internal CiescopeFilterGen(ImageMap input) : base("ciescope", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set color system (from 0 to 9) (default hdtv)
        /// </summary>
        public CiescopeFilterGen system(CiescopeFilterGenSystem system) => this.SetOption("system", system.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set cie system (from 0 to 2) (default xyy)
        /// </summary>
        public CiescopeFilterGen cie(CiescopeFilterGenCie cie) => this.SetOption("cie", cie.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set what gamuts to draw (default 0)
        /// </summary>
        public CiescopeFilterGen gamuts(CiescopeFilterGenGamuts gamuts) => this.SetOption("gamuts", gamuts.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set ciescope size (from 256 to 8192) (default 512)
        /// </summary>
        public CiescopeFilterGen size(int size) => this.SetOptionRange("size", size, 256, 8192);
        /// <summary>
        ///  set ciescope intensity (from 0 to 1) (default 0.001)
        /// </summary>
        public CiescopeFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity, 0, 1);
        /// <summary>
        ///  (from 0 to 1) (default 0.75)
        /// </summary>
        public CiescopeFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast, 0, 1);
        /// <summary>
        ///  (default true)
        /// </summary>
        public CiescopeFilterGen corrgamma(bool corrgamma) => this.SetOption("corrgamma", corrgamma.ToFFmpegFlag());
        /// <summary>
        ///  (default false)
        /// </summary>
        public CiescopeFilterGen showwhite(bool showwhite) => this.SetOption("showwhite", showwhite.ToFFmpegFlag());
        /// <summary>
        ///  (from 0.1 to 6) (default 2.6)
        /// </summary>
        public CiescopeFilterGen gamma(double gamma) => this.SetOptionRange("gamma", gamma, 0.1, 6);
        /// <summary>
        ///  fill with CIE colors (default true)
        /// </summary>
        public CiescopeFilterGen fill(bool fill) => this.SetOption("fill", fill.ToFFmpegFlag());
    }

    /// <summary>
    ///  set color system (from 0 to 9) (default hdtv)
    /// </summary>
    public enum CiescopeFilterGenSystem
    {
        /// <summary>
        /// ntsc            0            ..FV....... NTSC 1953 Y&#39;I&#39;O&#39; (ITU-R BT.470 System M)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ntsc")]
        ntsc = 0,
        /// <summary>
        /// 470m            0            ..FV....... NTSC 1953 Y&#39;I&#39;O&#39; (ITU-R BT.470 System M)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("470m")]
        _470m = 0,
        /// <summary>
        /// ebu             1            ..FV....... EBU Y&#39;U&#39;V&#39; (PAL/SECAM) (ITU-R BT.470 System B, G)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ebu")]
        ebu = 1,
        /// <summary>
        /// 470bg           1            ..FV....... EBU Y&#39;U&#39;V&#39; (PAL/SECAM) (ITU-R BT.470 System B, G)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("470bg")]
        _470bg = 1,
        /// <summary>
        /// smpte           2            ..FV....... SMPTE-C RGB
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte")]
        smpte = 2,
        /// <summary>
        /// 240m            3            ..FV....... SMPTE-240M Y&#39;PbPr
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("240m")]
        _240m = 3,
        /// <summary>
        /// apple           4            ..FV....... Apple RGB
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("apple")]
        apple = 4,
        /// <summary>
        /// widergb         5            ..FV....... Adobe Wide Gamut RGB
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("widergb")]
        widergb = 5,
        /// <summary>
        /// cie1931         6            ..FV....... CIE 1931 RGB
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cie1931")]
        cie1931 = 6,
        /// <summary>
        /// hdtv            7            ..FV....... ITU.BT-709 Y&#39;CbCr
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hdtv")]
        hdtv = 7,
        /// <summary>
        /// rec709          7            ..FV....... ITU.BT-709 Y&#39;CbCr
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rec709")]
        rec709 = 7,
        /// <summary>
        /// uhdtv           8            ..FV....... ITU-R.BT-2020
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("uhdtv")]
        uhdtv = 8,
        /// <summary>
        /// rec2020         8            ..FV....... ITU-R.BT-2020
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rec2020")]
        rec2020 = 8,
        /// <summary>
        /// dcip3           9            ..FV....... DCI-P3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dcip3")]
        dcip3 = 9
    }

    /// <summary>
    ///  set cie system (from 0 to 2) (default xyy)
    /// </summary>
    public enum CiescopeFilterGenCie
    {
        /// <summary>
        /// xyy             0            ..FV....... CIE 1931 xyY
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xyy")]
        xyy = 0,
        /// <summary>
        /// ucs             1            ..FV....... CIE 1960 UCS
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ucs")]
        ucs = 1,
        /// <summary>
        /// luv             2            ..FV....... CIE 1976 Luv
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("luv")]
        luv = 2
    }

    /// <summary>
    ///  set what gamuts to draw (default 0)
    /// </summary>
    public enum CiescopeFilterGenGamuts
    {
        /// <summary>
        /// ntsc                         ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ntsc")]
        ntsc,
        /// <summary>
        /// 470m                         ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("470m")]
        _470m,
        /// <summary>
        /// ebu                          ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ebu")]
        ebu,
        /// <summary>
        /// 470bg                        ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("470bg")]
        _470bg,
        /// <summary>
        /// smpte                        ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte")]
        smpte,
        /// <summary>
        /// 240m                         ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("240m")]
        _240m,
        /// <summary>
        /// apple                        ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("apple")]
        apple,
        /// <summary>
        /// widergb                      ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("widergb")]
        widergb,
        /// <summary>
        /// cie1931                      ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cie1931")]
        cie1931,
        /// <summary>
        /// hdtv                         ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hdtv")]
        hdtv,
        /// <summary>
        /// rec709                       ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rec709")]
        rec709,
        /// <summary>
        /// uhdtv                        ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("uhdtv")]
        uhdtv,
        /// <summary>
        /// rec2020                      ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rec2020")]
        rec2020,
        /// <summary>
        /// dcip3                        ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dcip3")]
        dcip3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Video CIE scope.
        /// </summary>
        public static CiescopeFilterGen CiescopeFilterGen(this ImageMap input0) => new CiescopeFilterGen(input0);
    }
}