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
public class KerndeintFilterGen : ImageToImageFilter
{
internal KerndeintFilterGen(ImageMap input) : base("kerndeint",input) { AddMapOut(); }
/// <summary>
///  set the threshold (from 0 to 255) (default 10)
/// </summary>
public KerndeintFilterGen thresh(int thresh) => this.SetOptionRange("thresh", thresh,0,255);
/// <summary>
///  set the map (default false)
/// </summary>
public KerndeintFilterGen map(bool map) => this.SetOption("map",map.ToFFmpegFlag());
/// <summary>
///  set the order (default false)
/// </summary>
public KerndeintFilterGen order(bool order) => this.SetOption("order",order.ToFFmpegFlag());
/// <summary>
///  set sharpening (default false)
/// </summary>
public KerndeintFilterGen sharp(bool sharp) => this.SetOption("sharp",sharp.ToFFmpegFlag());
/// <summary>
///  set twoway (default false)
/// </summary>
public KerndeintFilterGen twoway(bool twoway) => this.SetOption("twoway",twoway.ToFFmpegFlag());
}
public static class KerndeintFilterGenExtensions
{
/// <summary>
/// Apply kernel deinterlacing to the input.
/// </summary>
public static KerndeintFilterGen KerndeintFilterGen(this ImageMap input0) => new KerndeintFilterGen(input0);
/// <summary>
/// Apply kernel deinterlacing to the input.
/// </summary>
public static KerndeintFilterGen KerndeintFilterGen(this ImageMap input0,KerndeintFilterGenConfig config)
{
var result = new KerndeintFilterGen(input0);
if(config?.thresh != null) result.thresh(config.thresh);
if(config?.map != null) result.map(config.map);
if(config?.order != null) result.order(config.order);
if(config?.sharp != null) result.sharp(config.sharp);
if(config?.twoway != null) result.twoway(config.twoway);
return result;
}
}
public class KerndeintFilterGenConfig
{
/// <summary>
///  set the threshold (from 0 to 255) (default 10)
/// </summary>
public int thresh { get; set; }
/// <summary>
///  set the map (default false)
/// </summary>
public bool map { get; set; }
/// <summary>
///  set the order (default false)
/// </summary>
public bool order { get; set; }
/// <summary>
///  set sharpening (default false)
/// </summary>
public bool sharp { get; set; }
/// <summary>
///  set twoway (default false)
/// </summary>
public bool twoway { get; set; }
}
}
