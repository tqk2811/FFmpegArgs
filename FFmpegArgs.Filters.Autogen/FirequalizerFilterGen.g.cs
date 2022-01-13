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
public FirequalizerFilterGen wfunc(FirequalizerFilterGenWfunc wfunc) => this.SetOption("wfunc", wfunc.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set fixed frame samples (default false)
/// </summary>
public FirequalizerFilterGen _fixed(bool _fixed) => this.SetOption("fixed",_fixed.ToFFmpegFlag());
/// <summary>
///  set multi channels mode (default false)
/// </summary>
public FirequalizerFilterGen multi(bool multi) => this.SetOption("multi",multi.ToFFmpegFlag());
/// <summary>
///  set zero phase mode (default false)
/// </summary>
public FirequalizerFilterGen zero_phase(bool zero_phase) => this.SetOption("zero_phase",zero_phase.ToFFmpegFlag());
/// <summary>
///  set gain scale (from 0 to 3) (default linlog)
/// </summary>
public FirequalizerFilterGen scale(FirequalizerFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set dump file
/// </summary>
public FirequalizerFilterGen dumpfile(string dumpfile) => this.SetOption("dumpfile",dumpfile);
/// <summary>
///  set dump scale (from 0 to 3) (default linlog)
/// </summary>
public FirequalizerFilterGen dumpscale(FirequalizerFilterGenDumpscale dumpscale) => this.SetOption("dumpscale", dumpscale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set 2-channels fft (default false)
/// </summary>
public FirequalizerFilterGen fft2(bool fft2) => this.SetOption("fft2",fft2.ToFFmpegFlag());
/// <summary>
///  set minimum phase mode (default false)
/// </summary>
public FirequalizerFilterGen min_phase(bool min_phase) => this.SetOption("min_phase",min_phase.ToFFmpegFlag());
}
public static class FirequalizerFilterGenExtensions
{
/// <summary>
/// Finite Impulse Response Equalizer.
/// </summary>
public static FirequalizerFilterGen FirequalizerFilterGen(this AudioMap input0) => new FirequalizerFilterGen(input0);
/// <summary>
/// Finite Impulse Response Equalizer.
/// </summary>
public static FirequalizerFilterGen FirequalizerFilterGen(this AudioMap input0,FirequalizerFilterGenConfig config)
{
var result = new FirequalizerFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.gain)) result.gain(config.gain);
if(!string.IsNullOrWhiteSpace(config?.gain_entry)) result.gain_entry(config.gain_entry);
if(config?.delay != null) result.delay(config.delay.Value);
if(config?.accuracy != null) result.accuracy(config.accuracy.Value);
if(config?.wfunc != null) result.wfunc(config.wfunc.Value);
if(config?._fixed != null) result._fixed(config._fixed.Value);
if(config?.multi != null) result.multi(config.multi.Value);
if(config?.zero_phase != null) result.zero_phase(config.zero_phase.Value);
if(config?.scale != null) result.scale(config.scale.Value);
if(!string.IsNullOrWhiteSpace(config?.dumpfile)) result.dumpfile(config.dumpfile);
if(config?.dumpscale != null) result.dumpscale(config.dumpscale.Value);
if(config?.fft2 != null) result.fft2(config.fft2.Value);
if(config?.min_phase != null) result.min_phase(config.min_phase.Value);
return result;
}
}
public class FirequalizerFilterGenConfig
{
/// <summary>
///  set gain curve (default "gain_interpolate(f)")
/// </summary>
public string gain { get; set; }
/// <summary>
///  set gain entry
/// </summary>
public string gain_entry { get; set; }
/// <summary>
///  set delay (from 0 to 1e+10) (default 0.01)
/// </summary>
public double? delay { get; set; }
/// <summary>
///  set accuracy (from 0 to 1e+10) (default 5)
/// </summary>
public double? accuracy { get; set; }
/// <summary>
///  set window function (from 0 to 9) (default hann)
/// </summary>
public FirequalizerFilterGenWfunc? wfunc { get; set; }
/// <summary>
///  set fixed frame samples (default false)
/// </summary>
public bool? _fixed { get; set; }
/// <summary>
///  set multi channels mode (default false)
/// </summary>
public bool? multi { get; set; }
/// <summary>
///  set zero phase mode (default false)
/// </summary>
public bool? zero_phase { get; set; }
/// <summary>
///  set gain scale (from 0 to 3) (default linlog)
/// </summary>
public FirequalizerFilterGenScale? scale { get; set; }
/// <summary>
///  set dump file
/// </summary>
public string dumpfile { get; set; }
/// <summary>
///  set dump scale (from 0 to 3) (default linlog)
/// </summary>
public FirequalizerFilterGenDumpscale? dumpscale { get; set; }
/// <summary>
///  set 2-channels fft (default false)
/// </summary>
public bool? fft2 { get; set; }
/// <summary>
///  set minimum phase mode (default false)
/// </summary>
public bool? min_phase { get; set; }
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
