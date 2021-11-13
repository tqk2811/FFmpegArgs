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
public class EqFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal EqFilterGen(ImageMap input) : base("eq",input) { AddMapOut(); }
/// <summary>
///  set the contrast adjustment, negative values give a negative image (default "1.0")
/// </summary>
public EqFilterGen contrast(string contrast) => this.SetOption("contrast",contrast);
/// <summary>
///  set the brightness adjustment (default "0.0")
/// </summary>
public EqFilterGen brightness(string brightness) => this.SetOption("brightness",brightness);
/// <summary>
///  set the saturation adjustment (default "1.0")
/// </summary>
public EqFilterGen saturation(string saturation) => this.SetOption("saturation",saturation);
/// <summary>
///  set the initial gamma value (default "1.0")
/// </summary>
public EqFilterGen gamma(string gamma) => this.SetOption("gamma",gamma);
/// <summary>
///  gamma value for red (default "1.0")
/// </summary>
public EqFilterGen gamma_r(string gamma_r) => this.SetOption("gamma_r",gamma_r);
/// <summary>
///  gamma value for green (default "1.0")
/// </summary>
public EqFilterGen gamma_g(string gamma_g) => this.SetOption("gamma_g",gamma_g);
/// <summary>
///  gamma value for blue (default "1.0")
/// </summary>
public EqFilterGen gamma_b(string gamma_b) => this.SetOption("gamma_b",gamma_b);
/// <summary>
///  set the gamma weight which reduces the effect of gamma on bright areas (default "1.0")
/// </summary>
public EqFilterGen gamma_weight(string gamma_weight) => this.SetOption("gamma_weight",gamma_weight);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public EqFilterGen eval(EqFilterGenEval eval) => this.SetOption("eval", eval.GetAttribute<NameAttribute>().Name);
}
public static class EqFilterGenExtensions
{
/// <summary>
/// Adjust brightness, contrast, gamma, and saturation.
/// </summary>
public static EqFilterGen EqFilterGen(this ImageMap input) => new EqFilterGen(input);
}
public enum EqFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
