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
public VignetteFilterGen dither(bool dither) => this.SetOption("dither",dither.ToFFmpegFlag());
/// <summary>
///  set aspect ratio (from 0 to DBL_MAX) (default 1/1)
/// </summary>
public VignetteFilterGen aspect(Rational aspect) => this.SetOption("aspect",aspect.Check(0,DBL_MAX));
}
public static class VignetteFilterGenExtensions
{
/// <summary>
/// Make or reverse a vignette effect.
/// </summary>
public static VignetteFilterGen VignetteFilterGen(this ImageMap input0) => new VignetteFilterGen(input0);
/// <summary>
/// Make or reverse a vignette effect.
/// </summary>
public static VignetteFilterGen VignetteFilterGen(this ImageMap input0,VignetteFilterGenConfig config)
{
var result = new VignetteFilterGen(input0);
if(config?.angle != null) result.angle(config.angle);
if(config?.x0 != null) result.x0(config.x0);
if(config?.y0 != null) result.y0(config.y0);
if(config?.mode != null) result.mode(config.mode);
if(config?.eval != null) result.eval(config.eval);
if(config?.dither != null) result.dither(config.dither);
if(config?.aspect != null) result.aspect(config.aspect);
return result;
}
}
public class VignetteFilterGenConfig
{
/// <summary>
///  set lens angle (default "PI/5")
/// </summary>
public string angle { get; set; }
/// <summary>
///  set circle center position on x-axis (default "w/2")
/// </summary>
public string x0 { get; set; }
/// <summary>
///  set circle center position on y-axis (default "h/2")
/// </summary>
public string y0 { get; set; }
/// <summary>
///  set forward/backward mode (from 0 to 1) (default forward)
/// </summary>
public VignetteFilterGenMode mode { get; set; }
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public VignetteFilterGenEval eval { get; set; }
/// <summary>
///  set dithering (default true)
/// </summary>
public bool dither { get; set; }
/// <summary>
///  set aspect ratio (from 0 to DBL_MAX) (default 1/1)
/// </summary>
public Rational aspect { get; set; }
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
