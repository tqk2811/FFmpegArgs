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
///  set frame rate (default "25")
/// </summary>
public SierpinskiFilterGen rate(Rational rate) => this.SetOption("rate",rate);
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
/// <summary>
/// Render a Sierpinski fractal.
/// </summary>
public static SierpinskiFilterGen SierpinskiFilterGen(this FilterGraph input0,SierpinskiFilterGenConfig config)
{
var result = new SierpinskiFilterGen(input0);
if(config?.size != null) result.size(config.size);
if(config?.rate != null) result.rate(config.rate);
if(config?.seed != null) result.seed(config.seed);
if(config?.jump != null) result.jump(config.jump);
if(config?.type != null) result.type(config.type);
return result;
}
}
public class SierpinskiFilterGenConfig
{
/// <summary>
///  set frame size (default "640x480")
/// </summary>
public Size size { get; set; }
/// <summary>
///  set frame rate (default "25")
/// </summary>
public Rational rate { get; set; }
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long seed { get; set; }
/// <summary>
///  set the jump (from 1 to 10000) (default 100)
/// </summary>
public int jump { get; set; }
/// <summary>
///  set fractal type (from 0 to 1) (default carpet)
/// </summary>
public SierpinskiFilterGenType type { get; set; }
}
public enum SierpinskiFilterGenType
{
[Name("carpet")] carpet,
[Name("triangle")] triangle,
}

}
