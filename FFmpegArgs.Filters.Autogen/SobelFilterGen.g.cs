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
public class SobelFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal SobelFilterGen(ImageMap input) : base("sobel",input) { AddMapOut(); }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public SobelFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public SobelFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,65535);
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public SobelFilterGen delta(float delta) => this.SetOptionRange("delta", delta,-65535,65535);
}
public static class SobelFilterGenExtensions
{
/// <summary>
/// Apply sobel operator.
/// </summary>
public static SobelFilterGen SobelFilterGen(this ImageMap input0) => new SobelFilterGen(input0);
/// <summary>
/// Apply sobel operator.
/// </summary>
public static SobelFilterGen SobelFilterGen(this ImageMap input0,SobelFilterGenConfig config)
{
var result = new SobelFilterGen(input0);
if(config?.planes != null) result.planes(config.planes);
if(config?.scale != null) result.scale(config.scale);
if(config?.delta != null) result.delta(config.delta);
return result;
}
}
public class SobelFilterGenConfig
{
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public int planes { get; set; }
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public float scale { get; set; }
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public float delta { get; set; }
}
}
