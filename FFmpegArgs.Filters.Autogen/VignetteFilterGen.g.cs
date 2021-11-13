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
public class VignetteFilterGen : ImageToImageFilter,ITimelineSupport
{
internal VignetteFilterGen(ImageMap input) : base("vignette",input) { AddMapOut(); }
/// <summary>
///  set lens angle (default "PI/5")
/// </summary>
public VignetteFilterGen angle(string angle) => this.SetOption("angle",angle);
/// <summary>
///  set lens angle (default "PI/5")
/// </summary>
public VignetteFilterGen a(string a) => this.SetOption("a",a);
/// <summary>
///  set circle center position on x-axis (default "w/2")
/// </summary>
public VignetteFilterGen x0(string x0) => this.SetOption("x0",x0);
/// <summary>
///  set circle center position on y-axis (default "h/2")
/// </summary>
public VignetteFilterGen y0(string y0) => this.SetOption("y0",y0);
/// <summary>
///  set forward/backward mode (from 0 to 1) (default forward)
/// </summary>
public VignetteFilterGen mode(VignetteFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public VignetteFilterGen eval(VignetteFilterGenEval eval) => this.SetOption("eval", eval.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set dithering (default true)
/// </summary>
public VignetteFilterGen dither(bool flag) => this.SetOption("dither",flag.ToFFmpegFlag());
/// <summary>
///  set aspect ratio (from 0 to DBL_MAX) (default 1/1)
/// </summary>
public VignetteFilterGen aspect(string aspect) => this.SetOption("aspect",aspect);
}
public static class VignetteFilterGenExtensions
{
/// <summary>
/// Make or reverse a vignette effect.
/// </summary>
public static VignetteFilterGen VignetteFilterGen(this ImageMap input) => new VignetteFilterGen(input);
}
public enum VignetteFilterGenMode
{
[Name("forward")] forward,
[Name("backward")] backward,
}

public enum VignetteFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
