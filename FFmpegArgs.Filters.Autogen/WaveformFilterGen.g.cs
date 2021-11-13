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
public class WaveformFilterGen : ImageToImageFilter,ISliceThreading
{
internal WaveformFilterGen(ImageMap input) : base("waveform",input) { AddMapOut(); }
/// <summary>
///  set mode (from 0 to 1) (default column)
/// </summary>
public WaveformFilterGen mode(WaveformFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set mode (from 0 to 1) (default column)
/// </summary>
public WaveformFilterGen m(WaveformFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set intensity (from 0 to 1) (default 0.04)
/// </summary>
public WaveformFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,0,1);
/// <summary>
///  set intensity (from 0 to 1) (default 0.04)
/// </summary>
public WaveformFilterGen i(float i) => this.SetOptionRange("i", i,0,1);
/// <summary>
///  set mirroring (default true)
/// </summary>
public WaveformFilterGen mirror(bool flag) => this.SetOption("mirror",flag.ToFFmpegFlag());
/// <summary>
///  set mirroring (default true)
/// </summary>
public WaveformFilterGen r(bool flag) => this.SetOption("r",flag.ToFFmpegFlag());
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public WaveformFilterGen display(WaveformFilterGenDisplay display) => this.SetOption("display", display.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public WaveformFilterGen d(WaveformFilterGenD d) => this.SetOption("d", d.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set components to display (from 1 to 15) (default 1)
/// </summary>
public WaveformFilterGen components(int components) => this.SetOptionRange("components", components,1,15);
/// <summary>
///  set components to display (from 1 to 15) (default 1)
/// </summary>
public WaveformFilterGen c(int c) => this.SetOptionRange("c", c,1,15);
/// <summary>
///  set envelope to display (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGen envelope(WaveformFilterGenEnvelope envelope) => this.SetOption("envelope", envelope.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set envelope to display (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGen e(WaveformFilterGenE e) => this.SetOption("e", e.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter (from 0 to 7) (default lowpass)
/// </summary>
public WaveformFilterGen filter(WaveformFilterGenFilter filter) => this.SetOption("filter", filter.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter (from 0 to 7) (default lowpass)
/// </summary>
public WaveformFilterGen f(WaveformFilterGenF f) => this.SetOption("f", f.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGen graticule(WaveformFilterGenGraticule graticule) => this.SetOption("graticule", graticule.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGen g(WaveformFilterGenG g) => this.SetOption("g", g.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public WaveformFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public WaveformFilterGen o(float o) => this.SetOptionRange("o", o,0,1);
/// <summary>
///  set graticule flags (default numbers)
/// </summary>
public WaveformFilterGen flags(WaveformFilterGenFlags flags) => this.SetOption("flags", flags.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule flags (default numbers)
/// </summary>
public WaveformFilterGen fl(WaveformFilterGenFl fl) => this.SetOption("fl", fl.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set scale (from 0 to 2) (default digital)
/// </summary>
public WaveformFilterGen scale(WaveformFilterGenScale scale) => this.SetOption("scale", scale.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set scale (from 0 to 2) (default digital)
/// </summary>
public WaveformFilterGen s(WaveformFilterGenS s) => this.SetOption("s", s.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.75)
/// </summary>
public WaveformFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.75)
/// </summary>
public WaveformFilterGen b(float b) => this.SetOptionRange("b", b,0,1);
/// <summary>
///  set 1st tint (from -1 to 1) (default 0)
/// </summary>
public WaveformFilterGen tint0(float tint0) => this.SetOptionRange("tint0", tint0,-1,1);
/// <summary>
///  set 1st tint (from -1 to 1) (default 0)
/// </summary>
public WaveformFilterGen t0(float t0) => this.SetOptionRange("t0", t0,-1,1);
/// <summary>
///  set 2nd tint (from -1 to 1) (default 0)
/// </summary>
public WaveformFilterGen tint1(float tint1) => this.SetOptionRange("tint1", tint1,-1,1);
/// <summary>
///  set 2nd tint (from -1 to 1) (default 0)
/// </summary>
public WaveformFilterGen t1(float t1) => this.SetOptionRange("t1", t1,-1,1);
}
public static class WaveformFilterGenExtensions
{
/// <summary>
/// Video waveform monitor.
/// </summary>
public static WaveformFilterGen WaveformFilterGen(this ImageMap input) => new WaveformFilterGen(input);
}
public enum WaveformFilterGenMode
{
[Name("row")] row,
[Name("column")] column,
}

public enum WaveformFilterGenM
{
[Name("row")] row,
[Name("column")] column,
}

public enum WaveformFilterGenDisplay
{
[Name("overlay")] overlay,
[Name("stack")] stack,
[Name("parade")] parade,
}

public enum WaveformFilterGenD
{
[Name("overlay")] overlay,
[Name("stack")] stack,
[Name("parade")] parade,
}

public enum WaveformFilterGenEnvelope
{
[Name("none")] none,
[Name("instant")] instant,
[Name("peak")] peak,
[Name("peak+instant")] peakPlusinstant,
}

public enum WaveformFilterGenE
{
[Name("none")] none,
[Name("instant")] instant,
[Name("peak")] peak,
[Name("peak+instant")] peakPlusinstant,
}

public enum WaveformFilterGenFilter
{
[Name("lowpass")] lowpass,
[Name("flat")] flat,
[Name("aflat")] aflat,
[Name("chroma")] chroma,
[Name("color")] color,
[Name("acolor")] acolor,
[Name("xflat")] xflat,
[Name("yflat")] yflat,
}

public enum WaveformFilterGenF
{
[Name("lowpass")] lowpass,
[Name("flat")] flat,
[Name("aflat")] aflat,
[Name("chroma")] chroma,
[Name("color")] color,
[Name("acolor")] acolor,
[Name("xflat")] xflat,
[Name("yflat")] yflat,
}

public enum WaveformFilterGenGraticule
{
[Name("none")] none,
[Name("green")] green,
[Name("orange")] orange,
[Name("invert")] invert,
}

public enum WaveformFilterGenG
{
[Name("none")] none,
[Name("green")] green,
[Name("orange")] orange,
[Name("invert")] invert,
}

public enum WaveformFilterGenFlags
{
[Name("numbers")] numbers,
[Name("dots")] dots,
}

public enum WaveformFilterGenFl
{
[Name("numbers")] numbers,
[Name("dots")] dots,
}

public enum WaveformFilterGenScale
{
[Name("digital")] digital,
[Name("millivolts")] millivolts,
[Name("ire")] ire,
}

public enum WaveformFilterGenS
{
[Name("digital")] digital,
[Name("millivolts")] millivolts,
[Name("ire")] ire,
}

}
