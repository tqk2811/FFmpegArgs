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
public RotateFilterGen bilinear(bool bilinear) => this.SetOption("bilinear",bilinear.ToFFmpegFlag());
}
public static class RotateFilterGenExtensions
{
/// <summary>
/// Rotate the input image.
/// </summary>
public static RotateFilterGen RotateFilterGen(this ImageMap input0) => new RotateFilterGen(input0);
/// <summary>
/// Rotate the input image.
/// </summary>
public static RotateFilterGen RotateFilterGen(this ImageMap input0,RotateFilterGenConfig config)
{
var result = new RotateFilterGen(input0);
if(config?.angle != null) result.angle(config.angle);
if(config?.out_w != null) result.out_w(config.out_w);
if(config?.ow != null) result.ow(config.ow);
if(config?.out_h != null) result.out_h(config.out_h);
if(config?.oh != null) result.oh(config.oh);
if(config?.fillcolor != null) result.fillcolor(config.fillcolor);
if(config?.c != null) result.c(config.c);
if(config?.bilinear != null) result.bilinear(config.bilinear);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class RotateFilterGenConfig
{
/// <summary>
///  set angle (in radians) (default "0")
/// </summary>
public string angle { get; set; }
/// <summary>
///  set output width expression (default "iw")
/// </summary>
public string out_w { get; set; }
/// <summary>
///  set output width expression (default "iw")
/// </summary>
public string ow { get; set; }
/// <summary>
///  set output height expression (default "ih")
/// </summary>
public string out_h { get; set; }
/// <summary>
///  set output height expression (default "ih")
/// </summary>
public string oh { get; set; }
/// <summary>
///  set background fill color (default "black")
/// </summary>
public string fillcolor { get; set; }
/// <summary>
///  set background fill color (default "black")
/// </summary>
public string c { get; set; }
/// <summary>
///  use bilinear interpolation (default true)
/// </summary>
public bool bilinear { get; set; }
public string TimelineSupport { get; set; }
}
}
