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
public class NlmeansFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal NlmeansFilterGen(ImageMap input) : base("nlmeans",input) { AddMapOut(); }
/// <summary>
///  denoising strength (from 1 to 30) (default 1)
/// </summary>
public NlmeansFilterGen s(double s) => this.SetOptionRange("s", s,1,30);
/// <summary>
///  patch size (from 0 to 99) (default 7)
/// </summary>
public NlmeansFilterGen p(int p) => this.SetOptionRange("p", p,0,99);
/// <summary>
///  patch size for chroma planes (from 0 to 99) (default 0)
/// </summary>
public NlmeansFilterGen pc(int pc) => this.SetOptionRange("pc", pc,0,99);
/// <summary>
///  research window (from 0 to 99) (default 15)
/// </summary>
public NlmeansFilterGen r(int r) => this.SetOptionRange("r", r,0,99);
/// <summary>
///  research window for chroma planes (from 0 to 99) (default 0)
/// </summary>
public NlmeansFilterGen rc(int rc) => this.SetOptionRange("rc", rc,0,99);
}
public static class NlmeansFilterGenExtensions
{
/// <summary>
/// Non-local means denoiser.
/// </summary>
public static NlmeansFilterGen NlmeansFilterGen(this ImageMap input) => new NlmeansFilterGen(input);
}
}
