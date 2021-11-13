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
public class FftfiltFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FftfiltFilterGen(ImageMap input) : base("fftfilt",input) { AddMapOut(); }
/// <summary>
///  adjust gain in Y plane (from 0 to 1000) (default 0)
/// </summary>
public FftfiltFilterGen dc_Y(int dc_Y) => this.SetOptionRange("dc_Y", dc_Y,0,1000);
/// <summary>
///  adjust gain in U plane (from 0 to 1000) (default 0)
/// </summary>
public FftfiltFilterGen dc_U(int dc_U) => this.SetOptionRange("dc_U", dc_U,0,1000);
/// <summary>
///  adjust gain in V plane (from 0 to 1000) (default 0)
/// </summary>
public FftfiltFilterGen dc_V(int dc_V) => this.SetOptionRange("dc_V", dc_V,0,1000);
/// <summary>
///  set luminance expression in Y plane (default "1")
/// </summary>
public FftfiltFilterGen weight_Y(string weight_Y) => this.SetOption("weight_Y",weight_Y);
/// <summary>
///  set chrominance expression in U plane
/// </summary>
public FftfiltFilterGen weight_U(string weight_U) => this.SetOption("weight_U",weight_U);
/// <summary>
///  set chrominance expression in V plane
/// </summary>
public FftfiltFilterGen weight_V(string weight_V) => this.SetOption("weight_V",weight_V);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public FftfiltFilterGen eval(FftfiltFilterGenEval eval) => this.SetOption("eval", eval.GetAttribute<NameAttribute>().Name);
}
public static class FftfiltFilterGenExtensions
{
/// <summary>
/// Apply arbitrary expressions to pixels in frequency domain.
/// </summary>
public static FftfiltFilterGen FftfiltFilterGen(this ImageMap input) => new FftfiltFilterGen(input);
}
public enum FftfiltFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
