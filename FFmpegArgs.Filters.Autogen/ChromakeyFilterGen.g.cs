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
public class ChromakeyFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ChromakeyFilterGen(ImageMap input) : base("chromakey",input) { AddMapOut(); }
/// <summary>
///  set the chromakey key color (default "black")
/// </summary>
public ChromakeyFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set the chromakey similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public ChromakeyFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,0.01,1);
/// <summary>
///  set the chromakey key blend value (from 0 to 1) (default 0)
/// </summary>
public ChromakeyFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
/// <summary>
///  color parameter is in yuv instead of rgb (default false)
/// </summary>
public ChromakeyFilterGen yuv(bool yuv) => this.SetOption("yuv",yuv.ToFFmpegFlag());
}
public static class ChromakeyFilterGenExtensions
{
/// <summary>
/// Turns a certain color into transparency. Operates on YUV colors.
/// </summary>
public static ChromakeyFilterGen ChromakeyFilterGen(this ImageMap input0) => new ChromakeyFilterGen(input0);
/// <summary>
/// Turns a certain color into transparency. Operates on YUV colors.
/// </summary>
public static ChromakeyFilterGen ChromakeyFilterGen(this ImageMap input0,ChromakeyFilterGenConfig config)
{
var result = new ChromakeyFilterGen(input0);
if(config?.color != null) result.color(config.color);
if(config?.similarity != null) result.similarity(config.similarity);
if(config?.blend != null) result.blend(config.blend);
if(config?.yuv != null) result.yuv(config.yuv);
return result;
}
}
public class ChromakeyFilterGenConfig
{
/// <summary>
///  set the chromakey key color (default "black")
/// </summary>
public Color color { get; set; }
/// <summary>
///  set the chromakey similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public float similarity { get; set; }
/// <summary>
///  set the chromakey key blend value (from 0 to 1) (default 0)
/// </summary>
public float blend { get; set; }
/// <summary>
///  color parameter is in yuv instead of rgb (default false)
/// </summary>
public bool yuv { get; set; }
}
}
