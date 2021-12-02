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
public class Nlmeans_openclFilterGen : ImageToImageFilter
{
internal Nlmeans_openclFilterGen(ImageMap input) : base("nlmeans_opencl",input) { AddMapOut(); }
/// <summary>
///  denoising strength (from 1 to 30) (default 1)
/// </summary>
public Nlmeans_openclFilterGen s(double s) => this.SetOptionRange("s", s,1,30);
/// <summary>
///  patch size (from 0 to 99) (default 7)
/// </summary>
public Nlmeans_openclFilterGen p(int p) => this.SetOptionRange("p", p,0,99);
/// <summary>
///  patch size for chroma planes (from 0 to 99) (default 0)
/// </summary>
public Nlmeans_openclFilterGen pc(int pc) => this.SetOptionRange("pc", pc,0,99);
/// <summary>
///  research window (from 0 to 99) (default 15)
/// </summary>
public Nlmeans_openclFilterGen r(int r) => this.SetOptionRange("r", r,0,99);
/// <summary>
///  research window for chroma planes (from 0 to 99) (default 0)
/// </summary>
public Nlmeans_openclFilterGen rc(int rc) => this.SetOptionRange("rc", rc,0,99);
}
public static class Nlmeans_openclFilterGenExtensions
{
/// <summary>
/// Non-local means denoiser through OpenCL
/// </summary>
public static Nlmeans_openclFilterGen Nlmeans_openclFilterGen(this ImageMap input0) => new Nlmeans_openclFilterGen(input0);
/// <summary>
/// Non-local means denoiser through OpenCL
/// </summary>
public static Nlmeans_openclFilterGen Nlmeans_openclFilterGen(this ImageMap input0,Nlmeans_openclFilterGenConfig config)
{
var result = new Nlmeans_openclFilterGen(input0);
if(config?.s != null) result.s(config.s.Value);
if(config?.p != null) result.p(config.p.Value);
if(config?.pc != null) result.pc(config.pc.Value);
if(config?.r != null) result.r(config.r.Value);
if(config?.rc != null) result.rc(config.rc.Value);
return result;
}
}
public class Nlmeans_openclFilterGenConfig
{
/// <summary>
///  denoising strength (from 1 to 30) (default 1)
/// </summary>
public double? s { get; set; }
/// <summary>
///  patch size (from 0 to 99) (default 7)
/// </summary>
public int? p { get; set; }
/// <summary>
///  patch size for chroma planes (from 0 to 99) (default 0)
/// </summary>
public int? pc { get; set; }
/// <summary>
///  research window (from 0 to 99) (default 15)
/// </summary>
public int? r { get; set; }
/// <summary>
///  research window for chroma planes (from 0 to 99) (default 0)
/// </summary>
public int? rc { get; set; }
}
}
