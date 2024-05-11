namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. afftfilt          A-&gt;A       Apply arbitrary expressions to samples in frequency domain.
/// </summary>
public class AfftfiltFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading
{
internal AfftfiltFilterGen(AudioMap input) : base("afftfilt",input) { AddMapOut(); }
/// <summary>
///  set channels real expressions (default &quot;re&quot;)
/// </summary>
public AfftfiltFilterGen real(ExpressionValue real) => this.SetOption("real",(string)real);
/// <summary>
///  set channels imaginary expressions (default &quot;im&quot;)
/// </summary>
public AfftfiltFilterGen imag(ExpressionValue imag) => this.SetOption("imag",(string)imag);
/// <summary>
///  set window size (from 16 to 131072) (default 4096)
/// </summary>
public AfftfiltFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size,16,131072);
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public AfftfiltFilterGen win_func(AfftfiltFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set window overlap (from 0 to 1) (default 0.75)
/// </summary>
public AfftfiltFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply arbitrary expressions to samples in frequency domain.
/// </summary>
public static AfftfiltFilterGen AfftfiltFilterGen(this AudioMap input0) => new AfftfiltFilterGen(input0);
}
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public enum AfftfiltFilterGenWin_func
{
/// <summary>
/// rect            0            ..F.A...... Rectangular
/// </summary>
[Name("rect")] rect,
/// <summary>
/// bartlett        4            ..F.A...... Bartlett
/// </summary>
[Name("bartlett")] bartlett,
/// <summary>
/// hann            1            ..F.A...... Hann
/// </summary>
[Name("hann")] hann,
/// <summary>
/// hanning         1            ..F.A...... Hanning
/// </summary>
[Name("hanning")] hanning,
/// <summary>
/// hamming         2            ..F.A...... Hamming
/// </summary>
[Name("hamming")] hamming,
/// <summary>
/// blackman        3            ..F.A...... Blackman
/// </summary>
[Name("blackman")] blackman,
/// <summary>
/// welch           5            ..F.A...... Welch
/// </summary>
[Name("welch")] welch,
/// <summary>
/// flattop         6            ..F.A...... Flat-top
/// </summary>
[Name("flattop")] flattop,
/// <summary>
/// bharris         7            ..F.A...... Blackman-Harris
/// </summary>
[Name("bharris")] bharris,
/// <summary>
/// bnuttall        8            ..F.A...... Blackman-Nuttall
/// </summary>
[Name("bnuttall")] bnuttall,
/// <summary>
/// bhann           11           ..F.A...... Bartlett-Hann
/// </summary>
[Name("bhann")] bhann,
/// <summary>
/// sine            9            ..F.A...... Sine
/// </summary>
[Name("sine")] sine,
/// <summary>
/// nuttall         10           ..F.A...... Nuttall
/// </summary>
[Name("nuttall")] nuttall,
/// <summary>
/// lanczos         12           ..F.A...... Lanczos
/// </summary>
[Name("lanczos")] lanczos,
/// <summary>
/// gauss           13           ..F.A...... Gauss
/// </summary>
[Name("gauss")] gauss,
/// <summary>
/// tukey           14           ..F.A...... Tukey
/// </summary>
[Name("tukey")] tukey,
/// <summary>
/// dolph           15           ..F.A...... Dolph-Chebyshev
/// </summary>
[Name("dolph")] dolph,
/// <summary>
/// cauchy          16           ..F.A...... Cauchy
/// </summary>
[Name("cauchy")] cauchy,
/// <summary>
/// parzen          17           ..F.A...... Parzen
/// </summary>
[Name("parzen")] parzen,
/// <summary>
/// poisson         18           ..F.A...... Poisson
/// </summary>
[Name("poisson")] poisson,
/// <summary>
/// bohman          19           ..F.A...... Bohman
/// </summary>
[Name("bohman")] bohman,
/// <summary>
/// kaiser          20           ..F.A...... Kaiser
/// </summary>
[Name("kaiser")] kaiser,
}

}
