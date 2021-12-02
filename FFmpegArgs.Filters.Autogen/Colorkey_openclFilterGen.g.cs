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
public class Colorkey_openclFilterGen : ImageToImageFilter
{
internal Colorkey_openclFilterGen(ImageMap input) : base("colorkey_opencl",input) { AddMapOut(); }
/// <summary>
///  set the colorkey key color (default "black")
/// </summary>
public Colorkey_openclFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set the colorkey similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public Colorkey_openclFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,0.01,1);
/// <summary>
///  set the colorkey key blend value (from 0 to 1) (default 0)
/// </summary>
public Colorkey_openclFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
}
public static class Colorkey_openclFilterGenExtensions
{
/// <summary>
/// Turns a certain color into transparency. Operates on RGB colors.
/// </summary>
public static Colorkey_openclFilterGen Colorkey_openclFilterGen(this ImageMap input0) => new Colorkey_openclFilterGen(input0);
/// <summary>
/// Turns a certain color into transparency. Operates on RGB colors.
/// </summary>
public static Colorkey_openclFilterGen Colorkey_openclFilterGen(this ImageMap input0,Colorkey_openclFilterGenConfig config)
{
var result = new Colorkey_openclFilterGen(input0);
if(config?.color != null) result.color(config.color.Value);
if(config?.similarity != null) result.similarity(config.similarity.Value);
if(config?.blend != null) result.blend(config.blend.Value);
return result;
}
}
public class Colorkey_openclFilterGenConfig
{
/// <summary>
///  set the colorkey key color (default "black")
/// </summary>
public Color? color { get; set; }
/// <summary>
///  set the colorkey similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public float? similarity { get; set; }
/// <summary>
///  set the colorkey key blend value (from 0 to 1) (default 0)
/// </summary>
public float? blend { get; set; }
}
}
