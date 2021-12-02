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
public class LowpassFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LowpassFilterGen(AudioMap input) : base("lowpass",input) { AddMapOut(); }
/// <summary>
///  set frequency (from 0 to 999999) (default 500)
/// </summary>
public LowpassFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowpassFilterGen width_type(LowpassFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowpassFilterGen t(LowpassFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set width (from 0 to 99999) (default 0.707)
/// </summary>
public LowpassFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public LowpassFilterGen poles(int poles) => this.SetOptionRange("poles", poles,1,2);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public LowpassFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public LowpassFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public LowpassFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public LowpassFilterGen transform(LowpassFilterGenTransform transform) => this.SetOption("transform", transform.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public LowpassFilterGen a(LowpassFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowpassFilterGen precision(LowpassFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowpassFilterGen r(LowpassFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
}
public static class LowpassFilterGenExtensions
{
/// <summary>
/// Apply a low-pass filter with 3dB point frequency.
/// </summary>
public static LowpassFilterGen LowpassFilterGen(this AudioMap input0) => new LowpassFilterGen(input0);
/// <summary>
/// Apply a low-pass filter with 3dB point frequency.
/// </summary>
public static LowpassFilterGen LowpassFilterGen(this AudioMap input0,LowpassFilterGenConfig config)
{
var result = new LowpassFilterGen(input0);
if(config?.frequency != null) result.frequency(config.frequency);
if(config?.width_type != null) result.width_type(config.width_type);
if(config?.t != null) result.t(config.t);
if(config?.width != null) result.width(config.width);
if(config?.poles != null) result.poles(config.poles);
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
public class LowpassFilterGenConfig
{
/// <summary>
///  set frequency (from 0 to 999999) (default 500)
/// </summary>
public double frequency { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowpassFilterGenWidth_type width_type { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowpassFilterGenT t { get; set; }
/// <summary>
///  set width (from 0 to 99999) (default 0.707)
/// </summary>
public double width { get; set; }
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public int poles { get; set; }
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
public LowpassFilterGenTransform transform { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public LowpassFilterGenA a { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowpassFilterGenPrecision precision { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowpassFilterGenR r { get; set; }
public string TimelineSupport { get; set; }
}
public enum LowpassFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum LowpassFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum LowpassFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum LowpassFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum LowpassFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum LowpassFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
