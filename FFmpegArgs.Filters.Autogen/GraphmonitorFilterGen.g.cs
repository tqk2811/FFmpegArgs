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
public class GraphmonitorFilterGen : ImageToImageFilter
{
internal GraphmonitorFilterGen(ImageMap input) : base("graphmonitor",input) { AddMapOut(); }
/// <summary>
///  set monitor size (default "hd720")
/// </summary>
public GraphmonitorFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set monitor size (default "hd720")
/// </summary>
public GraphmonitorFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set video opacity (from 0 to 1) (default 0.9)
/// </summary>
public GraphmonitorFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set video opacity (from 0 to 1) (default 0.9)
/// </summary>
public GraphmonitorFilterGen o(float o) => this.SetOptionRange("o", o,0,1);
/// <summary>
///  set mode (from 0 to 1) (default full)
/// </summary>
public GraphmonitorFilterGen mode(GraphmonitorFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set mode (from 0 to 1) (default full)
/// </summary>
public GraphmonitorFilterGen m(GraphmonitorFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set flags (default queue)
/// </summary>
public GraphmonitorFilterGen flags(GraphmonitorFilterGenFlags flags) => this.SetOption("flags", flags.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set flags (default queue)
/// </summary>
public GraphmonitorFilterGen f(GraphmonitorFilterGenF f) => this.SetOption("f", f.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set video rate (default "25")
/// </summary>
public GraphmonitorFilterGen Rate(string r) => this.SetOption("rate", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public GraphmonitorFilterGen rate(int r) => this.SetOptionRange("rate", r, 1, int.MaxValue);
/// <summary>
///  set video rate (default "25")
/// </summary>
public GraphmonitorFilterGen R(string r) => this.SetOption("r", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public GraphmonitorFilterGen r(int r) => this.SetOptionRange("r", r, 1, int.MaxValue);
}
public static class GraphmonitorFilterGenExtensions
{
/// <summary>
/// Show various filtergraph stats.
/// </summary>
public static GraphmonitorFilterGen GraphmonitorFilterGen(this ImageMap input0) => new GraphmonitorFilterGen(input0);
}
public enum GraphmonitorFilterGenMode
{
[Name("full")] full,
[Name("compact")] compact,
}

public enum GraphmonitorFilterGenM
{
[Name("full")] full,
[Name("compact")] compact,
}

public enum GraphmonitorFilterGenFlags
{
[Name("queue")] queue,
[Name("frame_count_in")] frame_count_in,
[Name("frame_count_out")] frame_count_out,
[Name("pts")] pts,
[Name("time")] time,
[Name("timebase")] timebase,
[Name("format")] format,
[Name("size")] size,
[Name("rate")] rate,
[Name("eof")] eof,
}

public enum GraphmonitorFilterGenF
{
[Name("queue")] queue,
[Name("frame_count_in")] frame_count_in,
[Name("frame_count_out")] frame_count_out,
[Name("pts")] pts,
[Name("time")] time,
[Name("timebase")] timebase,
[Name("format")] format,
[Name("size")] size,
[Name("rate")] rate,
[Name("eof")] eof,
}

}
