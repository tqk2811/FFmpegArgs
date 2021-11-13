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
public class OwdenoiseFilterGen : ImageToImageFilter,ITimelineSupport
{
internal OwdenoiseFilterGen(ImageMap input) : base("owdenoise",input) { AddMapOut(); }
/// <summary>
///  set depth (from 8 to 16) (default 8)
/// </summary>
public OwdenoiseFilterGen depth(int depth) => this.SetOptionRange("depth", depth,8,16);
/// <summary>
///  set luma strength (from 0 to 1000) (default 1)
/// </summary>
public OwdenoiseFilterGen luma_strength(double luma_strength) => this.SetOptionRange("luma_strength", luma_strength,0,1000);
/// <summary>
///  set luma strength (from 0 to 1000) (default 1)
/// </summary>
public OwdenoiseFilterGen ls(double ls) => this.SetOptionRange("ls", ls,0,1000);
/// <summary>
///  set chroma strength (from 0 to 1000) (default 1)
/// </summary>
public OwdenoiseFilterGen chroma_strength(double chroma_strength) => this.SetOptionRange("chroma_strength", chroma_strength,0,1000);
/// <summary>
///  set chroma strength (from 0 to 1000) (default 1)
/// </summary>
public OwdenoiseFilterGen cs(double cs) => this.SetOptionRange("cs", cs,0,1000);
}
public static class OwdenoiseFilterGenExtensions
{
/// <summary>
/// Denoise using wavelets.
/// </summary>
public static OwdenoiseFilterGen OwdenoiseFilterGen(this ImageMap input) => new OwdenoiseFilterGen(input);
}
}
