namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C vectorscope       V->V       Video vectorscope.
/// </summary>
public class VectorscopeFilterGen : ImageToImageFilter,ICommandSupport
{
internal VectorscopeFilterGen(ImageMap input) : base("vectorscope",input) { AddMapOut(); }
/// <summary>
///  set vectorscope mode (from 0 to 5) (default gray)
/// </summary>
public VectorscopeFilterGen mode(VectorscopeFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set color component on X axis (from 0 to 2) (default 1)
/// </summary>
public VectorscopeFilterGen x(int x) => this.SetOptionRange("x", x,0,2);
/// <summary>
///  set color component on Y axis (from 0 to 2) (default 2)
/// </summary>
public VectorscopeFilterGen y(int y) => this.SetOptionRange("y", y,0,2);
/// <summary>
///  set intensity (from 0 to 1) (default 0.004)
/// </summary>
public VectorscopeFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,0,1);
/// <summary>
///  set envelope (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGen envelope(VectorscopeFilterGenEnvelope envelope) => this.SetOption("envelope", envelope.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGen graticule(VectorscopeFilterGenGraticule graticule) => this.SetOption("graticule", graticule.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public VectorscopeFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set graticule flags (default name)
/// </summary>
public VectorscopeFilterGen flags(VectorscopeFilterGenFlags flags) => this.SetOption("flags", flags.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.3)
/// </summary>
public VectorscopeFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
/// <summary>
///  set low threshold (from 0 to 1) (default 0)
/// </summary>
public VectorscopeFilterGen lthreshold(float lthreshold) => this.SetOptionRange("lthreshold", lthreshold,0,1);
/// <summary>
///  set high threshold (from 0 to 1) (default 1)
/// </summary>
public VectorscopeFilterGen hthreshold(float hthreshold) => this.SetOptionRange("hthreshold", hthreshold,0,1);
/// <summary>
///  set colorspace (from 0 to 2) (default auto)
/// </summary>
public VectorscopeFilterGen colorspace(VectorscopeFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set 1st tint (from -1 to 1) (default 0)
/// </summary>
public VectorscopeFilterGen tint0(float tint0) => this.SetOptionRange("tint0", tint0,-1,1);
/// <summary>
///  set 1st tint (from -1 to 1) (default 0)
/// </summary>
public VectorscopeFilterGen t0(float t0) => this.SetOptionRange("t0", t0,-1,1);
/// <summary>
///  set 2nd tint (from -1 to 1) (default 0)
/// </summary>
public VectorscopeFilterGen tint1(float tint1) => this.SetOptionRange("tint1", tint1,-1,1);
/// <summary>
///  set 2nd tint (from -1 to 1) (default 0)
/// </summary>
public VectorscopeFilterGen t1(float t1) => this.SetOptionRange("t1", t1,-1,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Video vectorscope.
/// </summary>
public static VectorscopeFilterGen VectorscopeFilterGen(this ImageMap input0) => new VectorscopeFilterGen(input0);
}
/// <summary>
///  set vectorscope mode (from 0 to 5) (default gray)
/// </summary>
public enum VectorscopeFilterGenMode
{
/// <summary>
/// gray            0            ..FV.......
/// </summary>
[Name("gray")] gray,
/// <summary>
/// tint            0            ..FV.......
/// </summary>
[Name("tint")] tint,
/// <summary>
/// color           1            ..FV.......
/// </summary>
[Name("color")] color,
/// <summary>
/// color2          2            ..FV.......
/// </summary>
[Name("color2")] color2,
/// <summary>
/// color3          3            ..FV.......
/// </summary>
[Name("color3")] color3,
/// <summary>
/// color4          4            ..FV.......
/// </summary>
[Name("color4")] color4,
/// <summary>
/// color5          5            ..FV.......
/// </summary>
[Name("color5")] color5,
}

/// <summary>
///  set envelope (from 0 to 3) (default none)
/// </summary>
public enum VectorscopeFilterGenEnvelope
{
/// <summary>
/// none            0            ..FV.....T.
/// </summary>
[Name("none")] none,
/// <summary>
/// instant         1            ..FV.....T.
/// </summary>
[Name("instant")] instant,
/// <summary>
/// peak            2            ..FV.....T.
/// </summary>
[Name("peak")] peak,
/// <summary>
/// peak+instant    3            ..FV.....T.
/// </summary>
[Name("peak+instant")] peakPlusinstant,
}

/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public enum VectorscopeFilterGenGraticule
{
/// <summary>
/// none            0            ..FV.......
/// </summary>
[Name("none")] none,
/// <summary>
/// green           1            ..FV.......
/// </summary>
[Name("green")] green,
/// <summary>
/// color           2            ..FV.......
/// </summary>
[Name("color")] color,
/// <summary>
/// invert          3            ..FV.......
/// </summary>
[Name("invert")] invert,
}

/// <summary>
///  set graticule flags (default name)
/// </summary>
public enum VectorscopeFilterGenFlags
{
/// <summary>
/// white                        ..FV.....T. draw white point
/// </summary>
[Name("white")] white,
/// <summary>
/// black                        ..FV.....T. draw black point
/// </summary>
[Name("black")] black,
/// <summary>
/// name                         ..FV.....T. draw point name
/// </summary>
[Name("name")] name,
}

/// <summary>
///  set colorspace (from 0 to 2) (default auto)
/// </summary>
public enum VectorscopeFilterGenColorspace
{
/// <summary>
/// auto            0            ..FV.......
/// </summary>
[Name("auto")] auto,
/// <summary>
/// 601             1            ..FV.......
/// </summary>
[Name("601")] _601,
/// <summary>
/// 709             2            ..FV.......
/// </summary>
[Name("709")] _709,
}

}
