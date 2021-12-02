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
public class ShuffleplanesFilterGen : ImageToImageFilter,ITimelineSupport
{
internal ShuffleplanesFilterGen(ImageMap input) : base("shuffleplanes",input) { AddMapOut(); }
/// <summary>
///  Index of the input plane to be used as the first output plane  (from 0 to 3) (default 0)
/// </summary>
public ShuffleplanesFilterGen map0(int map0) => this.SetOptionRange("map0", map0,0,3);
/// <summary>
///  Index of the input plane to be used as the second output plane  (from 0 to 3) (default 1)
/// </summary>
public ShuffleplanesFilterGen map1(int map1) => this.SetOptionRange("map1", map1,0,3);
/// <summary>
///  Index of the input plane to be used as the third output plane  (from 0 to 3) (default 2)
/// </summary>
public ShuffleplanesFilterGen map2(int map2) => this.SetOptionRange("map2", map2,0,3);
/// <summary>
///  Index of the input plane to be used as the fourth output plane  (from 0 to 3) (default 3)
/// </summary>
public ShuffleplanesFilterGen map3(int map3) => this.SetOptionRange("map3", map3,0,3);
}
public static class ShuffleplanesFilterGenExtensions
{
/// <summary>
/// Shuffle video planes.
/// </summary>
public static ShuffleplanesFilterGen ShuffleplanesFilterGen(this ImageMap input0) => new ShuffleplanesFilterGen(input0);
/// <summary>
/// Shuffle video planes.
/// </summary>
public static ShuffleplanesFilterGen ShuffleplanesFilterGen(this ImageMap input0,ShuffleplanesFilterGenConfig config)
{
var result = new ShuffleplanesFilterGen(input0);
if(config?.map0 != null) result.map0(config.map0.Value);
if(config?.map1 != null) result.map1(config.map1.Value);
if(config?.map2 != null) result.map2(config.map2.Value);
if(config?.map3 != null) result.map3(config.map3.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ShuffleplanesFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  Index of the input plane to be used as the first output plane  (from 0 to 3) (default 0)
/// </summary>
public int? map0 { get; set; }
/// <summary>
///  Index of the input plane to be used as the second output plane  (from 0 to 3) (default 1)
/// </summary>
public int? map1 { get; set; }
/// <summary>
///  Index of the input plane to be used as the third output plane  (from 0 to 3) (default 2)
/// </summary>
public int? map2 { get; set; }
/// <summary>
///  Index of the input plane to be used as the fourth output plane  (from 0 to 3) (default 3)
/// </summary>
public int? map3 { get; set; }
public string TimelineSupport { get; set; }
}
}
