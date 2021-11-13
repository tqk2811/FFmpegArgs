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
public class LagfunFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LagfunFilterGen(ImageMap input) : base("lagfun",input) { AddMapOut(); }
/// <summary>
///  set decay (from 0 to 1) (default 0.95)
/// </summary>
public LagfunFilterGen decay(float decay) => this.SetOptionRange("decay", decay,0,1);
/// <summary>
///  set what planes to filter (default F)
/// </summary>
public LagfunFilterGen planes(LagfunFilterGenPlanes planes) => this.SetOption("planes", planes.GetAttribute<NameAttribute>().Name);
}
public static class LagfunFilterGenExtensions
{
/// <summary>
/// Slowly update darker pixels.
/// </summary>
public static LagfunFilterGen LagfunFilterGen(this ImageMap input) => new LagfunFilterGen(input);
}
public enum LagfunFilterGenPlanes
{
}

}
