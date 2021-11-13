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
public class PanFilterGen : AudioToAudioFilter
{
internal PanFilterGen(AudioMap input) : base("pan",input) { AddMapOut(); }
/// <summary>
/// 
/// </summary>
public PanFilterGen args(string args) => this.SetOption("args",args);
}
public static class PanFilterGenExtensions
{
/// <summary>
/// Remix channels with coefficients (panning).
/// </summary>
public static PanFilterGen PanFilterGen(this AudioMap input) => new PanFilterGen(input);
}
}
