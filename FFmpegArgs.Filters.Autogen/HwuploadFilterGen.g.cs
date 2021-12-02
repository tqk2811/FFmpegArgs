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
public class HwuploadFilterGen : ImageToImageFilter
{
internal HwuploadFilterGen(ImageMap input) : base("hwupload",input) { AddMapOut(); }
/// <summary>
///  Derive a new device of this type
/// </summary>
public HwuploadFilterGen derive_device(string derive_device) => this.SetOption("derive_device",derive_device);
}
public static class HwuploadFilterGenExtensions
{
/// <summary>
/// Upload a normal frame to a hardware frame
/// </summary>
public static HwuploadFilterGen HwuploadFilterGen(this ImageMap input0) => new HwuploadFilterGen(input0);
/// <summary>
/// Upload a normal frame to a hardware frame
/// </summary>
public static HwuploadFilterGen HwuploadFilterGen(this ImageMap input0,HwuploadFilterGenConfig config)
{
var result = new HwuploadFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.derive_device)) result.derive_device(config.derive_device);
return result;
}
}
public class HwuploadFilterGenConfig
{
/// <summary>
///  Derive a new device of this type
/// </summary>
public string derive_device { get; set; }
}
}
