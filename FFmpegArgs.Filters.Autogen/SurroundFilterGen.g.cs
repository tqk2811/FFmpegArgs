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
public SurroundFilterGen lfe(bool flag) => this.SetOption("lfe",flag.ToFFmpegFlag());
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
