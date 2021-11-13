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
public class FreezedetectFilterGen : ImageToImageFilter
{
internal FreezedetectFilterGen(ImageMap input) : base("freezedetect",input) { AddMapOut(); }
/// <summary>
///  set noise tolerance (from 0 to 1) (default 0.001)
/// </summary>
public FreezedetectFilterGen n(double n) => this.SetOptionRange("n", n,0,1);
/// <summary>
///  set noise tolerance (from 0 to 1) (default 0.001)
/// </summary>
public FreezedetectFilterGen noise(double noise) => this.SetOptionRange("noise", noise,0,1);
/// <summary>
///  set minimum duration in seconds (default 2)
/// </summary>
public FreezedetectFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set minimum duration in seconds (default 2)
/// </summary>
public FreezedetectFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
}
public static class FreezedetectFilterGenExtensions
{
/// <summary>
/// Detects frozen video input.
/// </summary>
public static FreezedetectFilterGen FreezedetectFilterGen(this ImageMap input0) => new FreezedetectFilterGen(input0);
}
}
