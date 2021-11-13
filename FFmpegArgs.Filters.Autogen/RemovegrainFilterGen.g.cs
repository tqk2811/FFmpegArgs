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
public class RemovegrainFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal RemovegrainFilterGen(ImageMap input) : base("removegrain",input) { AddMapOut(); }
/// <summary>
///  set mode for 1st plane (from 0 to 24) (default 0)
/// </summary>
public RemovegrainFilterGen m0(int m0) => this.SetOptionRange("m0", m0,0,24);
/// <summary>
///  set mode for 2nd plane (from 0 to 24) (default 0)
/// </summary>
public RemovegrainFilterGen m1(int m1) => this.SetOptionRange("m1", m1,0,24);
/// <summary>
///  set mode for 3rd plane (from 0 to 24) (default 0)
/// </summary>
public RemovegrainFilterGen m2(int m2) => this.SetOptionRange("m2", m2,0,24);
/// <summary>
///  set mode for 4th plane (from 0 to 24) (default 0)
/// </summary>
public RemovegrainFilterGen m3(int m3) => this.SetOptionRange("m3", m3,0,24);
}
public static class RemovegrainFilterGenExtensions
{
/// <summary>
/// Remove grain.
/// </summary>
public static RemovegrainFilterGen RemovegrainFilterGen(this ImageMap input) => new RemovegrainFilterGen(input);
}
}
