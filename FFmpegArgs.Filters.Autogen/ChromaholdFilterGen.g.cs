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
public ChromaholdFilterGen yuv(bool flag) => this.SetOption("yuv",flag.ToFFmpegFlag());
}
public static class ChromaholdFilterGenExtensions
{
/// <summary>
/// Turns a certain color range into gray.
/// </summary>
public static ChromaholdFilterGen ChromaholdFilterGen(this ImageMap input) => new ChromaholdFilterGen(input);
}
}
