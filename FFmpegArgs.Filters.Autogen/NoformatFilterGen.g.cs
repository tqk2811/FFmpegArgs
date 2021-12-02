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
public class NoformatFilterGen : ImageToImageFilter
{
internal NoformatFilterGen(ImageMap input) : base("noformat",input) { AddMapOut(); }
/// <summary>
///  A '|'-separated list of pixel formats
/// </summary>
public NoformatFilterGen pix_fmts(string pix_fmts) => this.SetOption("pix_fmts",pix_fmts);
}
public static class NoformatFilterGenExtensions
{
/// <summary>
/// Force libavfilter not to use any of the specified pixel formats for the input to the next filter.
/// </summary>
public static NoformatFilterGen NoformatFilterGen(this ImageMap input0) => new NoformatFilterGen(input0);
/// <summary>
/// Force libavfilter not to use any of the specified pixel formats for the input to the next filter.
/// </summary>
public static NoformatFilterGen NoformatFilterGen(this ImageMap input0,NoformatFilterGenConfig config)
{
var result = new NoformatFilterGen(input0);
if(config?.pix_fmts != null) result.pix_fmts(config.pix_fmts);
return result;
}
}
public class NoformatFilterGenConfig
{
/// <summary>
///  A '|'-separated list of pixel formats
/// </summary>
public string pix_fmts { get; set; }
}
}
