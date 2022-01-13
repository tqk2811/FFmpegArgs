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
///  set frequency points (default "0 1")
/// </summary>
public AfirsrcFilterGen frequency(string frequency) => this.SetOption("frequency",frequency);
/// <summary>
///  set magnitude values (default "1 1")
/// </summary>
public AfirsrcFilterGen magnitude(string magnitude) => this.SetOption("magnitude",magnitude);
/// <summary>
///  set phase values (default "0 0")
/// </summary>
public AfirsrcFilterGen phase(string phase) => this.SetOption("phase",phase);
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
///  set window function (from 0 to 19) (default blackman)
/// </summary>
public AfirsrcFilterGen win_func(AfirsrcFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
}
public static class AfirsrcFilterGenExtensions
{
/// <summary>
/// Generate a FIR coefficients audio stream.
/// </summary>
public static AfirsrcFilterGen AfirsrcFilterGen(this FilterGraph input0) => new AfirsrcFilterGen(input0);
/// <summary>
/// Generate a FIR coefficients audio stream.
/// </summary>
public static AfirsrcFilterGen AfirsrcFilterGen(this FilterGraph input0,AfirsrcFilterGenConfig config)
{
var result = new AfirsrcFilterGen(input0);
if(config?.taps != null) result.taps(config.taps.Value);
if(!string.IsNullOrWhiteSpace(config?.frequency)) result.frequency(config.frequency);
if(!string.IsNullOrWhiteSpace(config?.magnitude)) result.magnitude(config.magnitude);
if(!string.IsNullOrWhiteSpace(config?.phase)) result.phase(config.phase);
if(config?.sample_rate != null) result.sample_rate(config.sample_rate.Value);
if(config?.r != null) result.r(config.r.Value);
if(config?.nb_samples != null) result.nb_samples(config.nb_samples.Value);
if(config?.win_func != null) result.win_func(config.win_func.Value);
return result;
}
}
public class AfirsrcFilterGenConfig
{
/// <summary>
///  set number of taps (from 9 to 65535) (default 1025)
/// </summary>
public int? taps { get; set; }
/// <summary>
///  set frequency points (default "0 1")
/// </summary>
public string frequency { get; set; }
/// <summary>
///  set magnitude values (default "1 1")
/// </summary>
public string magnitude { get; set; }
/// <summary>
///  set phase values (default "0 0")
/// </summary>
public string phase { get; set; }
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int? sample_rate { get; set; }
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public int? r { get; set; }
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public int? nb_samples { get; set; }
/// <summary>
///  set window function (from 0 to 19) (default blackman)
/// </summary>
public AfirsrcFilterGenWin_func? win_func { get; set; }
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

}
