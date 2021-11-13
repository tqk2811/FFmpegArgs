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
public class BenchFilterGen : ImageToImageFilter
{
internal BenchFilterGen(ImageMap input) : base("bench",input) { AddMapOut(); }
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public BenchFilterGen action(BenchFilterGenAction action) => this.SetOption("action", action.GetAttribute<NameAttribute>().Name);
}
public static class BenchFilterGenExtensions
{
/// <summary>
/// Benchmark part of a filtergraph.
/// </summary>
public static BenchFilterGen BenchFilterGen(this ImageMap input) => new BenchFilterGen(input);
}
public enum BenchFilterGenAction
{
[Name("start")] start,
[Name("stop")] stop,
}

}
