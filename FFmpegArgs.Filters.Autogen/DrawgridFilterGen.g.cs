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
public class DrawgridFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal DrawgridFilterGen(ImageMap input) : base("drawgrid",input) { AddMapOut(); }
/// <summary>
///  set horizontal offset (default "0")
/// </summary>
public DrawgridFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set vertical offset (default "0")
/// </summary>
public DrawgridFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set width of grid cell (default "0")
/// </summary>
public DrawgridFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  set height of grid cell (default "0")
/// </summary>
public DrawgridFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set color of the grid (default "black")
/// </summary>
public DrawgridFilterGen color(string color) => this.SetOption("color",color);
/// <summary>
///  set grid line thickness (default "1")
/// </summary>
public DrawgridFilterGen thickness(string thickness) => this.SetOption("thickness",thickness);
/// <summary>
///  replace color & alpha (default false)
/// </summary>
public DrawgridFilterGen replace(bool replace) => this.SetOption("replace",replace.ToFFmpegFlag());
}
public static class DrawgridFilterGenExtensions
{
/// <summary>
/// Draw a colored grid on the input video.
/// </summary>
public static DrawgridFilterGen DrawgridFilterGen(this ImageMap input0) => new DrawgridFilterGen(input0);
/// <summary>
/// Draw a colored grid on the input video.
/// </summary>
public static DrawgridFilterGen DrawgridFilterGen(this ImageMap input0,DrawgridFilterGenConfig config)
{
var result = new DrawgridFilterGen(input0);
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
public class DrawgridFilterGenConfig
{
/// <summary>
///  set horizontal offset (default "0")
/// </summary>
public string x { get; set; }
/// <summary>
///  set vertical offset (default "0")
/// </summary>
public string y { get; set; }
/// <summary>
///  set width of grid cell (default "0")
/// </summary>
public string width { get; set; }
/// <summary>
///  set height of grid cell (default "0")
/// </summary>
public string height { get; set; }
/// <summary>
///  set color of the grid (default "black")
/// </summary>
public string color { get; set; }
/// <summary>
///  set grid line thickness (default "1")
/// </summary>
public string thickness { get; set; }
/// <summary>
///  replace color & alpha (default false)
/// </summary>
public bool replace { get; set; }
public string TimelineSupport { get; set; }
}
}
