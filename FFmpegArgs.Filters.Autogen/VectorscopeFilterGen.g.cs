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
public class VectorscopeFilterGen : ImageToImageFilter
{
internal VectorscopeFilterGen(ImageMap input) : base("vectorscope",input) { AddMapOut(); }
/// <summary>
///  set vectorscope mode (from 0 to 5) (default gray)
/// </summary>
public VectorscopeFilterGen mode(VectorscopeFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
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
public VectorscopeFilterGen envelope(VectorscopeFilterGenEnvelope envelope) => this.SetOption("envelope", envelope.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGen graticule(VectorscopeFilterGenGraticule graticule) => this.SetOption("graticule", graticule.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public VectorscopeFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set graticule flags (default name)
/// </summary>
public VectorscopeFilterGen flags(VectorscopeFilterGenFlags flags) => this.SetOption("flags", flags.GetAttribute<NameAttribute>().Name);
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
public VectorscopeFilterGen colorspace(VectorscopeFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetAttribute<NameAttribute>().Name);
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
public static class VectorscopeFilterGenExtensions
{
/// <summary>
/// Video vectorscope.
/// </summary>
public static VectorscopeFilterGen VectorscopeFilterGen(this ImageMap input0) => new VectorscopeFilterGen(input0);
/// <summary>
/// Video vectorscope.
/// </summary>
public static VectorscopeFilterGen VectorscopeFilterGen(this ImageMap input0,VectorscopeFilterGenConfig config)
{
var result = new VectorscopeFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.x != null) result.x(config.x.Value);
if(config?.y != null) result.y(config.y.Value);
if(config?.intensity != null) result.intensity(config.intensity.Value);
if(config?.envelope != null) result.envelope(config.envelope.Value);
if(config?.graticule != null) result.graticule(config.graticule.Value);
if(config?.opacity != null) result.opacity(config.opacity.Value);
if(config?.flags != null) result.flags(config.flags.Value);
if(config?.bgopacity != null) result.bgopacity(config.bgopacity.Value);
if(config?.lthreshold != null) result.lthreshold(config.lthreshold.Value);
if(config?.hthreshold != null) result.hthreshold(config.hthreshold.Value);
if(config?.colorspace != null) result.colorspace(config.colorspace.Value);
if(config?.tint0 != null) result.tint0(config.tint0.Value);
if(config?.t0 != null) result.t0(config.t0.Value);
if(config?.tint1 != null) result.tint1(config.tint1.Value);
if(config?.t1 != null) result.t1(config.t1.Value);
return result;
}
}
public class VectorscopeFilterGenConfig
{
/// <summary>
///  set vectorscope mode (from 0 to 5) (default gray)
/// </summary>
public VectorscopeFilterGenMode? mode { get; set; }
/// <summary>
///  set color component on X axis (from 0 to 2) (default 1)
/// </summary>
public int? x { get; set; }
/// <summary>
///  set color component on Y axis (from 0 to 2) (default 2)
/// </summary>
public int? y { get; set; }
/// <summary>
///  set intensity (from 0 to 1) (default 0.004)
/// </summary>
public float? intensity { get; set; }
/// <summary>
///  set envelope (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGenEnvelope? envelope { get; set; }
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGenGraticule? graticule { get; set; }
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public float? opacity { get; set; }
/// <summary>
///  set graticule flags (default name)
/// </summary>
public VectorscopeFilterGenFlags? flags { get; set; }
/// <summary>
///  set background opacity (from 0 to 1) (default 0.3)
/// </summary>
public float? bgopacity { get; set; }
/// <summary>
///  set low threshold (from 0 to 1) (default 0)
/// </summary>
public float? lthreshold { get; set; }
/// <summary>
///  set high threshold (from 0 to 1) (default 1)
/// </summary>
public float? hthreshold { get; set; }
/// <summary>
///  set colorspace (from 0 to 2) (default auto)
/// </summary>
public VectorscopeFilterGenColorspace? colorspace { get; set; }
/// <summary>
///  set 1st tint (from -1 to 1) (default 0)
/// </summary>
public float? tint0 { get; set; }
/// <summary>
///  set 1st tint (from -1 to 1) (default 0)
/// </summary>
public float? t0 { get; set; }
/// <summary>
///  set 2nd tint (from -1 to 1) (default 0)
/// </summary>
public float? tint1 { get; set; }
/// <summary>
///  set 2nd tint (from -1 to 1) (default 0)
/// </summary>
public float? t1 { get; set; }
}
public enum VectorscopeFilterGenMode
{
[Name("gray")] gray,
[Name("tint")] tint,
[Name("color")] color,
[Name("color2")] color2,
[Name("color3")] color3,
[Name("color4")] color4,
[Name("color5")] color5,
}

public enum VectorscopeFilterGenEnvelope
{
[Name("none")] none,
[Name("instant")] instant,
[Name("peak")] peak,
[Name("peak+instant")] peakPlusinstant,
}

public enum VectorscopeFilterGenGraticule
{
[Name("none")] none,
[Name("green")] green,
[Name("color")] color,
[Name("invert")] invert,
}

public enum VectorscopeFilterGenFlags
{
[Name("white")] white,
[Name("black")] black,
[Name("name")] name,
}

public enum VectorscopeFilterGenColorspace
{
[Name("auto")] auto,
[Name("601")] _601,
[Name("709")] _709,
}

}
