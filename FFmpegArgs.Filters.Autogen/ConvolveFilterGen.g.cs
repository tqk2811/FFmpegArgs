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
}
public enum ConvolveFilterGenImpulse
{
[Name("first")] first,
[Name("all")] all,
}

}
