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
public class GeqFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal GeqFilterGen(ImageMap input) : base("geq",input) { AddMapOut(); }
/// <summary>
///  set luminance expression
/// </summary>
public GeqFilterGen lum_expr(string lum_expr) => this.SetOption("lum_expr",lum_expr);
/// <summary>
///  set luminance expression
/// </summary>
public GeqFilterGen lum(string lum) => this.SetOption("lum",lum);
/// <summary>
///  set chroma blue expression
/// </summary>
public GeqFilterGen cb_expr(string cb_expr) => this.SetOption("cb_expr",cb_expr);
/// <summary>
///  set chroma blue expression
/// </summary>
public GeqFilterGen cb(string cb) => this.SetOption("cb",cb);
/// <summary>
///  set chroma red expression
/// </summary>
public GeqFilterGen cr_expr(string cr_expr) => this.SetOption("cr_expr",cr_expr);
/// <summary>
///  set chroma red expression
/// </summary>
public GeqFilterGen cr(string cr) => this.SetOption("cr",cr);
/// <summary>
///  set alpha expression
/// </summary>
public GeqFilterGen alpha_expr(string alpha_expr) => this.SetOption("alpha_expr",alpha_expr);
/// <summary>
///  set alpha expression
/// </summary>
public GeqFilterGen a(string a) => this.SetOption("a",a);
/// <summary>
///  set red expression
/// </summary>
public GeqFilterGen red_expr(string red_expr) => this.SetOption("red_expr",red_expr);
/// <summary>
///  set red expression
/// </summary>
public GeqFilterGen r(string r) => this.SetOption("r",r);
/// <summary>
///  set green expression
/// </summary>
public GeqFilterGen green_expr(string green_expr) => this.SetOption("green_expr",green_expr);
/// <summary>
///  set green expression
/// </summary>
public GeqFilterGen g(string g) => this.SetOption("g",g);
/// <summary>
///  set blue expression
/// </summary>
public GeqFilterGen blue_expr(string blue_expr) => this.SetOption("blue_expr",blue_expr);
/// <summary>
///  set blue expression
/// </summary>
public GeqFilterGen b(string b) => this.SetOption("b",b);
/// <summary>
///  set interpolation method (from 0 to 1) (default bilinear)
/// </summary>
public GeqFilterGen interpolation(GeqFilterGenInterpolation interpolation) => this.SetOption("interpolation", interpolation.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set interpolation method (from 0 to 1) (default bilinear)
/// </summary>
public GeqFilterGen i(GeqFilterGenI i) => this.SetOption("i", i.GetAttribute<NameAttribute>().Name);
}
public static class GeqFilterGenExtensions
{
/// <summary>
/// Apply generic equation to each pixel.
/// </summary>
public static GeqFilterGen GeqFilterGen(this ImageMap input0) => new GeqFilterGen(input0);
}
public enum GeqFilterGenInterpolation
{
[Name("nearest")] nearest,
[Name("n")] n,
[Name("bilinear")] bilinear,
[Name("b")] b,
}

public enum GeqFilterGenI
{
[Name("nearest")] nearest,
[Name("n")] n,
[Name("bilinear")] bilinear,
[Name("b")] b,
}

}
