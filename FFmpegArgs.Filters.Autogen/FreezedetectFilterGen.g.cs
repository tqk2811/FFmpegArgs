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
public FreezedetectFilterGen noise(double noise) => this.SetOptionRange("noise", noise,0,1);
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
/// <summary>
/// Detects frozen video input.
/// </summary>
public static FreezedetectFilterGen FreezedetectFilterGen(this ImageMap input0,FreezedetectFilterGenConfig config)
{
var result = new FreezedetectFilterGen(input0);
if(config?.noise != null) result.noise(config.noise);
if(config?.duration != null) result.duration(config.duration);
return result;
}
}
public class FreezedetectFilterGenConfig
{
/// <summary>
///  set noise tolerance (from 0 to 1) (default 0.001)
/// </summary>
public double noise { get; set; }
/// <summary>
///  set minimum duration in seconds (default 2)
/// </summary>
public TimeSpan duration { get; set; }
}
}
