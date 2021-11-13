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
public class GreyedgeFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal GreyedgeFilterGen(ImageMap input) : base("greyedge",input) { AddMapOut(); }
/// <summary>
///  set differentiation order (from 0 to 2) (default 1)
/// </summary>
public GreyedgeFilterGen difford(int difford) => this.SetOptionRange("difford", difford,0,2);
/// <summary>
///  set Minkowski norm (from 0 to 20) (default 1)
/// </summary>
public GreyedgeFilterGen minknorm(int minknorm) => this.SetOptionRange("minknorm", minknorm,0,20);
/// <summary>
///  set sigma (from 0 to 1024) (default 1)
/// </summary>
public GreyedgeFilterGen sigma(double sigma) => this.SetOptionRange("sigma", sigma,0,1024);
}
public static class GreyedgeFilterGenExtensions
{
/// <summary>
/// Estimates scene illumination by grey edge assumption.
/// </summary>
public static GreyedgeFilterGen GreyedgeFilterGen(this ImageMap input) => new GreyedgeFilterGen(input);
}
}
