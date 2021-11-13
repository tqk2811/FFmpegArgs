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
public class PerspectiveFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal PerspectiveFilterGen(ImageMap input) : base("perspective",input) { AddMapOut(); }
/// <summary>
///  set top left x coordinate (default "0")
/// </summary>
public PerspectiveFilterGen x0(string x0) => this.SetOption("x0",x0);
/// <summary>
///  set top left y coordinate (default "0")
/// </summary>
public PerspectiveFilterGen y0(string y0) => this.SetOption("y0",y0);
/// <summary>
///  set top right x coordinate (default "W")
/// </summary>
public PerspectiveFilterGen x1(string x1) => this.SetOption("x1",x1);
/// <summary>
///  set top right y coordinate (default "0")
/// </summary>
public PerspectiveFilterGen y1(string y1) => this.SetOption("y1",y1);
/// <summary>
///  set bottom left x coordinate (default "0")
/// </summary>
public PerspectiveFilterGen x2(string x2) => this.SetOption("x2",x2);
/// <summary>
///  set bottom left y coordinate (default "H")
/// </summary>
public PerspectiveFilterGen y2(string y2) => this.SetOption("y2",y2);
/// <summary>
///  set bottom right x coordinate (default "W")
/// </summary>
public PerspectiveFilterGen x3(string x3) => this.SetOption("x3",x3);
/// <summary>
///  set bottom right y coordinate (default "H")
/// </summary>
public PerspectiveFilterGen y3(string y3) => this.SetOption("y3",y3);
/// <summary>
///  set interpolation (from 0 to 1) (default linear)
/// </summary>
public PerspectiveFilterGen interpolation(PerspectiveFilterGenInterpolation interpolation) => this.SetOption("interpolation", interpolation.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify the sense of the coordinates (from 0 to 1) (default source)
/// </summary>
public PerspectiveFilterGen sense(PerspectiveFilterGenSense sense) => this.SetOption("sense", sense.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public PerspectiveFilterGen eval(PerspectiveFilterGenEval eval) => this.SetOption("eval", eval.GetAttribute<NameAttribute>().Name);
}
public static class PerspectiveFilterGenExtensions
{
/// <summary>
/// Correct the perspective of video.
/// </summary>
public static PerspectiveFilterGen PerspectiveFilterGen(this ImageMap input0) => new PerspectiveFilterGen(input0);
}
public enum PerspectiveFilterGenInterpolation
{
[Name("linear")] linear,
[Name("cubic")] cubic,
}

public enum PerspectiveFilterGenSense
{
[Name("source")] source,
[Name("destination")] destination,
}

public enum PerspectiveFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
