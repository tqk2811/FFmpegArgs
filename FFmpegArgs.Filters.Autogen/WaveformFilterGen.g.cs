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
///  set intensity (from 0 to 1) (default 0.04)
/// </summary>
public WaveformFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,0,1);
/// <summary>
///  set mirroring (default true)
/// </summary>
public WaveformFilterGen mirror(bool mirror) => this.SetOption("mirror",mirror.ToFFmpegFlag());
/// <summary>
///  set mirroring (default true)
/// </summary>
public WaveformFilterGen r(bool r) => this.SetOption("r",r.ToFFmpegFlag());
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public WaveformFilterGen display(WaveformFilterGenDisplay display) => this.SetOption("display", display.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set components to display (from 1 to 15) (default 1)
/// </summary>
public WaveformFilterGen components(int components) => this.SetOptionRange("components", components,1,15);
/// <summary>
///  set envelope to display (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGen envelope(WaveformFilterGenEnvelope envelope) => this.SetOption("envelope", envelope.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter (from 0 to 7) (default lowpass)
/// </summary>
public WaveformFilterGen filter(WaveformFilterGenFilter filter) => this.SetOption("filter", filter.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGen graticule(WaveformFilterGenGraticule graticule) => this.SetOption("graticule", graticule.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public WaveformFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set graticule flags (default numbers)
/// </summary>
public WaveformFilterGen flags(WaveformFilterGenFlags flags) => this.SetOption("flags", flags.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set scale (from 0 to 2) (default digital)
/// </summary>
public WaveformFilterGen scale(WaveformFilterGenScale scale) => this.SetOption("scale", scale.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.75)
/// </summary>
public WaveformFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
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
public static WaveformFilterGen WaveformFilterGen(this ImageMap input0) => new WaveformFilterGen(input0);
/// <summary>
/// Video waveform monitor.
/// </summary>
public static WaveformFilterGen WaveformFilterGen(this ImageMap input0,WaveformFilterGenConfig config)
{
var result = new WaveformFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.intensity != null) result.intensity(config.intensity.Value);
if(config?.mirror != null) result.mirror(config.mirror.Value);
if(config?.r != null) result.r(config.r.Value);
if(config?.display != null) result.display(config.display.Value);
if(config?.components != null) result.components(config.components.Value);
if(config?.envelope != null) result.envelope(config.envelope.Value);
if(config?.filter != null) result.filter(config.filter.Value);
if(config?.graticule != null) result.graticule(config.graticule.Value);
if(config?.opacity != null) result.opacity(config.opacity.Value);
if(config?.flags != null) result.flags(config.flags.Value);
if(config?.scale != null) result.scale(config.scale.Value);
if(config?.bgopacity != null) result.bgopacity(config.bgopacity.Value);
if(config?.tint0 != null) result.tint0(config.tint0.Value);
if(config?.t0 != null) result.t0(config.t0.Value);
if(config?.tint1 != null) result.tint1(config.tint1.Value);
if(config?.t1 != null) result.t1(config.t1.Value);
return result;
}
}
public class WaveformFilterGenConfig
{
/// <summary>
///  set mode (from 0 to 1) (default column)
/// </summary>
public WaveformFilterGenMode? mode { get; set; }
/// <summary>
///  set intensity (from 0 to 1) (default 0.04)
/// </summary>
public float? intensity { get; set; }
/// <summary>
///  set mirroring (default true)
/// </summary>
public bool? mirror { get; set; }
/// <summary>
///  set mirroring (default true)
/// </summary>
public bool? r { get; set; }
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public WaveformFilterGenDisplay? display { get; set; }
/// <summary>
///  set components to display (from 1 to 15) (default 1)
/// </summary>
public int? components { get; set; }
/// <summary>
///  set envelope to display (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGenEnvelope? envelope { get; set; }
/// <summary>
///  set filter (from 0 to 7) (default lowpass)
/// </summary>
public WaveformFilterGenFilter? filter { get; set; }
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGenGraticule? graticule { get; set; }
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public float? opacity { get; set; }
/// <summary>
///  set graticule flags (default numbers)
/// </summary>
public WaveformFilterGenFlags? flags { get; set; }
/// <summary>
///  set scale (from 0 to 2) (default digital)
/// </summary>
public WaveformFilterGenScale? scale { get; set; }
/// <summary>
///  set background opacity (from 0 to 1) (default 0.75)
/// </summary>
public float? bgopacity { get; set; }
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
public enum WaveformFilterGenMode
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

public enum WaveformFilterGenEnvelope
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

public enum WaveformFilterGenGraticule
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

public enum WaveformFilterGenScale
{
[Name("digital")] digital,
[Name("millivolts")] millivolts,
[Name("ire")] ire,
}

}
