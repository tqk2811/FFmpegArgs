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
public class AsendcmdFilterGen : AudioToAudioFilter
{
internal AsendcmdFilterGen(AudioMap input) : base("asendcmd",input) { AddMapOut(); }
/// <summary>
///  set commands
/// </summary>
public AsendcmdFilterGen commands(string commands) => this.SetOption("commands",commands);
/// <summary>
///  set commands file
/// </summary>
public AsendcmdFilterGen filename(string filename) => this.SetOption("filename",filename);
}
public static class AsendcmdFilterGenExtensions
{
/// <summary>
/// Send commands to filters.
/// </summary>
public static AsendcmdFilterGen AsendcmdFilterGen(this AudioMap input0) => new AsendcmdFilterGen(input0);
}
}
