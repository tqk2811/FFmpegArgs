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
public class Boxblur_openclFilterGen : ImageToImageFilter
{
internal Boxblur_openclFilterGen(ImageMap input) : base("boxblur_opencl",input) { AddMapOut(); }
/// <summary>
///  Radius of the luma blurring box (default "2")
/// </summary>
public Boxblur_openclFilterGen luma_radius(string luma_radius) => this.SetOption("luma_radius",luma_radius);
/// <summary>
///  Radius of the luma blurring box (default "2")
/// </summary>
public Boxblur_openclFilterGen lr(string lr) => this.SetOption("lr",lr);
/// <summary>
///  How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
/// </summary>
public Boxblur_openclFilterGen luma_power(int luma_power) => this.SetOptionRange("luma_power", luma_power,0,INT_MAX);
/// <summary>
///  How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
/// </summary>
public Boxblur_openclFilterGen lp(int lp) => this.SetOptionRange("lp", lp,0,INT_MAX);
/// <summary>
///  Radius of the chroma blurring box
/// </summary>
public Boxblur_openclFilterGen chroma_radius(string chroma_radius) => this.SetOption("chroma_radius",chroma_radius);
/// <summary>
///  Radius of the chroma blurring box
/// </summary>
public Boxblur_openclFilterGen cr(string cr) => this.SetOption("cr",cr);
/// <summary>
///  How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
/// </summary>
public Boxblur_openclFilterGen chroma_power(int chroma_power) => this.SetOptionRange("chroma_power", chroma_power,-1,INT_MAX);
/// <summary>
///  How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
/// </summary>
public Boxblur_openclFilterGen cp(int cp) => this.SetOptionRange("cp", cp,-1,INT_MAX);
/// <summary>
///  Radius of the alpha blurring box
/// </summary>
public Boxblur_openclFilterGen alpha_radius(string alpha_radius) => this.SetOption("alpha_radius",alpha_radius);
/// <summary>
///  Radius of the alpha blurring box
/// </summary>
public Boxblur_openclFilterGen ar(string ar) => this.SetOption("ar",ar);
/// <summary>
///  How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
/// </summary>
public Boxblur_openclFilterGen alpha_power(int alpha_power) => this.SetOptionRange("alpha_power", alpha_power,-1,INT_MAX);
/// <summary>
///  How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
/// </summary>
public Boxblur_openclFilterGen ap(int ap) => this.SetOptionRange("ap", ap,-1,INT_MAX);
}
public static class Boxblur_openclFilterGenExtensions
{
/// <summary>
/// Apply boxblur filter to input video
/// </summary>
public static Boxblur_openclFilterGen Boxblur_openclFilterGen(this ImageMap input) => new Boxblur_openclFilterGen(input);
}
}
