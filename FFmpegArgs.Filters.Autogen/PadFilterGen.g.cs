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
public class PadFilterGen : ImageToImageFilter
{
internal PadFilterGen(ImageMap input) : base("pad",input) { AddMapOut(); }
/// <summary>
///  set the pad area width expression (default "iw")
/// </summary>
public PadFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  set the pad area height expression (default "ih")
/// </summary>
public PadFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set the x offset expression for the input image position (default "0")
/// </summary>
public PadFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set the y offset expression for the input image position (default "0")
/// </summary>
public PadFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set the color of the padded area border (default "black")
/// </summary>
public PadFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public PadFilterGen eval(PadFilterGenEval eval) => this.SetOption("eval", eval.GetAttribute<NameAttribute>().Name);
/// <summary>
///  pad to fit an aspect instead of a resolution (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public PadFilterGen aspect(Rational aspect) => this.SetOption("aspect",aspect.Check(0,DBL_MAX));
}
public static class PadFilterGenExtensions
{
/// <summary>
/// Pad the input video.
/// </summary>
public static PadFilterGen PadFilterGen(this ImageMap input0) => new PadFilterGen(input0);
/// <summary>
/// Pad the input video.
/// </summary>
public static PadFilterGen PadFilterGen(this ImageMap input0,PadFilterGenConfig config)
{
var result = new PadFilterGen(input0);
if(config?.width != null) result.width(config.width);
if(config?.height != null) result.height(config.height);
if(config?.x != null) result.x(config.x);
if(config?.y != null) result.y(config.y);
if(config?.color != null) result.color(config.color);
if(config?.eval != null) result.eval(config.eval);
if(config?.aspect != null) result.aspect(config.aspect);
return result;
}
}
public class PadFilterGenConfig
{
/// <summary>
///  set the pad area width expression (default "iw")
/// </summary>
public string width { get; set; }
/// <summary>
///  set the pad area height expression (default "ih")
/// </summary>
public string height { get; set; }
/// <summary>
///  set the x offset expression for the input image position (default "0")
/// </summary>
public string x { get; set; }
/// <summary>
///  set the y offset expression for the input image position (default "0")
/// </summary>
public string y { get; set; }
/// <summary>
///  set the color of the padded area border (default "black")
/// </summary>
public Color color { get; set; }
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public PadFilterGenEval eval { get; set; }
/// <summary>
///  pad to fit an aspect instead of a resolution (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public Rational aspect { get; set; }
}
public enum PadFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
