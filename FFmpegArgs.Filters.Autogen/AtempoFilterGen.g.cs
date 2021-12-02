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
public class AtempoFilterGen : AudioToAudioFilter,ICommandSupport
{
internal AtempoFilterGen(AudioMap input) : base("atempo",input) { AddMapOut(); }
/// <summary>
///  set tempo scale factor (from 0.5 to 100) (default 1)
/// </summary>
public AtempoFilterGen tempo(double tempo) => this.SetOptionRange("tempo", tempo,0.5,100);
}
public static class AtempoFilterGenExtensions
{
/// <summary>
/// Adjust audio tempo.
/// </summary>
public static AtempoFilterGen AtempoFilterGen(this AudioMap input0) => new AtempoFilterGen(input0);
/// <summary>
/// Adjust audio tempo.
/// </summary>
public static AtempoFilterGen AtempoFilterGen(this AudioMap input0,AtempoFilterGenConfig config)
{
var result = new AtempoFilterGen(input0);
if(config?.tempo != null) result.tempo(config.tempo);
return result;
}
}
public class AtempoFilterGenConfig
{
/// <summary>
///  set tempo scale factor (from 0.5 to 100) (default 1)
/// </summary>
public double tempo { get; set; }
}
}
