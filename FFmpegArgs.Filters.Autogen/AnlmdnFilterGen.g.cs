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
public static AnlmdnFilterGen AnlmdnFilterGen(this AudioMap input) => new AnlmdnFilterGen(input);
}
public enum AnlmdnFilterGenO
{
[Name("i")] i,
[Name("o")] o,
[Name("n")] n,
}

}
