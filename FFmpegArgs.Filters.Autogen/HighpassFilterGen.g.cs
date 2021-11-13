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
public class HighpassFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal HighpassFilterGen(AudioMap input) : base("highpass",input) { AddMapOut(); }
/// <summary>
///  set frequency (from 0 to 999999) (default 3000)
/// </summary>
public HighpassFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set frequency (from 0 to 999999) (default 3000)
/// </summary>
public HighpassFilterGen f(double f) => this.SetOptionRange("f", f,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public HighpassFilterGen width_type(HighpassFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public HighpassFilterGen t(HighpassFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set width (from 0 to 99999) (default 0.707)
/// </summary>
public HighpassFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set width (from 0 to 99999) (default 0.707)
/// </summary>
public HighpassFilterGen w(double w) => this.SetOptionRange("w", w,0,99999);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public HighpassFilterGen poles(int poles) => this.SetOptionRange("poles", poles,1,2);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public HighpassFilterGen p(int p) => this.SetOptionRange("p", p,1,2);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public HighpassFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public HighpassFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public HighpassFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public HighpassFilterGen c(AV_CH_LAYOUT c) => this.SetOption("c",c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public HighpassFilterGen normalize(bool flag) => this.SetOption("normalize",flag.ToFFmpegFlag());
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public HighpassFilterGen n(bool flag) => this.SetOption("n",flag.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public HighpassFilterGen transform(HighpassFilterGenTransform transform) => this.SetOption("transform", transform.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public HighpassFilterGen a(HighpassFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public HighpassFilterGen precision(HighpassFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public HighpassFilterGen r(HighpassFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
}
public static class HighpassFilterGenExtensions
{
/// <summary>
/// Apply a high-pass filter with 3dB point frequency.
/// </summary>
public static HighpassFilterGen HighpassFilterGen(this AudioMap input) => new HighpassFilterGen(input);
}
public enum HighpassFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum HighpassFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum HighpassFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum HighpassFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum HighpassFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum HighpassFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
