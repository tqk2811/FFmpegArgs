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
public class AexciterFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal AexciterFilterGen(AudioMap input) : base("aexciter",input) { AddMapOut(); }
/// <summary>
///  set level in (from 0 to 64) (default 1)
/// </summary>
public AexciterFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0,64);
/// <summary>
///  set level out (from 0 to 64) (default 1)
/// </summary>
public AexciterFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0,64);
/// <summary>
///  set amount (from 0 to 64) (default 1)
/// </summary>
public AexciterFilterGen amount(double amount) => this.SetOptionRange("amount", amount,0,64);
/// <summary>
///  set harmonics (from 0.1 to 10) (default 8.5)
/// </summary>
public AexciterFilterGen drive(double drive) => this.SetOptionRange("drive", drive,0.1,10);
/// <summary>
///  set blend harmonics (from -10 to 10) (default 0)
/// </summary>
public AexciterFilterGen blend(double blend) => this.SetOptionRange("blend", blend,-10,10);
/// <summary>
///  set scope (from 2000 to 12000) (default 7500)
/// </summary>
public AexciterFilterGen freq(double freq) => this.SetOptionRange("freq", freq,2000,12000);
/// <summary>
///  set ceiling (from 9999 to 20000) (default 9999)
/// </summary>
public AexciterFilterGen ceil(double ceil) => this.SetOptionRange("ceil", ceil,9999,20000);
/// <summary>
///  enable listen mode (default false)
/// </summary>
public AexciterFilterGen listen(bool flag) => this.SetOption("listen",flag.ToFFmpegFlag());
}
public static class AexciterFilterGenExtensions
{
/// <summary>
/// Enhance high frequency part of audio.
/// </summary>
public static AexciterFilterGen AexciterFilterGen(this AudioMap input) => new AexciterFilterGen(input);
}
}
