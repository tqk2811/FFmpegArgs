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
public class VidstabtransformFilterGen : ImageToImageFilter
{
internal VidstabtransformFilterGen(ImageMap input) : base("vidstabtransform",input) { AddMapOut(); }
/// <summary>
///  set path to the file storing the transforms (default "transforms.trf")
/// </summary>
public VidstabtransformFilterGen input(string input) => this.SetOption("input",input);
/// <summary>
///  set number of frames*2 + 1 used for lowpass filtering (from 0 to 1000) (default 15)
/// </summary>
public VidstabtransformFilterGen smoothing(int smoothing) => this.SetOptionRange("smoothing", smoothing,0,1000);
/// <summary>
///  set camera path optimization algo (from 0 to 2) (default opt)
/// </summary>
public VidstabtransformFilterGen optalgo(VidstabtransformFilterGenOptalgo optalgo) => this.SetOption("optalgo", optalgo.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set maximal number of pixels to translate image (from -1 to 500) (default -1)
/// </summary>
public VidstabtransformFilterGen maxshift(int maxshift) => this.SetOptionRange("maxshift", maxshift,-1,500);
/// <summary>
///  set maximal angle in rad to rotate image (from -1 to 3.14) (default -1)
/// </summary>
public VidstabtransformFilterGen maxangle(double maxangle) => this.SetOptionRange("maxangle", maxangle,-1,3.14);
/// <summary>
///  set cropping mode (from 0 to 1) (default keep)
/// </summary>
public VidstabtransformFilterGen crop(VidstabtransformFilterGenCrop crop) => this.SetOption("crop", crop.GetAttribute<NameAttribute>().Name);
/// <summary>
///  invert transforms (from 0 to 1) (default 0)
/// </summary>
public VidstabtransformFilterGen invert(int invert) => this.SetOptionRange("invert", invert,0,1);
/// <summary>
///  consider transforms as relative (from 0 to 1) (default 1)
/// </summary>
public VidstabtransformFilterGen relative(int relative) => this.SetOptionRange("relative", relative,0,1);
/// <summary>
///  set percentage to zoom (>0: zoom in, <0: zoom out (from -100 to 100) (default 0)
/// </summary>
public VidstabtransformFilterGen zoom(double zoom) => this.SetOptionRange("zoom", zoom,-100,100);
/// <summary>
///  set optimal zoom (0: nothing, 1: optimal static zoom, 2: optimal dynamic zoom) (from 0 to 2) (default 1)
/// </summary>
public VidstabtransformFilterGen optzoom(int optzoom) => this.SetOptionRange("optzoom", optzoom,0,2);
/// <summary>
///  for adative zoom: percent to zoom maximally each frame (from 0 to 5) (default 0.25)
/// </summary>
public VidstabtransformFilterGen zoomspeed(double zoomspeed) => this.SetOptionRange("zoomspeed", zoomspeed,0,5);
/// <summary>
///  set type of interpolation (from 0 to 3) (default bilinear)
/// </summary>
public VidstabtransformFilterGen interpol(VidstabtransformFilterGenInterpol interpol) => this.SetOption("interpol", interpol.GetAttribute<NameAttribute>().Name);
/// <summary>
///  enable virtual tripod mode (same as relative=0:smoothing=0) (default false)
/// </summary>
public VidstabtransformFilterGen tripod(bool tripod) => this.SetOption("tripod",tripod.ToFFmpegFlag());
/// <summary>
///  enable debug mode and writer global motions information to file (default false)
/// </summary>
public VidstabtransformFilterGen debug(bool debug) => this.SetOption("debug",debug.ToFFmpegFlag());
}
public static class VidstabtransformFilterGenExtensions
{
/// <summary>
/// Transform the frames, pass 2 of 2 for stabilization (see vidstabdetect for pass 1).
/// </summary>
public static VidstabtransformFilterGen VidstabtransformFilterGen(this ImageMap input0) => new VidstabtransformFilterGen(input0);
/// <summary>
/// Transform the frames, pass 2 of 2 for stabilization (see vidstabdetect for pass 1).
/// </summary>
public static VidstabtransformFilterGen VidstabtransformFilterGen(this ImageMap input0,VidstabtransformFilterGenConfig config)
{
var result = new VidstabtransformFilterGen(input0);
if(config?.input != null) result.input(config.input);
if(config?.smoothing != null) result.smoothing(config.smoothing);
if(config?.optalgo != null) result.optalgo(config.optalgo);
if(config?.maxshift != null) result.maxshift(config.maxshift);
if(config?.maxangle != null) result.maxangle(config.maxangle);
if(config?.crop != null) result.crop(config.crop);
if(config?.invert != null) result.invert(config.invert);
if(config?.relative != null) result.relative(config.relative);
if(config?.zoom != null) result.zoom(config.zoom);
if(config?.optzoom != null) result.optzoom(config.optzoom);
if(config?.zoomspeed != null) result.zoomspeed(config.zoomspeed);
if(config?.interpol != null) result.interpol(config.interpol);
if(config?.tripod != null) result.tripod(config.tripod);
if(config?.debug != null) result.debug(config.debug);
return result;
}
}
public class VidstabtransformFilterGenConfig
{
/// <summary>
///  set path to the file storing the transforms (default "transforms.trf")
/// </summary>
public string input { get; set; }
/// <summary>
///  set number of frames*2 + 1 used for lowpass filtering (from 0 to 1000) (default 15)
/// </summary>
public int smoothing { get; set; }
/// <summary>
///  set camera path optimization algo (from 0 to 2) (default opt)
/// </summary>
public VidstabtransformFilterGenOptalgo optalgo { get; set; }
/// <summary>
///  set maximal number of pixels to translate image (from -1 to 500) (default -1)
/// </summary>
public int maxshift { get; set; }
/// <summary>
///  set maximal angle in rad to rotate image (from -1 to 3.14) (default -1)
/// </summary>
public double maxangle { get; set; }
/// <summary>
///  set cropping mode (from 0 to 1) (default keep)
/// </summary>
public VidstabtransformFilterGenCrop crop { get; set; }
/// <summary>
///  invert transforms (from 0 to 1) (default 0)
/// </summary>
public int invert { get; set; }
/// <summary>
///  consider transforms as relative (from 0 to 1) (default 1)
/// </summary>
public int relative { get; set; }
/// <summary>
///  set percentage to zoom (>0: zoom in, <0: zoom out (from -100 to 100) (default 0)
/// </summary>
public double zoom { get; set; }
/// <summary>
///  set optimal zoom (0: nothing, 1: optimal static zoom, 2: optimal dynamic zoom) (from 0 to 2) (default 1)
/// </summary>
public int optzoom { get; set; }
/// <summary>
///  for adative zoom: percent to zoom maximally each frame (from 0 to 5) (default 0.25)
/// </summary>
public double zoomspeed { get; set; }
/// <summary>
///  set type of interpolation (from 0 to 3) (default bilinear)
/// </summary>
public VidstabtransformFilterGenInterpol interpol { get; set; }
/// <summary>
///  enable virtual tripod mode (same as relative=0:smoothing=0) (default false)
/// </summary>
public bool tripod { get; set; }
/// <summary>
///  enable debug mode and writer global motions information to file (default false)
/// </summary>
public bool debug { get; set; }
}
public enum VidstabtransformFilterGenOptalgo
{
[Name("opt")] opt,
[Name("gauss")] gauss,
[Name("avg")] avg,
}

public enum VidstabtransformFilterGenCrop
{
[Name("keep")] keep,
[Name("black")] black,
}

public enum VidstabtransformFilterGenInterpol
{
[Name("no")] no,
[Name("linear")] linear,
[Name("bilinear")] bilinear,
[Name("bicubic")] bicubic,
}

}
