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
public class CropFilterGen : ImageToImageFilter,ICommandSupport
{
internal CropFilterGen(ImageMap input) : base("crop",input) { AddMapOut(); }
/// <summary>
///  set the width crop area expression (default "iw")
/// </summary>
public CropFilterGen out_w(string out_w) => this.SetOption("out_w",out_w);
/// <summary>
///  set the width crop area expression (default "iw")
/// </summary>
public CropFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  set the height crop area expression (default "ih")
/// </summary>
public CropFilterGen out_h(string out_h) => this.SetOption("out_h",out_h);
/// <summary>
///  set the height crop area expression (default "ih")
/// </summary>
public CropFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  set the x crop area expression (default "(in_w-out_w)/2")
/// </summary>
public CropFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set the y crop area expression (default "(in_h-out_h)/2")
/// </summary>
public CropFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  keep aspect ratio (default false)
/// </summary>
public CropFilterGen keep_aspect(bool keep_aspect) => this.SetOption("keep_aspect",keep_aspect.ToFFmpegFlag());
/// <summary>
///  do exact cropping (default false)
/// </summary>
public CropFilterGen exact(bool exact) => this.SetOption("exact",exact.ToFFmpegFlag());
}
public static class CropFilterGenExtensions
{
/// <summary>
/// Crop the input video.
/// </summary>
public static CropFilterGen CropFilterGen(this ImageMap input0) => new CropFilterGen(input0);
/// <summary>
/// Crop the input video.
/// </summary>
public static CropFilterGen CropFilterGen(this ImageMap input0,CropFilterGenConfig config)
{
var result = new CropFilterGen(input0);
if(config?.out_w != null) result.out_w(config.out_w);
if(config?.w != null) result.w(config.w);
if(config?.out_h != null) result.out_h(config.out_h);
if(config?.h != null) result.h(config.h);
if(config?.x != null) result.x(config.x);
if(config?.y != null) result.y(config.y);
if(config?.keep_aspect != null) result.keep_aspect(config.keep_aspect);
if(config?.exact != null) result.exact(config.exact);
return result;
}
}
public class CropFilterGenConfig
{
/// <summary>
///  set the width crop area expression (default "iw")
/// </summary>
public string out_w { get; set; }
/// <summary>
///  set the width crop area expression (default "iw")
/// </summary>
public string w { get; set; }
/// <summary>
///  set the height crop area expression (default "ih")
/// </summary>
public string out_h { get; set; }
/// <summary>
///  set the height crop area expression (default "ih")
/// </summary>
public string h { get; set; }
/// <summary>
///  set the x crop area expression (default "(in_w-out_w)/2")
/// </summary>
public string x { get; set; }
/// <summary>
///  set the y crop area expression (default "(in_h-out_h)/2")
/// </summary>
public string y { get; set; }
/// <summary>
///  keep aspect ratio (default false)
/// </summary>
public bool keep_aspect { get; set; }
/// <summary>
///  do exact cropping (default false)
/// </summary>
public bool exact { get; set; }
}
}
