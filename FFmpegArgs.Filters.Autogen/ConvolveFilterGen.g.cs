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
public class ConvolveFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal ConvolveFilterGen(params ImageMap[] inputs) : base("convolve",inputs) { AddMapOut(); }
/// <summary>
///  set planes to convolve (from 0 to 15) (default 7)
/// </summary>
public ConvolveFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  when to process impulses (from 0 to 1) (default all)
/// </summary>
public ConvolveFilterGen impulse(ConvolveFilterGenImpulse impulse) => this.SetOption("impulse", impulse.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set noise (from 0 to 1) (default 1e-07)
/// </summary>
public ConvolveFilterGen noise(float noise) => this.SetOptionRange("noise", noise,0,1);
}
public static class ConvolveFilterGenExtensions
{
/// <summary>
/// Convolve first video stream with second video stream.
/// </summary>
public static ConvolveFilterGen ConvolveFilterGen(this ImageMap input0, ImageMap input1) => new ConvolveFilterGen(input0, input1);
/// <summary>
/// Convolve first video stream with second video stream.
/// </summary>
public static ConvolveFilterGen ConvolveFilterGen(this ImageMap input0, ImageMap input1,ConvolveFilterGenConfig config)
{
var result = new ConvolveFilterGen(input0, input1);
if(config?.planes != null) result.planes(config.planes);
if(config?.impulse != null) result.impulse(config.impulse);
if(config?.noise != null) result.noise(config.noise);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class ConvolveFilterGenConfig
{
/// <summary>
///  set planes to convolve (from 0 to 15) (default 7)
/// </summary>
public int planes { get; set; }
/// <summary>
///  when to process impulses (from 0 to 1) (default all)
/// </summary>
public ConvolveFilterGenImpulse impulse { get; set; }
/// <summary>
///  set noise (from 0 to 1) (default 1e-07)
/// </summary>
public float noise { get; set; }
public string TimelineSupport { get; set; }
}
public enum ConvolveFilterGenImpulse
{
[Name("first")] first,
[Name("all")] all,
}

}
