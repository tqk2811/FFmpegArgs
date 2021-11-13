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
public class DrmeterFilterGen : AudioToAudioFilter
{
internal DrmeterFilterGen(AudioMap input) : base("drmeter",input) { AddMapOut(); }
/// <summary>
///  set the window length (from 0.01 to 10) (default 3)
/// </summary>
public DrmeterFilterGen length(double length) => this.SetOptionRange("length", length,0.01,10);
}
public static class DrmeterFilterGenExtensions
{
/// <summary>
/// Measure audio dynamic range.
/// </summary>
public static DrmeterFilterGen DrmeterFilterGen(this AudioMap input) => new DrmeterFilterGen(input);
}
}
