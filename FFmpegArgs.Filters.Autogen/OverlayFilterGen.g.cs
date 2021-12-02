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
public class OverlayFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal OverlayFilterGen(params ImageMap[] inputs) : base("overlay",inputs) { AddMapOut(); }
/// <summary>
///  set the x expression (default "0")
/// </summary>
public OverlayFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set the y expression (default "0")
/// </summary>
public OverlayFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public OverlayFilterGen eof_action(OverlayFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default frame)
/// </summary>
public OverlayFilterGen eval(OverlayFilterGenEval eval) => this.SetOption("eval", eval.GetAttribute<NameAttribute>().Name);
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public OverlayFilterGen shortest(bool shortest) => this.SetOption("shortest",shortest.ToFFmpegFlag());
/// <summary>
///  set output format (from 0 to 7) (default yuv420)
/// </summary>
public OverlayFilterGen format(OverlayFilterGenFormat format) => this.SetOption("format", format.GetAttribute<NameAttribute>().Name);
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public OverlayFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast",repeatlast.ToFFmpegFlag());
/// <summary>
///  alpha format (from 0 to 1) (default straight)
/// </summary>
public OverlayFilterGen alpha(OverlayFilterGenAlpha alpha) => this.SetOption("alpha", alpha.GetAttribute<NameAttribute>().Name);
}
public static class OverlayFilterGenExtensions
{
/// <summary>
/// Overlay a video source on top of the input.
/// </summary>
public static OverlayFilterGen OverlayFilterGen(this ImageMap input0, ImageMap input1) => new OverlayFilterGen(input0, input1);
/// <summary>
/// Overlay a video source on top of the input.
/// </summary>
public static OverlayFilterGen OverlayFilterGen(this ImageMap input0, ImageMap input1,OverlayFilterGenConfig config)
{
var result = new OverlayFilterGen(input0, input1);
if(config?.x != null) result.x(config.x);
if(config?.y != null) result.y(config.y);
if(config?.eof_action != null) result.eof_action(config.eof_action);
if(config?.eval != null) result.eval(config.eval);
if(config?.shortest != null) result.shortest(config.shortest);
if(config?.format != null) result.format(config.format);
if(config?.repeatlast != null) result.repeatlast(config.repeatlast);
if(config?.alpha != null) result.alpha(config.alpha);
return result;
}
}
public class OverlayFilterGenConfig
{
/// <summary>
///  set the x expression (default "0")
/// </summary>
public string x { get; set; }
/// <summary>
///  set the y expression (default "0")
/// </summary>
public string y { get; set; }
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public OverlayFilterGenEof_action eof_action { get; set; }
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default frame)
/// </summary>
public OverlayFilterGenEval eval { get; set; }
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public bool shortest { get; set; }
/// <summary>
///  set output format (from 0 to 7) (default yuv420)
/// </summary>
public OverlayFilterGenFormat format { get; set; }
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public bool repeatlast { get; set; }
/// <summary>
///  alpha format (from 0 to 1) (default straight)
/// </summary>
public OverlayFilterGenAlpha alpha { get; set; }
}
public enum OverlayFilterGenEof_action
{
[Name("repeat")] repeat,
[Name("endall")] endall,
[Name("pass")] pass,
}

public enum OverlayFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

public enum OverlayFilterGenFormat
{
[Name("yuv420")] yuv420,
[Name("yuv420p10")] yuv420p10,
[Name("yuv422")] yuv422,
[Name("yuv422p10")] yuv422p10,
[Name("yuv444")] yuv444,
[Name("rgb")] rgb,
[Name("gbrp")] gbrp,
[Name("auto")] auto,
}

public enum OverlayFilterGenAlpha
{
[Name("straight")] straight,
[Name("premultiplied")] premultiplied,
}

}
