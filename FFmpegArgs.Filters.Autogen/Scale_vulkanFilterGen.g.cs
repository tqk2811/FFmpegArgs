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
public class Scale_vulkanFilterGen : ImageToImageFilter
{
internal Scale_vulkanFilterGen(ImageMap input) : base("scale_vulkan",input) { AddMapOut(); }
/// <summary>
///  Output video width (default "iw")
/// </summary>
public Scale_vulkanFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video height (default "ih")
/// </summary>
public Scale_vulkanFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Scaler function (from 0 to 2) (default bilinear)
/// </summary>
public Scale_vulkanFilterGen scaler(Scale_vulkanFilterGenScaler scaler) => this.SetOption("scaler", scaler.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Output video format (software format of hardware frames)
/// </summary>
public Scale_vulkanFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
/// </summary>
public Scale_vulkanFilterGen out_range(Scale_vulkanFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetAttribute<NameAttribute>().Name);
}
public static class Scale_vulkanFilterGenExtensions
{
/// <summary>
/// Scale Vulkan frames
/// </summary>
public static Scale_vulkanFilterGen Scale_vulkanFilterGen(this ImageMap input0) => new Scale_vulkanFilterGen(input0);
/// <summary>
/// Scale Vulkan frames
/// </summary>
public static Scale_vulkanFilterGen Scale_vulkanFilterGen(this ImageMap input0,Scale_vulkanFilterGenConfig config)
{
var result = new Scale_vulkanFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.w)) result.w(config.w);
if(!string.IsNullOrWhiteSpace(config?.h)) result.h(config.h);
if(config?.scaler != null) result.scaler(config.scaler.Value);
if(!string.IsNullOrWhiteSpace(config?.format)) result.format(config.format);
if(config?.out_range != null) result.out_range(config.out_range.Value);
return result;
}
}
public class Scale_vulkanFilterGenConfig
{
/// <summary>
///  Output video width (default "iw")
/// </summary>
public string w { get; set; }
/// <summary>
///  Output video height (default "ih")
/// </summary>
public string h { get; set; }
/// <summary>
///  Scaler function (from 0 to 2) (default bilinear)
/// </summary>
public Scale_vulkanFilterGenScaler? scaler { get; set; }
/// <summary>
///  Output video format (software format of hardware frames)
/// </summary>
public string format { get; set; }
/// <summary>
///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
/// </summary>
public Scale_vulkanFilterGenOut_range? out_range { get; set; }
}
public enum Scale_vulkanFilterGenScaler
{
[Name("bilinear")] bilinear,
[Name("nearest")] nearest,
}

public enum Scale_vulkanFilterGenOut_range
{
[Name("full")] full,
[Name("limited")] limited,
[Name("jpeg")] jpeg,
[Name("mpeg")] mpeg,
[Name("tv")] tv,
[Name("pc")] pc,
}

}
