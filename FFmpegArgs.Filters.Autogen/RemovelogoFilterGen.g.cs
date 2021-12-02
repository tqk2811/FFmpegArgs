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
}
public static class RemovelogoFilterGenExtensions
{
/// <summary>
/// Remove a TV logo based on a mask image.
/// </summary>
public static RemovelogoFilterGen RemovelogoFilterGen(this ImageMap input0) => new RemovelogoFilterGen(input0);
/// <summary>
/// Remove a TV logo based on a mask image.
/// </summary>
public static RemovelogoFilterGen RemovelogoFilterGen(this ImageMap input0,RemovelogoFilterGenConfig config)
{
var result = new RemovelogoFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.filename)) result.filename(config.filename);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class RemovelogoFilterGenConfig
{
/// <summary>
///  set bitmap filename
/// </summary>
public string filename { get; set; }
public string TimelineSupport { get; set; }
}
}
