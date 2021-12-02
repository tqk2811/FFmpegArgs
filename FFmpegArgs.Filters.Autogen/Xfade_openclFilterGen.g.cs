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
public class Xfade_openclFilterGen : ImageToImageFilter
{
internal Xfade_openclFilterGen(params ImageMap[] inputs) : base("xfade_opencl",inputs) { AddMapOut(); }
/// <summary>
///  set cross fade transition (from 0 to 9) (default fade)
/// </summary>
public Xfade_openclFilterGen transition(Xfade_openclFilterGenTransition transition) => this.SetOption("transition", transition.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set OpenCL program source file for custom transition
/// </summary>
public Xfade_openclFilterGen source(string source) => this.SetOption("source",source);
/// <summary>
///  set kernel name in program file for custom transition
/// </summary>
public Xfade_openclFilterGen kernel(string kernel) => this.SetOption("kernel",kernel);
/// <summary>
///  set cross fade duration (default 1)
/// </summary>
public Xfade_openclFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set cross fade start relative to first input stream (default 0)
/// </summary>
public Xfade_openclFilterGen offset(TimeSpan offset) => this.SetOptionRange("offset",offset,TimeSpan.Zero,TimeSpan.MaxValue);
}
public static class Xfade_openclFilterGenExtensions
{
/// <summary>
/// Cross fade one video with another video.
/// </summary>
public static Xfade_openclFilterGen Xfade_openclFilterGen(this ImageMap input0, ImageMap input1) => new Xfade_openclFilterGen(input0, input1);
/// <summary>
/// Cross fade one video with another video.
/// </summary>
public static Xfade_openclFilterGen Xfade_openclFilterGen(this ImageMap input0, ImageMap input1,Xfade_openclFilterGenConfig config)
{
var result = new Xfade_openclFilterGen(input0, input1);
if(config?.transition != null) result.transition(config.transition);
if(config?.source != null) result.source(config.source);
if(config?.kernel != null) result.kernel(config.kernel);
if(config?.duration != null) result.duration(config.duration);
if(config?.offset != null) result.offset(config.offset);
return result;
}
}
public class Xfade_openclFilterGenConfig
{
/// <summary>
///  set cross fade transition (from 0 to 9) (default fade)
/// </summary>
public Xfade_openclFilterGenTransition transition { get; set; }
/// <summary>
///  set OpenCL program source file for custom transition
/// </summary>
public string source { get; set; }
/// <summary>
///  set kernel name in program file for custom transition
/// </summary>
public string kernel { get; set; }
/// <summary>
///  set cross fade duration (default 1)
/// </summary>
public TimeSpan duration { get; set; }
/// <summary>
///  set cross fade start relative to first input stream (default 0)
/// </summary>
public TimeSpan offset { get; set; }
}
public enum Xfade_openclFilterGenTransition
{
[Name("custom")] custom,
[Name("fade")] fade,
[Name("wipeleft")] wipeleft,
[Name("wiperight")] wiperight,
[Name("wipeup")] wipeup,
[Name("wipedown")] wipedown,
[Name("slideleft")] slideleft,
[Name("slideright")] slideright,
[Name("slideup")] slideup,
[Name("slidedown")] slidedown,
}

}
