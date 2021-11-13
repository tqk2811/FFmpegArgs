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
public class TrebleFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal TrebleFilterGen(AudioMap input) : base("treble",input) { AddMapOut(); }
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public TrebleFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public TrebleFilterGen f(double f) => this.SetOptionRange("f", f,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public TrebleFilterGen width_type(TrebleFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public TrebleFilterGen t(TrebleFilterGenT t) => this.SetOption("t", t.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set shelf transition steep (from 0 to 99999) (default 0.5)
/// </summary>
public TrebleFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set shelf transition steep (from 0 to 99999) (default 0.5)
/// </summary>
public TrebleFilterGen w(double w) => this.SetOptionRange("w", w,0,99999);
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public TrebleFilterGen gain(double gain) => this.SetOptionRange("gain", gain,-900,900);
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public TrebleFilterGen g(double g) => this.SetOptionRange("g", g,-900,900);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public TrebleFilterGen poles(int poles) => this.SetOptionRange("poles", poles,1,2);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public TrebleFilterGen p(int p) => this.SetOptionRange("p", p,1,2);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public TrebleFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public TrebleFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public TrebleFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public TrebleFilterGen c(AV_CH_LAYOUT c) => this.SetOption("c",c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public TrebleFilterGen normalize(bool flag) => this.SetOption("normalize",flag.ToFFmpegFlag());
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public TrebleFilterGen n(bool flag) => this.SetOption("n",flag.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public TrebleFilterGen transform(TrebleFilterGenTransform transform) => this.SetOption("transform", transform.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public TrebleFilterGen a(TrebleFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public TrebleFilterGen precision(TrebleFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public TrebleFilterGen r(TrebleFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
}
public static class TrebleFilterGenExtensions
{
/// <summary>
/// Boost or cut upper frequencies.
/// </summary>
public static TrebleFilterGen TrebleFilterGen(this AudioMap input) => new TrebleFilterGen(input);
}
public enum TrebleFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum TrebleFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum TrebleFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum TrebleFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum TrebleFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum TrebleFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
