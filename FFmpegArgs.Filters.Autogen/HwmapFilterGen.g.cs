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
public class HwmapFilterGen : ImageToImageFilter
{
internal HwmapFilterGen(ImageMap input) : base("hwmap",input) { AddMapOut(); }
/// <summary>
///  Frame mapping mode (default read+write)
/// </summary>
public HwmapFilterGen mode(HwmapFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Derive a new device of this type
/// </summary>
public HwmapFilterGen derive_device(string derive_device) => this.SetOption("derive_device",derive_device);
/// <summary>
///  Map in reverse (create and allocate in the sink) (from 0 to 1) (default 0)
/// </summary>
public HwmapFilterGen reverse(int reverse) => this.SetOptionRange("reverse", reverse,0,1);
}
public static class HwmapFilterGenExtensions
{
/// <summary>
/// Map hardware frames
/// </summary>
public static HwmapFilterGen HwmapFilterGen(this ImageMap input0) => new HwmapFilterGen(input0);
}
public enum HwmapFilterGenMode
{
[Name("read")] read,
[Name("write")] write,
[Name("overwrite")] overwrite,
[Name("direct")] direct,
}

}
