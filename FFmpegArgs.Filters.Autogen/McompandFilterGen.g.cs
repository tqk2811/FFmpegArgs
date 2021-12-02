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
public class McompandFilterGen : AudioToAudioFilter
{
internal McompandFilterGen(AudioMap input) : base("mcompand",input) { AddMapOut(); }
/// <summary>
///  set parameters for each band (default "0.005,0.1 6 -47/-40,-34/-34,-17/-33 100 | 0.003,0.05 6 -47/-40,-34/-34,-17/-33 400 | 0.000625,0.0125 6 -47/-40,-34/-34,-15/-33 1600 | 0.0001,0.025 6 -47/-40,-34/-34,-31/-31,-0/-30 6400 | 0,0.025 6 -38/-31,-28/-28,-0/-25 22000")
/// </summary>
public McompandFilterGen args(string args) => this.SetOption("args",args);
}
public static class McompandFilterGenExtensions
{
/// <summary>
/// Multiband Compress or expand audio dynamic range.
/// </summary>
public static McompandFilterGen McompandFilterGen(this AudioMap input0) => new McompandFilterGen(input0);
/// <summary>
/// Multiband Compress or expand audio dynamic range.
/// </summary>
public static McompandFilterGen McompandFilterGen(this AudioMap input0,McompandFilterGenConfig config)
{
var result = new McompandFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.args)) result.args(config.args);
return result;
}
}
public class McompandFilterGenConfig
{
/// <summary>
///  set parameters for each band (default "0.005,0.1 6 -47/-40,-34/-34,-17/-33 100 | 0.003,0.05 6 -47/-40,-34/-34,-17/-33 400 | 0.000625,0.0125 6 -47/-40,-34/-34,-15/-33 1600 | 0.0001,0.025 6 -47/-40,-34/-34,-31/-31,-0/-30 6400 | 0,0.025 6 -38/-31,-28/-28,-0/-25 22000")
/// </summary>
public string args { get; set; }
}
}
