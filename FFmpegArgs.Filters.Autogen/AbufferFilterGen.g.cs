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
public class AbufferFilterGen : SourceAudioFilter
{
internal AbufferFilterGen(FilterGraph input) : base("abuffer",input) { AddMapOut(); }
/// <summary>
///  (from 0 to INT_MAX) (default 0/1)
/// </summary>
public AbufferFilterGen time_base(string time_base) => this.SetOption("time_base",time_base);
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public AbufferFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,0,INT_MAX);
/// <summary>
///  (default none)
/// </summary>
public AbufferFilterGen sample_fmt(AVSampleFormat sample_fmt) => this.SetOption("sample_fmt",sample_fmt.GetAttribute<NameAttribute>().Name);
/// <summary>
/// 
/// </summary>
public AbufferFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public AbufferFilterGen channels(int channels) => this.SetOptionRange("channels", channels,0,INT_MAX);
}
public static class AbufferFilterGenExtensions
{
/// <summary>
/// Buffer audio frames, and make them accessible to the filterchain.
/// </summary>
public static AbufferFilterGen AbufferFilterGen(this FilterGraph input0) => new AbufferFilterGen(input0);
}
}
