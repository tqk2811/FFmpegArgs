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
public class ShowinfoFilterGen : ImageToImageFilter
{
internal ShowinfoFilterGen(ImageMap input) : base("showinfo",input) { AddMapOut(); }
/// <summary>
///  calculate checksums (default true)
/// </summary>
public ShowinfoFilterGen checksum(bool checksum) => this.SetOption("checksum",checksum.ToFFmpegFlag());
}
public static class ShowinfoFilterGenExtensions
{
/// <summary>
/// Show textual information for each video frame.
/// </summary>
public static ShowinfoFilterGen ShowinfoFilterGen(this ImageMap input0) => new ShowinfoFilterGen(input0);
/// <summary>
/// Show textual information for each video frame.
/// </summary>
public static ShowinfoFilterGen ShowinfoFilterGen(this ImageMap input0,ShowinfoFilterGenConfig config)
{
var result = new ShowinfoFilterGen(input0);
if(config?.checksum != null) result.checksum(config.checksum.Value);
return result;
}
}
public class ShowinfoFilterGenConfig
{
/// <summary>
///  calculate checksums (default true)
/// </summary>
public bool? checksum { get; set; }
}
}
