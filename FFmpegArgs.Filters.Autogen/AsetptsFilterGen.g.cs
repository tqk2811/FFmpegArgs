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
public class AsetptsFilterGen : AudioToAudioFilter
{
internal AsetptsFilterGen(AudioMap input) : base("asetpts",input) { AddMapOut(); }
/// <summary>
///  Expression determining the frame timestamp (default "PTS")
/// </summary>
public AsetptsFilterGen expr(string expr) => this.SetOption("expr",expr);
}
public static class AsetptsFilterGenExtensions
{
/// <summary>
/// Set PTS for the output audio frame.
/// </summary>
public static AsetptsFilterGen AsetptsFilterGen(this AudioMap input) => new AsetptsFilterGen(input);
}
}
