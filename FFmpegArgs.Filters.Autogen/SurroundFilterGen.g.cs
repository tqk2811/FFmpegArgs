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
public class SurroundFilterGen : AudioToAudioFilter,ISliceThreading
{
internal SurroundFilterGen(AudioMap input) : base("surround",input) { AddMapOut(); }
/// <summary>
///  set output channel layout (default "5.1")
/// </summary>
public SurroundFilterGen chl_out(string chl_out) => this.SetOption("chl_out",chl_out);
/// <summary>
///  set input channel layout (default "stereo")
/// </summary>
public SurroundFilterGen chl_in(string chl_in) => this.SetOption("chl_in",chl_in);
/// <summary>
///  set input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen level_in(float level_in) => this.SetOptionRange("level_in", level_in,0,10);
/// <summary>
///  set output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen level_out(float level_out) => this.SetOptionRange("level_out", level_out,0,10);
/// <summary>
///  output LFE (default true)
/// </summary>
public SurroundFilterGen lfe(bool lfe) => this.SetOption("lfe",lfe.ToFFmpegFlag());
/// <summary>
///  LFE low cut off (from 0 to 256) (default 128)
/// </summary>
public SurroundFilterGen lfe_low(int lfe_low) => this.SetOptionRange("lfe_low", lfe_low,0,256);
/// <summary>
///  LFE high cut off (from 0 to 512) (default 256)
/// </summary>
public SurroundFilterGen lfe_high(int lfe_high) => this.SetOptionRange("lfe_high", lfe_high,0,512);
/// <summary>
///  set LFE channel mode (from 0 to 1) (default add)
/// </summary>
public SurroundFilterGen lfe_mode(SurroundFilterGenLfe_mode lfe_mode) => this.SetOption("lfe_mode", lfe_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set soundfield transform angle (from 0 to 360) (default 90)
/// </summary>
public SurroundFilterGen angle(float angle) => this.SetOptionRange("angle", angle,0,360);
/// <summary>
///  set front center channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen fc_in(float fc_in) => this.SetOptionRange("fc_in", fc_in,0,10);
/// <summary>
///  set front center channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen fc_out(float fc_out) => this.SetOptionRange("fc_out", fc_out,0,10);
/// <summary>
///  set front left channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen fl_in(float fl_in) => this.SetOptionRange("fl_in", fl_in,0,10);
/// <summary>
///  set front left channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen fl_out(float fl_out) => this.SetOptionRange("fl_out", fl_out,0,10);
/// <summary>
///  set front right channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen fr_in(float fr_in) => this.SetOptionRange("fr_in", fr_in,0,10);
/// <summary>
///  set front right channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen fr_out(float fr_out) => this.SetOptionRange("fr_out", fr_out,0,10);
/// <summary>
///  set side left channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen sl_in(float sl_in) => this.SetOptionRange("sl_in", sl_in,0,10);
/// <summary>
///  set side left channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen sl_out(float sl_out) => this.SetOptionRange("sl_out", sl_out,0,10);
/// <summary>
///  set side right channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen sr_in(float sr_in) => this.SetOptionRange("sr_in", sr_in,0,10);
/// <summary>
///  set side right channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen sr_out(float sr_out) => this.SetOptionRange("sr_out", sr_out,0,10);
/// <summary>
///  set back left channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen bl_in(float bl_in) => this.SetOptionRange("bl_in", bl_in,0,10);
/// <summary>
///  set back left channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen bl_out(float bl_out) => this.SetOptionRange("bl_out", bl_out,0,10);
/// <summary>
///  set back right channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen br_in(float br_in) => this.SetOptionRange("br_in", br_in,0,10);
/// <summary>
///  set back right channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen br_out(float br_out) => this.SetOptionRange("br_out", br_out,0,10);
/// <summary>
///  set back center channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen bc_in(float bc_in) => this.SetOptionRange("bc_in", bc_in,0,10);
/// <summary>
///  set back center channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen bc_out(float bc_out) => this.SetOptionRange("bc_out", bc_out,0,10);
/// <summary>
///  set lfe channel input level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen lfe_in(float lfe_in) => this.SetOptionRange("lfe_in", lfe_in,0,10);
/// <summary>
///  set lfe channel output level (from 0 to 10) (default 1)
/// </summary>
public SurroundFilterGen lfe_out(float lfe_out) => this.SetOptionRange("lfe_out", lfe_out,0,10);
/// <summary>
///  set all channel's x spread (from -1 to 15) (default -1)
/// </summary>
public SurroundFilterGen allx(float allx) => this.SetOptionRange("allx", allx,-1,15);
/// <summary>
///  set all channel's y spread (from -1 to 15) (default -1)
/// </summary>
public SurroundFilterGen ally(float ally) => this.SetOptionRange("ally", ally,-1,15);
/// <summary>
///  set front center channel x spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen fcx(float fcx) => this.SetOptionRange("fcx", fcx,0,15);
/// <summary>
///  set front left channel x spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen flx(float flx) => this.SetOptionRange("flx", flx,0,15);
/// <summary>
///  set front right channel x spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen frx(float frx) => this.SetOptionRange("frx", frx,0,15);
/// <summary>
///  set back left channel x spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen blx(float blx) => this.SetOptionRange("blx", blx,0,15);
/// <summary>
///  set back right channel x spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen brx(float brx) => this.SetOptionRange("brx", brx,0,15);
/// <summary>
///  set side left channel x spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen slx(float slx) => this.SetOptionRange("slx", slx,0,15);
/// <summary>
///  set side right channel x spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen srx(float srx) => this.SetOptionRange("srx", srx,0,15);
/// <summary>
///  set back center channel x spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen bcx(float bcx) => this.SetOptionRange("bcx", bcx,0,15);
/// <summary>
///  set front center channel y spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen fcy(float fcy) => this.SetOptionRange("fcy", fcy,0,15);
/// <summary>
///  set front left channel y spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen fly(float fly) => this.SetOptionRange("fly", fly,0,15);
/// <summary>
///  set front right channel y spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen fry(float fry) => this.SetOptionRange("fry", fry,0,15);
/// <summary>
///  set back left channel y spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen bly(float bly) => this.SetOptionRange("bly", bly,0,15);
/// <summary>
///  set back right channel y spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen bry(float bry) => this.SetOptionRange("bry", bry,0,15);
/// <summary>
///  set side left channel y spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen sly(float sly) => this.SetOptionRange("sly", sly,0,15);
/// <summary>
///  set side right channel y spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen sry(float sry) => this.SetOptionRange("sry", sry,0,15);
/// <summary>
///  set back center channel y spread (from 0 to 15) (default 1)
/// </summary>
public SurroundFilterGen bcy(float bcy) => this.SetOptionRange("bcy", bcy,0,15);
/// <summary>
///  set window size (from 1024 to 65536) (default 4096)
/// </summary>
public SurroundFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size,1024,65536);
/// <summary>
///  set window function (from 0 to 19) (default hann)
/// </summary>
public SurroundFilterGen win_func(SurroundFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set window overlap (from 0 to 1) (default 0.5)
/// </summary>
public SurroundFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap,0,1);
}
public static class SurroundFilterGenExtensions
{
/// <summary>
/// Apply audio surround upmix filter.
/// </summary>
public static SurroundFilterGen SurroundFilterGen(this AudioMap input0) => new SurroundFilterGen(input0);
/// <summary>
/// Apply audio surround upmix filter.
/// </summary>
public static SurroundFilterGen SurroundFilterGen(this AudioMap input0,SurroundFilterGenConfig config)
{
var result = new SurroundFilterGen(input0);
if(config?.chl_out != null) result.chl_out(config.chl_out);
if(config?.chl_in != null) result.chl_in(config.chl_in);
if(config?.level_in != null) result.level_in(config.level_in);
if(config?.level_out != null) result.level_out(config.level_out);
if(config?.lfe != null) result.lfe(config.lfe);
if(config?.lfe_low != null) result.lfe_low(config.lfe_low);
if(config?.lfe_high != null) result.lfe_high(config.lfe_high);
if(config?.lfe_mode != null) result.lfe_mode(config.lfe_mode);
if(config?.angle != null) result.angle(config.angle);
if(config?.fc_in != null) result.fc_in(config.fc_in);
if(config?.fc_out != null) result.fc_out(config.fc_out);
if(config?.fl_in != null) result.fl_in(config.fl_in);
if(config?.fl_out != null) result.fl_out(config.fl_out);
if(config?.fr_in != null) result.fr_in(config.fr_in);
if(config?.fr_out != null) result.fr_out(config.fr_out);
if(config?.sl_in != null) result.sl_in(config.sl_in);
if(config?.sl_out != null) result.sl_out(config.sl_out);
if(config?.sr_in != null) result.sr_in(config.sr_in);
if(config?.sr_out != null) result.sr_out(config.sr_out);
if(config?.bl_in != null) result.bl_in(config.bl_in);
if(config?.bl_out != null) result.bl_out(config.bl_out);
if(config?.br_in != null) result.br_in(config.br_in);
if(config?.br_out != null) result.br_out(config.br_out);
if(config?.bc_in != null) result.bc_in(config.bc_in);
if(config?.bc_out != null) result.bc_out(config.bc_out);
if(config?.lfe_in != null) result.lfe_in(config.lfe_in);
if(config?.lfe_out != null) result.lfe_out(config.lfe_out);
if(config?.allx != null) result.allx(config.allx);
if(config?.ally != null) result.ally(config.ally);
if(config?.fcx != null) result.fcx(config.fcx);
if(config?.flx != null) result.flx(config.flx);
if(config?.frx != null) result.frx(config.frx);
if(config?.blx != null) result.blx(config.blx);
if(config?.brx != null) result.brx(config.brx);
if(config?.slx != null) result.slx(config.slx);
if(config?.srx != null) result.srx(config.srx);
if(config?.bcx != null) result.bcx(config.bcx);
if(config?.fcy != null) result.fcy(config.fcy);
if(config?.fly != null) result.fly(config.fly);
if(config?.fry != null) result.fry(config.fry);
if(config?.bly != null) result.bly(config.bly);
if(config?.bry != null) result.bry(config.bry);
if(config?.sly != null) result.sly(config.sly);
if(config?.sry != null) result.sry(config.sry);
if(config?.bcy != null) result.bcy(config.bcy);
if(config?.win_size != null) result.win_size(config.win_size);
if(config?.win_func != null) result.win_func(config.win_func);
if(config?.overlap != null) result.overlap(config.overlap);
return result;
}
}
public class SurroundFilterGenConfig
{
/// <summary>
///  set output channel layout (default "5.1")
/// </summary>
public string chl_out { get; set; }
/// <summary>
///  set input channel layout (default "stereo")
/// </summary>
public string chl_in { get; set; }
/// <summary>
///  set input level (from 0 to 10) (default 1)
/// </summary>
public float level_in { get; set; }
/// <summary>
///  set output level (from 0 to 10) (default 1)
/// </summary>
public float level_out { get; set; }
/// <summary>
///  output LFE (default true)
/// </summary>
public bool lfe { get; set; }
/// <summary>
///  LFE low cut off (from 0 to 256) (default 128)
/// </summary>
public int lfe_low { get; set; }
/// <summary>
///  LFE high cut off (from 0 to 512) (default 256)
/// </summary>
public int lfe_high { get; set; }
/// <summary>
///  set LFE channel mode (from 0 to 1) (default add)
/// </summary>
public SurroundFilterGenLfe_mode lfe_mode { get; set; }
/// <summary>
///  set soundfield transform angle (from 0 to 360) (default 90)
/// </summary>
public float angle { get; set; }
/// <summary>
///  set front center channel input level (from 0 to 10) (default 1)
/// </summary>
public float fc_in { get; set; }
/// <summary>
///  set front center channel output level (from 0 to 10) (default 1)
/// </summary>
public float fc_out { get; set; }
/// <summary>
///  set front left channel input level (from 0 to 10) (default 1)
/// </summary>
public float fl_in { get; set; }
/// <summary>
///  set front left channel output level (from 0 to 10) (default 1)
/// </summary>
public float fl_out { get; set; }
/// <summary>
///  set front right channel input level (from 0 to 10) (default 1)
/// </summary>
public float fr_in { get; set; }
/// <summary>
///  set front right channel output level (from 0 to 10) (default 1)
/// </summary>
public float fr_out { get; set; }
/// <summary>
///  set side left channel input level (from 0 to 10) (default 1)
/// </summary>
public float sl_in { get; set; }
/// <summary>
///  set side left channel output level (from 0 to 10) (default 1)
/// </summary>
public float sl_out { get; set; }
/// <summary>
///  set side right channel input level (from 0 to 10) (default 1)
/// </summary>
public float sr_in { get; set; }
/// <summary>
///  set side right channel output level (from 0 to 10) (default 1)
/// </summary>
public float sr_out { get; set; }
/// <summary>
///  set back left channel input level (from 0 to 10) (default 1)
/// </summary>
public float bl_in { get; set; }
/// <summary>
///  set back left channel output level (from 0 to 10) (default 1)
/// </summary>
public float bl_out { get; set; }
/// <summary>
///  set back right channel input level (from 0 to 10) (default 1)
/// </summary>
public float br_in { get; set; }
/// <summary>
///  set back right channel output level (from 0 to 10) (default 1)
/// </summary>
public float br_out { get; set; }
/// <summary>
///  set back center channel input level (from 0 to 10) (default 1)
/// </summary>
public float bc_in { get; set; }
/// <summary>
///  set back center channel output level (from 0 to 10) (default 1)
/// </summary>
public float bc_out { get; set; }
/// <summary>
///  set lfe channel input level (from 0 to 10) (default 1)
/// </summary>
public float lfe_in { get; set; }
/// <summary>
///  set lfe channel output level (from 0 to 10) (default 1)
/// </summary>
public float lfe_out { get; set; }
/// <summary>
///  set all channel's x spread (from -1 to 15) (default -1)
/// </summary>
public float allx { get; set; }
/// <summary>
///  set all channel's y spread (from -1 to 15) (default -1)
/// </summary>
public float ally { get; set; }
/// <summary>
///  set front center channel x spread (from 0 to 15) (default 1)
/// </summary>
public float fcx { get; set; }
/// <summary>
///  set front left channel x spread (from 0 to 15) (default 1)
/// </summary>
public float flx { get; set; }
/// <summary>
///  set front right channel x spread (from 0 to 15) (default 1)
/// </summary>
public float frx { get; set; }
/// <summary>
///  set back left channel x spread (from 0 to 15) (default 1)
/// </summary>
public float blx { get; set; }
/// <summary>
///  set back right channel x spread (from 0 to 15) (default 1)
/// </summary>
public float brx { get; set; }
/// <summary>
///  set side left channel x spread (from 0 to 15) (default 1)
/// </summary>
public float slx { get; set; }
/// <summary>
///  set side right channel x spread (from 0 to 15) (default 1)
/// </summary>
public float srx { get; set; }
/// <summary>
///  set back center channel x spread (from 0 to 15) (default 1)
/// </summary>
public float bcx { get; set; }
/// <summary>
///  set front center channel y spread (from 0 to 15) (default 1)
/// </summary>
public float fcy { get; set; }
/// <summary>
///  set front left channel y spread (from 0 to 15) (default 1)
/// </summary>
public float fly { get; set; }
/// <summary>
///  set front right channel y spread (from 0 to 15) (default 1)
/// </summary>
public float fry { get; set; }
/// <summary>
///  set back left channel y spread (from 0 to 15) (default 1)
/// </summary>
public float bly { get; set; }
/// <summary>
///  set back right channel y spread (from 0 to 15) (default 1)
/// </summary>
public float bry { get; set; }
/// <summary>
///  set side left channel y spread (from 0 to 15) (default 1)
/// </summary>
public float sly { get; set; }
/// <summary>
///  set side right channel y spread (from 0 to 15) (default 1)
/// </summary>
public float sry { get; set; }
/// <summary>
///  set back center channel y spread (from 0 to 15) (default 1)
/// </summary>
public float bcy { get; set; }
/// <summary>
///  set window size (from 1024 to 65536) (default 4096)
/// </summary>
public int win_size { get; set; }
/// <summary>
///  set window function (from 0 to 19) (default hann)
/// </summary>
public SurroundFilterGenWin_func win_func { get; set; }
/// <summary>
///  set window overlap (from 0 to 1) (default 0.5)
/// </summary>
public float overlap { get; set; }
}
public enum SurroundFilterGenLfe_mode
{
[Name("add")] add,
[Name("sub")] sub,
}

public enum SurroundFilterGenWin_func
{
[Name("rect")] rect,
[Name("bartlett")] bartlett,
[Name("hann")] hann,
[Name("hanning")] hanning,
[Name("hamming")] hamming,
[Name("blackman")] blackman,
[Name("welch")] welch,
[Name("flattop")] flattop,
[Name("bharris")] bharris,
[Name("bnuttall")] bnuttall,
[Name("bhann")] bhann,
[Name("sine")] sine,
[Name("nuttall")] nuttall,
[Name("lanczos")] lanczos,
[Name("gauss")] gauss,
[Name("tukey")] tukey,
[Name("dolph")] dolph,
[Name("cauchy")] cauchy,
[Name("parzen")] parzen,
[Name("poisson")] poisson,
[Name("bohman")] bohman,
}

}
