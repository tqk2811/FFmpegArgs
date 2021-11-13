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
public class MaskfunFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskfunFilterGen(ImageMap input) : base("maskfun",input) { AddMapOut(); }
/// <summary>
///  set low threshold (from 0 to 65535) (default 10)
/// </summary>
public MaskfunFilterGen low(int low) => this.SetOptionRange("low", low,0,65535);
/// <summary>
///  set high threshold (from 0 to 65535) (default 10)
/// </summary>
public MaskfunFilterGen high(int high) => this.SetOptionRange("high", high,0,65535);
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskfunFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set fill value (from 0 to 65535) (default 0)
/// </summary>
public MaskfunFilterGen fill(int fill) => this.SetOptionRange("fill", fill,0,65535);
/// <summary>
///  set sum value (from 0 to 65535) (default 10)
/// </summary>
public MaskfunFilterGen sum(int sum) => this.SetOptionRange("sum", sum,0,65535);
}
public static class MaskfunFilterGenExtensions
{
/// <summary>
/// Create Mask.
/// </summary>
public static MaskfunFilterGen MaskfunFilterGen(this ImageMap input) => new MaskfunFilterGen(input);
}
}
