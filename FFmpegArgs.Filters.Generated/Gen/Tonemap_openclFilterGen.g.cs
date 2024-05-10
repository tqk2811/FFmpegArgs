namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... tonemap_opencl    V->V       Perform HDR to SDR conversion with tonemapping.
/// </summary>
public class Tonemap_openclFilterGen : ImageToImageFilter
{
internal Tonemap_openclFilterGen(ImageMap input) : base("tonemap_opencl",input) { AddMapOut(); }
/// <summary>
///  tonemap algorithm selection (from 0 to 6) (default none)
/// </summary>
public Tonemap_openclFilterGen tonemap(Tonemap_openclFilterGenTonemap tonemap) => this.SetOption("tonemap", tonemap.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set transfer characteristic (from -1 to INT_MAX) (default bt709)
/// </summary>
public Tonemap_openclFilterGen transfer(Tonemap_openclFilterGenTransfer transfer) => this.SetOption("transfer", transfer.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set colorspace matrix (from -1 to INT_MAX) (default -1)
/// </summary>
public Tonemap_openclFilterGen matrix(Tonemap_openclFilterGenMatrix matrix) => this.SetOption("matrix", matrix.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set color primaries (from -1 to INT_MAX) (default -1)
/// </summary>
public Tonemap_openclFilterGen primaries(Tonemap_openclFilterGenPrimaries primaries) => this.SetOption("primaries", primaries.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set color range (from -1 to INT_MAX) (default -1)
/// </summary>
public Tonemap_openclFilterGen range(Tonemap_openclFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  output pixel format (default none)
/// </summary>
public Tonemap_openclFilterGen format(PixFmt format) => this.SetOption("format",format.ToString());
/// <summary>
///  signal peak override (from 0 to DBL_MAX) (default 0)
/// </summary>
public Tonemap_openclFilterGen peak(double peak) => this.SetOptionRange("peak", peak,0,DBL_MAX);
/// <summary>
///  tonemap parameter (from DBL_MIN to DBL_MAX) (default nan)
/// </summary>
public Tonemap_openclFilterGen param(double param) => this.SetOptionRange("param", param,DBL_MIN,DBL_MAX);
/// <summary>
///  desaturation parameter (from 0 to DBL_MAX) (default 0.5)
/// </summary>
public Tonemap_openclFilterGen desat(double desat) => this.SetOptionRange("desat", desat,0,DBL_MAX);
/// <summary>
///  scene detection threshold (from 0 to DBL_MAX) (default 0.2)
/// </summary>
public Tonemap_openclFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,DBL_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Perform HDR to SDR conversion with tonemapping.
/// </summary>
public static Tonemap_openclFilterGen Tonemap_openclFilterGen(this ImageMap input0) => new Tonemap_openclFilterGen(input0);
}
/// <summary>
///  tonemap algorithm selection (from 0 to 6) (default none)
/// </summary>
public enum Tonemap_openclFilterGenTonemap
{
/// <summary>
/// none            0            ..FV.......
/// </summary>
[Name("none")] none,
/// <summary>
/// linear          1            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// gamma           2            ..FV.......
/// </summary>
[Name("gamma")] gamma,
/// <summary>
/// clip            3            ..FV.......
/// </summary>
[Name("clip")] clip,
/// <summary>
/// reinhard        4            ..FV.......
/// </summary>
[Name("reinhard")] reinhard,
/// <summary>
/// hable           5            ..FV.......
/// </summary>
[Name("hable")] hable,
/// <summary>
/// mobius          6            ..FV.......
/// </summary>
[Name("mobius")] mobius,
}

/// <summary>
///  set transfer characteristic (from -1 to INT_MAX) (default bt709)
/// </summary>
public enum Tonemap_openclFilterGenTransfer
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt2020          14           ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
}

/// <summary>
///  set colorspace matrix (from -1 to INT_MAX) (default -1)
/// </summary>
public enum Tonemap_openclFilterGenMatrix
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
}

/// <summary>
///  set color primaries (from -1 to INT_MAX) (default -1)
/// </summary>
public enum Tonemap_openclFilterGenPrimaries
{
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
}

/// <summary>
///  set color range (from -1 to INT_MAX) (default -1)
/// </summary>
public enum Tonemap_openclFilterGenRange
{
/// <summary>
/// tv              1            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              2            ..FV.......
/// </summary>
[Name("pc")] pc,
/// <summary>
/// limited         1            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// full            2            ..FV.......
/// </summary>
[Name("full")] full,
}

}
