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
public class AcrusherFilterGen : AudioToAudioFilter,ICommandSupport
{
internal AcrusherFilterGen(AudioMap input) : base("acrusher",input) { AddMapOut(); }
/// <summary>
///  set level in (from 0.015625 to 64) (default 1)
/// </summary>
public AcrusherFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set level out (from 0.015625 to 64) (default 1)
/// </summary>
public AcrusherFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0.015625,64);
/// <summary>
///  set bit reduction (from 1 to 64) (default 8)
/// </summary>
public AcrusherFilterGen bits(double bits) => this.SetOptionRange("bits", bits,1,64);
/// <summary>
///  set mix (from 0 to 1) (default 0.5)
/// </summary>
public AcrusherFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set mode (from 0 to 1) (default lin)
/// </summary>
public AcrusherFilterGen mode(AcrusherFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set DC (from 0.25 to 4) (default 1)
/// </summary>
public AcrusherFilterGen dc(double dc) => this.SetOptionRange("dc", dc,0.25,4);
/// <summary>
///  set anti-aliasing (from 0 to 1) (default 0.5)
/// </summary>
public AcrusherFilterGen aa(double aa) => this.SetOptionRange("aa", aa,0,1);
/// <summary>
///  set sample reduction (from 1 to 250) (default 1)
/// </summary>
public AcrusherFilterGen samples(double samples) => this.SetOptionRange("samples", samples,1,250);
/// <summary>
///  enable LFO (default false)
/// </summary>
public AcrusherFilterGen lfo(bool lfo) => this.SetOption("lfo",lfo.ToFFmpegFlag());
/// <summary>
///  set LFO depth (from 1 to 250) (default 20)
/// </summary>
public AcrusherFilterGen lforange(double lforange) => this.SetOptionRange("lforange", lforange,1,250);
/// <summary>
///  set LFO rate (from 0.01 to 200) (default 0.3)
/// </summary>
public AcrusherFilterGen lforate(double lforate) => this.SetOptionRange("lforate", lforate,0.01,200);
}
public static class AcrusherFilterGenExtensions
{
/// <summary>
/// Reduce audio bit resolution.
/// </summary>
public static AcrusherFilterGen AcrusherFilterGen(this AudioMap input0) => new AcrusherFilterGen(input0);
/// <summary>
/// Reduce audio bit resolution.
/// </summary>
public static AcrusherFilterGen AcrusherFilterGen(this AudioMap input0,AcrusherFilterGenConfig config)
{
var result = new AcrusherFilterGen(input0);
if(config?.level_in != null) result.level_in(config.level_in);
if(config?.level_out != null) result.level_out(config.level_out);
if(config?.bits != null) result.bits(config.bits);
if(config?.mix != null) result.mix(config.mix);
if(config?.mode != null) result.mode(config.mode);
if(config?.dc != null) result.dc(config.dc);
if(config?.aa != null) result.aa(config.aa);
if(config?.samples != null) result.samples(config.samples);
if(config?.lfo != null) result.lfo(config.lfo);
if(config?.lforange != null) result.lforange(config.lforange);
if(config?.lforate != null) result.lforate(config.lforate);
return result;
}
}
public class AcrusherFilterGenConfig
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
///  set bit reduction (from 1 to 64) (default 8)
/// </summary>
public double bits { get; set; }
/// <summary>
///  set mix (from 0 to 1) (default 0.5)
/// </summary>
public double mix { get; set; }
/// <summary>
///  set mode (from 0 to 1) (default lin)
/// </summary>
public AcrusherFilterGenMode mode { get; set; }
/// <summary>
///  set DC (from 0.25 to 4) (default 1)
/// </summary>
public double dc { get; set; }
/// <summary>
///  set anti-aliasing (from 0 to 1) (default 0.5)
/// </summary>
public double aa { get; set; }
/// <summary>
///  set sample reduction (from 1 to 250) (default 1)
/// </summary>
public double samples { get; set; }
/// <summary>
///  enable LFO (default false)
/// </summary>
public bool lfo { get; set; }
/// <summary>
///  set LFO depth (from 1 to 250) (default 20)
/// </summary>
public double lforange { get; set; }
/// <summary>
///  set LFO rate (from 0.01 to 200) (default 0.3)
/// </summary>
public double lforate { get; set; }
}
public enum AcrusherFilterGenMode
{
[Name("lin")] lin,
[Name("log")] log,
}

}
