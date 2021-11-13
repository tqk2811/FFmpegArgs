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
