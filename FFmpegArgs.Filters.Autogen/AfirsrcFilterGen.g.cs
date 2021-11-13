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
public class AfirsrcFilterGen : SourceAudioFilter
{
internal AfirsrcFilterGen(FilterGraph input) : base("afirsrc",input) { AddMapOut(); }
/// <summary>
///  set number of taps (from 9 to 65535) (default 1025)
/// </summary>
public AfirsrcFilterGen taps(int taps) => this.SetOptionRange("taps", taps,9,65535);
/// <summary>
///  set number of taps (from 9 to 65535) (default 1025)
/// </summary>
public AfirsrcFilterGen t(int t) => this.SetOptionRange("t", t,9,65535);
/// <summary>
///  set frequency points (default "0 1")
/// </summary>
public AfirsrcFilterGen frequency(string frequency) => this.SetOption("frequency",frequency);
/// <summary>
///  set frequency points (default "0 1")
/// </summary>
public AfirsrcFilterGen f(string f) => this.SetOption("f",f);
/// <summary>
///  set magnitude values (default "1 1")
/// </summary>
public AfirsrcFilterGen magnitude(string magnitude) => this.SetOption("magnitude",magnitude);
/// <summary>
///  set magnitude values (default "1 1")
/// </summary>
public AfirsrcFilterGen m(string m) => this.SetOption("m",m);
/// <summary>
///  set phase values (default "0 0")
/// </summary>
public AfirsrcFilterGen phase(string phase) => this.SetOption("phase",phase);
/// <summary>
///  set phase values (default "0 0")
/// </summary>
public AfirsrcFilterGen p(string p) => this.SetOption("p",p);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AfirsrcFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AfirsrcFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public AfirsrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public AfirsrcFilterGen n(int n) => this.SetOptionRange("n", n,1,INT_MAX);
/// <summary>
///  set window function (from 0 to 19) (default blackman)
/// </summary>
public AfirsrcFilterGen win_func(AfirsrcFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set window function (from 0 to 19) (default blackman)
/// </summary>
public AfirsrcFilterGen w(AfirsrcFilterGenW w) => this.SetOption("w", w.GetAttribute<NameAttribute>().Name);
}
public static class AfirsrcFilterGenExtensions
{
/// <summary>
/// Generate a FIR coefficients audio stream.
/// </summary>
public static AfirsrcFilterGen AfirsrcFilterGen(this FilterGraph input0) => new AfirsrcFilterGen(input0);
}
public enum AfirsrcFilterGenWin_func
{
[Name("rect")] rect,
[Name("bartlett")] bartlett,
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

public enum AfirsrcFilterGenW
{
[Name("rect")] rect,
[Name("bartlett")] bartlett,
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
