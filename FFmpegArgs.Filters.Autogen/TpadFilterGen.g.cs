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
public class TpadFilterGen : ImageToImageFilter
{
internal TpadFilterGen(ImageMap input) : base("tpad",input) { AddMapOut(); }
/// <summary>
///  set the number of frames to delay input (from 0 to INT_MAX) (default 0)
/// </summary>
public TpadFilterGen start(int start) => this.SetOptionRange("start", start,0,INT_MAX);
/// <summary>
///  set the number of frames to add after input finished (from -1 to INT_MAX) (default 0)
/// </summary>
public TpadFilterGen stop(int stop) => this.SetOptionRange("stop", stop,-1,INT_MAX);
/// <summary>
///  set the mode of added frames to start (from 0 to 1) (default add)
/// </summary>
public TpadFilterGen start_mode(TpadFilterGenStart_mode start_mode) => this.SetOption("start_mode", start_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the mode of added frames to end (from 0 to 1) (default add)
/// </summary>
public TpadFilterGen stop_mode(TpadFilterGenStop_mode stop_mode) => this.SetOption("stop_mode", stop_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the duration to delay input (default 0)
/// </summary>
public TpadFilterGen start_duration(TimeSpan start_duration) => this.SetOptionRange("start_duration",start_duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set the duration to pad input (default 0)
/// </summary>
public TpadFilterGen stop_duration(TimeSpan stop_duration) => this.SetOptionRange("stop_duration",stop_duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set the color of the added frames (default "black")
/// </summary>
public TpadFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
}
public static class TpadFilterGenExtensions
{
/// <summary>
/// Temporarily pad video frames.
/// </summary>
public static TpadFilterGen TpadFilterGen(this ImageMap input0) => new TpadFilterGen(input0);
/// <summary>
/// Temporarily pad video frames.
/// </summary>
public static TpadFilterGen TpadFilterGen(this ImageMap input0,TpadFilterGenConfig config)
{
var result = new TpadFilterGen(input0);
if(config?.start != null) result.start(config.start.Value);
if(config?.stop != null) result.stop(config.stop.Value);
if(config?.start_mode != null) result.start_mode(config.start_mode.Value);
if(config?.stop_mode != null) result.stop_mode(config.stop_mode.Value);
if(config?.start_duration != null) result.start_duration(config.start_duration.Value);
if(config?.stop_duration != null) result.stop_duration(config.stop_duration.Value);
if(config?.color != null) result.color(config.color.Value);
return result;
}
}
public class TpadFilterGenConfig
{
/// <summary>
///  set the number of frames to delay input (from 0 to INT_MAX) (default 0)
/// </summary>
public int? start { get; set; }
/// <summary>
///  set the number of frames to add after input finished (from -1 to INT_MAX) (default 0)
/// </summary>
public int? stop { get; set; }
/// <summary>
///  set the mode of added frames to start (from 0 to 1) (default add)
/// </summary>
public TpadFilterGenStart_mode? start_mode { get; set; }
/// <summary>
///  set the mode of added frames to end (from 0 to 1) (default add)
/// </summary>
public TpadFilterGenStop_mode? stop_mode { get; set; }
/// <summary>
///  set the duration to delay input (default 0)
/// </summary>
public TimeSpan? start_duration { get; set; }
/// <summary>
///  set the duration to pad input (default 0)
/// </summary>
public TimeSpan? stop_duration { get; set; }
/// <summary>
///  set the color of the added frames (default "black")
/// </summary>
public Color? color { get; set; }
}
public enum TpadFilterGenStart_mode
{
[Name("add")] add,
[Name("clone")] clone,
}

public enum TpadFilterGenStop_mode
{
[Name("add")] add,
[Name("clone")] clone,
}

}
