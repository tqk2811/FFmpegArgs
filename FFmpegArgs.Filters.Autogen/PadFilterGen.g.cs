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
///  set the pad area width expression (default "iw")
/// </summary>
public PadFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  set the pad area height expression (default "ih")
/// </summary>
public PadFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set the pad area height expression (default "ih")
/// </summary>
public PadFilterGen h(string h) => this.SetOption("h",h);
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
public PadFilterGen aspect(string aspect) => this.SetOption("aspect",aspect);
}
public static class PadFilterGenExtensions
{
/// <summary>
/// Pad the input video.
/// </summary>
public static PadFilterGen PadFilterGen(this ImageMap input0) => new PadFilterGen(input0);
}
public enum PadFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
