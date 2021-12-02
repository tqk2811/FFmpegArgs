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
public class HisteqFilterGen : ImageToImageFilter,ITimelineSupport
{
internal HisteqFilterGen(ImageMap input) : base("histeq",input) { AddMapOut(); }
/// <summary>
///  set the strength (from 0 to 1) (default 0.2)
/// </summary>
public HisteqFilterGen strength(float strength) => this.SetOptionRange("strength", strength,0,1);
/// <summary>
///  set the intensity (from 0 to 1) (default 0.21)
/// </summary>
public HisteqFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,0,1);
/// <summary>
///  set the antibanding level (from 0 to 2) (default none)
/// </summary>
public HisteqFilterGen antibanding(HisteqFilterGenAntibanding antibanding) => this.SetOption("antibanding", antibanding.GetAttribute<NameAttribute>().Name);
}
public static class HisteqFilterGenExtensions
{
/// <summary>
/// Apply global color histogram equalization.
/// </summary>
public static HisteqFilterGen HisteqFilterGen(this ImageMap input0) => new HisteqFilterGen(input0);
/// <summary>
/// Apply global color histogram equalization.
/// </summary>
public static HisteqFilterGen HisteqFilterGen(this ImageMap input0,HisteqFilterGenConfig config)
{
var result = new HisteqFilterGen(input0);
if(config?.strength != null) result.strength(config.strength.Value);
if(config?.intensity != null) result.intensity(config.intensity.Value);
if(config?.antibanding != null) result.antibanding(config.antibanding.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class HisteqFilterGenConfig
{
/// <summary>
///  set the strength (from 0 to 1) (default 0.2)
/// </summary>
public float? strength { get; set; }
/// <summary>
///  set the intensity (from 0 to 1) (default 0.21)
/// </summary>
public float? intensity { get; set; }
/// <summary>
///  set the antibanding level (from 0 to 2) (default none)
/// </summary>
public HisteqFilterGenAntibanding? antibanding { get; set; }
public string TimelineSupport { get; set; }
}
public enum HisteqFilterGenAntibanding
{
[Name("none")] none,
[Name("weak")] weak,
[Name("strong")] strong,
}

}
