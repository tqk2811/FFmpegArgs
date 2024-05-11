namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .SC avectorscope      A->V       Convert input audio to vectorscope video output.
/// </summary>
public class AvectorscopeFilterGen : AudioToImageFilter,ISliceThreading,ICommandSupport
{
internal AvectorscopeFilterGen(AudioMap input) : base("avectorscope",input) { AddMapOut(); }
/// <summary>
///  set mode (from 0 to 2) (default lissajous)
/// </summary>
public AvectorscopeFilterGen mode(AvectorscopeFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set video rate (default "25")
/// </summary>
public AvectorscopeFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video size (default "400x400")
/// </summary>
public AvectorscopeFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set red contrast (from 0 to 255) (default 40)
/// </summary>
public AvectorscopeFilterGen rc(int rc) => this.SetOptionRange("rc", rc,0,255);
/// <summary>
///  set green contrast (from 0 to 255) (default 160)
/// </summary>
public AvectorscopeFilterGen gc(int gc) => this.SetOptionRange("gc", gc,0,255);
/// <summary>
///  set blue contrast (from 0 to 255) (default 80)
/// </summary>
public AvectorscopeFilterGen bc(int bc) => this.SetOptionRange("bc", bc,0,255);
/// <summary>
///  set alpha contrast (from 0 to 255) (default 255)
/// </summary>
public AvectorscopeFilterGen ac(int ac) => this.SetOptionRange("ac", ac,0,255);
/// <summary>
///  set red fade (from 0 to 255) (default 15)
/// </summary>
public AvectorscopeFilterGen rf(int rf) => this.SetOptionRange("rf", rf,0,255);
/// <summary>
///  set green fade (from 0 to 255) (default 10)
/// </summary>
public AvectorscopeFilterGen gf(int gf) => this.SetOptionRange("gf", gf,0,255);
/// <summary>
///  set blue fade (from 0 to 255) (default 5)
/// </summary>
public AvectorscopeFilterGen bf(int bf) => this.SetOptionRange("bf", bf,0,255);
/// <summary>
///  set alpha fade (from 0 to 255) (default 5)
/// </summary>
public AvectorscopeFilterGen af(int af) => this.SetOptionRange("af", af,0,255);
/// <summary>
///  set zoom factor (from 0 to 10) (default 1)
/// </summary>
public AvectorscopeFilterGen zoom(double zoom) => this.SetOptionRange("zoom", zoom,0,10);
/// <summary>
///  set draw mode (from 0 to 2) (default dot)
/// </summary>
public AvectorscopeFilterGen draw(AvectorscopeFilterGenDraw draw) => this.SetOption("draw", draw.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set amplitude scale mode (from 0 to 3) (default lin)
/// </summary>
public AvectorscopeFilterGen scale(AvectorscopeFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  swap x axis with y axis (default true)
/// </summary>
public AvectorscopeFilterGen swap(bool swap) => this.SetOption("swap",swap.ToFFmpegFlag());
/// <summary>
///  mirror axis (from 0 to 3) (default none)
/// </summary>
public AvectorscopeFilterGen mirror(AvectorscopeFilterGenMirror mirror) => this.SetOption("mirror", mirror.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to vectorscope video output.
/// </summary>
public static AvectorscopeFilterGen AvectorscopeFilterGen(this AudioMap input0) => new AvectorscopeFilterGen(input0);
}
/// <summary>
///  set mode (from 0 to 2) (default lissajous)
/// </summary>
public enum AvectorscopeFilterGenMode
{
/// <summary>
/// lissajous       0            ..FV.....T.
/// </summary>
[Name("lissajous")] lissajous,
/// <summary>
/// lissajous_xy    1            ..FV.....T.
/// </summary>
[Name("lissajous_xy")] lissajous_xy,
/// <summary>
/// polar           2            ..FV.....T.
/// </summary>
[Name("polar")] polar,
}

/// <summary>
///  set draw mode (from 0 to 2) (default dot)
/// </summary>
public enum AvectorscopeFilterGenDraw
{
/// <summary>
/// dot             0            ..FV.....T. draw dots
/// </summary>
[Name("dot")] dot,
/// <summary>
/// line            1            ..FV.....T. draw lines
/// </summary>
[Name("line")] line,
/// <summary>
/// aaline          2            ..FV.....T. draw anti-aliased lines
/// </summary>
[Name("aaline")] aaline,
}

/// <summary>
///  set amplitude scale mode (from 0 to 3) (default lin)
/// </summary>
public enum AvectorscopeFilterGenScale
{
/// <summary>
/// lin             0            ..FV.....T. linear
/// </summary>
[Name("lin")] lin,
/// <summary>
/// sqrt            1            ..FV.....T. square root
/// </summary>
[Name("sqrt")] sqrt,
/// <summary>
/// cbrt            2            ..FV.....T. cube root
/// </summary>
[Name("cbrt")] cbrt,
/// <summary>
/// log             3            ..FV.....T. logarithmic
/// </summary>
[Name("log")] log,
}

/// <summary>
///  mirror axis (from 0 to 3) (default none)
/// </summary>
public enum AvectorscopeFilterGenMirror
{
/// <summary>
/// none            0            ..FV.....T. no mirror
/// </summary>
[Name("none")] none,
/// <summary>
/// x               1            ..FV.....T. mirror x
/// </summary>
[Name("x")] x,
/// <summary>
/// y               2            ..FV.....T. mirror y
/// </summary>
[Name("y")] y,
/// <summary>
/// xy              3            ..FV.....T. mirror both
/// </summary>
[Name("xy")] xy,
}

}
