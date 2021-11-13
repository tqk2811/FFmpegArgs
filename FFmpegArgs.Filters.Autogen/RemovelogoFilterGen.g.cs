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
public class RemovelogoFilterGen : ImageToImageFilter,ITimelineSupport
{
internal RemovelogoFilterGen(ImageMap input) : base("removelogo",input) { AddMapOut(); }
/// <summary>
///  set bitmap filename
/// </summary>
public RemovelogoFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set bitmap filename
/// </summary>
public RemovelogoFilterGen f(string f) => this.SetOption("f",f);
}
public static class RemovelogoFilterGenExtensions
{
/// <summary>
/// Remove a TV logo based on a mask image.
/// </summary>
public static RemovelogoFilterGen RemovelogoFilterGen(this ImageMap input0) => new RemovelogoFilterGen(input0);
}
}
