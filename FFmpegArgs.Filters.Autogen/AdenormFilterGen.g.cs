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
public class AdenormFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AdenormFilterGen(AudioMap input) : base("adenorm",input) { AddMapOut(); }
/// <summary>
///  set level (from -451 to -90) (default -351)
/// </summary>
public AdenormFilterGen level(double level) => this.SetOptionRange("level", level,-451,-90);
/// <summary>
///  set type (from 0 to 3) (default dc)
/// </summary>
public AdenormFilterGen type(AdenormFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
}
public static class AdenormFilterGenExtensions
{
/// <summary>
/// Remedy denormals by adding extremely low-level noise.
/// </summary>
public static AdenormFilterGen AdenormFilterGen(this AudioMap input0) => new AdenormFilterGen(input0);
}
public enum AdenormFilterGenType
{
[Name("dc")] dc,
[Name("ac")] ac,
[Name("square")] square,
[Name("pulse")] pulse,
}

}
