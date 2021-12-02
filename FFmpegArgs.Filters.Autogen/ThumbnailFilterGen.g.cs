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
public class ThumbnailFilterGen : ImageToImageFilter,ITimelineSupport
{
internal ThumbnailFilterGen(ImageMap input) : base("thumbnail",input) { AddMapOut(); }
/// <summary>
///  set the frames batch size (from 2 to INT_MAX) (default 100)
/// </summary>
public ThumbnailFilterGen n(int n) => this.SetOptionRange("n", n,2,INT_MAX);
}
public static class ThumbnailFilterGenExtensions
{
/// <summary>
/// Select the most representative frame in a given sequence of consecutive frames.
/// </summary>
public static ThumbnailFilterGen ThumbnailFilterGen(this ImageMap input0) => new ThumbnailFilterGen(input0);
/// <summary>
/// Select the most representative frame in a given sequence of consecutive frames.
/// </summary>
public static ThumbnailFilterGen ThumbnailFilterGen(this ImageMap input0,ThumbnailFilterGenConfig config)
{
var result = new ThumbnailFilterGen(input0);
if(config?.n != null) result.n(config.n);
return result;
}
}
public class ThumbnailFilterGenConfig
{
/// <summary>
///  set the frames batch size (from 2 to INT_MAX) (default 100)
/// </summary>
public int n { get; set; }
}
}
