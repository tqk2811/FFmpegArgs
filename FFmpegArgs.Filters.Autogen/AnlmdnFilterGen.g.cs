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
public class AnlmdnFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AnlmdnFilterGen(AudioMap input) : base("anlmdn",input) { AddMapOut(); }
/// <summary>
///  set denoising strength (from 1e-05 to 10) (default 1e-05)
/// </summary>
public AnlmdnFilterGen s(float s) => this.SetOptionRange("s", s,1e-05,10);
/// <summary>
///  set patch duration (default 0.002)
/// </summary>
public AnlmdnFilterGen p(TimeSpan p) => this.SetOptionRange("p",p,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set research duration (default 0.006)
/// </summary>
public AnlmdnFilterGen r(TimeSpan r) => this.SetOptionRange("r",r,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public AnlmdnFilterGen o(AnlmdnFilterGenO o) => this.SetOption("o", o.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set smooth factor (from 1 to 15) (default 11)
/// </summary>
public AnlmdnFilterGen m(float m) => this.SetOptionRange("m", m,1,15);
}
public static class AnlmdnFilterGenExtensions
{
/// <summary>
/// Reduce broadband noise from stream using Non-Local Means.
/// </summary>
public static AnlmdnFilterGen AnlmdnFilterGen(this AudioMap input0) => new AnlmdnFilterGen(input0);
/// <summary>
/// Reduce broadband noise from stream using Non-Local Means.
/// </summary>
public static AnlmdnFilterGen AnlmdnFilterGen(this AudioMap input0,AnlmdnFilterGenConfig config)
{
var result = new AnlmdnFilterGen(input0);
if(config?.s != null) result.s(config.s);
if(config?.p != null) result.p(config.p);
if(config?.r != null) result.r(config.r);
if(config?.o != null) result.o(config.o);
if(config?.m != null) result.m(config.m);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class AnlmdnFilterGenConfig
{
/// <summary>
///  set denoising strength (from 1e-05 to 10) (default 1e-05)
/// </summary>
public float s { get; set; }
/// <summary>
///  set patch duration (default 0.002)
/// </summary>
public TimeSpan p { get; set; }
/// <summary>
///  set research duration (default 0.006)
/// </summary>
public TimeSpan r { get; set; }
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public AnlmdnFilterGenO o { get; set; }
/// <summary>
///  set smooth factor (from 1 to 15) (default 11)
/// </summary>
public float m { get; set; }
public string TimelineSupport { get; set; }
}
public enum AnlmdnFilterGenO
{
[Name("i")] i,
[Name("o")] o,
[Name("n")] n,
}

}
