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
///  set frequency (from 0 to 999999) (default 500)
/// </summary>
public LowpassFilterGen f(double f) => this.SetOptionRange("f", f,0,999999);
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
///  set width (from 0 to 99999) (default 0.707)
/// </summary>
public LowpassFilterGen w(double w) => this.SetOptionRange("w", w,0,99999);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public LowpassFilterGen poles(int poles) => this.SetOptionRange("poles", poles,1,2);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public LowpassFilterGen p(int p) => this.SetOptionRange("p", p,1,2);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public LowpassFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public LowpassFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public LowpassFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public LowpassFilterGen c(AV_CH_LAYOUT c) => this.SetOption("c",c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public LowpassFilterGen normalize(bool flag) => this.SetOption("normalize",flag.ToFFmpegFlag());
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public LowpassFilterGen n(bool flag) => this.SetOption("n",flag.ToFFmpegFlag());
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
public static LowpassFilterGen LowpassFilterGen(this AudioMap input) => new LowpassFilterGen(input);
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
