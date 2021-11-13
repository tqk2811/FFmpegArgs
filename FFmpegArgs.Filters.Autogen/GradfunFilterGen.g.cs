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
public class GradfunFilterGen : ImageToImageFilter,ITimelineSupport
{
internal GradfunFilterGen(ImageMap input) : base("gradfun",input) { AddMapOut(); }
/// <summary>
///  The maximum amount by which the filter will change any one pixel. (from 0.51 to 64) (default 1.2)
/// </summary>
public GradfunFilterGen strength(float strength) => this.SetOptionRange("strength", strength,0.51,64);
/// <summary>
///  The neighborhood to fit the gradient to. (from 4 to 32) (default 16)
/// </summary>
public GradfunFilterGen radius(int radius) => this.SetOptionRange("radius", radius,4,32);
}
public static class GradfunFilterGenExtensions
{
/// <summary>
/// Debands video quickly using gradients.
/// </summary>
public static GradfunFilterGen GradfunFilterGen(this ImageMap input) => new GradfunFilterGen(input);
}
}
