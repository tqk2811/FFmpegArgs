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
public ShowinfoFilterGen checksum(bool flag) => this.SetOption("checksum",flag.ToFFmpegFlag());
}
public static class ShowinfoFilterGenExtensions
{
/// <summary>
/// Show textual information for each video frame.
/// </summary>
public static ShowinfoFilterGen ShowinfoFilterGen(this ImageMap input) => new ShowinfoFilterGen(input);
}
}
