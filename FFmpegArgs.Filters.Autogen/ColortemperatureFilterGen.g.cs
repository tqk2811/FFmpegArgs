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
public class ColortemperatureFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColortemperatureFilterGen(ImageMap input) : base("colortemperature",input) { AddMapOut(); }
/// <summary>
///  set the temperature in Kelvin (from 1000 to 40000) (default 6500)
/// </summary>
public ColortemperatureFilterGen temperature(float temperature) => this.SetOptionRange("temperature", temperature,1000,40000);
/// <summary>
///  set the mix with filtered output (from 0 to 1) (default 1)
/// </summary>
public ColortemperatureFilterGen mix(float mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set the amount of preserving lightness (from 0 to 1) (default 0)
/// </summary>
public ColortemperatureFilterGen pl(float pl) => this.SetOptionRange("pl", pl,0,1);
}
public static class ColortemperatureFilterGenExtensions
{
/// <summary>
/// Adjust color temperature of video.
/// </summary>
public static ColortemperatureFilterGen ColortemperatureFilterGen(this ImageMap input0) => new ColortemperatureFilterGen(input0);
}
}