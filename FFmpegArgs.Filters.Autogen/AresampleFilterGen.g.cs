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
public class AresampleFilterGen : AudioToAudioFilter
{
internal AresampleFilterGen(AudioMap input) : base("aresample",input) { AddMapOut(); }
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public AresampleFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,0,INT_MAX);
}
public static class AresampleFilterGenExtensions
{
/// <summary>
/// Resample audio data.
/// </summary>
public static AresampleFilterGen AresampleFilterGen(this AudioMap input0) => new AresampleFilterGen(input0);
}
}
