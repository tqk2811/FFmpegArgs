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
public class TmedianFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal TmedianFilterGen(ImageMap input) : base("tmedian",input) { AddMapOut(); }
/// <summary>
///  set median filter radius (from 1 to 127) (default 1)
/// </summary>
public TmedianFilterGen radius(int radius) => this.SetOptionRange("radius", radius,1,127);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public TmedianFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set percentile (from 0 to 1) (default 0.5)
/// </summary>
public TmedianFilterGen percentile(float percentile) => this.SetOptionRange("percentile", percentile,0,1);
}
public static class TmedianFilterGenExtensions
{
/// <summary>
/// Pick median pixels from successive frames.
/// </summary>
public static TmedianFilterGen TmedianFilterGen(this ImageMap input0) => new TmedianFilterGen(input0);
}
}