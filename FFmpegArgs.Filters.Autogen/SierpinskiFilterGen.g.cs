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
public class SierpinskiFilterGen : SourceImageFilter,ISliceThreading
{
internal SierpinskiFilterGen(FilterGraph input) : base("sierpinski",input) { AddMapOut(); }
/// <summary>
///  set frame size (default "640x480")
/// </summary>
public SierpinskiFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame size (default "640x480")
/// </summary>
public SierpinskiFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame rate (default "25")
/// </summary>
public SierpinskiFilterGen Rate(string r) => this.SetOption("rate", r);
/// <summary>
///  set frame rate (default "25")
/// </summary>
public SierpinskiFilterGen rate(int r) => this.SetOptionRange("rate", r, 1, int.MaxValue);
/// <summary>
///  set frame rate (default "25")
/// </summary>
public SierpinskiFilterGen R(string r) => this.SetOption("r", r);
/// <summary>
///  set frame rate (default "25")
/// </summary>
public SierpinskiFilterGen r(int r) => this.SetOptionRange("r", r, 1, int.MaxValue);
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public SierpinskiFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set the jump (from 1 to 10000) (default 100)
/// </summary>
public SierpinskiFilterGen jump(int jump) => this.SetOptionRange("jump", jump,1,10000);
/// <summary>
///  set fractal type (from 0 to 1) (default carpet)
/// </summary>
public SierpinskiFilterGen type(SierpinskiFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
}
public static class SierpinskiFilterGenExtensions
{
/// <summary>
/// Render a Sierpinski fractal.
/// </summary>
public static SierpinskiFilterGen SierpinskiFilterGen(this FilterGraph input0) => new SierpinskiFilterGen(input0);
}
public enum SierpinskiFilterGenType
{
[Name("carpet")] carpet,
[Name("triangle")] triangle,
}

}
