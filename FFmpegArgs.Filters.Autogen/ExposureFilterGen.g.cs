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
public class ExposureFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ExposureFilterGen(ImageMap input) : base("exposure",input) { AddMapOut(); }
/// <summary>
///  set the exposure correction (from -3 to 3) (default 0)
/// </summary>
public ExposureFilterGen exposure(float exposure) => this.SetOptionRange("exposure", exposure,-3,3);
/// <summary>
///  set the black level correction (from -1 to 1) (default 0)
/// </summary>
public ExposureFilterGen black(float black) => this.SetOptionRange("black", black,-1,1);
}
public static class ExposureFilterGenExtensions
{
/// <summary>
/// Adjust exposure of the video stream.
/// </summary>
public static ExposureFilterGen ExposureFilterGen(this ImageMap input) => new ExposureFilterGen(input);
}
}
