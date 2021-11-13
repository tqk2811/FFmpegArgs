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
public static EstdifFilterGen EstdifFilterGen(this ImageMap input) => new EstdifFilterGen(input);
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
