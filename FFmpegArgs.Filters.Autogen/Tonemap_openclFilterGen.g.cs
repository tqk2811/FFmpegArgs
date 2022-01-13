namespace FFmpegArgs.Filters.Autogens
{
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
public static class Tonemap_openclFilterGenExtensions
{
/// <summary>
/// Perform HDR to SDR conversion with tonemapping.
/// </summary>
public static Tonemap_openclFilterGen Tonemap_openclFilterGen(this ImageMap input0) => new Tonemap_openclFilterGen(input0);
/// <summary>
/// Perform HDR to SDR conversion with tonemapping.
/// </summary>
public static Tonemap_openclFilterGen Tonemap_openclFilterGen(this ImageMap input0,Tonemap_openclFilterGenConfig config)
{
var result = new Tonemap_openclFilterGen(input0);
if(config?.tonemap != null) result.tonemap(config.tonemap.Value);
if(config?.transfer != null) result.transfer(config.transfer.Value);
if(config?.matrix != null) result.matrix(config.matrix.Value);
if(config?.primaries != null) result.primaries(config.primaries.Value);
if(config?.range != null) result.range(config.range.Value);
if(config?.format != null) result.format(config.format.Value);
if(config?.peak != null) result.peak(config.peak.Value);
if(config?.param != null) result.param(config.param.Value);
if(config?.desat != null) result.desat(config.desat.Value);
if(config?.threshold != null) result.threshold(config.threshold.Value);
return result;
}
}
public class Tonemap_openclFilterGenConfig
{
/// <summary>
///  tonemap algorithm selection (from 0 to 6) (default none)
/// </summary>
public Tonemap_openclFilterGenTonemap? tonemap { get; set; }
/// <summary>
///  set transfer characteristic (from -1 to INT_MAX) (default bt709)
/// </summary>
public Tonemap_openclFilterGenTransfer? transfer { get; set; }
/// <summary>
///  set colorspace matrix (from -1 to INT_MAX) (default -1)
/// </summary>
public Tonemap_openclFilterGenMatrix? matrix { get; set; }
/// <summary>
///  set color primaries (from -1 to INT_MAX) (default -1)
/// </summary>
public Tonemap_openclFilterGenPrimaries? primaries { get; set; }
/// <summary>
///  set color range (from -1 to INT_MAX) (default -1)
/// </summary>
public Tonemap_openclFilterGenRange? range { get; set; }
/// <summary>
///  output pixel format (default none)
/// </summary>
public PixFmt? format { get; set; }
/// <summary>
///  signal peak override (from 0 to DBL_MAX) (default 0)
/// </summary>
public double? peak { get; set; }
/// <summary>
///  tonemap parameter (from DBL_MIN to DBL_MAX) (default nan)
/// </summary>
public double? param { get; set; }
/// <summary>
///  desaturation parameter (from 0 to DBL_MAX) (default 0.5)
/// </summary>
public double? desat { get; set; }
/// <summary>
///  scene detection threshold (from 0 to DBL_MAX) (default 0.2)
/// </summary>
public double? threshold { get; set; }
}
public enum Tonemap_openclFilterGenTonemap
{
[Name("none")] none,
[Name("linear")] linear,
[Name("gamma")] gamma,
[Name("clip")] clip,
[Name("reinhard")] reinhard,
[Name("hable")] hable,
[Name("mobius")] mobius,
}

public enum Tonemap_openclFilterGenTransfer
{
[Name("bt709")] bt709,
[Name("bt2020")] bt2020,
}

public enum Tonemap_openclFilterGenMatrix
{
[Name("bt709")] bt709,
[Name("bt2020")] bt2020,
}

public enum Tonemap_openclFilterGenPrimaries
{
[Name("bt709")] bt709,
[Name("bt2020")] bt2020,
}

public enum Tonemap_openclFilterGenRange
{
[Name("tv")] tv,
[Name("pc")] pc,
[Name("limited")] limited,
[Name("full")] full,
}

}
