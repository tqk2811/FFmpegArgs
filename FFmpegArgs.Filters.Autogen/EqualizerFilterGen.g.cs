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
public class EqualizerFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal EqualizerFilterGen(AudioMap input) : base("equalizer",input) { AddMapOut(); }
/// <summary>
///  set central frequency (from 0 to 999999) (default 0)
/// </summary>
public EqualizerFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public EqualizerFilterGen width_type(EqualizerFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public EqualizerFilterGen t(EqualizerFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set band-width (from 0 to 99999) (default 1)
/// </summary>
public EqualizerFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public EqualizerFilterGen gain(double gain) => this.SetOptionRange("gain", gain,-900,900);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public EqualizerFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public EqualizerFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public EqualizerFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public EqualizerFilterGen transform(EqualizerFilterGenTransform transform) => this.SetOption("transform", transform.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public EqualizerFilterGen a(EqualizerFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public EqualizerFilterGen precision(EqualizerFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public EqualizerFilterGen r(EqualizerFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
}
public static class EqualizerFilterGenExtensions
{
/// <summary>
/// Apply two-pole peaking equalization (EQ) filter.
/// </summary>
public static EqualizerFilterGen EqualizerFilterGen(this AudioMap input0) => new EqualizerFilterGen(input0);
/// <summary>
/// Apply two-pole peaking equalization (EQ) filter.
/// </summary>
public static EqualizerFilterGen EqualizerFilterGen(this AudioMap input0,EqualizerFilterGenConfig config)
{
var result = new EqualizerFilterGen(input0);
if(config?.frequency != null) result.frequency(config.frequency);
if(config?.width_type != null) result.width_type(config.width_type);
if(config?.t != null) result.t(config.t);
if(config?.width != null) result.width(config.width);
if(config?.gain != null) result.gain(config.gain);
if(config?.mix != null) result.mix(config.mix);
if(config?.channels != null) result.channels(config.channels);
if(config?.normalize != null) result.normalize(config.normalize);
if(config?.transform != null) result.transform(config.transform);
if(config?.a != null) result.a(config.a);
if(config?.precision != null) result.precision(config.precision);
if(config?.r != null) result.r(config.r);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class EqualizerFilterGenConfig
{
/// <summary>
///  set central frequency (from 0 to 999999) (default 0)
/// </summary>
public double frequency { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public EqualizerFilterGenWidth_type width_type { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public EqualizerFilterGenT t { get; set; }
/// <summary>
///  set band-width (from 0 to 99999) (default 1)
/// </summary>
public double width { get; set; }
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public double gain { get; set; }
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public double mix { get; set; }
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public AV_CH_LAYOUT channels { get; set; }
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public bool normalize { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public EqualizerFilterGenTransform transform { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public EqualizerFilterGenA a { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public EqualizerFilterGenPrecision precision { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public EqualizerFilterGenR r { get; set; }
public string TimelineSupport { get; set; }
}
public enum EqualizerFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum EqualizerFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum EqualizerFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum EqualizerFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum EqualizerFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum EqualizerFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
