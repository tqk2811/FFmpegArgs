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
public class ColorholdFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorholdFilterGen(ImageMap input) : base("colorhold",input) { AddMapOut(); }
/// <summary>
///  set the colorhold key color (default "black")
/// </summary>
public ColorholdFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set the colorhold similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public ColorholdFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,0.01,1);
/// <summary>
///  set the colorhold blend value (from 0 to 1) (default 0)
/// </summary>
public ColorholdFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
}
public static class ColorholdFilterGenExtensions
{
/// <summary>
/// Turns a certain color range into gray. Operates on RGB colors.
/// </summary>
public static ColorholdFilterGen ColorholdFilterGen(this ImageMap input0) => new ColorholdFilterGen(input0);
/// <summary>
/// Turns a certain color range into gray. Operates on RGB colors.
/// </summary>
public static ColorholdFilterGen ColorholdFilterGen(this ImageMap input0,ColorholdFilterGenConfig config)
{
var result = new ColorholdFilterGen(input0);
if(config?.color != null) result.color(config.color.Value);
if(config?.similarity != null) result.similarity(config.similarity.Value);
if(config?.blend != null) result.blend(config.blend.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ColorholdFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the colorhold key color (default "black")
/// </summary>
public Color? color { get; set; }
/// <summary>
///  set the colorhold similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public float? similarity { get; set; }
/// <summary>
///  set the colorhold blend value (from 0 to 1) (default 0)
/// </summary>
public float? blend { get; set; }
public string TimelineSupport { get; set; }
}
}
