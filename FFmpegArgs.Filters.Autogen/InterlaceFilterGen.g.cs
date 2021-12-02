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
public class InterlaceFilterGen : ImageToImageFilter
{
internal InterlaceFilterGen(ImageMap input) : base("interlace",input) { AddMapOut(); }
/// <summary>
///  scanning mode (from 0 to 1) (default tff)
/// </summary>
public InterlaceFilterGen scan(InterlaceFilterGenScan scan) => this.SetOption("scan", scan.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set vertical low-pass filter (from 0 to 2) (default linear)
/// </summary>
public InterlaceFilterGen lowpass(InterlaceFilterGenLowpass lowpass) => this.SetOption("lowpass", lowpass.GetAttribute<NameAttribute>().Name);
}
public static class InterlaceFilterGenExtensions
{
/// <summary>
/// Convert progressive video into interlaced.
/// </summary>
public static InterlaceFilterGen InterlaceFilterGen(this ImageMap input0) => new InterlaceFilterGen(input0);
/// <summary>
/// Convert progressive video into interlaced.
/// </summary>
public static InterlaceFilterGen InterlaceFilterGen(this ImageMap input0,InterlaceFilterGenConfig config)
{
var result = new InterlaceFilterGen(input0);
if(config?.scan != null) result.scan(config.scan);
if(config?.lowpass != null) result.lowpass(config.lowpass);
return result;
}
}
public class InterlaceFilterGenConfig
{
/// <summary>
///  scanning mode (from 0 to 1) (default tff)
/// </summary>
public InterlaceFilterGenScan scan { get; set; }
/// <summary>
///  set vertical low-pass filter (from 0 to 2) (default linear)
/// </summary>
public InterlaceFilterGenLowpass lowpass { get; set; }
}
public enum InterlaceFilterGenScan
{
[Name("tff")] tff,
[Name("bff")] bff,
}

public enum InterlaceFilterGenLowpass
{
[Name("off")] off,
[Name("linear")] linear,
[Name("complex")] complex,
}

}
