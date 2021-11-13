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
public class Avgblur_openclFilterGen : ImageToImageFilter
{
internal Avgblur_openclFilterGen(ImageMap input) : base("avgblur_opencl",input) { AddMapOut(); }
/// <summary>
///  set horizontal size (from 1 to 1024) (default 1)
/// </summary>
public Avgblur_openclFilterGen sizeX(int sizeX) => this.SetOptionRange("sizeX", sizeX,1,1024);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public Avgblur_openclFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set vertical size (from 0 to 1024) (default 0)
/// </summary>
public Avgblur_openclFilterGen sizeY(int sizeY) => this.SetOptionRange("sizeY", sizeY,0,1024);
}
public static class Avgblur_openclFilterGenExtensions
{
/// <summary>
/// Apply average blur filter
/// </summary>
public static Avgblur_openclFilterGen Avgblur_openclFilterGen(this ImageMap input) => new Avgblur_openclFilterGen(input);
}
}
