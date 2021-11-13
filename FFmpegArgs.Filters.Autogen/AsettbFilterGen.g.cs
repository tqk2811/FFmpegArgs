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
public class AsettbFilterGen : AudioToAudioFilter
{
internal AsettbFilterGen(AudioMap input) : base("asettb",input) { AddMapOut(); }
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public AsettbFilterGen expr(string expr) => this.SetOption("expr",expr);
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public AsettbFilterGen tb(string tb) => this.SetOption("tb",tb);
}
public static class AsettbFilterGenExtensions
{
/// <summary>
/// Set timebase for the audio output link.
/// </summary>
public static AsettbFilterGen AsettbFilterGen(this AudioMap input0) => new AsettbFilterGen(input0);
}
}
