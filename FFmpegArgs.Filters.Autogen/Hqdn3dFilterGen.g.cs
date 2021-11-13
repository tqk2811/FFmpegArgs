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
public class Hqdn3dFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Hqdn3dFilterGen(ImageMap input) : base("hqdn3d",input) { AddMapOut(); }
/// <summary>
///  spatial luma strength (from 0 to DBL_MAX) (default 0)
/// </summary>
public Hqdn3dFilterGen luma_spatial(double luma_spatial) => this.SetOptionRange("luma_spatial", luma_spatial,0,DBL_MAX);
/// <summary>
///  spatial chroma strength (from 0 to DBL_MAX) (default 0)
/// </summary>
public Hqdn3dFilterGen chroma_spatial(double chroma_spatial) => this.SetOptionRange("chroma_spatial", chroma_spatial,0,DBL_MAX);
/// <summary>
///  temporal luma strength (from 0 to DBL_MAX) (default 0)
/// </summary>
public Hqdn3dFilterGen luma_tmp(double luma_tmp) => this.SetOptionRange("luma_tmp", luma_tmp,0,DBL_MAX);
/// <summary>
///  temporal chroma strength (from 0 to DBL_MAX) (default 0)
/// </summary>
public Hqdn3dFilterGen chroma_tmp(double chroma_tmp) => this.SetOptionRange("chroma_tmp", chroma_tmp,0,DBL_MAX);
}
public static class Hqdn3dFilterGenExtensions
{
/// <summary>
/// Apply a High Quality 3D Denoiser.
/// </summary>
public static Hqdn3dFilterGen Hqdn3dFilterGen(this ImageMap input) => new Hqdn3dFilterGen(input);
}
}
