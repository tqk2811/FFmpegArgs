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
public class EstdifFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal EstdifFilterGen(ImageMap input) : base("estdif",input) { AddMapOut(); }
/// <summary>
///  specify the mode (from 0 to 1) (default field)
/// </summary>
public EstdifFilterGen mode(EstdifFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public EstdifFilterGen parity(EstdifFilterGenParity parity) => this.SetOption("parity", parity.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public EstdifFilterGen deint(EstdifFilterGenDeint deint) => this.SetOption("deint", deint.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify the search radius for edge slope tracing (from 1 to 15) (default 1)
/// </summary>
public EstdifFilterGen rslope(int rslope) => this.SetOptionRange("rslope", rslope,1,15);
/// <summary>
///  specify the search radius for best edge matching (from 0 to 15) (default 2)
/// </summary>
public EstdifFilterGen redge(int redge) => this.SetOptionRange("redge", redge,0,15);
/// <summary>
///  specify the type of interpolation (from 0 to 2) (default 4p)
/// </summary>
public EstdifFilterGen interp(EstdifFilterGenInterp interp) => this.SetOption("interp", interp.GetAttribute<NameAttribute>().Name);
}
public static class EstdifFilterGenExtensions
{
/// <summary>
/// Apply Edge Slope Tracing deinterlace.
/// </summary>
public static EstdifFilterGen EstdifFilterGen(this ImageMap input0) => new EstdifFilterGen(input0);
/// <summary>
/// Apply Edge Slope Tracing deinterlace.
/// </summary>
public static EstdifFilterGen EstdifFilterGen(this ImageMap input0,EstdifFilterGenConfig config)
{
var result = new EstdifFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.parity != null) result.parity(config.parity.Value);
if(config?.deint != null) result.deint(config.deint.Value);
if(config?.rslope != null) result.rslope(config.rslope.Value);
if(config?.redge != null) result.redge(config.redge.Value);
if(config?.interp != null) result.interp(config.interp.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class EstdifFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  specify the mode (from 0 to 1) (default field)
/// </summary>
public EstdifFilterGenMode? mode { get; set; }
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public EstdifFilterGenParity? parity { get; set; }
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public EstdifFilterGenDeint? deint { get; set; }
/// <summary>
///  specify the search radius for edge slope tracing (from 1 to 15) (default 1)
/// </summary>
public int? rslope { get; set; }
/// <summary>
///  specify the search radius for best edge matching (from 0 to 15) (default 2)
/// </summary>
public int? redge { get; set; }
/// <summary>
///  specify the type of interpolation (from 0 to 2) (default 4p)
/// </summary>
public EstdifFilterGenInterp? interp { get; set; }
public string TimelineSupport { get; set; }
}
public enum EstdifFilterGenMode
{
[Name("frame")] frame,
[Name("field")] field,
}

public enum EstdifFilterGenParity
{
[Name("tff")] tff,
[Name("bff")] bff,
[Name("auto")] auto,
}

public enum EstdifFilterGenDeint
{
[Name("all")] all,
[Name("interlaced")] interlaced,
}

public enum EstdifFilterGenInterp
{
[Name("2p")] _2p,
[Name("4p")] _4p,
[Name("6p")] _6p,
}

}
