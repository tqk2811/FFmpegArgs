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
///  set shuffle direction (from 0 to 1) (default forward)
/// </summary>
public ShufflepixelsFilterGen d(ShufflepixelsFilterGenD d) => this.SetOption("d", d.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set shuffle mode (from 0 to 2) (default horizontal)
/// </summary>
public ShufflepixelsFilterGen mode(ShufflepixelsFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set shuffle mode (from 0 to 2) (default horizontal)
/// </summary>
public ShufflepixelsFilterGen m(ShufflepixelsFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set block width (from 1 to 8000) (default 10)
/// </summary>
public ShufflepixelsFilterGen width(int width) => this.SetOptionRange("width", width,1,8000);
/// <summary>
///  set block width (from 1 to 8000) (default 10)
/// </summary>
public ShufflepixelsFilterGen w(int w) => this.SetOptionRange("w", w,1,8000);
/// <summary>
///  set block height (from 1 to 8000) (default 10)
/// </summary>
public ShufflepixelsFilterGen height(int height) => this.SetOptionRange("height", height,1,8000);
/// <summary>
///  set block height (from 1 to 8000) (default 10)
/// </summary>
public ShufflepixelsFilterGen h(int h) => this.SetOptionRange("h", h,1,8000);
/// <summary>
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public ShufflepixelsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public ShufflepixelsFilterGen s(long s) => this.SetOptionRange("s", s,-1,UINT32_MAX);
}
public static class ShufflepixelsFilterGenExtensions
{
/// <summary>
/// Shuffle video pixels.
/// </summary>
public static ShufflepixelsFilterGen ShufflepixelsFilterGen(this ImageMap input0) => new ShufflepixelsFilterGen(input0);
}
public enum ShufflepixelsFilterGenDirection
{
[Name("forward")] forward,
[Name("inverse")] inverse,
}

public enum ShufflepixelsFilterGenD
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

public enum ShufflepixelsFilterGenM
{
[Name("horizontal")] horizontal,
[Name("vertical")] vertical,
[Name("block")] block,
}

}
