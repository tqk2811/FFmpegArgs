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
/// <summary>
/// Draw a gradients.
/// </summary>
public static GradientsFilterGen GradientsFilterGen(this FilterGraph input0,GradientsFilterGenConfig config)
{
var result = new GradientsFilterGen(input0);
if(config?.size != null) result.size(config.size);
if(config?.rate != null) result.rate(config.rate);
if(config?.c0 != null) result.c0(config.c0);
if(config?.c1 != null) result.c1(config.c1);
if(config?.c2 != null) result.c2(config.c2);
if(config?.c3 != null) result.c3(config.c3);
if(config?.c4 != null) result.c4(config.c4);
if(config?.c5 != null) result.c5(config.c5);
if(config?.c6 != null) result.c6(config.c6);
if(config?.c7 != null) result.c7(config.c7);
if(config?.x0 != null) result.x0(config.x0);
if(config?.y0 != null) result.y0(config.y0);
if(config?.x1 != null) result.x1(config.x1);
if(config?.y1 != null) result.y1(config.y1);
if(config?.nb_colors != null) result.nb_colors(config.nb_colors);
if(config?.seed != null) result.seed(config.seed);
if(config?.duration != null) result.duration(config.duration);
if(config?.speed != null) result.speed(config.speed);
return result;
}
}
public class GradientsFilterGenConfig
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
///  set 1st color (default "random")
/// </summary>
public Color c0 { get; set; }
/// <summary>
///  set 2nd color (default "random")
/// </summary>
public Color c1 { get; set; }
/// <summary>
///  set 3rd color (default "random")
/// </summary>
public Color c2 { get; set; }
/// <summary>
///  set 4th color (default "random")
/// </summary>
public Color c3 { get; set; }
/// <summary>
///  set 5th color (default "random")
/// </summary>
public Color c4 { get; set; }
/// <summary>
///  set 6th color (default "random")
/// </summary>
public Color c5 { get; set; }
/// <summary>
///  set 7th color (default "random")
/// </summary>
public Color c6 { get; set; }
/// <summary>
///  set 8th color (default "random")
/// </summary>
public Color c7 { get; set; }
/// <summary>
///  set gradient line source x0 (from -1 to INT_MAX) (default -1)
/// </summary>
public int x0 { get; set; }
/// <summary>
///  set gradient line source y0 (from -1 to INT_MAX) (default -1)
/// </summary>
public int y0 { get; set; }
/// <summary>
///  set gradient line destination x1 (from -1 to INT_MAX) (default -1)
/// </summary>
public int x1 { get; set; }
/// <summary>
///  set gradient line destination y1 (from -1 to INT_MAX) (default -1)
/// </summary>
public int y1 { get; set; }
/// <summary>
///  set the number of colors (from 2 to 8) (default 2)
/// </summary>
public int nb_colors { get; set; }
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long seed { get; set; }
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public TimeSpan duration { get; set; }
/// <summary>
///  set gradients rotation speed (from 1e-05 to 1) (default 0.01)
/// </summary>
public float speed { get; set; }
}
}
