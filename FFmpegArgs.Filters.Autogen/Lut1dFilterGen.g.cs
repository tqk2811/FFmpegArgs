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
public class Lut1dFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Lut1dFilterGen(ImageMap input) : base("lut1d",input) { AddMapOut(); }
/// <summary>
///  set 1D LUT file name
/// </summary>
public Lut1dFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  select interpolation mode (from 0 to 4) (default linear)
/// </summary>
public Lut1dFilterGen interp(Lut1dFilterGenInterp interp) => this.SetOption("interp", interp.GetAttribute<NameAttribute>().Name);
}
public static class Lut1dFilterGenExtensions
{
/// <summary>
/// Adjust colors using a 1D LUT.
/// </summary>
public static Lut1dFilterGen Lut1dFilterGen(this ImageMap input0) => new Lut1dFilterGen(input0);
/// <summary>
/// Adjust colors using a 1D LUT.
/// </summary>
public static Lut1dFilterGen Lut1dFilterGen(this ImageMap input0,Lut1dFilterGenConfig config)
{
var result = new Lut1dFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.file)) result.file(config.file);
if(config?.interp != null) result.interp(config.interp.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class Lut1dFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set 1D LUT file name
/// </summary>
public string file { get; set; }
/// <summary>
///  select interpolation mode (from 0 to 4) (default linear)
/// </summary>
public Lut1dFilterGenInterp? interp { get; set; }
public string TimelineSupport { get; set; }
}
public enum Lut1dFilterGenInterp
{
[Name("nearest")] nearest,
[Name("linear")] linear,
[Name("cosine")] cosine,
[Name("cubic")] cubic,
[Name("spline")] spline,
}

}
