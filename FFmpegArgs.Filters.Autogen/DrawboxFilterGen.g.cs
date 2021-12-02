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
public DrawboxFilterGen replace(bool replace) => this.SetOption("replace",replace.ToFFmpegFlag());
}
public static class DrawboxFilterGenExtensions
{
/// <summary>
/// Draw a colored box on the input video.
/// </summary>
public static DrawboxFilterGen DrawboxFilterGen(this ImageMap input0) => new DrawboxFilterGen(input0);
/// <summary>
/// Draw a colored box on the input video.
/// </summary>
public static DrawboxFilterGen DrawboxFilterGen(this ImageMap input0,DrawboxFilterGenConfig config)
{
var result = new DrawboxFilterGen(input0);
if(config?.x != null) result.x(config.x);
if(config?.y != null) result.y(config.y);
if(config?.width != null) result.width(config.width);
if(config?.height != null) result.height(config.height);
if(config?.color != null) result.color(config.color);
if(config?.thickness != null) result.thickness(config.thickness);
if(config?.replace != null) result.replace(config.replace);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class DrawboxFilterGenConfig
{
/// <summary>
///  set horizontal position of the left box edge (default "0")
/// </summary>
public string x { get; set; }
/// <summary>
///  set vertical position of the top box edge (default "0")
/// </summary>
public string y { get; set; }
/// <summary>
///  set width of the box (default "0")
/// </summary>
public string width { get; set; }
/// <summary>
///  set height of the box (default "0")
/// </summary>
public string height { get; set; }
/// <summary>
///  set color of the box (default "black")
/// </summary>
public string color { get; set; }
/// <summary>
///  set the box thickness (default "3")
/// </summary>
public string thickness { get; set; }
/// <summary>
///  replace color & alpha (default false)
/// </summary>
public bool replace { get; set; }
public string TimelineSupport { get; set; }
}
}
