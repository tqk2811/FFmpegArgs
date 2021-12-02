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
public class BlackdetectFilterGen : ImageToImageFilter,ISliceThreading
{
internal BlackdetectFilterGen(ImageMap input) : base("blackdetect",input) { AddMapOut(); }
/// <summary>
///  set minimum detected black duration in seconds (from 0 to DBL_MAX) (default 2)
/// </summary>
public BlackdetectFilterGen d(double d) => this.SetOptionRange("d", d,0,DBL_MAX);
/// <summary>
///  set minimum detected black duration in seconds (from 0 to DBL_MAX) (default 2)
/// </summary>
public BlackdetectFilterGen black_min_duration(double black_min_duration) => this.SetOptionRange("black_min_duration", black_min_duration,0,DBL_MAX);
/// <summary>
///  set the picture black ratio threshold (from 0 to 1) (default 0.98)
/// </summary>
public BlackdetectFilterGen picture_black_ratio_th(double picture_black_ratio_th) => this.SetOptionRange("picture_black_ratio_th", picture_black_ratio_th,0,1);
/// <summary>
///  set the picture black ratio threshold (from 0 to 1) (default 0.98)
/// </summary>
public BlackdetectFilterGen pic_th(double pic_th) => this.SetOptionRange("pic_th", pic_th,0,1);
/// <summary>
///  set the pixel black threshold (from 0 to 1) (default 0.1)
/// </summary>
public BlackdetectFilterGen pixel_black_th(double pixel_black_th) => this.SetOptionRange("pixel_black_th", pixel_black_th,0,1);
/// <summary>
///  set the pixel black threshold (from 0 to 1) (default 0.1)
/// </summary>
public BlackdetectFilterGen pix_th(double pix_th) => this.SetOptionRange("pix_th", pix_th,0,1);
}
public static class BlackdetectFilterGenExtensions
{
/// <summary>
/// Detect video intervals that are (almost) black.
/// </summary>
public static BlackdetectFilterGen BlackdetectFilterGen(this ImageMap input0) => new BlackdetectFilterGen(input0);
/// <summary>
/// Detect video intervals that are (almost) black.
/// </summary>
public static BlackdetectFilterGen BlackdetectFilterGen(this ImageMap input0,BlackdetectFilterGenConfig config)
{
var result = new BlackdetectFilterGen(input0);
if(config?.d != null) result.d(config.d.Value);
if(config?.black_min_duration != null) result.black_min_duration(config.black_min_duration.Value);
if(config?.picture_black_ratio_th != null) result.picture_black_ratio_th(config.picture_black_ratio_th.Value);
if(config?.pic_th != null) result.pic_th(config.pic_th.Value);
if(config?.pixel_black_th != null) result.pixel_black_th(config.pixel_black_th.Value);
if(config?.pix_th != null) result.pix_th(config.pix_th.Value);
return result;
}
}
public class BlackdetectFilterGenConfig
{
/// <summary>
///  set minimum detected black duration in seconds (from 0 to DBL_MAX) (default 2)
/// </summary>
public double? d { get; set; }
/// <summary>
///  set minimum detected black duration in seconds (from 0 to DBL_MAX) (default 2)
/// </summary>
public double? black_min_duration { get; set; }
/// <summary>
///  set the picture black ratio threshold (from 0 to 1) (default 0.98)
/// </summary>
public double? picture_black_ratio_th { get; set; }
/// <summary>
///  set the picture black ratio threshold (from 0 to 1) (default 0.98)
/// </summary>
public double? pic_th { get; set; }
/// <summary>
///  set the pixel black threshold (from 0 to 1) (default 0.1)
/// </summary>
public double? pixel_black_th { get; set; }
/// <summary>
///  set the pixel black threshold (from 0 to 1) (default 0.1)
/// </summary>
public double? pix_th { get; set; }
}
}
