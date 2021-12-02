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
public AsetnsamplesFilterGen pad(bool pad) => this.SetOption("pad",pad.ToFFmpegFlag());
}
public static class AsetnsamplesFilterGenExtensions
{
/// <summary>
/// Set the number of samples for each output audio frames.
/// </summary>
public static AsetnsamplesFilterGen AsetnsamplesFilterGen(this AudioMap input0) => new AsetnsamplesFilterGen(input0);
/// <summary>
/// Set the number of samples for each output audio frames.
/// </summary>
public static AsetnsamplesFilterGen AsetnsamplesFilterGen(this AudioMap input0,AsetnsamplesFilterGenConfig config)
{
var result = new AsetnsamplesFilterGen(input0);
if(config?.nb_out_samples != null) result.nb_out_samples(config.nb_out_samples);
if(config?.pad != null) result.pad(config.pad);
return result;
}
}
public class AsetnsamplesFilterGenConfig
{
/// <summary>
///  set the number of per-frame output samples (from 1 to INT_MAX) (default 1024)
/// </summary>
public int nb_out_samples { get; set; }
/// <summary>
///  pad last frame with zeros (default true)
/// </summary>
public bool pad { get; set; }
}
}
