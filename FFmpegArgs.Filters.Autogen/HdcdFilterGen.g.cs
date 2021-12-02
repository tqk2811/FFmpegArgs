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
public HdcdFilterGen disable_autoconvert(bool disable_autoconvert) => this.SetOption("disable_autoconvert",disable_autoconvert.ToFFmpegFlag());
/// <summary>
///  Process stereo channels together. Only apply target_gain when both channels match. (default true)
/// </summary>
public HdcdFilterGen process_stereo(bool process_stereo) => this.SetOption("process_stereo",process_stereo.ToFFmpegFlag());
/// <summary>
///  Code detect timer period in ms. (from 100 to 60000) (default 2000)
/// </summary>
public HdcdFilterGen cdt_ms(int cdt_ms) => this.SetOptionRange("cdt_ms", cdt_ms,100,60000);
/// <summary>
///  Always extend peaks above -3dBFS even when PE is not signaled. (default false)
/// </summary>
public HdcdFilterGen force_pe(bool force_pe) => this.SetOption("force_pe",force_pe.ToFFmpegFlag());
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
public static HdcdFilterGen HdcdFilterGen(this AudioMap input0) => new HdcdFilterGen(input0);
/// <summary>
/// Apply High Definition Compatible Digital (HDCD) decoding.
/// </summary>
public static HdcdFilterGen HdcdFilterGen(this AudioMap input0,HdcdFilterGenConfig config)
{
var result = new HdcdFilterGen(input0);
if(config?.disable_autoconvert != null) result.disable_autoconvert(config.disable_autoconvert.Value);
if(config?.process_stereo != null) result.process_stereo(config.process_stereo.Value);
if(config?.cdt_ms != null) result.cdt_ms(config.cdt_ms.Value);
if(config?.force_pe != null) result.force_pe(config.force_pe.Value);
if(config?.analyze_mode != null) result.analyze_mode(config.analyze_mode.Value);
if(config?.bits_per_sample != null) result.bits_per_sample(config.bits_per_sample.Value);
return result;
}
}
public class HdcdFilterGenConfig
{
/// <summary>
///  Disable any format conversion or resampling in the filter graph. (default true)
/// </summary>
public bool? disable_autoconvert { get; set; }
/// <summary>
///  Process stereo channels together. Only apply target_gain when both channels match. (default true)
/// </summary>
public bool? process_stereo { get; set; }
/// <summary>
///  Code detect timer period in ms. (from 100 to 60000) (default 2000)
/// </summary>
public int? cdt_ms { get; set; }
/// <summary>
///  Always extend peaks above -3dBFS even when PE is not signaled. (default false)
/// </summary>
public bool? force_pe { get; set; }
/// <summary>
///  Replace audio with solid tone and signal some processing aspect in the amplitude. (from 0 to 4) (default off)
/// </summary>
public HdcdFilterGenAnalyze_mode? analyze_mode { get; set; }
/// <summary>
///  Valid bits per sample (location of the true LSB). (from 16 to 24) (default 16)
/// </summary>
public HdcdFilterGenBits_per_sample? bits_per_sample { get; set; }
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
