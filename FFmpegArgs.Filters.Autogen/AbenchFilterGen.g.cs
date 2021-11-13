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
public class AbenchFilterGen : AudioToAudioFilter
{
internal AbenchFilterGen(AudioMap input) : base("abench",input) { AddMapOut(); }
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public AbenchFilterGen action(AbenchFilterGenAction action) => this.SetOption("action", action.GetAttribute<NameAttribute>().Name);
}
public static class AbenchFilterGenExtensions
{
/// <summary>
/// Benchmark part of a filtergraph.
/// </summary>
public static AbenchFilterGen AbenchFilterGen(this AudioMap input0) => new AbenchFilterGen(input0);
}
public enum AbenchFilterGenAction
{
[Name("start")] start,
[Name("stop")] stop,
}

}
