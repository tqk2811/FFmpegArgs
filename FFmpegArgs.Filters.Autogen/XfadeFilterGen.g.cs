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
public class XfadeFilterGen : ImageToImageFilter,ISliceThreading
{
internal XfadeFilterGen(params ImageMap[] inputs) : base("xfade",inputs) { AddMapOut(); }
/// <summary>
///  set cross fade transition (from -1 to 42) (default fade)
/// </summary>
public XfadeFilterGen transition(XfadeFilterGenTransition transition) => this.SetOption("transition", transition.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set cross fade duration (default 1)
/// </summary>
public XfadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set cross fade start relative to first input stream (default 0)
/// </summary>
public XfadeFilterGen offset(TimeSpan offset) => this.SetOptionRange("offset",offset,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set expression for custom transition
/// </summary>
public XfadeFilterGen expr(string expr) => this.SetOption("expr",expr);
}
public static class XfadeFilterGenExtensions
{
/// <summary>
/// Cross fade one video with another video.
/// </summary>
public static XfadeFilterGen XfadeFilterGen(this ImageMap input0, ImageMap input1) => new XfadeFilterGen(input0, input1);
/// <summary>
/// Cross fade one video with another video.
/// </summary>
public static XfadeFilterGen XfadeFilterGen(this ImageMap input0, ImageMap input1,XfadeFilterGenConfig config)
{
var result = new XfadeFilterGen(input0, input1);
if(config?.transition != null) result.transition(config.transition);
if(config?.duration != null) result.duration(config.duration);
if(config?.offset != null) result.offset(config.offset);
if(config?.expr != null) result.expr(config.expr);
return result;
}
}
public class XfadeFilterGenConfig
{
/// <summary>
///  set cross fade transition (from -1 to 42) (default fade)
/// </summary>
public XfadeFilterGenTransition transition { get; set; }
/// <summary>
///  set cross fade duration (default 1)
/// </summary>
public TimeSpan duration { get; set; }
/// <summary>
///  set cross fade start relative to first input stream (default 0)
/// </summary>
public TimeSpan offset { get; set; }
/// <summary>
///  set expression for custom transition
/// </summary>
public string expr { get; set; }
}
public enum XfadeFilterGenTransition
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
[Name("circlecrop")] circlecrop,
[Name("rectcrop")] rectcrop,
[Name("distance")] distance,
[Name("fadeblack")] fadeblack,
[Name("fadewhite")] fadewhite,
[Name("radial")] radial,
[Name("smoothleft")] smoothleft,
[Name("smoothright")] smoothright,
[Name("smoothup")] smoothup,
[Name("smoothdown")] smoothdown,
[Name("circleopen")] circleopen,
[Name("circleclose")] circleclose,
[Name("vertopen")] vertopen,
[Name("vertclose")] vertclose,
[Name("horzopen")] horzopen,
[Name("horzclose")] horzclose,
[Name("dissolve")] dissolve,
[Name("pixelize")] pixelize,
[Name("diagtl")] diagtl,
[Name("diagtr")] diagtr,
[Name("diagbl")] diagbl,
[Name("diagbr")] diagbr,
[Name("hlslice")] hlslice,
[Name("hrslice")] hrslice,
[Name("vuslice")] vuslice,
[Name("vdslice")] vdslice,
[Name("hblur")] hblur,
[Name("fadegrays")] fadegrays,
[Name("wipetl")] wipetl,
[Name("wipetr")] wipetr,
[Name("wipebl")] wipebl,
[Name("wipebr")] wipebr,
[Name("squeezeh")] squeezeh,
[Name("squeezev")] squeezev,
}

}
