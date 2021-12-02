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
public class Prewitt_openclFilterGen : ImageToImageFilter
{
internal Prewitt_openclFilterGen(ImageMap input) : base("prewitt_opencl",input) { AddMapOut(); }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public Prewitt_openclFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public Prewitt_openclFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,65535);
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public Prewitt_openclFilterGen delta(float delta) => this.SetOptionRange("delta", delta,-65535,65535);
}
public static class Prewitt_openclFilterGenExtensions
{
/// <summary>
/// Apply prewitt operator
/// </summary>
public static Prewitt_openclFilterGen Prewitt_openclFilterGen(this ImageMap input0) => new Prewitt_openclFilterGen(input0);
/// <summary>
/// Apply prewitt operator
/// </summary>
public static Prewitt_openclFilterGen Prewitt_openclFilterGen(this ImageMap input0,Prewitt_openclFilterGenConfig config)
{
var result = new Prewitt_openclFilterGen(input0);
if(config?.planes != null) result.planes(config.planes.Value);
if(config?.scale != null) result.scale(config.scale.Value);
if(config?.delta != null) result.delta(config.delta.Value);
return result;
}
}
public class Prewitt_openclFilterGenConfig
{
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public float? scale { get; set; }
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public float? delta { get; set; }
}
}
