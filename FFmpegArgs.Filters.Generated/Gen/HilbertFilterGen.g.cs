namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... hilbert           |->A       Generate a Hilbert transform FIR coefficients.
/// </summary>
public class HilbertFilterGen : SourceAudioFilter
{
internal HilbertFilterGen(IAudioFilterGraph input) : base("hilbert",input) { AddMapOut(); }
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
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public HilbertFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
/// <summary>
///  set window function (from 0 to 20) (default blackman)
/// </summary>
public HilbertFilterGen win_func(HilbertFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Generate a Hilbert transform FIR coefficients.
/// </summary>
public static HilbertFilterGen HilbertFilterGen(this IAudioFilterGraph input0) => new HilbertFilterGen(input0);
}
/// <summary>
///  set window function (from 0 to 20) (default blackman)
/// </summary>
public enum HilbertFilterGenWin_func
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
