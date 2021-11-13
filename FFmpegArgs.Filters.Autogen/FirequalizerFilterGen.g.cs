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
public class FirequalizerFilterGen : AudioToAudioFilter,ICommandSupport
{
internal FirequalizerFilterGen(AudioMap input) : base("firequalizer",input) { AddMapOut(); }
/// <summary>
///  set gain curve (default "gain_interpolate(f)")
/// </summary>
public FirequalizerFilterGen gain(string gain) => this.SetOption("gain",gain);
/// <summary>
///  set gain entry
/// </summary>
public FirequalizerFilterGen gain_entry(string gain_entry) => this.SetOption("gain_entry",gain_entry);
/// <summary>
///  set delay (from 0 to 1e+10) (default 0.01)
/// </summary>
public FirequalizerFilterGen delay(double delay) => this.SetOptionRange("delay", delay,0,1e+10);
/// <summary>
///  set accuracy (from 0 to 1e+10) (default 5)
/// </summary>
public FirequalizerFilterGen accuracy(double accuracy) => this.SetOptionRange("accuracy", accuracy,0,1e+10);
/// <summary>
///  set window function (from 0 to 9) (default hann)
/// </summary>
public FirequalizerFilterGen wfunc(FirequalizerFilterGenWfunc wfunc) => this.SetOption("wfunc", wfunc.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set fixed frame samples (default false)
/// </summary>
public FirequalizerFilterGen _fixed(bool flag) => this.SetOption("fixed",flag.ToFFmpegFlag());
/// <summary>
///  set multi channels mode (default false)
/// </summary>
public FirequalizerFilterGen multi(bool flag) => this.SetOption("multi",flag.ToFFmpegFlag());
/// <summary>
///  set zero phase mode (default false)
/// </summary>
public FirequalizerFilterGen zero_phase(bool flag) => this.SetOption("zero_phase",flag.ToFFmpegFlag());
/// <summary>
///  set gain scale (from 0 to 3) (default linlog)
/// </summary>
public FirequalizerFilterGen scale(FirequalizerFilterGenScale scale) => this.SetOption("scale", scale.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set dump file
/// </summary>
public FirequalizerFilterGen dumpfile(string dumpfile) => this.SetOption("dumpfile",dumpfile);
/// <summary>
///  set dump scale (from 0 to 3) (default linlog)
/// </summary>
public FirequalizerFilterGen dumpscale(FirequalizerFilterGenDumpscale dumpscale) => this.SetOption("dumpscale", dumpscale.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set 2-channels fft (default false)
/// </summary>
public FirequalizerFilterGen fft2(bool flag) => this.SetOption("fft2",flag.ToFFmpegFlag());
/// <summary>
///  set minimum phase mode (default false)
/// </summary>
public FirequalizerFilterGen min_phase(bool flag) => this.SetOption("min_phase",flag.ToFFmpegFlag());
}
public static class FirequalizerFilterGenExtensions
{
/// <summary>
/// Finite Impulse Response Equalizer.
/// </summary>
public static FirequalizerFilterGen FirequalizerFilterGen(this AudioMap input0) => new FirequalizerFilterGen(input0);
}
public enum FirequalizerFilterGenWfunc
{
[Name("rectangular")] rectangular,
[Name("hann")] hann,
[Name("hamming")] hamming,
[Name("blackman")] blackman,
[Name("nuttall3")] nuttall3,
[Name("mnuttall3")] mnuttall3,
[Name("nuttall")] nuttall,
[Name("bnuttall")] bnuttall,
[Name("bharris")] bharris,
[Name("tukey")] tukey,
}

public enum FirequalizerFilterGenScale
{
[Name("linlin")] linlin,
[Name("linlog")] linlog,
[Name("loglin")] loglin,
[Name("loglog")] loglog,
}

public enum FirequalizerFilterGenDumpscale
{
[Name("linlin")] linlin,
[Name("linlog")] linlog,
[Name("loglin")] loglin,
[Name("loglog")] loglog,
}

}
