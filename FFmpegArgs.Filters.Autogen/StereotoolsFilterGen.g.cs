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
public StereotoolsFilterGen softclip(bool softclip) => this.SetOption("softclip",softclip.ToFFmpegFlag());
/// <summary>
///  mute L (default false)
/// </summary>
public StereotoolsFilterGen mutel(bool mutel) => this.SetOption("mutel",mutel.ToFFmpegFlag());
/// <summary>
///  mute R (default false)
/// </summary>
public StereotoolsFilterGen muter(bool muter) => this.SetOption("muter",muter.ToFFmpegFlag());
/// <summary>
///  phase L (default false)
/// </summary>
public StereotoolsFilterGen phasel(bool phasel) => this.SetOption("phasel",phasel.ToFFmpegFlag());
/// <summary>
///  phase R (default false)
/// </summary>
public StereotoolsFilterGen phaser(bool phaser) => this.SetOption("phaser",phaser.ToFFmpegFlag());
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
public static StereotoolsFilterGen StereotoolsFilterGen(this AudioMap input0) => new StereotoolsFilterGen(input0);
/// <summary>
/// Apply various stereo tools.
/// </summary>
public static StereotoolsFilterGen StereotoolsFilterGen(this AudioMap input0,StereotoolsFilterGenConfig config)
{
var result = new StereotoolsFilterGen(input0);
if(config?.level_in != null) result.level_in(config.level_in);
if(config?.level_out != null) result.level_out(config.level_out);
if(config?.balance_in != null) result.balance_in(config.balance_in);
if(config?.balance_out != null) result.balance_out(config.balance_out);
if(config?.softclip != null) result.softclip(config.softclip);
if(config?.mutel != null) result.mutel(config.mutel);
if(config?.muter != null) result.muter(config.muter);
if(config?.phasel != null) result.phasel(config.phasel);
if(config?.phaser != null) result.phaser(config.phaser);
if(config?.mode != null) result.mode(config.mode);
if(config?.slev != null) result.slev(config.slev);
if(config?.sbal != null) result.sbal(config.sbal);
if(config?.mlev != null) result.mlev(config.mlev);
if(config?.mpan != null) result.mpan(config.mpan);
if(config?._base != null) result._base(config._base);
if(config?.delay != null) result.delay(config.delay);
if(config?.sclevel != null) result.sclevel(config.sclevel);
if(config?.phase != null) result.phase(config.phase);
if(config?.bmode_in != null) result.bmode_in(config.bmode_in);
if(config?.bmode_out != null) result.bmode_out(config.bmode_out);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class StereotoolsFilterGenConfig
{
/// <summary>
///  set level in (from 0.015625 to 64) (default 1)
/// </summary>
public double level_in { get; set; }
/// <summary>
///  set level out (from 0.015625 to 64) (default 1)
/// </summary>
public double level_out { get; set; }
/// <summary>
///  set balance in (from -1 to 1) (default 0)
/// </summary>
public double balance_in { get; set; }
/// <summary>
///  set balance out (from -1 to 1) (default 0)
/// </summary>
public double balance_out { get; set; }
/// <summary>
///  enable softclip (default false)
/// </summary>
public bool softclip { get; set; }
/// <summary>
///  mute L (default false)
/// </summary>
public bool mutel { get; set; }
/// <summary>
///  mute R (default false)
/// </summary>
public bool muter { get; set; }
/// <summary>
///  phase L (default false)
/// </summary>
public bool phasel { get; set; }
/// <summary>
///  phase R (default false)
/// </summary>
public bool phaser { get; set; }
/// <summary>
///  set stereo mode (from 0 to 10) (default lr>lr)
/// </summary>
public StereotoolsFilterGenMode mode { get; set; }
/// <summary>
///  set side level (from 0.015625 to 64) (default 1)
/// </summary>
public double slev { get; set; }
/// <summary>
///  set side balance (from -1 to 1) (default 0)
/// </summary>
public double sbal { get; set; }
/// <summary>
///  set middle level (from 0.015625 to 64) (default 1)
/// </summary>
public double mlev { get; set; }
/// <summary>
///  set middle pan (from -1 to 1) (default 0)
/// </summary>
public double mpan { get; set; }
/// <summary>
///  set stereo base (from -1 to 1) (default 0)
/// </summary>
public double _base { get; set; }
/// <summary>
///  set delay (from -20 to 20) (default 0)
/// </summary>
public double delay { get; set; }
/// <summary>
///  set S/C level (from 1 to 100) (default 1)
/// </summary>
public double sclevel { get; set; }
/// <summary>
///  set stereo phase (from 0 to 360) (default 0)
/// </summary>
public double phase { get; set; }
/// <summary>
///  set balance in mode (from 0 to 2) (default balance)
/// </summary>
public StereotoolsFilterGenBmode_in bmode_in { get; set; }
/// <summary>
///  set balance out mode (from 0 to 2) (default balance)
/// </summary>
public StereotoolsFilterGenBmode_out bmode_out { get; set; }
public string TimelineSupport { get; set; }
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
