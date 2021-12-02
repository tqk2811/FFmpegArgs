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
public class ShufflepixelsFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal ShufflepixelsFilterGen(ImageMap input) : base("shufflepixels",input) { AddMapOut(); }
/// <summary>
///  set shuffle direction (from 0 to 1) (default forward)
/// </summary>
public ShufflepixelsFilterGen direction(ShufflepixelsFilterGenDirection direction) => this.SetOption("direction", direction.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set shuffle mode (from 0 to 2) (default horizontal)
/// </summary>
public ShufflepixelsFilterGen mode(ShufflepixelsFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set block width (from 1 to 8000) (default 10)
/// </summary>
public ShufflepixelsFilterGen width(int width) => this.SetOptionRange("width", width,1,8000);
/// <summary>
///  set block height (from 1 to 8000) (default 10)
/// </summary>
public ShufflepixelsFilterGen height(int height) => this.SetOptionRange("height", height,1,8000);
/// <summary>
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public ShufflepixelsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
public static class ShufflepixelsFilterGenExtensions
{
/// <summary>
/// Shuffle video pixels.
/// </summary>
public static ShufflepixelsFilterGen ShufflepixelsFilterGen(this ImageMap input0) => new ShufflepixelsFilterGen(input0);
/// <summary>
/// Shuffle video pixels.
/// </summary>
public static ShufflepixelsFilterGen ShufflepixelsFilterGen(this ImageMap input0,ShufflepixelsFilterGenConfig config)
{
var result = new ShufflepixelsFilterGen(input0);
if(config?.direction != null) result.direction(config.direction.Value);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.width != null) result.width(config.width.Value);
if(config?.height != null) result.height(config.height.Value);
if(config?.seed != null) result.seed(config.seed.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class ShufflepixelsFilterGenConfig
{
/// <summary>
///  set shuffle direction (from 0 to 1) (default forward)
/// </summary>
public ShufflepixelsFilterGenDirection? direction { get; set; }
/// <summary>
///  set shuffle mode (from 0 to 2) (default horizontal)
/// </summary>
public ShufflepixelsFilterGenMode? mode { get; set; }
/// <summary>
///  set block width (from 1 to 8000) (default 10)
/// </summary>
public int? width { get; set; }
/// <summary>
///  set block height (from 1 to 8000) (default 10)
/// </summary>
public int? height { get; set; }
/// <summary>
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long? seed { get; set; }
public string TimelineSupport { get; set; }
}
public enum ShufflepixelsFilterGenDirection
{
[Name("forward")] forward,
[Name("inverse")] inverse,
}

public enum ShufflepixelsFilterGenMode
{
[Name("horizontal")] horizontal,
[Name("vertical")] vertical,
[Name("block")] block,
}

}
