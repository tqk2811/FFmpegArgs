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
public class ShowpaletteFilterGen : ImageToImageFilter
{
internal ShowpaletteFilterGen(ImageMap input) : base("showpalette",input) { AddMapOut(); }
/// <summary>
///  set pixel box size (from 1 to 100) (default 30)
/// </summary>
public ShowpaletteFilterGen s(int s) => this.SetOptionRange("s", s,1,100);
}
public static class ShowpaletteFilterGenExtensions
{
/// <summary>
/// Display frame palette.
/// </summary>
public static ShowpaletteFilterGen ShowpaletteFilterGen(this ImageMap input0) => new ShowpaletteFilterGen(input0);
/// <summary>
/// Display frame palette.
/// </summary>
public static ShowpaletteFilterGen ShowpaletteFilterGen(this ImageMap input0,ShowpaletteFilterGenConfig config)
{
var result = new ShowpaletteFilterGen(input0);
if(config?.s != null) result.s(config.s);
return result;
}
}
public class ShowpaletteFilterGenConfig
{
/// <summary>
///  set pixel box size (from 1 to 100) (default 30)
/// </summary>
public int s { get; set; }
}
}
