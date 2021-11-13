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
public static HisteqFilterGen HisteqFilterGen(this ImageMap input) => new HisteqFilterGen(input);
}
public enum HisteqFilterGenAntibanding
{
[Name("none")] none,
[Name("weak")] weak,
[Name("strong")] strong,
}

}
