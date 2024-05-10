namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C firequalizer      A->A       Finite Impulse Response Equalizer.
/// </summary>
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
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Finite Impulse Response Equalizer.
/// </summary>
public static FirequalizerFilterGen FirequalizerFilterGen(this AudioMap input0) => new FirequalizerFilterGen(input0);
}
/// <summary>
///  set window function (from 0 to 9) (default hann)
/// </summary>
public enum FirequalizerFilterGenWfunc
{
/// <summary>
/// rectangular     0            ..F.A...... rectangular window
/// </summary>
[Name("rectangular")] rectangular,
/// <summary>
/// hann            1            ..F.A...... hann window
/// </summary>
[Name("hann")] hann,
/// <summary>
/// hamming         2            ..F.A...... hamming window
/// </summary>
[Name("hamming")] hamming,
/// <summary>
/// blackman        3            ..F.A...... blackman window
/// </summary>
[Name("blackman")] blackman,
/// <summary>
/// nuttall3        4            ..F.A...... 3-term nuttall window
/// </summary>
[Name("nuttall3")] nuttall3,
/// <summary>
/// mnuttall3       5            ..F.A...... minimum 3-term nuttall window
/// </summary>
[Name("mnuttall3")] mnuttall3,
/// <summary>
/// nuttall         6            ..F.A...... nuttall window
/// </summary>
[Name("nuttall")] nuttall,
/// <summary>
/// bnuttall        7            ..F.A...... blackman-nuttall window
/// </summary>
[Name("bnuttall")] bnuttall,
/// <summary>
/// bharris         8            ..F.A...... blackman-harris window
/// </summary>
[Name("bharris")] bharris,
/// <summary>
/// tukey           9            ..F.A...... tukey window
/// </summary>
[Name("tukey")] tukey,
}

/// <summary>
///  set gain scale (from 0 to 3) (default linlog)
/// </summary>
public enum FirequalizerFilterGenScale
{
/// <summary>
/// linlin          0            ..F.A...... linear-freq linear-gain
/// </summary>
[Name("linlin")] linlin,
/// <summary>
/// linlog          1            ..F.A...... linear-freq logarithmic-gain
/// </summary>
[Name("linlog")] linlog,
/// <summary>
/// loglin          2            ..F.A...... logarithmic-freq linear-gain
/// </summary>
[Name("loglin")] loglin,
/// <summary>
/// loglog          3            ..F.A...... logarithmic-freq logarithmic-gain
/// </summary>
[Name("loglog")] loglog,
}

/// <summary>
///  set dump scale (from 0 to 3) (default linlog)
/// </summary>
public enum FirequalizerFilterGenDumpscale
{
/// <summary>
/// linlin          0            ..F.A...... linear-freq linear-gain
/// </summary>
[Name("linlin")] linlin,
/// <summary>
/// linlog          1            ..F.A...... linear-freq logarithmic-gain
/// </summary>
[Name("linlog")] linlog,
/// <summary>
/// loglin          2            ..F.A...... logarithmic-freq linear-gain
/// </summary>
[Name("loglin")] loglin,
/// <summary>
/// loglog          3            ..F.A...... logarithmic-freq logarithmic-gain
/// </summary>
[Name("loglog")] loglog,
}

}
