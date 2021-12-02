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
public class RgbashiftFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal RgbashiftFilterGen(ImageMap input) : base("rgbashift",input) { AddMapOut(); }
/// <summary>
///  shift red horizontally (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen rh(int rh) => this.SetOptionRange("rh", rh,-255,255);
/// <summary>
///  shift red vertically (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen rv(int rv) => this.SetOptionRange("rv", rv,-255,255);
/// <summary>
///  shift green horizontally (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen gh(int gh) => this.SetOptionRange("gh", gh,-255,255);
/// <summary>
///  shift green vertically (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen gv(int gv) => this.SetOptionRange("gv", gv,-255,255);
/// <summary>
///  shift blue horizontally (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen bh(int bh) => this.SetOptionRange("bh", bh,-255,255);
/// <summary>
///  shift blue vertically (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen bv(int bv) => this.SetOptionRange("bv", bv,-255,255);
/// <summary>
///  shift alpha horizontally (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen ah(int ah) => this.SetOptionRange("ah", ah,-255,255);
/// <summary>
///  shift alpha vertically (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen av(int av) => this.SetOptionRange("av", av,-255,255);
/// <summary>
///  set edge operation (from 0 to 1) (default smear)
/// </summary>
public RgbashiftFilterGen edge(RgbashiftFilterGenEdge edge) => this.SetOption("edge", edge.GetAttribute<NameAttribute>().Name);
}
public static class RgbashiftFilterGenExtensions
{
/// <summary>
/// Shift RGBA.
/// </summary>
public static RgbashiftFilterGen RgbashiftFilterGen(this ImageMap input0) => new RgbashiftFilterGen(input0);
/// <summary>
/// Shift RGBA.
/// </summary>
public static RgbashiftFilterGen RgbashiftFilterGen(this ImageMap input0,RgbashiftFilterGenConfig config)
{
var result = new RgbashiftFilterGen(input0);
if(config?.rh != null) result.rh(config.rh);
if(config?.rv != null) result.rv(config.rv);
if(config?.gh != null) result.gh(config.gh);
if(config?.gv != null) result.gv(config.gv);
if(config?.bh != null) result.bh(config.bh);
if(config?.bv != null) result.bv(config.bv);
if(config?.ah != null) result.ah(config.ah);
if(config?.av != null) result.av(config.av);
if(config?.edge != null) result.edge(config.edge);
return result;
}
}
public class RgbashiftFilterGenConfig
{
/// <summary>
///  shift red horizontally (from -255 to 255) (default 0)
/// </summary>
public int rh { get; set; }
/// <summary>
///  shift red vertically (from -255 to 255) (default 0)
/// </summary>
public int rv { get; set; }
/// <summary>
///  shift green horizontally (from -255 to 255) (default 0)
/// </summary>
public int gh { get; set; }
/// <summary>
///  shift green vertically (from -255 to 255) (default 0)
/// </summary>
public int gv { get; set; }
/// <summary>
///  shift blue horizontally (from -255 to 255) (default 0)
/// </summary>
public int bh { get; set; }
/// <summary>
///  shift blue vertically (from -255 to 255) (default 0)
/// </summary>
public int bv { get; set; }
/// <summary>
///  shift alpha horizontally (from -255 to 255) (default 0)
/// </summary>
public int ah { get; set; }
/// <summary>
///  shift alpha vertically (from -255 to 255) (default 0)
/// </summary>
public int av { get; set; }
/// <summary>
///  set edge operation (from 0 to 1) (default smear)
/// </summary>
public RgbashiftFilterGenEdge edge { get; set; }
}
public enum RgbashiftFilterGenEdge
{
[Name("smear")] smear,
[Name("wrap")] wrap,
}

}
