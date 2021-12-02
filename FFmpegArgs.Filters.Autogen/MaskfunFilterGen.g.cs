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
public static MaskfunFilterGen MaskfunFilterGen(this ImageMap input0) => new MaskfunFilterGen(input0);
/// <summary>
/// Create Mask.
/// </summary>
public static MaskfunFilterGen MaskfunFilterGen(this ImageMap input0,MaskfunFilterGenConfig config)
{
var result = new MaskfunFilterGen(input0);
if(config?.low != null) result.low(config.low.Value);
if(config?.high != null) result.high(config.high.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(config?.fill != null) result.fill(config.fill.Value);
if(config?.sum != null) result.sum(config.sum.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class MaskfunFilterGenConfig
{
/// <summary>
///  set low threshold (from 0 to 65535) (default 10)
/// </summary>
public int? low { get; set; }
/// <summary>
///  set high threshold (from 0 to 65535) (default 10)
/// </summary>
public int? high { get; set; }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
/// <summary>
///  set fill value (from 0 to 65535) (default 0)
/// </summary>
public int? fill { get; set; }
/// <summary>
///  set sum value (from 0 to 65535) (default 10)
/// </summary>
public int? sum { get; set; }
public string TimelineSupport { get; set; }
}
}
