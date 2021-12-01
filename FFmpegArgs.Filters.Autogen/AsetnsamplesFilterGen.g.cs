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
public class AsetnsamplesFilterGen : AudioToAudioFilter
{
internal AsetnsamplesFilterGen(AudioMap input) : base("asetnsamples",input) { AddMapOut(); }
/// <summary>
///  set the number of per-frame output samples (from 1 to INT_MAX) (default 1024)
/// </summary>
public AsetnsamplesFilterGen nb_out_samples(int nb_out_samples) => this.SetOptionRange("nb_out_samples", nb_out_samples,1,INT_MAX);
/// <summary>
///  pad last frame with zeros (default true)
/// </summary>
public AsetnsamplesFilterGen pad(bool flag) => this.SetOption("pad",flag.ToFFmpegFlag());
}
public static class AsetnsamplesFilterGenExtensions
{
/// <summary>
/// Set the number of samples for each output audio frames.
/// </summary>
public static AsetnsamplesFilterGen AsetnsamplesFilterGen(this AudioMap input0) => new AsetnsamplesFilterGen(input0);
}
}
