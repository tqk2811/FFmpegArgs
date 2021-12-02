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
public class AformatFilterGen : AudioToAudioFilter
{
internal AformatFilterGen(AudioMap input) : base("aformat",input) { AddMapOut(); }
/// <summary>
///  A '|'-separated list of sample formats.
/// </summary>
public AformatFilterGen sample_fmts(string sample_fmts) => this.SetOption("sample_fmts",sample_fmts);
/// <summary>
///  A '|'-separated list of sample formats.
/// </summary>
public AformatFilterGen f(string f) => this.SetOption("f",f);
/// <summary>
///  A '|'-separated list of sample rates.
/// </summary>
public AformatFilterGen sample_rates(string sample_rates) => this.SetOption("sample_rates",sample_rates);
/// <summary>
///  A '|'-separated list of sample rates.
/// </summary>
public AformatFilterGen r(string r) => this.SetOption("r",r);
/// <summary>
///  A '|'-separated list of channel layouts.
/// </summary>
public AformatFilterGen channel_layouts(string channel_layouts) => this.SetOption("channel_layouts",channel_layouts);
/// <summary>
///  A '|'-separated list of channel layouts.
/// </summary>
public AformatFilterGen cl(string cl) => this.SetOption("cl",cl);
}
public static class AformatFilterGenExtensions
{
/// <summary>
/// Convert the input audio to one of the specified formats.
/// </summary>
public static AformatFilterGen AformatFilterGen(this AudioMap input0) => new AformatFilterGen(input0);
/// <summary>
/// Convert the input audio to one of the specified formats.
/// </summary>
public static AformatFilterGen AformatFilterGen(this AudioMap input0,AformatFilterGenConfig config)
{
var result = new AformatFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.sample_fmts)) result.sample_fmts(config.sample_fmts);
if(!string.IsNullOrWhiteSpace(config?.f)) result.f(config.f);
if(!string.IsNullOrWhiteSpace(config?.sample_rates)) result.sample_rates(config.sample_rates);
if(!string.IsNullOrWhiteSpace(config?.r)) result.r(config.r);
if(!string.IsNullOrWhiteSpace(config?.channel_layouts)) result.channel_layouts(config.channel_layouts);
if(!string.IsNullOrWhiteSpace(config?.cl)) result.cl(config.cl);
return result;
}
}
public class AformatFilterGenConfig
{
/// <summary>
///  A '|'-separated list of sample formats.
/// </summary>
public string sample_fmts { get; set; }
/// <summary>
///  A '|'-separated list of sample formats.
/// </summary>
public string f { get; set; }
/// <summary>
///  A '|'-separated list of sample rates.
/// </summary>
public string sample_rates { get; set; }
/// <summary>
///  A '|'-separated list of sample rates.
/// </summary>
public string r { get; set; }
/// <summary>
///  A '|'-separated list of channel layouts.
/// </summary>
public string channel_layouts { get; set; }
/// <summary>
///  A '|'-separated list of channel layouts.
/// </summary>
public string cl { get; set; }
}
}
