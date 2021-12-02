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
public class ErosionFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ErosionFilterGen(ImageMap input) : base("erosion",input) { AddMapOut(); }
/// <summary>
///  set coordinates (from 0 to 255) (default 255)
/// </summary>
public ErosionFilterGen coordinates(int coordinates) => this.SetOptionRange("coordinates", coordinates,0,255);
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public ErosionFilterGen threshold0(int threshold0) => this.SetOptionRange("threshold0", threshold0,0,65535);
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public ErosionFilterGen threshold1(int threshold1) => this.SetOptionRange("threshold1", threshold1,0,65535);
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public ErosionFilterGen threshold2(int threshold2) => this.SetOptionRange("threshold2", threshold2,0,65535);
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public ErosionFilterGen threshold3(int threshold3) => this.SetOptionRange("threshold3", threshold3,0,65535);
}
public static class ErosionFilterGenExtensions
{
/// <summary>
/// Apply erosion effect.
/// </summary>
public static ErosionFilterGen ErosionFilterGen(this ImageMap input0) => new ErosionFilterGen(input0);
/// <summary>
/// Apply erosion effect.
/// </summary>
public static ErosionFilterGen ErosionFilterGen(this ImageMap input0,ErosionFilterGenConfig config)
{
var result = new ErosionFilterGen(input0);
if(config?.coordinates != null) result.coordinates(config.coordinates);
if(config?.threshold0 != null) result.threshold0(config.threshold0);
if(config?.threshold1 != null) result.threshold1(config.threshold1);
if(config?.threshold2 != null) result.threshold2(config.threshold2);
if(config?.threshold3 != null) result.threshold3(config.threshold3);
return result;
}
}
public class ErosionFilterGenConfig
{
/// <summary>
///  set coordinates (from 0 to 255) (default 255)
/// </summary>
public int coordinates { get; set; }
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public int threshold0 { get; set; }
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public int threshold1 { get; set; }
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public int threshold2 { get; set; }
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public int threshold3 { get; set; }
}
}
