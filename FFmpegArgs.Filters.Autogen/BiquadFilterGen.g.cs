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
public class BiquadFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal BiquadFilterGen(AudioMap input) : base("biquad",input) { AddMapOut(); }
/// <summary>
///  (from INT_MIN to INT_MAX) (default 1)
/// </summary>
public BiquadFilterGen a0(double a0) => this.SetOptionRange("a0", a0,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen a1(double a1) => this.SetOptionRange("a1", a1,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen a2(double a2) => this.SetOptionRange("a2", a2,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen b0(double b0) => this.SetOptionRange("b0", b0,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen b1(double b1) => this.SetOptionRange("b1", b1,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen b2(double b2) => this.SetOptionRange("b2", b2,INT_MIN,INT_MAX);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public BiquadFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public BiquadFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public BiquadFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public BiquadFilterGen c(AV_CH_LAYOUT c) => this.SetOption("c",c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public BiquadFilterGen normalize(bool flag) => this.SetOption("normalize",flag.ToFFmpegFlag());
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public BiquadFilterGen n(bool flag) => this.SetOption("n",flag.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BiquadFilterGen transform(BiquadFilterGenTransform transform) => this.SetOption("transform", transform.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BiquadFilterGen a(BiquadFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BiquadFilterGen precision(BiquadFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BiquadFilterGen r(BiquadFilterGenR r) => this.SetOption("r", r.GetAttribute<NameAttribute>().Name);
}
public static class BiquadFilterGenExtensions
{
/// <summary>
/// Apply a biquad IIR filter with the given coefficients.
/// </summary>
public static BiquadFilterGen BiquadFilterGen(this AudioMap input) => new BiquadFilterGen(input);
}
public enum BiquadFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum BiquadFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum BiquadFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum BiquadFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
