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
public class HaldclutFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal HaldclutFilterGen(params ImageMap[] inputs) : base("haldclut",inputs) { AddMapOut(); }
/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public HaldclutFilterGen interp(HaldclutFilterGenInterp interp) => this.SetOption("interp", interp.GetAttribute<NameAttribute>().Name);
}
public static class HaldclutFilterGenExtensions
{
/// <summary>
/// Adjust colors using a Hald CLUT.
/// </summary>
public static HaldclutFilterGen HaldclutFilterGen(this ImageMap input0, ImageMap input1) => new HaldclutFilterGen(input0, input1);
/// <summary>
/// Adjust colors using a Hald CLUT.
/// </summary>
public static HaldclutFilterGen HaldclutFilterGen(this ImageMap input0, ImageMap input1,HaldclutFilterGenConfig config)
{
var result = new HaldclutFilterGen(input0, input1);
if(config?.interp != null) result.interp(config.interp);
return result;
}
}
public class HaldclutFilterGenConfig
{
/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public HaldclutFilterGenInterp interp { get; set; }
}
public enum HaldclutFilterGenInterp
{
[Name("nearest")] nearest,
[Name("trilinear")] trilinear,
[Name("tetrahedral")] tetrahedral,
[Name("pyramid")] pyramid,
[Name("prism")] prism,
}

}
