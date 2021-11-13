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
public class DeshakeFilterGen : ImageToImageFilter
{
internal DeshakeFilterGen(ImageMap input) : base("deshake",input) { AddMapOut(); }
/// <summary>
///  set x for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public DeshakeFilterGen x(int x) => this.SetOptionRange("x", x,-1,INT_MAX);
/// <summary>
///  set y for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public DeshakeFilterGen y(int y) => this.SetOptionRange("y", y,-1,INT_MAX);
/// <summary>
///  set width for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public DeshakeFilterGen w(int w) => this.SetOptionRange("w", w,-1,INT_MAX);
/// <summary>
///  set height for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public DeshakeFilterGen h(int h) => this.SetOptionRange("h", h,-1,INT_MAX);
/// <summary>
///  set x for the rectangular search area (from 0 to 64) (default 16)
/// </summary>
public DeshakeFilterGen rx(int rx) => this.SetOptionRange("rx", rx,0,64);
/// <summary>
///  set y for the rectangular search area (from 0 to 64) (default 16)
/// </summary>
public DeshakeFilterGen ry(int ry) => this.SetOptionRange("ry", ry,0,64);
/// <summary>
///  set edge mode (from 0 to 3) (default mirror)
/// </summary>
public DeshakeFilterGen edge(DeshakeFilterGenEdge edge) => this.SetOption("edge", edge.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set motion search blocksize (from 4 to 128) (default 8)
/// </summary>
public DeshakeFilterGen blocksize(int blocksize) => this.SetOptionRange("blocksize", blocksize,4,128);
/// <summary>
///  set contrast threshold for blocks (from 1 to 255) (default 125)
/// </summary>
public DeshakeFilterGen contrast(int contrast) => this.SetOptionRange("contrast", contrast,1,255);
/// <summary>
///  set search strategy (from 0 to 1) (default exhaustive)
/// </summary>
public DeshakeFilterGen search(DeshakeFilterGenSearch search) => this.SetOption("search", search.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set motion search detailed log file name
/// </summary>
public DeshakeFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  ignored (default false)
/// </summary>
public DeshakeFilterGen opencl(bool flag) => this.SetOption("opencl",flag.ToFFmpegFlag());
}
public static class DeshakeFilterGenExtensions
{
/// <summary>
/// Stabilize shaky video.
/// </summary>
public static DeshakeFilterGen DeshakeFilterGen(this ImageMap input) => new DeshakeFilterGen(input);
}
public enum DeshakeFilterGenEdge
{
[Name("blank")] blank,
[Name("original")] original,
[Name("clamp")] clamp,
[Name("mirror")] mirror,
}

public enum DeshakeFilterGenSearch
{
[Name("exhaustive")] exhaustive,
[Name("less")] less,
}

}
