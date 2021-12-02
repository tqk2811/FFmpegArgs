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
public class Dilation_openclFilterGen : ImageToImageFilter
{
internal Dilation_openclFilterGen(ImageMap input) : base("dilation_opencl",input) { AddMapOut(); }
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public Dilation_openclFilterGen threshold0(float threshold0) => this.SetOptionRange("threshold0", threshold0,0,65535);
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public Dilation_openclFilterGen threshold1(float threshold1) => this.SetOptionRange("threshold1", threshold1,0,65535);
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public Dilation_openclFilterGen threshold2(float threshold2) => this.SetOptionRange("threshold2", threshold2,0,65535);
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public Dilation_openclFilterGen threshold3(float threshold3) => this.SetOptionRange("threshold3", threshold3,0,65535);
/// <summary>
///  set coordinates (from 0 to 255) (default 255)
/// </summary>
public Dilation_openclFilterGen coordinates(int coordinates) => this.SetOptionRange("coordinates", coordinates,0,255);
}
public static class Dilation_openclFilterGenExtensions
{
/// <summary>
/// Apply dilation effect
/// </summary>
public static Dilation_openclFilterGen Dilation_openclFilterGen(this ImageMap input0) => new Dilation_openclFilterGen(input0);
/// <summary>
/// Apply dilation effect
/// </summary>
public static Dilation_openclFilterGen Dilation_openclFilterGen(this ImageMap input0,Dilation_openclFilterGenConfig config)
{
var result = new Dilation_openclFilterGen(input0);
if(config?.threshold0 != null) result.threshold0(config.threshold0);
if(config?.threshold1 != null) result.threshold1(config.threshold1);
if(config?.threshold2 != null) result.threshold2(config.threshold2);
if(config?.threshold3 != null) result.threshold3(config.threshold3);
if(config?.coordinates != null) result.coordinates(config.coordinates);
return result;
}
}
public class Dilation_openclFilterGenConfig
{
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public float threshold0 { get; set; }
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public float threshold1 { get; set; }
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public float threshold2 { get; set; }
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public float threshold3 { get; set; }
/// <summary>
///  set coordinates (from 0 to 255) (default 255)
/// </summary>
public int coordinates { get; set; }
}
}
