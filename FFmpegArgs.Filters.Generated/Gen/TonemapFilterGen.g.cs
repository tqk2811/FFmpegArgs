namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. tonemap           V-&gt;V       Conversion to/from different dynamic ranges.
/// </summary>
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
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Conversion to/from different dynamic ranges.
/// </summary>
public static TonemapFilterGen TonemapFilterGen(this ImageMap input0) => new TonemapFilterGen(input0);
}
/// <summary>
///  tonemap algorithm selection (from 0 to 6) (default none)
/// </summary>
public enum TonemapFilterGenTonemap
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

}
