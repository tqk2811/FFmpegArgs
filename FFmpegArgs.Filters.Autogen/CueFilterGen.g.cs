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
public class CueFilterGen : ImageToImageFilter
{
internal CueFilterGen(ImageMap input) : base("cue",input) { AddMapOut(); }
/// <summary>
///  cue unix timestamp in microseconds (from 0 to I64_MAX) (default 0)
/// </summary>
public CueFilterGen cue(long cue) => this.SetOptionRange("cue", cue,0,I64_MAX);
/// <summary>
///  preroll duration in seconds (default 0)
/// </summary>
public CueFilterGen preroll(TimeSpan preroll) => this.SetOptionRange("preroll",preroll,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  buffer duration in seconds (default 0)
/// </summary>
public CueFilterGen buffer(TimeSpan buffer) => this.SetOptionRange("buffer",buffer,TimeSpan.Zero,TimeSpan.MaxValue);
}
public static class CueFilterGenExtensions
{
/// <summary>
/// Delay filtering to match a cue.
/// </summary>
public static CueFilterGen CueFilterGen(this ImageMap input) => new CueFilterGen(input);
}
}
