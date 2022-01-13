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
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public HilbertFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
/// <summary>
///  set window function (from 0 to 19) (default blackman)
/// </summary>
public HilbertFilterGen win_func(HilbertFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
}
public static class HilbertFilterGenExtensions
{
/// <summary>
/// Generate a Hilbert transform FIR coefficients.
/// </summary>
public static HilbertFilterGen HilbertFilterGen(this FilterGraph input0) => new HilbertFilterGen(input0);
/// <summary>
/// Generate a Hilbert transform FIR coefficients.
/// </summary>
public static HilbertFilterGen HilbertFilterGen(this FilterGraph input0,HilbertFilterGenConfig config)
{
var result = new HilbertFilterGen(input0);
if(config?.sample_rate != null) result.sample_rate(config.sample_rate.Value);
if(config?.r != null) result.r(config.r.Value);
if(config?.taps != null) result.taps(config.taps.Value);
if(config?.nb_samples != null) result.nb_samples(config.nb_samples.Value);
if(config?.win_func != null) result.win_func(config.win_func.Value);
return result;
}
}
public class HilbertFilterGenConfig
{
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int? sample_rate { get; set; }
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int? r { get; set; }
/// <summary>
///  set number of taps (from 11 to 65535) (default 22051)
/// </summary>
public int? taps { get; set; }
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public int? nb_samples { get; set; }
/// <summary>
///  set window function (from 0 to 19) (default blackman)
/// </summary>
public HilbertFilterGenWin_func? win_func { get; set; }
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

}
