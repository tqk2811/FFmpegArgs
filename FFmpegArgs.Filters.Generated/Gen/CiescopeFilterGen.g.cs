namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... ciescope          V->V       Video CIE scope.
/// </summary>
public class CiescopeFilterGen : ImageToImageFilter
{
internal CiescopeFilterGen(ImageMap input) : base("ciescope",input) { AddMapOut(); }
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
public CiescopeFilterGen size(int size) => this.SetOptionRange("size", size,256,8192);
/// <summary>
///  set ciescope intensity (from 0 to 1) (default 0.001)
/// </summary>
public CiescopeFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,0,1);
/// <summary>
///  (from 0 to 1) (default 0.75)
/// </summary>
public CiescopeFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast,0,1);
/// <summary>
///  (default true)
/// </summary>
public CiescopeFilterGen corrgamma(bool corrgamma) => this.SetOption("corrgamma",corrgamma.ToFFmpegFlag());
/// <summary>
///  (default false)
/// </summary>
public CiescopeFilterGen showwhite(bool showwhite) => this.SetOption("showwhite",showwhite.ToFFmpegFlag());
/// <summary>
///  (from 0.1 to 6) (default 2.6)
/// </summary>
public CiescopeFilterGen gamma(double gamma) => this.SetOptionRange("gamma", gamma,0.1,6);
/// <summary>
///  fill with CIE colors (default true)
/// </summary>
public CiescopeFilterGen fill(bool fill) => this.SetOption("fill",fill.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Video CIE scope.
/// </summary>
public static CiescopeFilterGen CiescopeFilterGen(this ImageMap input0) => new CiescopeFilterGen(input0);
}
/// <summary>
///  set color system (from 0 to 9) (default hdtv)
/// </summary>
public enum CiescopeFilterGenSystem
{
/// <summary>
/// ntsc            0            ..FV....... NTSC 1953 Y'I'O' (ITU-R BT.470 System M)
/// </summary>
[Name("ntsc")] ntsc,
/// <summary>
/// 470m            0            ..FV....... NTSC 1953 Y'I'O' (ITU-R BT.470 System M)
/// </summary>
[Name("470m")] _470m,
/// <summary>
/// ebu             1            ..FV....... EBU Y'U'V' (PAL/SECAM) (ITU-R BT.470 System B, G)
/// </summary>
[Name("ebu")] ebu,
/// <summary>
/// 470bg           1            ..FV....... EBU Y'U'V' (PAL/SECAM) (ITU-R BT.470 System B, G)
/// </summary>
[Name("470bg")] _470bg,
/// <summary>
/// smpte           2            ..FV....... SMPTE-C RGB
/// </summary>
[Name("smpte")] smpte,
/// <summary>
/// 240m            3            ..FV....... SMPTE-240M Y'PbPr
/// </summary>
[Name("240m")] _240m,
/// <summary>
/// apple           4            ..FV....... Apple RGB
/// </summary>
[Name("apple")] apple,
/// <summary>
/// widergb         5            ..FV....... Adobe Wide Gamut RGB
/// </summary>
[Name("widergb")] widergb,
/// <summary>
/// cie1931         6            ..FV....... CIE 1931 RGB
/// </summary>
[Name("cie1931")] cie1931,
/// <summary>
/// hdtv            7            ..FV....... ITU.BT-709 Y'CbCr
/// </summary>
[Name("hdtv")] hdtv,
/// <summary>
/// rec709          7            ..FV....... ITU.BT-709 Y'CbCr
/// </summary>
[Name("rec709")] rec709,
/// <summary>
/// uhdtv           8            ..FV....... ITU-R.BT-2020
/// </summary>
[Name("uhdtv")] uhdtv,
/// <summary>
/// rec2020         8            ..FV....... ITU-R.BT-2020
/// </summary>
[Name("rec2020")] rec2020,
/// <summary>
/// dcip3           9            ..FV....... DCI-P3
/// </summary>
[Name("dcip3")] dcip3,
}

/// <summary>
///  set cie system (from 0 to 2) (default xyy)
/// </summary>
public enum CiescopeFilterGenCie
{
/// <summary>
/// xyy             0            ..FV....... CIE 1931 xyY
/// </summary>
[Name("xyy")] xyy,
/// <summary>
/// ucs             1            ..FV....... CIE 1960 UCS
/// </summary>
[Name("ucs")] ucs,
/// <summary>
/// luv             2            ..FV....... CIE 1976 Luv
/// </summary>
[Name("luv")] luv,
}

/// <summary>
///  set what gamuts to draw (default 0)
/// </summary>
public enum CiescopeFilterGenGamuts
{
/// <summary>
/// ntsc                         ..FV.......
/// </summary>
[Name("ntsc")] ntsc,
/// <summary>
/// 470m                         ..FV.......
/// </summary>
[Name("470m")] _470m,
/// <summary>
/// ebu                          ..FV.......
/// </summary>
[Name("ebu")] ebu,
/// <summary>
/// 470bg                        ..FV.......
/// </summary>
[Name("470bg")] _470bg,
/// <summary>
/// smpte                        ..FV.......
/// </summary>
[Name("smpte")] smpte,
/// <summary>
/// 240m                         ..FV.......
/// </summary>
[Name("240m")] _240m,
/// <summary>
/// apple                        ..FV.......
/// </summary>
[Name("apple")] apple,
/// <summary>
/// widergb                      ..FV.......
/// </summary>
[Name("widergb")] widergb,
/// <summary>
/// cie1931                      ..FV.......
/// </summary>
[Name("cie1931")] cie1931,
/// <summary>
/// hdtv                         ..FV.......
/// </summary>
[Name("hdtv")] hdtv,
/// <summary>
/// rec709                       ..FV.......
/// </summary>
[Name("rec709")] rec709,
/// <summary>
/// uhdtv                        ..FV.......
/// </summary>
[Name("uhdtv")] uhdtv,
/// <summary>
/// rec2020                      ..FV.......
/// </summary>
[Name("rec2020")] rec2020,
/// <summary>
/// dcip3                        ..FV.......
/// </summary>
[Name("dcip3")] dcip3,
}

}
