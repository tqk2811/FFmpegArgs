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
public class AsetrateFilterGen : AudioToAudioFilter
{
internal AsetrateFilterGen(AudioMap input) : base("asetrate",input) { AddMapOut(); }
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AsetrateFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AsetrateFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
}
public static class AsetrateFilterGenExtensions
{
/// <summary>
/// Change the sample rate without altering the data.
/// </summary>
public static AsetrateFilterGen AsetrateFilterGen(this AudioMap input0) => new AsetrateFilterGen(input0);
/// <summary>
/// Change the sample rate without altering the data.
/// </summary>
public static AsetrateFilterGen AsetrateFilterGen(this AudioMap input0,AsetrateFilterGenConfig config)
{
var result = new AsetrateFilterGen(input0);
if(config?.sample_rate != null) result.sample_rate(config.sample_rate);
if(config?.r != null) result.r(config.r);
return result;
}
}
public class AsetrateFilterGenConfig
{
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int sample_rate { get; set; }
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int r { get; set; }
}
}
