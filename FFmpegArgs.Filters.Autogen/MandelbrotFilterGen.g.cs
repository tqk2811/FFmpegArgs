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
public class MandelbrotFilterGen : SourceImageFilter
{
internal MandelbrotFilterGen(FilterGraph input) : base("mandelbrot",input) { AddMapOut(); }
/// <summary>
///  set frame size (default "640x480")
/// </summary>
public MandelbrotFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame size (default "640x480")
/// </summary>
public MandelbrotFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame rate (default "25")
/// </summary>
public MandelbrotFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set frame rate (default "25")
/// </summary>
public MandelbrotFilterGen r(Rational r) => this.SetOption("r",r);
/// <summary>
///  set max iterations number (from 1 to INT_MAX) (default 7189)
/// </summary>
public MandelbrotFilterGen maxiter(int maxiter) => this.SetOptionRange("maxiter", maxiter,1,INT_MAX);
/// <summary>
///  set the initial x position (from -100 to 100) (default -0.743644)
/// </summary>
public MandelbrotFilterGen start_x(double start_x) => this.SetOptionRange("start_x", start_x,-100,100);
/// <summary>
///  set the initial y position (from -100 to 100) (default -0.131826)
/// </summary>
public MandelbrotFilterGen start_y(double start_y) => this.SetOptionRange("start_y", start_y,-100,100);
/// <summary>
///  set the initial scale value (from 0 to FLT_MAX) (default 3)
/// </summary>
public MandelbrotFilterGen start_scale(double start_scale) => this.SetOptionRange("start_scale", start_scale,0,FLT_MAX);
/// <summary>
///  set the terminal scale value (from 0 to FLT_MAX) (default 0.3)
/// </summary>
public MandelbrotFilterGen end_scale(double end_scale) => this.SetOptionRange("end_scale", end_scale,0,FLT_MAX);
/// <summary>
///  set the terminal pts value (from 0 to I64_MAX) (default 400)
/// </summary>
public MandelbrotFilterGen end_pts(double end_pts) => this.SetOptionRange("end_pts", end_pts,0,I64_MAX);
/// <summary>
///  set the bailout value (from 0 to FLT_MAX) (default 10)
/// </summary>
public MandelbrotFilterGen bailout(double bailout) => this.SetOptionRange("bailout", bailout,0,FLT_MAX);
/// <summary>
///  set morph x frequency (from -FLT_MAX to FLT_MAX) (default 0.01)
/// </summary>
public MandelbrotFilterGen morphxf(double morphxf) => this.SetOptionRange("morphxf", morphxf,-FLT_MAX,FLT_MAX);
/// <summary>
///  set morph y frequency (from -FLT_MAX to FLT_MAX) (default 0.0123)
/// </summary>
public MandelbrotFilterGen morphyf(double morphyf) => this.SetOptionRange("morphyf", morphyf,-FLT_MAX,FLT_MAX);
/// <summary>
///  set morph amplitude (from -FLT_MAX to FLT_MAX) (default 0)
/// </summary>
public MandelbrotFilterGen morphamp(double morphamp) => this.SetOptionRange("morphamp", morphamp,-FLT_MAX,FLT_MAX);
/// <summary>
///  set outer coloring mode (from 0 to INT_MAX) (default normalized_iteration_count)
/// </summary>
public MandelbrotFilterGen outer(MandelbrotFilterGenOuter outer) => this.SetOption("outer", outer.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set inner coloring mode (from 0 to INT_MAX) (default mincol)
/// </summary>
public MandelbrotFilterGen inner(MandelbrotFilterGenInner inner) => this.SetOption("inner", inner.GetAttribute<NameAttribute>().Name);
}
public static class MandelbrotFilterGenExtensions
{
/// <summary>
/// Render a Mandelbrot fractal.
/// </summary>
public static MandelbrotFilterGen MandelbrotFilterGen(this FilterGraph input0) => new MandelbrotFilterGen(input0);
}
public enum MandelbrotFilterGenOuter
{
[Name("iteration_count")] iteration_count,
[Name("normalized_iteration_count")] normalized_iteration_count,
[Name("white")] white,
[Name("outz")] outz,
}

public enum MandelbrotFilterGenInner
{
[Name("black")] black,
[Name("period")] period,
[Name("convergence")] convergence,
[Name("mincol")] mincol,
}

}
