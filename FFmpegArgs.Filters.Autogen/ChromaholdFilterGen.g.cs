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
public class ChromaholdFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ChromaholdFilterGen(ImageMap input) : base("chromahold",input) { AddMapOut(); }
/// <summary>
///  set the chromahold key color (default "black")
/// </summary>
public ChromaholdFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set the chromahold similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public ChromaholdFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,0.01,1);
/// <summary>
///  set the chromahold blend value (from 0 to 1) (default 0)
/// </summary>
public ChromaholdFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
/// <summary>
///  color parameter is in yuv instead of rgb (default false)
/// </summary>
public ChromaholdFilterGen yuv(bool yuv) => this.SetOption("yuv",yuv.ToFFmpegFlag());
}
public static class ChromaholdFilterGenExtensions
{
/// <summary>
/// Turns a certain color range into gray.
/// </summary>
public static ChromaholdFilterGen ChromaholdFilterGen(this ImageMap input0) => new ChromaholdFilterGen(input0);
/// <summary>
/// Turns a certain color range into gray.
/// </summary>
public static ChromaholdFilterGen ChromaholdFilterGen(this ImageMap input0,ChromaholdFilterGenConfig config)
{
var result = new ChromaholdFilterGen(input0);
if(config?.color != null) result.color(config.color.Value);
if(config?.similarity != null) result.similarity(config.similarity.Value);
if(config?.blend != null) result.blend(config.blend.Value);
if(config?.yuv != null) result.yuv(config.yuv.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class ChromaholdFilterGenConfig
{
/// <summary>
///  set the chromahold key color (default "black")
/// </summary>
public Color? color { get; set; }
/// <summary>
///  set the chromahold similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public float? similarity { get; set; }
/// <summary>
///  set the chromahold blend value (from 0 to 1) (default 0)
/// </summary>
public float? blend { get; set; }
/// <summary>
///  color parameter is in yuv instead of rgb (default false)
/// </summary>
public bool? yuv { get; set; }
public string TimelineSupport { get; set; }
}
}
