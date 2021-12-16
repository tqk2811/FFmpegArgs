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
public class LowshelfFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LowshelfFilterGen(AudioMap input) : base("lowshelf",input) { AddMapOut(); }
/// <summary>
///  set central frequency (from 0 to 999999) (default 100)
/// </summary>
public LowshelfFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowshelfFilterGen width_type(LowshelfFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowshelfFilterGen t(LowshelfFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set shelf transition steep (from 0 to 99999) (default 0.5)
/// </summary>
public LowshelfFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public LowshelfFilterGen gain(double gain) => this.SetOptionRange("gain", gain,-900,900);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public LowshelfFilterGen poles(int poles) => this.SetOptionRange("poles", poles,1,2);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public LowshelfFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public LowshelfFilterGen channels(ChannelLayout channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public LowshelfFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public LowshelfFilterGen transform(LowshelfFilterGenTransform transform) => this.SetOption("transform", transform.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public LowshelfFilterGen a(LowshelfFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowshelfFilterGen precision(LowshelfFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowshelfFilterGen r(LowshelfFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
}
public static class LowshelfFilterGenExtensions
{
/// <summary>
/// Apply a low shelf filter.
/// </summary>
public static LowshelfFilterGen LowshelfFilterGen(this AudioMap input0) => new LowshelfFilterGen(input0);
/// <summary>
/// Apply a low shelf filter.
/// </summary>
public static LowshelfFilterGen LowshelfFilterGen(this AudioMap input0,LowshelfFilterGenConfig config)
{
var result = new LowshelfFilterGen(input0);
if(config?.frequency != null) result.frequency(config.frequency.Value);
if(config?.width_type != null) result.width_type(config.width_type.Value);
if(config?.t != null) result.t(config.t.Value);
if(config?.width != null) result.width(config.width.Value);
if(config?.gain != null) result.gain(config.gain.Value);
if(config?.poles != null) result.poles(config.poles.Value);
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
public class LowshelfFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set central frequency (from 0 to 999999) (default 100)
/// </summary>
public double? frequency { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowshelfFilterGenWidth_type? width_type { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowshelfFilterGenT? t { get; set; }
/// <summary>
///  set shelf transition steep (from 0 to 99999) (default 0.5)
/// </summary>
public double? width { get; set; }
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public double? gain { get; set; }
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public int? poles { get; set; }
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
public LowshelfFilterGenTransform? transform { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public LowshelfFilterGenA? a { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowshelfFilterGenPrecision? precision { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowshelfFilterGenR? r { get; set; }
public string TimelineSupport { get; set; }
}
public enum LowshelfFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum LowshelfFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum LowshelfFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum LowshelfFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum LowshelfFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum LowshelfFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
