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
public class ExtrastereoFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal ExtrastereoFilterGen(AudioMap input) : base("extrastereo",input) { AddMapOut(); }
/// <summary>
///  set the difference coefficient (from -10 to 10) (default 2.5)
/// </summary>
public ExtrastereoFilterGen m(float m) => this.SetOptionRange("m", m,-10,10);
/// <summary>
///  enable clipping (default true)
/// </summary>
public ExtrastereoFilterGen c(bool flag) => this.SetOption("c",flag.ToFFmpegFlag());
}
public static class ExtrastereoFilterGenExtensions
{
/// <summary>
/// Increase difference between stereo audio channels.
/// </summary>
public static ExtrastereoFilterGen ExtrastereoFilterGen(this AudioMap input0) => new ExtrastereoFilterGen(input0);
}
}
