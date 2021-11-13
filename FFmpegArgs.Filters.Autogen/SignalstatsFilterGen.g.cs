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
public class SignalstatsFilterGen : ImageToImageFilter,ISliceThreading
{
internal SignalstatsFilterGen(ImageMap input) : base("signalstats",input) { AddMapOut(); }
/// <summary>
///  set statistics filters (default 0)
/// </summary>
public SignalstatsFilterGen stat(SignalstatsFilterGenStat stat) => this.SetOption("stat", stat.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set video filter (from -1 to 2) (default -1)
/// </summary>
public SignalstatsFilterGen _out(SignalstatsFilterGenOut _out) => this.SetOption("out", _out.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set highlight color (default "yellow")
/// </summary>
public SignalstatsFilterGen c(Color c) => this.SetOption("c",c.ToHexStringRGBA());
/// <summary>
///  set highlight color (default "yellow")
/// </summary>
public SignalstatsFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
}
public static class SignalstatsFilterGenExtensions
{
/// <summary>
/// Generate statistics from video analysis.
/// </summary>
public static SignalstatsFilterGen SignalstatsFilterGen(this ImageMap input0) => new SignalstatsFilterGen(input0);
}
public enum SignalstatsFilterGenStat
{
[Name("tout")] tout,
[Name("vrep")] vrep,
[Name("brng")] brng,
}

public enum SignalstatsFilterGenOut
{
[Name("tout")] tout,
[Name("vrep")] vrep,
[Name("brng")] brng,
}

}
