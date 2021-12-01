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
public class DrawboxFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal DrawboxFilterGen(ImageMap input) : base("drawbox",input) { AddMapOut(); }
/// <summary>
///  set horizontal position of the left box edge (default "0")
/// </summary>
public DrawboxFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set vertical position of the top box edge (default "0")
/// </summary>
public DrawboxFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set width of the box (default "0")
/// </summary>
public DrawboxFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  set height of the box (default "0")
/// </summary>
public DrawboxFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set color of the box (default "black")
/// </summary>
public DrawboxFilterGen color(string color) => this.SetOption("color",color);
/// <summary>
///  set the box thickness (default "3")
/// </summary>
public DrawboxFilterGen thickness(string thickness) => this.SetOption("thickness",thickness);
/// <summary>
///  replace color & alpha (default false)
/// </summary>
public DrawboxFilterGen replace(bool flag) => this.SetOption("replace",flag.ToFFmpegFlag());
}
public static class DrawboxFilterGenExtensions
{
/// <summary>
/// Draw a colored box on the input video.
/// </summary>
public static DrawboxFilterGen DrawboxFilterGen(this ImageMap input0) => new DrawboxFilterGen(input0);
}
}
