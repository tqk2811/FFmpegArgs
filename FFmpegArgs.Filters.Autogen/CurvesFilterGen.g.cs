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
public class CurvesFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal CurvesFilterGen(ImageMap input) : base("curves",input) { AddMapOut(); }
/// <summary>
///  select a color curves preset (from 0 to 10) (default none)
/// </summary>
public CurvesFilterGen preset(CurvesFilterGenPreset preset) => this.SetOption("preset", preset.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set master points coordinates
/// </summary>
public CurvesFilterGen master(string master) => this.SetOption("master",master);
/// <summary>
///  set red points coordinates
/// </summary>
public CurvesFilterGen red(string red) => this.SetOption("red",red);
/// <summary>
///  set green points coordinates
/// </summary>
public CurvesFilterGen green(string green) => this.SetOption("green",green);
/// <summary>
///  set blue points coordinates
/// </summary>
public CurvesFilterGen blue(string blue) => this.SetOption("blue",blue);
/// <summary>
///  set points coordinates for all components
/// </summary>
public CurvesFilterGen all(string all) => this.SetOption("all",all);
/// <summary>
///  set Photoshop curves file name
/// </summary>
public CurvesFilterGen psfile(string psfile) => this.SetOption("psfile",psfile);
/// <summary>
///  save Gnuplot script of the curves in specified file
/// </summary>
public CurvesFilterGen plot(string plot) => this.SetOption("plot",plot);
}
public static class CurvesFilterGenExtensions
{
/// <summary>
/// Adjust components curves.
/// </summary>
public static CurvesFilterGen CurvesFilterGen(this ImageMap input0) => new CurvesFilterGen(input0);
/// <summary>
/// Adjust components curves.
/// </summary>
public static CurvesFilterGen CurvesFilterGen(this ImageMap input0,CurvesFilterGenConfig config)
{
var result = new CurvesFilterGen(input0);
if(config?.preset != null) result.preset(config.preset.Value);
if(!string.IsNullOrWhiteSpace(config?.master)) result.master(config.master);
if(!string.IsNullOrWhiteSpace(config?.red)) result.red(config.red);
if(!string.IsNullOrWhiteSpace(config?.green)) result.green(config.green);
if(!string.IsNullOrWhiteSpace(config?.blue)) result.blue(config.blue);
if(!string.IsNullOrWhiteSpace(config?.all)) result.all(config.all);
if(!string.IsNullOrWhiteSpace(config?.psfile)) result.psfile(config.psfile);
if(!string.IsNullOrWhiteSpace(config?.plot)) result.plot(config.plot);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class CurvesFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  select a color curves preset (from 0 to 10) (default none)
/// </summary>
public CurvesFilterGenPreset? preset { get; set; }
/// <summary>
///  set master points coordinates
/// </summary>
public string master { get; set; }
/// <summary>
///  set red points coordinates
/// </summary>
public string red { get; set; }
/// <summary>
///  set green points coordinates
/// </summary>
public string green { get; set; }
/// <summary>
///  set blue points coordinates
/// </summary>
public string blue { get; set; }
/// <summary>
///  set points coordinates for all components
/// </summary>
public string all { get; set; }
/// <summary>
///  set Photoshop curves file name
/// </summary>
public string psfile { get; set; }
/// <summary>
///  save Gnuplot script of the curves in specified file
/// </summary>
public string plot { get; set; }
public string TimelineSupport { get; set; }
}
public enum CurvesFilterGenPreset
{
[Name("none")] none,
[Name("color_negative")] color_negative,
[Name("cross_process")] cross_process,
[Name("darker")] darker,
[Name("increase_contrast")] increase_contrast,
[Name("lighter")] lighter,
[Name("linear_contrast")] linear_contrast,
[Name("medium_contrast")] medium_contrast,
[Name("negative")] negative,
[Name("strong_contrast")] strong_contrast,
[Name("vintage")] vintage,
}

}
