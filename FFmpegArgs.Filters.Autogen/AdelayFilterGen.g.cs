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
public class AdelayFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal AdelayFilterGen(AudioMap input) : base("adelay",input) { AddMapOut(); }
/// <summary>
///  set list of delays for each channel
/// </summary>
public AdelayFilterGen delays(string delays) => this.SetOption("delays",delays);
/// <summary>
///  use last available delay for remained channels (default false)
/// </summary>
public AdelayFilterGen all(bool flag) => this.SetOption("all",flag.ToFFmpegFlag());
}
public static class AdelayFilterGenExtensions
{
/// <summary>
/// Delay one or more audio channels.
/// </summary>
public static AdelayFilterGen AdelayFilterGen(this AudioMap input0) => new AdelayFilterGen(input0);
}
}
