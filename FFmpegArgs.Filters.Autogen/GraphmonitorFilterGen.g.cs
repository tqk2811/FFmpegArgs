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
///  set video opacity (from 0 to 1) (default 0.9)
/// </summary>
public GraphmonitorFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set mode (from 0 to 1) (default full)
/// </summary>
public GraphmonitorFilterGen mode(GraphmonitorFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set flags (default queue)
/// </summary>
public GraphmonitorFilterGen flags(GraphmonitorFilterGenFlags flags) => this.SetOption("flags", flags.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set video rate (default "25")
/// </summary>
public GraphmonitorFilterGen rate(Rational rate) => this.SetOption("rate",rate);
}
public static class GraphmonitorFilterGenExtensions
{
/// <summary>
/// Show various filtergraph stats.
/// </summary>
public static GraphmonitorFilterGen GraphmonitorFilterGen(this ImageMap input0) => new GraphmonitorFilterGen(input0);
/// <summary>
/// Show various filtergraph stats.
/// </summary>
public static GraphmonitorFilterGen GraphmonitorFilterGen(this ImageMap input0,GraphmonitorFilterGenConfig config)
{
var result = new GraphmonitorFilterGen(input0);
if(config?.size != null) result.size(config.size);
if(config?.opacity != null) result.opacity(config.opacity);
if(config?.mode != null) result.mode(config.mode);
if(config?.flags != null) result.flags(config.flags);
if(config?.rate != null) result.rate(config.rate);
return result;
}
}
public class GraphmonitorFilterGenConfig
{
/// <summary>
///  set monitor size (default "hd720")
/// </summary>
public Size size { get; set; }
/// <summary>
///  set video opacity (from 0 to 1) (default 0.9)
/// </summary>
public float opacity { get; set; }
/// <summary>
///  set mode (from 0 to 1) (default full)
/// </summary>
public GraphmonitorFilterGenMode mode { get; set; }
/// <summary>
///  set flags (default queue)
/// </summary>
public GraphmonitorFilterGenFlags flags { get; set; }
/// <summary>
///  set video rate (default "25")
/// </summary>
public Rational rate { get; set; }
}
public enum GraphmonitorFilterGenMode
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

}
