namespace FFmpegArgs.Filters.Autogens
{
public class TonemapFilterGen : ImageToImageFilter,ISliceThreading
{
internal TonemapFilterGen(ImageMap input) : base("tonemap",input) { AddMapOut(); }
/// <summary>
///  tonemap algorithm selection (from 0 to 6) (default none)
/// </summary>
public TonemapFilterGen tonemap(TonemapFilterGenTonemap tonemap) => this.SetOption("tonemap", tonemap.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  tonemap parameter (from DBL_MIN to DBL_MAX) (default nan)
/// </summary>
public TonemapFilterGen param(double param) => this.SetOptionRange("param", param,DBL_MIN,DBL_MAX);
/// <summary>
///  desaturation strength (from 0 to DBL_MAX) (default 2)
/// </summary>
public TonemapFilterGen desat(double desat) => this.SetOptionRange("desat", desat,0,DBL_MAX);
/// <summary>
///  signal peak override (from 0 to DBL_MAX) (default 0)
/// </summary>
public TonemapFilterGen peak(double peak) => this.SetOptionRange("peak", peak,0,DBL_MAX);
}
public static class TonemapFilterGenExtensions
{
/// <summary>
/// Conversion to/from different dynamic ranges.
/// </summary>
public static TonemapFilterGen TonemapFilterGen(this ImageMap input0) => new TonemapFilterGen(input0);
/// <summary>
/// Conversion to/from different dynamic ranges.
/// </summary>
public static TonemapFilterGen TonemapFilterGen(this ImageMap input0,TonemapFilterGenConfig config)
{
var result = new TonemapFilterGen(input0);
if(config?.tonemap != null) result.tonemap(config.tonemap.Value);
if(config?.param != null) result.param(config.param.Value);
if(config?.desat != null) result.desat(config.desat.Value);
if(config?.peak != null) result.peak(config.peak.Value);
return result;
}
}
public class TonemapFilterGenConfig
{
/// <summary>
///  tonemap algorithm selection (from 0 to 6) (default none)
/// </summary>
public TonemapFilterGenTonemap? tonemap { get; set; }
/// <summary>
///  tonemap parameter (from DBL_MIN to DBL_MAX) (default nan)
/// </summary>
public double? param { get; set; }
/// <summary>
///  desaturation strength (from 0 to DBL_MAX) (default 2)
/// </summary>
public double? desat { get; set; }
/// <summary>
///  signal peak override (from 0 to DBL_MAX) (default 0)
/// </summary>
public double? peak { get; set; }
}
public enum TonemapFilterGenTonemap
{
[Name("none")] none,
[Name("linear")] linear,
[Name("gamma")] gamma,
[Name("clip")] clip,
[Name("reinhard")] reinhard,
[Name("hable")] hable,
[Name("mobius")] mobius,
}

}
