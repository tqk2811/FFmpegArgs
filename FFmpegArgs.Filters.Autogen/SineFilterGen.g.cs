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
public class SineFilterGen : SourceAudioFilter
{
internal SineFilterGen(FilterGraph input) : base("sine",input) { AddMapOut(); }
/// <summary>
///  set the sine frequency (from 0 to DBL_MAX) (default 440)
/// </summary>
public SineFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,DBL_MAX);
/// <summary>
///  set the beep frequency factor (from 0 to DBL_MAX) (default 0)
/// </summary>
public SineFilterGen beep_factor(double beep_factor) => this.SetOptionRange("beep_factor", beep_factor,0,DBL_MAX);
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public SineFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public SineFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
/// <summary>
///  set the audio duration (default 0)
/// </summary>
public SineFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set the number of samples per frame (default "1024")
/// </summary>
public SineFilterGen samples_per_frame(string samples_per_frame) => this.SetOption("samples_per_frame",samples_per_frame);
}
public static class SineFilterGenExtensions
{
/// <summary>
/// Generate sine wave audio signal.
/// </summary>
public static SineFilterGen SineFilterGen(this FilterGraph input0) => new SineFilterGen(input0);
/// <summary>
/// Generate sine wave audio signal.
/// </summary>
public static SineFilterGen SineFilterGen(this FilterGraph input0,SineFilterGenConfig config)
{
var result = new SineFilterGen(input0);
if(config?.frequency != null) result.frequency(config.frequency);
if(config?.beep_factor != null) result.beep_factor(config.beep_factor);
if(config?.sample_rate != null) result.sample_rate(config.sample_rate);
if(config?.r != null) result.r(config.r);
if(config?.duration != null) result.duration(config.duration);
if(config?.samples_per_frame != null) result.samples_per_frame(config.samples_per_frame);
return result;
}
}
public class SineFilterGenConfig
{
/// <summary>
///  set the sine frequency (from 0 to DBL_MAX) (default 440)
/// </summary>
public double frequency { get; set; }
/// <summary>
///  set the beep frequency factor (from 0 to DBL_MAX) (default 0)
/// </summary>
public double beep_factor { get; set; }
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int sample_rate { get; set; }
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int r { get; set; }
/// <summary>
///  set the audio duration (default 0)
/// </summary>
public TimeSpan duration { get; set; }
/// <summary>
///  set the number of samples per frame (default "1024")
/// </summary>
public string samples_per_frame { get; set; }
}
}
