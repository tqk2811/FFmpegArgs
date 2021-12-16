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
public class BandpassFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal BandpassFilterGen(AudioMap input) : base("bandpass",input) { AddMapOut(); }
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public BandpassFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public BandpassFilterGen width_type(BandpassFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public BandpassFilterGen t(BandpassFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set band-width (from 0 to 99999) (default 0.5)
/// </summary>
public BandpassFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  use constant skirt gain (default false)
/// </summary>
public BandpassFilterGen csg(bool csg) => this.SetOption("csg",csg.ToFFmpegFlag());
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public BandpassFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public BandpassFilterGen channels(ChannelLayout channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public BandpassFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BandpassFilterGen transform(BandpassFilterGenTransform transform) => this.SetOption("transform", transform.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BandpassFilterGen a(BandpassFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BandpassFilterGen precision(BandpassFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BandpassFilterGen r(BandpassFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
}
public static class BandpassFilterGenExtensions
{
/// <summary>
/// Apply a two-pole Butterworth band-pass filter.
/// </summary>
public static BandpassFilterGen BandpassFilterGen(this AudioMap input0) => new BandpassFilterGen(input0);
/// <summary>
/// Apply a two-pole Butterworth band-pass filter.
/// </summary>
public static BandpassFilterGen BandpassFilterGen(this AudioMap input0,BandpassFilterGenConfig config)
{
var result = new BandpassFilterGen(input0);
if(config?.frequency != null) result.frequency(config.frequency.Value);
if(config?.width_type != null) result.width_type(config.width_type.Value);
if(config?.t != null) result.t(config.t.Value);
if(config?.width != null) result.width(config.width.Value);
if(config?.csg != null) result.csg(config.csg.Value);
if(config?.mix != null) result.mix(config.mix.Value);
if(config?.channels != null) result.channels(config.channels.Value);
if(config?.normalize != null) result.normalize(config.normalize.Value);
if(config?.transform != null) result.transform(config.transform.Value);
if(config?.a != null) result.a(config.a.Value);
if(config?.precision != null) result.precision(config.precision.Value);
if(config?.r != null) result.r(config.r.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class BandpassFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public double? frequency { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public BandpassFilterGenWidth_type? width_type { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public BandpassFilterGenT? t { get; set; }
/// <summary>
///  set band-width (from 0 to 99999) (default 0.5)
/// </summary>
public double? width { get; set; }
/// <summary>
///  use constant skirt gain (default false)
/// </summary>
public bool? csg { get; set; }
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public double? mix { get; set; }
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public ChannelLayout? channels { get; set; }
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public bool? normalize { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BandpassFilterGenTransform? transform { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BandpassFilterGenA? a { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BandpassFilterGenPrecision? precision { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BandpassFilterGenR? r { get; set; }
public string TimelineSupport { get; set; }
}
public enum BandpassFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum BandpassFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum BandpassFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum BandpassFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum BandpassFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum BandpassFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
