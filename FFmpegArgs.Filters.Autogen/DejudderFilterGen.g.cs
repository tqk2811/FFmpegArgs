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
public class DejudderFilterGen : ImageToImageFilter
{
internal DejudderFilterGen(ImageMap input) : base("dejudder",input) { AddMapOut(); }
/// <summary>
///  set the length of the cycle to use for dejuddering (from 2 to 240) (default 4)
/// </summary>
public DejudderFilterGen cycle(int cycle) => this.SetOptionRange("cycle", cycle,2,240);
}
public static class DejudderFilterGenExtensions
{
/// <summary>
/// Remove judder produced by pullup.
/// </summary>
public static DejudderFilterGen DejudderFilterGen(this ImageMap input0) => new DejudderFilterGen(input0);
/// <summary>
/// Remove judder produced by pullup.
/// </summary>
public static DejudderFilterGen DejudderFilterGen(this ImageMap input0,DejudderFilterGenConfig config)
{
var result = new DejudderFilterGen(input0);
if(config?.cycle != null) result.cycle(config.cycle);
return result;
}
}
public class DejudderFilterGenConfig
{
/// <summary>
///  set the length of the cycle to use for dejuddering (from 2 to 240) (default 4)
/// </summary>
public int cycle { get; set; }
}
}
