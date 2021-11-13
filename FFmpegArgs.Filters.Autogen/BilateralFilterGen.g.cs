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
public class BilateralFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal BilateralFilterGen(ImageMap input) : base("bilateral",input) { AddMapOut(); }
/// <summary>
///  set spatial sigma (from 0 to 512) (default 0.1)
/// </summary>
public BilateralFilterGen sigmaS(float sigmaS) => this.SetOptionRange("sigmaS", sigmaS,0,512);
/// <summary>
///  set range sigma (from 0 to 1) (default 0.1)
/// </summary>
public BilateralFilterGen sigmaR(float sigmaR) => this.SetOptionRange("sigmaR", sigmaR,0,1);
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public BilateralFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class BilateralFilterGenExtensions
{
/// <summary>
/// Apply Bilateral filter.
/// </summary>
public static BilateralFilterGen BilateralFilterGen(this ImageMap input) => new BilateralFilterGen(input);
}
}
