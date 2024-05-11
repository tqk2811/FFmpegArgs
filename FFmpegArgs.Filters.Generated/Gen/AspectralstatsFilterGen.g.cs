namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. aspectralstats    A-&gt;A       Show frequency domain statistics about audio frames.
/// </summary>
public class AspectralstatsFilterGen : AudioToAudioFilter,ISliceThreading
{
internal AspectralstatsFilterGen(AudioMap input) : base("aspectralstats",input) { AddMapOut(); }
/// <summary>
///  set the window size (from 32 to 65536) (default 2048)
/// </summary>
public AspectralstatsFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size,32,65536);
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public AspectralstatsFilterGen win_func(AspectralstatsFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set window overlap (from 0 to 1) (default 0.5)
/// </summary>
public AspectralstatsFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap,0,1);
/// <summary>
///  select the parameters which are measured (default all+mean+variance+centroid+spread+skewness+kurtosis+entropy+flatness+crest+flux+slope+decrease+rolloff)
/// </summary>
public AspectralstatsFilterGen measure(AspectralstatsFilterGenMeasure measure) => this.SetOption("measure", measure.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Show frequency domain statistics about audio frames.
/// </summary>
public static AspectralstatsFilterGen AspectralstatsFilterGen(this AudioMap input0) => new AspectralstatsFilterGen(input0);
}
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public enum AspectralstatsFilterGenWin_func
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

/// <summary>
///  select the parameters which are measured (default all+mean+variance+centroid+spread+skewness+kurtosis+entropy+flatness+crest+flux+slope+decrease+rolloff)
/// </summary>
public enum AspectralstatsFilterGenMeasure
{
/// <summary>
/// none                         ..F.A......
/// </summary>
[Name("none")] none,
/// <summary>
/// all                          ..F.A......
/// </summary>
[Name("all")] all,
/// <summary>
/// mean                         ..F.A......
/// </summary>
[Name("mean")] mean,
/// <summary>
/// variance                     ..F.A......
/// </summary>
[Name("variance")] variance,
/// <summary>
/// centroid                     ..F.A......
/// </summary>
[Name("centroid")] centroid,
/// <summary>
/// spread                       ..F.A......
/// </summary>
[Name("spread")] spread,
/// <summary>
/// skewness                     ..F.A......
/// </summary>
[Name("skewness")] skewness,
/// <summary>
/// kurtosis                     ..F.A......
/// </summary>
[Name("kurtosis")] kurtosis,
/// <summary>
/// entropy                      ..F.A......
/// </summary>
[Name("entropy")] entropy,
/// <summary>
/// flatness                     ..F.A......
/// </summary>
[Name("flatness")] flatness,
/// <summary>
/// crest                        ..F.A......
/// </summary>
[Name("crest")] crest,
/// <summary>
/// flux                         ..F.A......
/// </summary>
[Name("flux")] flux,
/// <summary>
/// slope                        ..F.A......
/// </summary>
[Name("slope")] slope,
/// <summary>
/// decrease                     ..F.A......
/// </summary>
[Name("decrease")] decrease,
/// <summary>
/// rolloff                      ..F.A......
/// </summary>
[Name("rolloff")] rolloff,
}

}
