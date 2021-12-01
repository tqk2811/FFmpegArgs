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
public class GradientsFilterGen : SourceImageFilter,ISliceThreading
{
internal GradientsFilterGen(FilterGraph input) : base("gradients",input) { AddMapOut(); }
/// <summary>
///  set frame size (default "640x480")
/// </summary>
public GradientsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame rate (default "25")
/// </summary>
public GradientsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set 1st color (default "random")
/// </summary>
public GradientsFilterGen c0(Color c0) => this.SetOption("c0",c0.ToHexStringRGBA());
/// <summary>
///  set 2nd color (default "random")
/// </summary>
public GradientsFilterGen c1(Color c1) => this.SetOption("c1",c1.ToHexStringRGBA());
/// <summary>
///  set 3rd color (default "random")
/// </summary>
public GradientsFilterGen c2(Color c2) => this.SetOption("c2",c2.ToHexStringRGBA());
/// <summary>
///  set 4th color (default "random")
/// </summary>
public GradientsFilterGen c3(Color c3) => this.SetOption("c3",c3.ToHexStringRGBA());
/// <summary>
///  set 5th color (default "random")
/// </summary>
public GradientsFilterGen c4(Color c4) => this.SetOption("c4",c4.ToHexStringRGBA());
/// <summary>
///  set 6th color (default "random")
/// </summary>
public GradientsFilterGen c5(Color c5) => this.SetOption("c5",c5.ToHexStringRGBA());
/// <summary>
///  set 7th color (default "random")
/// </summary>
public GradientsFilterGen c6(Color c6) => this.SetOption("c6",c6.ToHexStringRGBA());
/// <summary>
///  set 8th color (default "random")
/// </summary>
public GradientsFilterGen c7(Color c7) => this.SetOption("c7",c7.ToHexStringRGBA());
/// <summary>
///  set gradient line source x0 (from -1 to INT_MAX) (default -1)
/// </summary>
public GradientsFilterGen x0(int x0) => this.SetOptionRange("x0", x0,-1,INT_MAX);
/// <summary>
///  set gradient line source y0 (from -1 to INT_MAX) (default -1)
/// </summary>
public GradientsFilterGen y0(int y0) => this.SetOptionRange("y0", y0,-1,INT_MAX);
/// <summary>
///  set gradient line destination x1 (from -1 to INT_MAX) (default -1)
/// </summary>
public GradientsFilterGen x1(int x1) => this.SetOptionRange("x1", x1,-1,INT_MAX);
/// <summary>
///  set gradient line destination y1 (from -1 to INT_MAX) (default -1)
/// </summary>
public GradientsFilterGen y1(int y1) => this.SetOptionRange("y1", y1,-1,INT_MAX);
/// <summary>
///  set the number of colors (from 2 to 8) (default 2)
/// </summary>
public GradientsFilterGen nb_colors(int nb_colors) => this.SetOptionRange("nb_colors", nb_colors,2,8);
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public GradientsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public GradientsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set gradients rotation speed (from 1e-05 to 1) (default 0.01)
/// </summary>
public GradientsFilterGen speed(float speed) => this.SetOptionRange("speed", speed,1e-05,1);
}
public static class GradientsFilterGenExtensions
{
/// <summary>
/// Draw a gradients.
/// </summary>
public static GradientsFilterGen GradientsFilterGen(this FilterGraph input0) => new GradientsFilterGen(input0);
}
}
