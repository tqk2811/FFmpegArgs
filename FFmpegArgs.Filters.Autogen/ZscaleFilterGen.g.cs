using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using FFmpegArgs;
using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
namespace FFmpegArgs.Filters.Autogens
{
public class ZscaleFilterGen : ImageToImageFilter,ICommandSupport
{
internal ZscaleFilterGen(ImageMap input) : base("zscale",input) { AddMapOut(); }
/// <summary>
///  Output video width
/// </summary>
public ZscaleFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video width
/// </summary>
public ZscaleFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  Output video height
/// </summary>
public ZscaleFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Output video height
/// </summary>
public ZscaleFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set video size
/// </summary>
public ZscaleFilterGen size(string size) => this.SetOption("size",size);
/// <summary>
///  set video size
/// </summary>
public ZscaleFilterGen s(string s) => this.SetOption("s",s);
/// <summary>
///  set dither type (from 0 to 3) (default none)
/// </summary>
public ZscaleFilterGen dither(ZscaleFilterGenDither dither) => this.SetOption("dither", dither.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set dither type (from 0 to 3) (default none)
/// </summary>
public ZscaleFilterGen d(ZscaleFilterGenD d) => this.SetOption("d", d.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter type (from 0 to 5) (default bilinear)
/// </summary>
public ZscaleFilterGen filter(ZscaleFilterGenFilter filter) => this.SetOption("filter", filter.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter type (from 0 to 5) (default bilinear)
/// </summary>
public ZscaleFilterGen f(ZscaleFilterGenF f) => this.SetOption("f", f.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set color range (from -1 to 1) (default input)
/// </summary>
public ZscaleFilterGen out_range(ZscaleFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set color range (from -1 to 1) (default input)
/// </summary>
public ZscaleFilterGen range(ZscaleFilterGenRange range) => this.SetOption("range", range.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set color range (from -1 to 1) (default input)
/// </summary>
public ZscaleFilterGen r(ZscaleFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set color primaries (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen primaries(ZscaleFilterGenPrimaries primaries) => this.SetOption("primaries", primaries.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set color primaries (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen p(ZscaleFilterGenP p) => this.SetOption("p", p.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transfer characteristic (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen transfer(ZscaleFilterGenTransfer transfer) => this.SetOption("transfer", transfer.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transfer characteristic (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen t(ZscaleFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set colorspace matrix (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen matrix(ZscaleFilterGenMatrix matrix) => this.SetOption("matrix", matrix.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set colorspace matrix (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen m(ZscaleFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input color range (from -1 to 1) (default input)
/// </summary>
public ZscaleFilterGen in_range(ZscaleFilterGenIn_range in_range) => this.SetOption("in_range", in_range.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input color range (from -1 to 1) (default input)
/// </summary>
public ZscaleFilterGen rangein(ZscaleFilterGenRangein rangein) => this.SetOption("rangein", rangein.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input color range (from -1 to 1) (default input)
/// </summary>
public ZscaleFilterGen rin(ZscaleFilterGenRin rin) => this.SetOption("rin", rin.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input color primaries (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen primariesin(ZscaleFilterGenPrimariesin primariesin) => this.SetOption("primariesin", primariesin.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input color primaries (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen pin(ZscaleFilterGenPin pin) => this.SetOption("pin", pin.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input transfer characteristic (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen transferin(ZscaleFilterGenTransferin transferin) => this.SetOption("transferin", transferin.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input transfer characteristic (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen tin(ZscaleFilterGenTin tin) => this.SetOption("tin", tin.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input colorspace matrix (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen matrixin(ZscaleFilterGenMatrixin matrixin) => this.SetOption("matrixin", matrixin.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input colorspace matrix (from -1 to INT_MAX) (default input)
/// </summary>
public ZscaleFilterGen min(ZscaleFilterGenMin min) => this.SetOption("min", min.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set output chroma location (from -1 to 5) (default input)
/// </summary>
public ZscaleFilterGen chromal(ZscaleFilterGenChromal chromal) => this.SetOption("chromal", chromal.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set output chroma location (from -1 to 5) (default input)
/// </summary>
public ZscaleFilterGen c(ZscaleFilterGenC c) => this.SetOption("c", c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input chroma location (from -1 to 5) (default input)
/// </summary>
public ZscaleFilterGen chromalin(ZscaleFilterGenChromalin chromalin) => this.SetOption("chromalin", chromalin.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set input chroma location (from -1 to 5) (default input)
/// </summary>
public ZscaleFilterGen cin(ZscaleFilterGenCin cin) => this.SetOption("cin", cin.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set nominal peak luminance (from 0 to DBL_MAX) (default nan)
/// </summary>
public ZscaleFilterGen npl(double npl) => this.SetOptionRange("npl", npl,0,DBL_MAX);
/// <summary>
///  allow approximate gamma (default true)
/// </summary>
public ZscaleFilterGen agamma(bool flag) => this.SetOption("agamma",flag.ToFFmpegFlag());
/// <summary>
///  parameter A, which is parameter "b" for bicubic, and the number of filter taps for lanczos (from -DBL_MAX to DBL_MAX) (default nan)
/// </summary>
public ZscaleFilterGen param_a(double param_a) => this.SetOptionRange("param_a", param_a,-DBL_MAX,DBL_MAX);
/// <summary>
///  parameter B, which is parameter "c" for bicubic (from -DBL_MAX to DBL_MAX) (default nan)
/// </summary>
public ZscaleFilterGen param_b(double param_b) => this.SetOptionRange("param_b", param_b,-DBL_MAX,DBL_MAX);
}
public static class ZscaleFilterGenExtensions
{
/// <summary>
/// Apply resizing, colorspace and bit depth conversion.
/// </summary>
public static ZscaleFilterGen ZscaleFilterGen(this ImageMap input0) => new ZscaleFilterGen(input0);
}
public enum ZscaleFilterGenDither
{
[Name("none")] none,
[Name("ordered")] ordered,
[Name("random")] random,
[Name("error_diffusion")] error_diffusion,
}

public enum ZscaleFilterGenD
{
[Name("none")] none,
[Name("ordered")] ordered,
[Name("random")] random,
[Name("error_diffusion")] error_diffusion,
}

public enum ZscaleFilterGenFilter
{
[Name("point")] point,
[Name("bilinear")] bilinear,
[Name("bicubic")] bicubic,
[Name("spline16")] spline16,
[Name("spline36")] spline36,
[Name("lanczos")] lanczos,
}

public enum ZscaleFilterGenF
{
[Name("point")] point,
[Name("bilinear")] bilinear,
[Name("bicubic")] bicubic,
[Name("spline16")] spline16,
[Name("spline36")] spline36,
[Name("lanczos")] lanczos,
}

public enum ZscaleFilterGenOut_range
{
[Name("input")] input,
[Name("limited")] limited,
[Name("full")] full,
[Name("unknown")] unknown,
[Name("tv")] tv,
[Name("pc")] pc,
}

public enum ZscaleFilterGenRange
{
[Name("input")] input,
[Name("limited")] limited,
[Name("full")] full,
[Name("unknown")] unknown,
[Name("tv")] tv,
[Name("pc")] pc,
}

public enum ZscaleFilterGenR
{
[Name("input")] input,
[Name("limited")] limited,
[Name("full")] full,
[Name("unknown")] unknown,
[Name("tv")] tv,
[Name("pc")] pc,
}

public enum ZscaleFilterGenPrimaries
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("170m")] _170m,
[Name("240m")] _240m,
[Name("2020")] _2020,
[Name("unknown")] unknown,
[Name("bt709")] bt709,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("film")] film,
[Name("bt2020")] bt2020,
[Name("smpte428")] smpte428,
[Name("smpte431")] smpte431,
[Name("smpte432")] smpte432,
[Name("jedec-p22")] jedec_p22,
[Name("ebu3213")] ebu3213,
}

public enum ZscaleFilterGenP
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("170m")] _170m,
[Name("240m")] _240m,
[Name("2020")] _2020,
[Name("unknown")] unknown,
[Name("bt709")] bt709,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("film")] film,
[Name("bt2020")] bt2020,
[Name("smpte428")] smpte428,
[Name("smpte431")] smpte431,
[Name("smpte432")] smpte432,
[Name("jedec-p22")] jedec_p22,
[Name("ebu3213")] ebu3213,
}

public enum ZscaleFilterGenTransfer
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("601")] _601,
[Name("linear")] linear,
[Name("2020_10")] _2020_10,
[Name("2020_12")] _2020_12,
[Name("unknown")] unknown,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("bt709")] bt709,
[Name("log100")] log100,
[Name("log316")] log316,
[Name("bt2020-10")] bt2020_10,
[Name("bt2020-12")] bt2020_12,
[Name("smpte2084")] smpte2084,
[Name("iec61966-2-4")] iec61966_2_4,
[Name("iec61966-2-1")] iec61966_2_1,
[Name("arib-std-b67")] arib_std_b67,
}

public enum ZscaleFilterGenT
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("601")] _601,
[Name("linear")] linear,
[Name("2020_10")] _2020_10,
[Name("2020_12")] _2020_12,
[Name("unknown")] unknown,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("bt709")] bt709,
[Name("log100")] log100,
[Name("log316")] log316,
[Name("bt2020-10")] bt2020_10,
[Name("bt2020-12")] bt2020_12,
[Name("smpte2084")] smpte2084,
[Name("iec61966-2-4")] iec61966_2_4,
[Name("iec61966-2-1")] iec61966_2_1,
[Name("arib-std-b67")] arib_std_b67,
}

public enum ZscaleFilterGenMatrix
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("470bg")] _470bg,
[Name("170m")] _170m,
[Name("2020_ncl")] _2020_ncl,
[Name("2020_cl")] _2020_cl,
[Name("unknown")] unknown,
[Name("gbr")] gbr,
[Name("bt709")] bt709,
[Name("fcc")] fcc,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte2400m")] smpte2400m,
[Name("ycgco")] ycgco,
[Name("bt2020nc")] bt2020nc,
[Name("bt2020c")] bt2020c,
[Name("chroma-derived-nc")] chroma_derived_nc,
[Name("chroma-derived-c")] chroma_derived_c,
[Name("ictcp")] ictcp,
}

public enum ZscaleFilterGenM
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("470bg")] _470bg,
[Name("170m")] _170m,
[Name("2020_ncl")] _2020_ncl,
[Name("2020_cl")] _2020_cl,
[Name("unknown")] unknown,
[Name("gbr")] gbr,
[Name("bt709")] bt709,
[Name("fcc")] fcc,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte2400m")] smpte2400m,
[Name("ycgco")] ycgco,
[Name("bt2020nc")] bt2020nc,
[Name("bt2020c")] bt2020c,
[Name("chroma-derived-nc")] chroma_derived_nc,
[Name("chroma-derived-c")] chroma_derived_c,
[Name("ictcp")] ictcp,
}

public enum ZscaleFilterGenIn_range
{
[Name("input")] input,
[Name("limited")] limited,
[Name("full")] full,
[Name("unknown")] unknown,
[Name("tv")] tv,
[Name("pc")] pc,
}

public enum ZscaleFilterGenRangein
{
[Name("input")] input,
[Name("limited")] limited,
[Name("full")] full,
[Name("unknown")] unknown,
[Name("tv")] tv,
[Name("pc")] pc,
}

public enum ZscaleFilterGenRin
{
[Name("input")] input,
[Name("limited")] limited,
[Name("full")] full,
[Name("unknown")] unknown,
[Name("tv")] tv,
[Name("pc")] pc,
}

public enum ZscaleFilterGenPrimariesin
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("170m")] _170m,
[Name("240m")] _240m,
[Name("2020")] _2020,
[Name("unknown")] unknown,
[Name("bt709")] bt709,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("film")] film,
[Name("bt2020")] bt2020,
[Name("smpte428")] smpte428,
[Name("smpte431")] smpte431,
[Name("smpte432")] smpte432,
[Name("jedec-p22")] jedec_p22,
[Name("ebu3213")] ebu3213,
}

public enum ZscaleFilterGenPin
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("170m")] _170m,
[Name("240m")] _240m,
[Name("2020")] _2020,
[Name("unknown")] unknown,
[Name("bt709")] bt709,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("film")] film,
[Name("bt2020")] bt2020,
[Name("smpte428")] smpte428,
[Name("smpte431")] smpte431,
[Name("smpte432")] smpte432,
[Name("jedec-p22")] jedec_p22,
[Name("ebu3213")] ebu3213,
}

public enum ZscaleFilterGenTransferin
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("601")] _601,
[Name("linear")] linear,
[Name("2020_10")] _2020_10,
[Name("2020_12")] _2020_12,
[Name("unknown")] unknown,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("bt709")] bt709,
[Name("log100")] log100,
[Name("log316")] log316,
[Name("bt2020-10")] bt2020_10,
[Name("bt2020-12")] bt2020_12,
[Name("smpte2084")] smpte2084,
[Name("iec61966-2-4")] iec61966_2_4,
[Name("iec61966-2-1")] iec61966_2_1,
[Name("arib-std-b67")] arib_std_b67,
}

public enum ZscaleFilterGenTin
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("601")] _601,
[Name("linear")] linear,
[Name("2020_10")] _2020_10,
[Name("2020_12")] _2020_12,
[Name("unknown")] unknown,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("bt709")] bt709,
[Name("log100")] log100,
[Name("log316")] log316,
[Name("bt2020-10")] bt2020_10,
[Name("bt2020-12")] bt2020_12,
[Name("smpte2084")] smpte2084,
[Name("iec61966-2-4")] iec61966_2_4,
[Name("iec61966-2-1")] iec61966_2_1,
[Name("arib-std-b67")] arib_std_b67,
}

public enum ZscaleFilterGenMatrixin
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("470bg")] _470bg,
[Name("170m")] _170m,
[Name("2020_ncl")] _2020_ncl,
[Name("2020_cl")] _2020_cl,
[Name("unknown")] unknown,
[Name("gbr")] gbr,
[Name("bt709")] bt709,
[Name("fcc")] fcc,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte2400m")] smpte2400m,
[Name("ycgco")] ycgco,
[Name("bt2020nc")] bt2020nc,
[Name("bt2020c")] bt2020c,
[Name("chroma-derived-nc")] chroma_derived_nc,
[Name("chroma-derived-c")] chroma_derived_c,
[Name("ictcp")] ictcp,
}

public enum ZscaleFilterGenMin
{
[Name("input")] input,
[Name("709")] _709,
[Name("unspecified")] unspecified,
[Name("470bg")] _470bg,
[Name("170m")] _170m,
[Name("2020_ncl")] _2020_ncl,
[Name("2020_cl")] _2020_cl,
[Name("unknown")] unknown,
[Name("gbr")] gbr,
[Name("bt709")] bt709,
[Name("fcc")] fcc,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte2400m")] smpte2400m,
[Name("ycgco")] ycgco,
[Name("bt2020nc")] bt2020nc,
[Name("bt2020c")] bt2020c,
[Name("chroma-derived-nc")] chroma_derived_nc,
[Name("chroma-derived-c")] chroma_derived_c,
[Name("ictcp")] ictcp,
}

public enum ZscaleFilterGenChromal
{
[Name("input")] input,
[Name("left")] left,
[Name("center")] center,
[Name("topleft")] topleft,
[Name("top")] top,
[Name("bottomleft")] bottomleft,
[Name("bottom")] bottom,
}

public enum ZscaleFilterGenC
{
[Name("input")] input,
[Name("left")] left,
[Name("center")] center,
[Name("topleft")] topleft,
[Name("top")] top,
[Name("bottomleft")] bottomleft,
[Name("bottom")] bottom,
}

public enum ZscaleFilterGenChromalin
{
[Name("input")] input,
[Name("left")] left,
[Name("center")] center,
[Name("topleft")] topleft,
[Name("top")] top,
[Name("bottomleft")] bottomleft,
[Name("bottom")] bottom,
}

public enum ZscaleFilterGenCin
{
[Name("input")] input,
[Name("left")] left,
[Name("center")] center,
[Name("topleft")] topleft,
[Name("top")] top,
[Name("bottomleft")] bottomleft,
[Name("bottom")] bottom,
}

}
