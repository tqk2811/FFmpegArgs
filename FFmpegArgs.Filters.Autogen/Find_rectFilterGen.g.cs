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
public class Find_rectFilterGen : ImageToImageFilter
{
internal Find_rectFilterGen(ImageMap input) : base("find_rect",input) { AddMapOut(); }
/// <summary>
///  object bitmap filename
/// </summary>
public Find_rectFilterGen _object(string _object) => this.SetOption("object",_object);
/// <summary>
///  set threshold (from 0 to 1) (default 0.5)
/// </summary>
public Find_rectFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold,0,1);
/// <summary>
///  set mipmaps (from 1 to 5) (default 3)
/// </summary>
public Find_rectFilterGen mipmaps(int mipmaps) => this.SetOptionRange("mipmaps", mipmaps,1,5);
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public Find_rectFilterGen xmin(int xmin) => this.SetOptionRange("xmin", xmin,0,INT_MAX);
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public Find_rectFilterGen ymin(int ymin) => this.SetOptionRange("ymin", ymin,0,INT_MAX);
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public Find_rectFilterGen xmax(int xmax) => this.SetOptionRange("xmax", xmax,0,INT_MAX);
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public Find_rectFilterGen ymax(int ymax) => this.SetOptionRange("ymax", ymax,0,INT_MAX);
}
public static class Find_rectFilterGenExtensions
{
/// <summary>
/// Find a user specified object.
/// </summary>
public static Find_rectFilterGen Find_rectFilterGen(this ImageMap input0) => new Find_rectFilterGen(input0);
}
}
