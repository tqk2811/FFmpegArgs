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
public static EqFilterGen EqFilterGen(this ImageMap input0) => new EqFilterGen(input0);
/// <summary>
/// Adjust brightness, contrast, gamma, and saturation.
/// </summary>
public static EqFilterGen EqFilterGen(this ImageMap input0,EqFilterGenConfig config)
{
var result = new EqFilterGen(input0);
if(config?.contrast != null) result.contrast(config.contrast);
if(config?.brightness != null) result.brightness(config.brightness);
if(config?.saturation != null) result.saturation(config.saturation);
if(config?.gamma != null) result.gamma(config.gamma);
if(config?.gamma_r != null) result.gamma_r(config.gamma_r);
if(config?.gamma_g != null) result.gamma_g(config.gamma_g);
if(config?.gamma_b != null) result.gamma_b(config.gamma_b);
if(config?.gamma_weight != null) result.gamma_weight(config.gamma_weight);
if(config?.eval != null) result.eval(config.eval);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class EqFilterGenConfig
{
/// <summary>
///  set the contrast adjustment, negative values give a negative image (default "1.0")
/// </summary>
public string contrast { get; set; }
/// <summary>
///  set the brightness adjustment (default "0.0")
/// </summary>
public string brightness { get; set; }
/// <summary>
///  set the saturation adjustment (default "1.0")
/// </summary>
public string saturation { get; set; }
/// <summary>
///  set the initial gamma value (default "1.0")
/// </summary>
public string gamma { get; set; }
/// <summary>
///  gamma value for red (default "1.0")
/// </summary>
public string gamma_r { get; set; }
/// <summary>
///  gamma value for green (default "1.0")
/// </summary>
public string gamma_g { get; set; }
/// <summary>
///  gamma value for blue (default "1.0")
/// </summary>
public string gamma_b { get; set; }
/// <summary>
///  set the gamma weight which reduces the effect of gamma on bright areas (default "1.0")
/// </summary>
public string gamma_weight { get; set; }
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public EqFilterGenEval eval { get; set; }
public string TimelineSupport { get; set; }
}
public enum EqFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
