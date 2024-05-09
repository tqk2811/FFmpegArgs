namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// .SC zscale            V->V       Apply resizing, colorspace and bit depth conversion.
/// </summary>
public class ZscaleFilterGen : ImageToImageFilter,ISliceThreading,ICommandSupport
{
internal ZscaleFilterGen(ImageMap input) : base("zscale",input) { AddMapOut(); }
/// <summary>
///  Output video width
/// </summary>
public ZscaleFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  Output video height
/// </summary>
public ZscaleFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set video size
/// </summary>
public ZscaleFilterGen size(string size) => this.SetOption("size",size);
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
public ZscaleFilterGen npl(double npl) => this.SetOptionRange("npl", npl,0,DBL_MAX);
/// <summary>
///  allow approximate gamma (default true)
/// </summary>
public ZscaleFilterGen agamma(bool agamma) => this.SetOption("agamma",agamma.ToFFmpegFlag());
/// <summary>
///  parameter A, which is parameter "b" for bicubic, and the number of filter taps for lanczos (from -DBL_MAX to DBL_MAX) (default nan)
/// </summary>
public ZscaleFilterGen param_a(double param_a) => this.SetOptionRange("param_a", param_a,-DBL_MAX,DBL_MAX);
/// <summary>
///  parameter B, which is parameter "c" for bicubic (from -DBL_MAX to DBL_MAX) (default nan)
/// </summary>
public ZscaleFilterGen param_b(double param_b) => this.SetOptionRange("param_b", param_b,-DBL_MAX,DBL_MAX);
}
/// <summary>
/// </summary>
public static class ZscaleFilterGenExtensions
{
/// <summary>
/// Apply resizing, colorspace and bit depth conversion.
/// </summary>
public static ZscaleFilterGen ZscaleFilterGen(this ImageMap input0) => new ZscaleFilterGen(input0);
}
/// <summary>
///  set dither type (from 0 to 3) (default none)
/// </summary>
public enum ZscaleFilterGenDither
{
/// <summary>
/// none            0            ..FV.......
/// </summary>
[Name("none")] none,
/// <summary>
/// ordered         1            ..FV.......
/// </summary>
[Name("ordered")] ordered,
/// <summary>
/// random          2            ..FV.......
/// </summary>
[Name("random")] random,
/// <summary>
/// error_diffusion 3            ..FV.......
/// </summary>
[Name("error_diffusion")] error_diffusion,
}

/// <summary>
///  set filter type (from 0 to 5) (default bilinear)
/// </summary>
public enum ZscaleFilterGenFilter
{
/// <summary>
/// point           0            ..FV.......
/// </summary>
[Name("point")] point,
/// <summary>
/// bilinear        1            ..FV.......
/// </summary>
[Name("bilinear")] bilinear,
/// <summary>
/// bicubic         2            ..FV.......
/// </summary>
[Name("bicubic")] bicubic,
/// <summary>
/// spline16        3            ..FV.......
/// </summary>
[Name("spline16")] spline16,
/// <summary>
/// spline36        4            ..FV.......
/// </summary>
[Name("spline36")] spline36,
/// <summary>
/// lanczos         5            ..FV.......
/// </summary>
[Name("lanczos")] lanczos,
}

/// <summary>
///  set color range (from -1 to 1) (default input)
/// </summary>
public enum ZscaleFilterGenOut_range
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// limited         0            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// full            1            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// unknown         -1           ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// tv              0            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              1            ..FV.......
/// </summary>
[Name("pc")] pc,
}

/// <summary>
///  set color range (from -1 to 1) (default input)
/// </summary>
public enum ZscaleFilterGenRange
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// limited         0            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// full            1            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// unknown         -1           ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// tv              0            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              1            ..FV.......
/// </summary>
[Name("pc")] pc,
}

/// <summary>
///  set color range (from -1 to 1) (default input)
/// </summary>
public enum ZscaleFilterGenR
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// limited         0            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// full            1            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// unknown         -1           ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// tv              0            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              1            ..FV.......
/// </summary>
[Name("pc")] pc,
}

/// <summary>
///  set color primaries (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenPrimaries
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 170m            6            ..FV.......
/// </summary>
[Name("170m")] _170m,
/// <summary>
/// 240m            7            ..FV.......
/// </summary>
[Name("240m")] _240m,
/// <summary>
/// 2020            9            ..FV.......
/// </summary>
[Name("2020")] _2020,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// film            8            ..FV.......
/// </summary>
[Name("film")] film,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
/// <summary>
/// smpte428        10           ..FV.......
/// </summary>
[Name("smpte428")] smpte428,
/// <summary>
/// smpte431        11           ..FV.......
/// </summary>
[Name("smpte431")] smpte431,
/// <summary>
/// smpte432        12           ..FV.......
/// </summary>
[Name("smpte432")] smpte432,
/// <summary>
/// jedec-p22       22           ..FV.......
/// </summary>
[Name("jedec-p22")] jedec_p22,
/// <summary>
/// ebu3213         22           ..FV.......
/// </summary>
[Name("ebu3213")] ebu3213,
}

/// <summary>
///  set transfer characteristic (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenTransfer
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 601             6            ..FV.......
/// </summary>
[Name("601")] _601,
/// <summary>
/// linear          8            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// 2020_10         14           ..FV.......
/// </summary>
[Name("2020_10")] _2020_10,
/// <summary>
/// 2020_12         15           ..FV.......
/// </summary>
[Name("2020_12")] _2020_12,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// log100          9            ..FV.......
/// </summary>
[Name("log100")] log100,
/// <summary>
/// log316          10           ..FV.......
/// </summary>
[Name("log316")] log316,
/// <summary>
/// bt2020-10       14           ..FV.......
/// </summary>
[Name("bt2020-10")] bt2020_10,
/// <summary>
/// bt2020-12       15           ..FV.......
/// </summary>
[Name("bt2020-12")] bt2020_12,
/// <summary>
/// smpte2084       16           ..FV.......
/// </summary>
[Name("smpte2084")] smpte2084,
/// <summary>
/// iec61966-2-4    11           ..FV.......
/// </summary>
[Name("iec61966-2-4")] iec61966_2_4,
/// <summary>
/// iec61966-2-1    13           ..FV.......
/// </summary>
[Name("iec61966-2-1")] iec61966_2_1,
/// <summary>
/// arib-std-b67    18           ..FV.......
/// </summary>
[Name("arib-std-b67")] arib_std_b67,
}

/// <summary>
///  set colorspace matrix (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenMatrix
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 470bg           5            ..FV.......
/// </summary>
[Name("470bg")] _470bg,
/// <summary>
/// 170m            6            ..FV.......
/// </summary>
[Name("170m")] _170m,
/// <summary>
/// 2020_ncl        9            ..FV.......
/// </summary>
[Name("2020_ncl")] _2020_ncl,
/// <summary>
/// 2020_cl         10           ..FV.......
/// </summary>
[Name("2020_cl")] _2020_cl,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// gbr             0            ..FV.......
/// </summary>
[Name("gbr")] gbr,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// fcc             4            ..FV.......
/// </summary>
[Name("fcc")] fcc,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// ycgco           8            ..FV.......
/// </summary>
[Name("ycgco")] ycgco,
/// <summary>
/// bt2020nc        9            ..FV.......
/// </summary>
[Name("bt2020nc")] bt2020nc,
/// <summary>
/// bt2020c         10           ..FV.......
/// </summary>
[Name("bt2020c")] bt2020c,
/// <summary>
/// chroma-derived-nc 12           ..FV.......
/// </summary>
[Name("chroma-derived-nc")] chroma_derived_nc,
/// <summary>
/// chroma-derived-c 13           ..FV.......
/// </summary>
[Name("chroma-derived-c")] chroma_derived_c,
/// <summary>
/// ictcp           14           ..FV.......
/// </summary>
[Name("ictcp")] ictcp,
}

/// <summary>
///  set input color range (from -1 to 1) (default input)
/// </summary>
public enum ZscaleFilterGenIn_range
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// limited         0            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// full            1            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// unknown         -1           ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// tv              0            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              1            ..FV.......
/// </summary>
[Name("pc")] pc,
}

/// <summary>
///  set input color range (from -1 to 1) (default input)
/// </summary>
public enum ZscaleFilterGenRangein
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// limited         0            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// full            1            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// unknown         -1           ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// tv              0            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              1            ..FV.......
/// </summary>
[Name("pc")] pc,
}

/// <summary>
///  set input color range (from -1 to 1) (default input)
/// </summary>
public enum ZscaleFilterGenRin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// limited         0            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// full            1            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// unknown         -1           ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// tv              0            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              1            ..FV.......
/// </summary>
[Name("pc")] pc,
}

/// <summary>
///  set input color primaries (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenPrimariesin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 170m            6            ..FV.......
/// </summary>
[Name("170m")] _170m,
/// <summary>
/// 240m            7            ..FV.......
/// </summary>
[Name("240m")] _240m,
/// <summary>
/// 2020            9            ..FV.......
/// </summary>
[Name("2020")] _2020,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// film            8            ..FV.......
/// </summary>
[Name("film")] film,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
/// <summary>
/// smpte428        10           ..FV.......
/// </summary>
[Name("smpte428")] smpte428,
/// <summary>
/// smpte431        11           ..FV.......
/// </summary>
[Name("smpte431")] smpte431,
/// <summary>
/// smpte432        12           ..FV.......
/// </summary>
[Name("smpte432")] smpte432,
/// <summary>
/// jedec-p22       22           ..FV.......
/// </summary>
[Name("jedec-p22")] jedec_p22,
/// <summary>
/// ebu3213         22           ..FV.......
/// </summary>
[Name("ebu3213")] ebu3213,
}

/// <summary>
///  set input color primaries (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenPin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 170m            6            ..FV.......
/// </summary>
[Name("170m")] _170m,
/// <summary>
/// 240m            7            ..FV.......
/// </summary>
[Name("240m")] _240m,
/// <summary>
/// 2020            9            ..FV.......
/// </summary>
[Name("2020")] _2020,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// film            8            ..FV.......
/// </summary>
[Name("film")] film,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
/// <summary>
/// smpte428        10           ..FV.......
/// </summary>
[Name("smpte428")] smpte428,
/// <summary>
/// smpte431        11           ..FV.......
/// </summary>
[Name("smpte431")] smpte431,
/// <summary>
/// smpte432        12           ..FV.......
/// </summary>
[Name("smpte432")] smpte432,
/// <summary>
/// jedec-p22       22           ..FV.......
/// </summary>
[Name("jedec-p22")] jedec_p22,
/// <summary>
/// ebu3213         22           ..FV.......
/// </summary>
[Name("ebu3213")] ebu3213,
}

/// <summary>
///  set input transfer characteristic (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenTransferin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 601             6            ..FV.......
/// </summary>
[Name("601")] _601,
/// <summary>
/// linear          8            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// 2020_10         14           ..FV.......
/// </summary>
[Name("2020_10")] _2020_10,
/// <summary>
/// 2020_12         15           ..FV.......
/// </summary>
[Name("2020_12")] _2020_12,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// log100          9            ..FV.......
/// </summary>
[Name("log100")] log100,
/// <summary>
/// log316          10           ..FV.......
/// </summary>
[Name("log316")] log316,
/// <summary>
/// bt2020-10       14           ..FV.......
/// </summary>
[Name("bt2020-10")] bt2020_10,
/// <summary>
/// bt2020-12       15           ..FV.......
/// </summary>
[Name("bt2020-12")] bt2020_12,
/// <summary>
/// smpte2084       16           ..FV.......
/// </summary>
[Name("smpte2084")] smpte2084,
/// <summary>
/// iec61966-2-4    11           ..FV.......
/// </summary>
[Name("iec61966-2-4")] iec61966_2_4,
/// <summary>
/// iec61966-2-1    13           ..FV.......
/// </summary>
[Name("iec61966-2-1")] iec61966_2_1,
/// <summary>
/// arib-std-b67    18           ..FV.......
/// </summary>
[Name("arib-std-b67")] arib_std_b67,
}

/// <summary>
///  set input transfer characteristic (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenTin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 601             6            ..FV.......
/// </summary>
[Name("601")] _601,
/// <summary>
/// linear          8            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// 2020_10         14           ..FV.......
/// </summary>
[Name("2020_10")] _2020_10,
/// <summary>
/// 2020_12         15           ..FV.......
/// </summary>
[Name("2020_12")] _2020_12,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// log100          9            ..FV.......
/// </summary>
[Name("log100")] log100,
/// <summary>
/// log316          10           ..FV.......
/// </summary>
[Name("log316")] log316,
/// <summary>
/// bt2020-10       14           ..FV.......
/// </summary>
[Name("bt2020-10")] bt2020_10,
/// <summary>
/// bt2020-12       15           ..FV.......
/// </summary>
[Name("bt2020-12")] bt2020_12,
/// <summary>
/// smpte2084       16           ..FV.......
/// </summary>
[Name("smpte2084")] smpte2084,
/// <summary>
/// iec61966-2-4    11           ..FV.......
/// </summary>
[Name("iec61966-2-4")] iec61966_2_4,
/// <summary>
/// iec61966-2-1    13           ..FV.......
/// </summary>
[Name("iec61966-2-1")] iec61966_2_1,
/// <summary>
/// arib-std-b67    18           ..FV.......
/// </summary>
[Name("arib-std-b67")] arib_std_b67,
}

/// <summary>
///  set input colorspace matrix (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenMatrixin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 470bg           5            ..FV.......
/// </summary>
[Name("470bg")] _470bg,
/// <summary>
/// 170m            6            ..FV.......
/// </summary>
[Name("170m")] _170m,
/// <summary>
/// 2020_ncl        9            ..FV.......
/// </summary>
[Name("2020_ncl")] _2020_ncl,
/// <summary>
/// 2020_cl         10           ..FV.......
/// </summary>
[Name("2020_cl")] _2020_cl,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// gbr             0            ..FV.......
/// </summary>
[Name("gbr")] gbr,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// fcc             4            ..FV.......
/// </summary>
[Name("fcc")] fcc,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// ycgco           8            ..FV.......
/// </summary>
[Name("ycgco")] ycgco,
/// <summary>
/// bt2020nc        9            ..FV.......
/// </summary>
[Name("bt2020nc")] bt2020nc,
/// <summary>
/// bt2020c         10           ..FV.......
/// </summary>
[Name("bt2020c")] bt2020c,
/// <summary>
/// chroma-derived-nc 12           ..FV.......
/// </summary>
[Name("chroma-derived-nc")] chroma_derived_nc,
/// <summary>
/// chroma-derived-c 13           ..FV.......
/// </summary>
[Name("chroma-derived-c")] chroma_derived_c,
/// <summary>
/// ictcp           14           ..FV.......
/// </summary>
[Name("ictcp")] ictcp,
}

/// <summary>
///  set input colorspace matrix (from -1 to INT_MAX) (default input)
/// </summary>
public enum ZscaleFilterGenMin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// 709             1            ..FV.......
/// </summary>
[Name("709")] _709,
/// <summary>
/// unspecified     2            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// 470bg           5            ..FV.......
/// </summary>
[Name("470bg")] _470bg,
/// <summary>
/// 170m            6            ..FV.......
/// </summary>
[Name("170m")] _170m,
/// <summary>
/// 2020_ncl        9            ..FV.......
/// </summary>
[Name("2020_ncl")] _2020_ncl,
/// <summary>
/// 2020_cl         10           ..FV.......
/// </summary>
[Name("2020_cl")] _2020_cl,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// gbr             0            ..FV.......
/// </summary>
[Name("gbr")] gbr,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// fcc             4            ..FV.......
/// </summary>
[Name("fcc")] fcc,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// ycgco           8            ..FV.......
/// </summary>
[Name("ycgco")] ycgco,
/// <summary>
/// bt2020nc        9            ..FV.......
/// </summary>
[Name("bt2020nc")] bt2020nc,
/// <summary>
/// bt2020c         10           ..FV.......
/// </summary>
[Name("bt2020c")] bt2020c,
/// <summary>
/// chroma-derived-nc 12           ..FV.......
/// </summary>
[Name("chroma-derived-nc")] chroma_derived_nc,
/// <summary>
/// chroma-derived-c 13           ..FV.......
/// </summary>
[Name("chroma-derived-c")] chroma_derived_c,
/// <summary>
/// ictcp           14           ..FV.......
/// </summary>
[Name("ictcp")] ictcp,
}

/// <summary>
///  set output chroma location (from -1 to 5) (default input)
/// </summary>
public enum ZscaleFilterGenChromal
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// left            0            ..FV.......
/// </summary>
[Name("left")] left,
/// <summary>
/// center          1            ..FV.......
/// </summary>
[Name("center")] center,
/// <summary>
/// topleft         2            ..FV.......
/// </summary>
[Name("topleft")] topleft,
/// <summary>
/// top             3            ..FV.......
/// </summary>
[Name("top")] top,
/// <summary>
/// bottomleft      4            ..FV.......
/// </summary>
[Name("bottomleft")] bottomleft,
/// <summary>
/// bottom          5            ..FV.......
/// </summary>
[Name("bottom")] bottom,
}

/// <summary>
///  set input chroma location (from -1 to 5) (default input)
/// </summary>
public enum ZscaleFilterGenChromalin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// left            0            ..FV.......
/// </summary>
[Name("left")] left,
/// <summary>
/// center          1            ..FV.......
/// </summary>
[Name("center")] center,
/// <summary>
/// topleft         2            ..FV.......
/// </summary>
[Name("topleft")] topleft,
/// <summary>
/// top             3            ..FV.......
/// </summary>
[Name("top")] top,
/// <summary>
/// bottomleft      4            ..FV.......
/// </summary>
[Name("bottomleft")] bottomleft,
/// <summary>
/// bottom          5            ..FV.......
/// </summary>
[Name("bottom")] bottom,
}

/// <summary>
///  set input chroma location (from -1 to 5) (default input)
/// </summary>
public enum ZscaleFilterGenCin
{
/// <summary>
/// input           -1           ..FV.......
/// </summary>
[Name("input")] input,
/// <summary>
/// left            0            ..FV.......
/// </summary>
[Name("left")] left,
/// <summary>
/// center          1            ..FV.......
/// </summary>
[Name("center")] center,
/// <summary>
/// topleft         2            ..FV.......
/// </summary>
[Name("topleft")] topleft,
/// <summary>
/// top             3            ..FV.......
/// </summary>
[Name("top")] top,
/// <summary>
/// bottomleft      4            ..FV.......
/// </summary>
[Name("bottomleft")] bottomleft,
/// <summary>
/// bottom          5            ..FV.......
/// </summary>
[Name("bottom")] bottom,
}

}
