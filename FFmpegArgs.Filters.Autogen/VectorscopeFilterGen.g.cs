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
///  set vectorscope mode (from 0 to 5) (default gray)
/// </summary>
public VectorscopeFilterGen m(VectorscopeFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
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
///  set intensity (from 0 to 1) (default 0.004)
/// </summary>
public VectorscopeFilterGen i(float i) => this.SetOptionRange("i", i,0,1);
/// <summary>
///  set envelope (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGen envelope(VectorscopeFilterGenEnvelope envelope) => this.SetOption("envelope", envelope.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set envelope (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGen e(VectorscopeFilterGenE e) => this.SetOption("e", e.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGen graticule(VectorscopeFilterGenGraticule graticule) => this.SetOption("graticule", graticule.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public VectorscopeFilterGen g(VectorscopeFilterGenG g) => this.SetOption("g", g.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public VectorscopeFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public VectorscopeFilterGen o(float o) => this.SetOptionRange("o", o,0,1);
/// <summary>
///  set graticule flags (default name)
/// </summary>
public VectorscopeFilterGen flags(VectorscopeFilterGenFlags flags) => this.SetOption("flags", flags.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule flags (default name)
/// </summary>
public VectorscopeFilterGen f(VectorscopeFilterGenF f) => this.SetOption("f", f.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.3)
/// </summary>
public VectorscopeFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.3)
/// </summary>
public VectorscopeFilterGen b(float b) => this.SetOptionRange("b", b,0,1);
/// <summary>
///  set low threshold (from 0 to 1) (default 0)
/// </summary>
public VectorscopeFilterGen lthreshold(float lthreshold) => this.SetOptionRange("lthreshold", lthreshold,0,1);
/// <summary>
///  set low threshold (from 0 to 1) (default 0)
/// </summary>
public VectorscopeFilterGen l(float l) => this.SetOptionRange("l", l,0,1);
/// <summary>
///  set high threshold (from 0 to 1) (default 1)
/// </summary>
public VectorscopeFilterGen hthreshold(float hthreshold) => this.SetOptionRange("hthreshold", hthreshold,0,1);
/// <summary>
///  set high threshold (from 0 to 1) (default 1)
/// </summary>
public VectorscopeFilterGen h(float h) => this.SetOptionRange("h", h,0,1);
/// <summary>
///  set colorspace (from 0 to 2) (default auto)
/// </summary>
public VectorscopeFilterGen colorspace(VectorscopeFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set colorspace (from 0 to 2) (default auto)
/// </summary>
public VectorscopeFilterGen c(VectorscopeFilterGenC c) => this.SetOption("c", c.GetAttribute<NameAttribute>().Name);
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

public enum VectorscopeFilterGenM
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

public enum VectorscopeFilterGenE
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

public enum VectorscopeFilterGenG
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

public enum VectorscopeFilterGenF
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

public enum VectorscopeFilterGenC
{
[Name("auto")] auto,
[Name("601")] _601,
[Name("709")] _709,
}

}
