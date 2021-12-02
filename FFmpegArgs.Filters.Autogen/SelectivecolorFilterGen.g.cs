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
public class SelectivecolorFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal SelectivecolorFilterGen(ImageMap input) : base("selectivecolor",input) { AddMapOut(); }
/// <summary>
///  select correction method (from 0 to 1) (default absolute)
/// </summary>
public SelectivecolorFilterGen correction_method(SelectivecolorFilterGenCorrection_method correction_method) => this.SetOption("correction_method", correction_method.GetAttribute<NameAttribute>().Name);
/// <summary>
///  adjust red regions
/// </summary>
public SelectivecolorFilterGen reds(string reds) => this.SetOption("reds",reds);
/// <summary>
///  adjust yellow regions
/// </summary>
public SelectivecolorFilterGen yellows(string yellows) => this.SetOption("yellows",yellows);
/// <summary>
///  adjust green regions
/// </summary>
public SelectivecolorFilterGen greens(string greens) => this.SetOption("greens",greens);
/// <summary>
///  adjust cyan regions
/// </summary>
public SelectivecolorFilterGen cyans(string cyans) => this.SetOption("cyans",cyans);
/// <summary>
///  adjust blue regions
/// </summary>
public SelectivecolorFilterGen blues(string blues) => this.SetOption("blues",blues);
/// <summary>
///  adjust magenta regions
/// </summary>
public SelectivecolorFilterGen magentas(string magentas) => this.SetOption("magentas",magentas);
/// <summary>
///  adjust white regions
/// </summary>
public SelectivecolorFilterGen whites(string whites) => this.SetOption("whites",whites);
/// <summary>
///  adjust neutral regions
/// </summary>
public SelectivecolorFilterGen neutrals(string neutrals) => this.SetOption("neutrals",neutrals);
/// <summary>
///  adjust black regions
/// </summary>
public SelectivecolorFilterGen blacks(string blacks) => this.SetOption("blacks",blacks);
/// <summary>
///  set Photoshop selectivecolor file name
/// </summary>
public SelectivecolorFilterGen psfile(string psfile) => this.SetOption("psfile",psfile);
}
public static class SelectivecolorFilterGenExtensions
{
/// <summary>
/// Apply CMYK adjustments to specific color ranges.
/// </summary>
public static SelectivecolorFilterGen SelectivecolorFilterGen(this ImageMap input0) => new SelectivecolorFilterGen(input0);
/// <summary>
/// Apply CMYK adjustments to specific color ranges.
/// </summary>
public static SelectivecolorFilterGen SelectivecolorFilterGen(this ImageMap input0,SelectivecolorFilterGenConfig config)
{
var result = new SelectivecolorFilterGen(input0);
if(config?.correction_method != null) result.correction_method(config.correction_method.Value);
if(!string.IsNullOrWhiteSpace(config?.reds)) result.reds(config.reds);
if(!string.IsNullOrWhiteSpace(config?.yellows)) result.yellows(config.yellows);
if(!string.IsNullOrWhiteSpace(config?.greens)) result.greens(config.greens);
if(!string.IsNullOrWhiteSpace(config?.cyans)) result.cyans(config.cyans);
if(!string.IsNullOrWhiteSpace(config?.blues)) result.blues(config.blues);
if(!string.IsNullOrWhiteSpace(config?.magentas)) result.magentas(config.magentas);
if(!string.IsNullOrWhiteSpace(config?.whites)) result.whites(config.whites);
if(!string.IsNullOrWhiteSpace(config?.neutrals)) result.neutrals(config.neutrals);
if(!string.IsNullOrWhiteSpace(config?.blacks)) result.blacks(config.blacks);
if(!string.IsNullOrWhiteSpace(config?.psfile)) result.psfile(config.psfile);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class SelectivecolorFilterGenConfig
{
/// <summary>
///  select correction method (from 0 to 1) (default absolute)
/// </summary>
public SelectivecolorFilterGenCorrection_method? correction_method { get; set; }
/// <summary>
///  adjust red regions
/// </summary>
public string reds { get; set; }
/// <summary>
///  adjust yellow regions
/// </summary>
public string yellows { get; set; }
/// <summary>
///  adjust green regions
/// </summary>
public string greens { get; set; }
/// <summary>
///  adjust cyan regions
/// </summary>
public string cyans { get; set; }
/// <summary>
///  adjust blue regions
/// </summary>
public string blues { get; set; }
/// <summary>
///  adjust magenta regions
/// </summary>
public string magentas { get; set; }
/// <summary>
///  adjust white regions
/// </summary>
public string whites { get; set; }
/// <summary>
///  adjust neutral regions
/// </summary>
public string neutrals { get; set; }
/// <summary>
///  adjust black regions
/// </summary>
public string blacks { get; set; }
/// <summary>
///  set Photoshop selectivecolor file name
/// </summary>
public string psfile { get; set; }
public string TimelineSupport { get; set; }
}
public enum SelectivecolorFilterGenCorrection_method
{
[Name("absolute")] absolute,
[Name("relative")] relative,
}

}
