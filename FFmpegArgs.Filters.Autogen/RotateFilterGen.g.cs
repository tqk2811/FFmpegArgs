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
public class RotateFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal RotateFilterGen(ImageMap input) : base("rotate",input) { AddMapOut(); }
/// <summary>
///  set angle (in radians) (default "0")
/// </summary>
public RotateFilterGen angle(string angle) => this.SetOption("angle",angle);
/// <summary>
///  set angle (in radians) (default "0")
/// </summary>
public RotateFilterGen a(string a) => this.SetOption("a",a);
/// <summary>
///  set output width expression (default "iw")
/// </summary>
public RotateFilterGen out_w(string out_w) => this.SetOption("out_w",out_w);
/// <summary>
///  set output width expression (default "iw")
/// </summary>
public RotateFilterGen ow(string ow) => this.SetOption("ow",ow);
/// <summary>
///  set output height expression (default "ih")
/// </summary>
public RotateFilterGen out_h(string out_h) => this.SetOption("out_h",out_h);
/// <summary>
///  set output height expression (default "ih")
/// </summary>
public RotateFilterGen oh(string oh) => this.SetOption("oh",oh);
/// <summary>
///  set background fill color (default "black")
/// </summary>
public RotateFilterGen fillcolor(string fillcolor) => this.SetOption("fillcolor",fillcolor);
/// <summary>
///  set background fill color (default "black")
/// </summary>
public RotateFilterGen c(string c) => this.SetOption("c",c);
/// <summary>
///  use bilinear interpolation (default true)
/// </summary>
public RotateFilterGen bilinear(bool flag) => this.SetOption("bilinear",flag.ToFFmpegFlag());
}
public static class RotateFilterGenExtensions
{
/// <summary>
/// Rotate the input image.
/// </summary>
public static RotateFilterGen RotateFilterGen(this ImageMap input0) => new RotateFilterGen(input0);
}
}
