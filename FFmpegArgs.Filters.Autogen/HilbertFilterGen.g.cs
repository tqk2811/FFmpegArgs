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
public class HilbertFilterGen : SourceAudioFilter
{
internal HilbertFilterGen(FilterGraph input) : base("hilbert",input) { AddMapOut(); }
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public HilbertFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public HilbertFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
/// <summary>
///  set number of taps (from 11 to 65535) (default 22051)
/// </summary>
public HilbertFilterGen taps(int taps) => this.SetOptionRange("taps", taps,11,65535);
/// <summary>
///  set number of taps (from 11 to 65535) (default 22051)
/// </summary>
public HilbertFilterGen t(int t) => this.SetOptionRange("t", t,11,65535);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public HilbertFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public HilbertFilterGen n(int n) => this.SetOptionRange("n", n,1,INT_MAX);
/// <summary>
///  set window function (from 0 to 19) (default blackman)
/// </summary>
public HilbertFilterGen win_func(HilbertFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set window function (from 0 to 19) (default blackman)
/// </summary>
public HilbertFilterGen w(HilbertFilterGenW w) => this.SetOption("w", w.GetAttribute<NameAttribute>().Name);
}
public static class HilbertFilterGenExtensions
{
/// <summary>
/// Generate a Hilbert transform FIR coefficients.
/// </summary>
public static HilbertFilterGen HilbertFilterGen(this FilterGraph input) => new HilbertFilterGen(input);
}
public enum HilbertFilterGenWin_func
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

public enum HilbertFilterGenW
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
