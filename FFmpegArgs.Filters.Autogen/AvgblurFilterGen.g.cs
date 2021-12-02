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
public class AvgblurFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AvgblurFilterGen(ImageMap input) : base("avgblur",input) { AddMapOut(); }
/// <summary>
///  set horizontal size (from 1 to 1024) (default 1)
/// </summary>
public AvgblurFilterGen sizeX(int sizeX) => this.SetOptionRange("sizeX", sizeX,1,1024);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public AvgblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set vertical size (from 0 to 1024) (default 0)
/// </summary>
public AvgblurFilterGen sizeY(int sizeY) => this.SetOptionRange("sizeY", sizeY,0,1024);
}
public static class AvgblurFilterGenExtensions
{
/// <summary>
/// Apply Average Blur filter.
/// </summary>
public static AvgblurFilterGen AvgblurFilterGen(this ImageMap input0) => new AvgblurFilterGen(input0);
/// <summary>
/// Apply Average Blur filter.
/// </summary>
public static AvgblurFilterGen AvgblurFilterGen(this ImageMap input0,AvgblurFilterGenConfig config)
{
var result = new AvgblurFilterGen(input0);
if(config?.sizeX != null) result.sizeX(config.sizeX.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(config?.sizeY != null) result.sizeY(config.sizeY.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class AvgblurFilterGenConfig
{
/// <summary>
///  set horizontal size (from 1 to 1024) (default 1)
/// </summary>
public int? sizeX { get; set; }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
/// <summary>
///  set vertical size (from 0 to 1024) (default 0)
/// </summary>
public int? sizeY { get; set; }
public string TimelineSupport { get; set; }
}
}
