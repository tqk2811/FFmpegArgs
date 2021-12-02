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
public class ColorbalanceFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorbalanceFilterGen(ImageMap input) : base("colorbalance",input) { AddMapOut(); }
/// <summary>
///  set red shadows (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen rs(float rs) => this.SetOptionRange("rs", rs,-1,1);
/// <summary>
///  set green shadows (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen gs(float gs) => this.SetOptionRange("gs", gs,-1,1);
/// <summary>
///  set blue shadows (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen bs(float bs) => this.SetOptionRange("bs", bs,-1,1);
/// <summary>
///  set red midtones (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen rm(float rm) => this.SetOptionRange("rm", rm,-1,1);
/// <summary>
///  set green midtones (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen gm(float gm) => this.SetOptionRange("gm", gm,-1,1);
/// <summary>
///  set blue midtones (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen bm(float bm) => this.SetOptionRange("bm", bm,-1,1);
/// <summary>
///  set red highlights (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen rh(float rh) => this.SetOptionRange("rh", rh,-1,1);
/// <summary>
///  set green highlights (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen gh(float gh) => this.SetOptionRange("gh", gh,-1,1);
/// <summary>
///  set blue highlights (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen bh(float bh) => this.SetOptionRange("bh", bh,-1,1);
/// <summary>
///  preserve lightness (default false)
/// </summary>
public ColorbalanceFilterGen pl(bool pl) => this.SetOption("pl",pl.ToFFmpegFlag());
}
public static class ColorbalanceFilterGenExtensions
{
/// <summary>
/// Adjust the color balance.
/// </summary>
public static ColorbalanceFilterGen ColorbalanceFilterGen(this ImageMap input0) => new ColorbalanceFilterGen(input0);
/// <summary>
/// Adjust the color balance.
/// </summary>
public static ColorbalanceFilterGen ColorbalanceFilterGen(this ImageMap input0,ColorbalanceFilterGenConfig config)
{
var result = new ColorbalanceFilterGen(input0);
if(config?.rs != null) result.rs(config.rs);
if(config?.gs != null) result.gs(config.gs);
if(config?.bs != null) result.bs(config.bs);
if(config?.rm != null) result.rm(config.rm);
if(config?.gm != null) result.gm(config.gm);
if(config?.bm != null) result.bm(config.bm);
if(config?.rh != null) result.rh(config.rh);
if(config?.gh != null) result.gh(config.gh);
if(config?.bh != null) result.bh(config.bh);
if(config?.pl != null) result.pl(config.pl);
return result;
}
}
public class ColorbalanceFilterGenConfig
{
/// <summary>
///  set red shadows (from -1 to 1) (default 0)
/// </summary>
public float rs { get; set; }
/// <summary>
///  set green shadows (from -1 to 1) (default 0)
/// </summary>
public float gs { get; set; }
/// <summary>
///  set blue shadows (from -1 to 1) (default 0)
/// </summary>
public float bs { get; set; }
/// <summary>
///  set red midtones (from -1 to 1) (default 0)
/// </summary>
public float rm { get; set; }
/// <summary>
///  set green midtones (from -1 to 1) (default 0)
/// </summary>
public float gm { get; set; }
/// <summary>
///  set blue midtones (from -1 to 1) (default 0)
/// </summary>
public float bm { get; set; }
/// <summary>
///  set red highlights (from -1 to 1) (default 0)
/// </summary>
public float rh { get; set; }
/// <summary>
///  set green highlights (from -1 to 1) (default 0)
/// </summary>
public float gh { get; set; }
/// <summary>
///  set blue highlights (from -1 to 1) (default 0)
/// </summary>
public float bh { get; set; }
/// <summary>
///  preserve lightness (default false)
/// </summary>
public bool pl { get; set; }
}
}
