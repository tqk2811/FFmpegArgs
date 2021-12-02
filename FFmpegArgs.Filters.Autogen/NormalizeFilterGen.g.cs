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
public class NormalizeFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal NormalizeFilterGen(ImageMap input) : base("normalize",input) { AddMapOut(); }
/// <summary>
///  output color to which darkest input color is mapped (default "black")
/// </summary>
public NormalizeFilterGen blackpt(Color blackpt) => this.SetOption("blackpt",blackpt.ToHexStringRGBA());
/// <summary>
///  output color to which brightest input color is mapped (default "white")
/// </summary>
public NormalizeFilterGen whitept(Color whitept) => this.SetOption("whitept",whitept.ToHexStringRGBA());
/// <summary>
///  amount of temporal smoothing of the input range, to reduce flicker (from 0 to 2.68435e+08) (default 0)
/// </summary>
public NormalizeFilterGen smoothing(int smoothing) => this.SetOptionRange("smoothing", smoothing,0,2.68435e+08);
/// <summary>
///  proportion of independent to linked channel normalization (from 0 to 1) (default 1)
/// </summary>
public NormalizeFilterGen independence(float independence) => this.SetOptionRange("independence", independence,0,1);
/// <summary>
///  strength of filter, from no effect to full normalization (from 0 to 1) (default 1)
/// </summary>
public NormalizeFilterGen strength(float strength) => this.SetOptionRange("strength", strength,0,1);
}
public static class NormalizeFilterGenExtensions
{
/// <summary>
/// Normalize RGB video.
/// </summary>
public static NormalizeFilterGen NormalizeFilterGen(this ImageMap input0) => new NormalizeFilterGen(input0);
/// <summary>
/// Normalize RGB video.
/// </summary>
public static NormalizeFilterGen NormalizeFilterGen(this ImageMap input0,NormalizeFilterGenConfig config)
{
var result = new NormalizeFilterGen(input0);
if(config?.blackpt != null) result.blackpt(config.blackpt.Value);
if(config?.whitept != null) result.whitept(config.whitept.Value);
if(config?.smoothing != null) result.smoothing(config.smoothing.Value);
if(config?.independence != null) result.independence(config.independence.Value);
if(config?.strength != null) result.strength(config.strength.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class NormalizeFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  output color to which darkest input color is mapped (default "black")
/// </summary>
public Color? blackpt { get; set; }
/// <summary>
///  output color to which brightest input color is mapped (default "white")
/// </summary>
public Color? whitept { get; set; }
/// <summary>
///  amount of temporal smoothing of the input range, to reduce flicker (from 0 to 2.68435e+08) (default 0)
/// </summary>
public int? smoothing { get; set; }
/// <summary>
///  proportion of independent to linked channel normalization (from 0 to 1) (default 1)
/// </summary>
public float? independence { get; set; }
/// <summary>
///  strength of filter, from no effect to full normalization (from 0 to 1) (default 1)
/// </summary>
public float? strength { get; set; }
public string TimelineSupport { get; set; }
}
}
