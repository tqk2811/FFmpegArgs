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
public class AllpassFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AllpassFilterGen(AudioMap input) : base("allpass",input) { AddMapOut(); }
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public AllpassFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public AllpassFilterGen f(double f) => this.SetOptionRange("f", f,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default h)
/// </summary>
public AllpassFilterGen width_type(AllpassFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default h)
/// </summary>
public AllpassFilterGen t(AllpassFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width (from 0 to 99999) (default 707.1)
/// </summary>
public AllpassFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set filter-width (from 0 to 99999) (default 707.1)
/// </summary>
public AllpassFilterGen w(double w) => this.SetOptionRange("w", w,0,99999);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public AllpassFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public AllpassFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public AllpassFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public AllpassFilterGen c(AV_CH_LAYOUT c) => this.SetOption("c",c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public AllpassFilterGen normalize(bool flag) => this.SetOption("normalize",flag.ToFFmpegFlag());
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public AllpassFilterGen n(bool flag) => this.SetOption("n",flag.ToFFmpegFlag());
/// <summary>
///  set filter order (from 1 to 2) (default 2)
/// </summary>
public AllpassFilterGen order(int order) => this.SetOptionRange("order", order,1,2);
/// <summary>
///  set filter order (from 1 to 2) (default 2)
/// </summary>
public AllpassFilterGen o(int o) => this.SetOptionRange("o", o,1,2);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public AllpassFilterGen transform(AllpassFilterGenTransform transform) => this.SetOption("transform", transform.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public AllpassFilterGen a(AllpassFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public AllpassFilterGen precision(AllpassFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public AllpassFilterGen r(AllpassFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
}
public static class AllpassFilterGenExtensions
{
/// <summary>
/// Apply a two-pole all-pass filter.
/// </summary>
public static AllpassFilterGen AllpassFilterGen(this AudioMap input) => new AllpassFilterGen(input);
}
public enum AllpassFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum AllpassFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum AllpassFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum AllpassFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum AllpassFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum AllpassFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
