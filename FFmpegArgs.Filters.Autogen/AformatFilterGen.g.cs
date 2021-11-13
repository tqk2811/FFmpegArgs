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
}
}
