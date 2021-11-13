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
public class StereotoolsFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal StereotoolsFilterGen(AudioMap input) : base("stereotools",input) { AddMapOut(); }
/// <summary>
///  set level in (from 0.015625 to 64) (default 1)
/// </summary>
public StereotoolsFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set level out (from 0.015625 to 64) (default 1)
/// </summary>
public StereotoolsFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0.015625,64);
/// <summary>
///  set balance in (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen balance_in(double balance_in) => this.SetOptionRange("balance_in", balance_in,-1,1);
/// <summary>
///  set balance out (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen balance_out(double balance_out) => this.SetOptionRange("balance_out", balance_out,-1,1);
/// <summary>
///  enable softclip (default false)
/// </summary>
public StereotoolsFilterGen softclip(bool flag) => this.SetOption("softclip",flag.ToFFmpegFlag());
/// <summary>
///  mute L (default false)
/// </summary>
public StereotoolsFilterGen mutel(bool flag) => this.SetOption("mutel",flag.ToFFmpegFlag());
/// <summary>
///  mute R (default false)
/// </summary>
public StereotoolsFilterGen muter(bool flag) => this.SetOption("muter",flag.ToFFmpegFlag());
/// <summary>
///  phase L (default false)
/// </summary>
public StereotoolsFilterGen phasel(bool flag) => this.SetOption("phasel",flag.ToFFmpegFlag());
/// <summary>
///  phase R (default false)
/// </summary>
public StereotoolsFilterGen phaser(bool flag) => this.SetOption("phaser",flag.ToFFmpegFlag());
/// <summary>
///  set stereo mode (from 0 to 10) (default lr>lr)
/// </summary>
public StereotoolsFilterGen mode(StereotoolsFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set side level (from 0.015625 to 64) (default 1)
/// </summary>
public StereotoolsFilterGen slev(double slev) => this.SetOptionRange("slev", slev,0.015625,64);
/// <summary>
///  set side balance (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen sbal(double sbal) => this.SetOptionRange("sbal", sbal,-1,1);
/// <summary>
///  set middle level (from 0.015625 to 64) (default 1)
/// </summary>
public StereotoolsFilterGen mlev(double mlev) => this.SetOptionRange("mlev", mlev,0.015625,64);
/// <summary>
///  set middle pan (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen mpan(double mpan) => this.SetOptionRange("mpan", mpan,-1,1);
/// <summary>
///  set stereo base (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen _base(double _base) => this.SetOptionRange("base", _base,-1,1);
/// <summary>
///  set delay (from -20 to 20) (default 0)
/// </summary>
public StereotoolsFilterGen delay(double delay) => this.SetOptionRange("delay", delay,-20,20);
/// <summary>
///  set S/C level (from 1 to 100) (default 1)
/// </summary>
public StereotoolsFilterGen sclevel(double sclevel) => this.SetOptionRange("sclevel", sclevel,1,100);
/// <summary>
///  set stereo phase (from 0 to 360) (default 0)
/// </summary>
public StereotoolsFilterGen phase(double phase) => this.SetOptionRange("phase", phase,0,360);
/// <summary>
///  set balance in mode (from 0 to 2) (default balance)
/// </summary>
public StereotoolsFilterGen bmode_in(StereotoolsFilterGenBmode_in bmode_in) => this.SetOption("bmode_in", bmode_in.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set balance out mode (from 0 to 2) (default balance)
/// </summary>
public StereotoolsFilterGen bmode_out(StereotoolsFilterGenBmode_out bmode_out) => this.SetOption("bmode_out", bmode_out.GetAttribute<NameAttribute>().Name);
}
public static class StereotoolsFilterGenExtensions
{
/// <summary>
/// Apply various stereo tools.
/// </summary>
public static StereotoolsFilterGen StereotoolsFilterGen(this AudioMap input) => new StereotoolsFilterGen(input);
}
public enum StereotoolsFilterGenMode
{
[Name("lr>lr")] lrGreaterThanlr,
[Name("lr>ms")] lrGreaterThanms,
[Name("ms>lr")] msGreaterThanlr,
[Name("lr>ll")] lrGreaterThanll,
[Name("lr>rr")] lrGreaterThanrr,
[Name("lr>l+r")] lrGreaterThanlPlusr,
[Name("lr>rl")] lrGreaterThanrl,
[Name("ms>ll")] msGreaterThanll,
[Name("ms>rr")] msGreaterThanrr,
[Name("ms>rl")] msGreaterThanrl,
[Name("lr>l-r")] lrGreaterThanl_r,
}

public enum StereotoolsFilterGenBmode_in
{
[Name("balance")] balance,
[Name("amplitude")] amplitude,
[Name("power")] power,
}

public enum StereotoolsFilterGenBmode_out
{
[Name("balance")] balance,
[Name("amplitude")] amplitude,
[Name("power")] power,
}

}
