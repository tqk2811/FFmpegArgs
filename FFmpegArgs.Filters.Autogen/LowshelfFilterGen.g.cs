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
///  set central frequency (from 0 to 999999) (default 100)
/// </summary>
public LowshelfFilterGen f(double f) => this.SetOptionRange("f", f,0,999999);
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
///  set shelf transition steep (from 0 to 99999) (default 0.5)
/// </summary>
public LowshelfFilterGen w(double w) => this.SetOptionRange("w", w,0,99999);
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public LowshelfFilterGen gain(double gain) => this.SetOptionRange("gain", gain,-900,900);
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public LowshelfFilterGen g(double g) => this.SetOptionRange("g", g,-900,900);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public LowshelfFilterGen poles(int poles) => this.SetOptionRange("poles", poles,1,2);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public LowshelfFilterGen p(int p) => this.SetOptionRange("p", p,1,2);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public LowshelfFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public LowshelfFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public LowshelfFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public LowshelfFilterGen c(AV_CH_LAYOUT c) => this.SetOption("c",c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public LowshelfFilterGen normalize(bool flag) => this.SetOption("normalize",flag.ToFFmpegFlag());
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public LowshelfFilterGen n(bool flag) => this.SetOption("n",flag.ToFFmpegFlag());
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