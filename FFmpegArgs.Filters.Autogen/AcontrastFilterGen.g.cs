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
public class AcontrastFilterGen : AudioToAudioFilter
{
internal AcontrastFilterGen(AudioMap input) : base("acontrast",input) { AddMapOut(); }
/// <summary>
///  set contrast (from 0 to 100) (default 33)
/// </summary>
public AcontrastFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast,0,100);
}
public static class AcontrastFilterGenExtensions
{
/// <summary>
/// Simple audio dynamic range compression/expansion filter.
/// </summary>
public static AcontrastFilterGen AcontrastFilterGen(this AudioMap input0) => new AcontrastFilterGen(input0);
}
}
