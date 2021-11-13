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
public class EdgedetectFilterGen : ImageToImageFilter,ITimelineSupport
{
internal EdgedetectFilterGen(ImageMap input) : base("edgedetect",input) { AddMapOut(); }
/// <summary>
///  set high threshold (from 0 to 1) (default 0.196078)
/// </summary>
public EdgedetectFilterGen high(double high) => this.SetOptionRange("high", high,0,1);
/// <summary>
///  set low threshold (from 0 to 1) (default 0.0784314)
/// </summary>
public EdgedetectFilterGen low(double low) => this.SetOptionRange("low", low,0,1);
/// <summary>
///  set mode (from 0 to 2) (default wires)
/// </summary>
public EdgedetectFilterGen mode(EdgedetectFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set planes to filter (default y+u+v+r+g+b)
/// </summary>
public EdgedetectFilterGen planes(EdgedetectFilterGenPlanes planes) => this.SetOption("planes", planes.GetAttribute<NameAttribute>().Name);
}
public static class EdgedetectFilterGenExtensions
{
/// <summary>
/// Detect and draw edge.
/// </summary>
public static EdgedetectFilterGen EdgedetectFilterGen(this ImageMap input0) => new EdgedetectFilterGen(input0);
}
public enum EdgedetectFilterGenMode
{
[Name("wires")] wires,
[Name("colormix")] colormix,
[Name("canny")] canny,
}

public enum EdgedetectFilterGenPlanes
{
[Name("y")] y,
[Name("u")] u,
[Name("v")] v,
[Name("r")] r,
[Name("g")] g,
[Name("b")] b,
}

}
