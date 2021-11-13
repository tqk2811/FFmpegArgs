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
public class HdcdFilterGen : AudioToAudioFilter
{
internal HdcdFilterGen(AudioMap input) : base("hdcd",input) { AddMapOut(); }
/// <summary>
///  Disable any format conversion or resampling in the filter graph. (default true)
/// </summary>
public HdcdFilterGen disable_autoconvert(bool flag) => this.SetOption("disable_autoconvert",flag.ToFFmpegFlag());
/// <summary>
///  Process stereo channels together. Only apply target_gain when both channels match. (default true)
/// </summary>
public HdcdFilterGen process_stereo(bool flag) => this.SetOption("process_stereo",flag.ToFFmpegFlag());
/// <summary>
///  Code detect timer period in ms. (from 100 to 60000) (default 2000)
/// </summary>
public HdcdFilterGen cdt_ms(int cdt_ms) => this.SetOptionRange("cdt_ms", cdt_ms,100,60000);
/// <summary>
///  Always extend peaks above -3dBFS even when PE is not signaled. (default false)
/// </summary>
public HdcdFilterGen force_pe(bool flag) => this.SetOption("force_pe",flag.ToFFmpegFlag());
/// <summary>
///  Replace audio with solid tone and signal some processing aspect in the amplitude. (from 0 to 4) (default off)
/// </summary>
public HdcdFilterGen analyze_mode(HdcdFilterGenAnalyze_mode analyze_mode) => this.SetOption("analyze_mode", analyze_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Valid bits per sample (location of the true LSB). (from 16 to 24) (default 16)
/// </summary>
public HdcdFilterGen bits_per_sample(HdcdFilterGenBits_per_sample bits_per_sample) => this.SetOption("bits_per_sample", bits_per_sample.GetAttribute<NameAttribute>().Name);
}
public static class HdcdFilterGenExtensions
{
/// <summary>
/// Apply High Definition Compatible Digital (HDCD) decoding.
/// </summary>
public static HdcdFilterGen HdcdFilterGen(this AudioMap input) => new HdcdFilterGen(input);
}
public enum HdcdFilterGenAnalyze_mode
{
[Name("off")] off,
[Name("lle")] lle,
[Name("pe")] pe,
[Name("cdt")] cdt,
[Name("tgm")] tgm,
}

public enum HdcdFilterGenBits_per_sample
{
[Name("16")] _16,
[Name("20")] _20,
[Name("24")] _24,
}

}
