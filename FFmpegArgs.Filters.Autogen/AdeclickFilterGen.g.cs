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
public class AdeclickFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading
{
internal AdeclickFilterGen(AudioMap input) : base("adeclick",input) { AddMapOut(); }
/// <summary>
///  set window size (from 10 to 100) (default 55)
/// </summary>
public AdeclickFilterGen window(double window) => this.SetOptionRange("window", window,10,100);
/// <summary>
///  set window size (from 10 to 100) (default 55)
/// </summary>
public AdeclickFilterGen w(double w) => this.SetOptionRange("w", w,10,100);
/// <summary>
///  set window overlap (from 50 to 95) (default 75)
/// </summary>
public AdeclickFilterGen overlap(double overlap) => this.SetOptionRange("overlap", overlap,50,95);
/// <summary>
///  set window overlap (from 50 to 95) (default 75)
/// </summary>
public AdeclickFilterGen o(double o) => this.SetOptionRange("o", o,50,95);
/// <summary>
///  set autoregression order (from 0 to 25) (default 2)
/// </summary>
public AdeclickFilterGen arorder(double arorder) => this.SetOptionRange("arorder", arorder,0,25);
/// <summary>
///  set autoregression order (from 0 to 25) (default 2)
/// </summary>
public AdeclickFilterGen a(double a) => this.SetOptionRange("a", a,0,25);
/// <summary>
///  set threshold (from 1 to 100) (default 2)
/// </summary>
public AdeclickFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,1,100);
/// <summary>
///  set threshold (from 1 to 100) (default 2)
/// </summary>
public AdeclickFilterGen t(double t) => this.SetOptionRange("t", t,1,100);
/// <summary>
///  set burst fusion (from 0 to 10) (default 2)
/// </summary>
public AdeclickFilterGen burst(double burst) => this.SetOptionRange("burst", burst,0,10);
/// <summary>
///  set burst fusion (from 0 to 10) (default 2)
/// </summary>
public AdeclickFilterGen b(double b) => this.SetOptionRange("b", b,0,10);
/// <summary>
///  set overlap method (from 0 to 1) (default add)
/// </summary>
public AdeclickFilterGen method(AdeclickFilterGenMethod method) => this.SetOption("method", method.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set overlap method (from 0 to 1) (default add)
/// </summary>
public AdeclickFilterGen m(AdeclickFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
}
public static class AdeclickFilterGenExtensions
{
/// <summary>
/// Remove impulsive noise from input audio.
/// </summary>
public static AdeclickFilterGen AdeclickFilterGen(this AudioMap input0) => new AdeclickFilterGen(input0);
}
public enum AdeclickFilterGenMethod
{
[Name("add")] add,
[Name("a")] a,
[Name("save")] save,
[Name("s")] s,
}

public enum AdeclickFilterGenM
{
[Name("add")] add,
[Name("a")] a,
[Name("save")] save,
[Name("s")] s,
}

}
