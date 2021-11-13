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
public static ShuffleplanesFilterGen ShuffleplanesFilterGen(this ImageMap input) => new ShuffleplanesFilterGen(input);
}
}
