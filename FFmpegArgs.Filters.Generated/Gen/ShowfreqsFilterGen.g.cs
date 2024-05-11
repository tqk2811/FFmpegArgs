namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... showfreqs         A->V       Convert input audio to a frequencies video output.
/// </summary>
public class ShowfreqsFilterGen : AudioToImageFilter
{
internal ShowfreqsFilterGen(AudioMap input) : base("showfreqs",input) { AddMapOut(); }
/// <summary>
///  set video size (default "1024x512")
/// </summary>
public ShowfreqsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public ShowfreqsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set display mode (from 0 to 2) (default bar)
/// </summary>
public ShowfreqsFilterGen mode(ShowfreqsFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set amplitude scale (from 0 to 3) (default log)
/// </summary>
public ShowfreqsFilterGen ascale(ShowfreqsFilterGenAscale ascale) => this.SetOption("ascale", ascale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set frequency scale (from 0 to 2) (default lin)
/// </summary>
public ShowfreqsFilterGen fscale(ShowfreqsFilterGenFscale fscale) => this.SetOption("fscale", fscale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set window size (from 16 to 65536) (default 2048)
/// </summary>
public ShowfreqsFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size,16,65536);
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public ShowfreqsFilterGen win_func(ShowfreqsFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set window overlap (from 0 to 1) (default 1)
/// </summary>
public ShowfreqsFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap,0,1);
/// <summary>
///  set time averaging (from 0 to INT_MAX) (default 1)
/// </summary>
public ShowfreqsFilterGen averaging(int averaging) => this.SetOptionRange("averaging", averaging,0,INT_MAX);
/// <summary>
///  set channels colors (default "red|green|blue|yellow|orange|lime|pink|magenta|brown")
/// </summary>
public ShowfreqsFilterGen colors(string colors) => this.SetOption("colors",colors);
/// <summary>
///  set channel mode (from 0 to 1) (default combined)
/// </summary>
public ShowfreqsFilterGen cmode(ShowfreqsFilterGenCmode cmode) => this.SetOption("cmode", cmode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set minimum amplitude (from FLT_MIN to 1e-06) (default 1e-06)
/// </summary>
public ShowfreqsFilterGen minamp(float minamp) => this.SetOptionRange("minamp", minamp,FLT_MIN,1e-06);
/// <summary>
///  set data mode (from 0 to 2) (default magnitude)
/// </summary>
public ShowfreqsFilterGen data(ShowfreqsFilterGenData data) => this.SetOption("data", data.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to draw (default "all")
/// </summary>
public ShowfreqsFilterGen channels(string channels) => this.SetOption("channels",channels);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to a frequencies video output.
/// </summary>
public static ShowfreqsFilterGen ShowfreqsFilterGen(this AudioMap input0) => new ShowfreqsFilterGen(input0);
}
/// <summary>
///  set display mode (from 0 to 2) (default bar)
/// </summary>
public enum ShowfreqsFilterGenMode
{
/// <summary>
/// line            0            ..FV....... show lines
/// </summary>
[Name("line")] line,
/// <summary>
/// bar             1            ..FV....... show bars
/// </summary>
[Name("bar")] bar,
/// <summary>
/// dot             2            ..FV....... show dots
/// </summary>
[Name("dot")] dot,
}

/// <summary>
///  set amplitude scale (from 0 to 3) (default log)
/// </summary>
public enum ShowfreqsFilterGenAscale
{
/// <summary>
/// lin             0            ..FV....... linear
/// </summary>
[Name("lin")] lin,
/// <summary>
/// sqrt            1            ..FV....... square root
/// </summary>
[Name("sqrt")] sqrt,
/// <summary>
/// cbrt            2            ..FV....... cubic root
/// </summary>
[Name("cbrt")] cbrt,
/// <summary>
/// log             3            ..FV....... logarithmic
/// </summary>
[Name("log")] log,
}

/// <summary>
///  set frequency scale (from 0 to 2) (default lin)
/// </summary>
public enum ShowfreqsFilterGenFscale
{
/// <summary>
/// lin             0            ..FV....... linear
/// </summary>
[Name("lin")] lin,
/// <summary>
/// log             1            ..FV....... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// rlog            2            ..FV....... reverse logarithmic
/// </summary>
[Name("rlog")] rlog,
}

/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public enum ShowfreqsFilterGenWin_func
{
/// <summary>
/// rect            0            ..FV....... Rectangular
/// </summary>
[Name("rect")] rect,
/// <summary>
/// bartlett        4            ..FV....... Bartlett
/// </summary>
[Name("bartlett")] bartlett,
/// <summary>
/// hann            1            ..FV....... Hann
/// </summary>
[Name("hann")] hann,
/// <summary>
/// hanning         1            ..FV....... Hanning
/// </summary>
[Name("hanning")] hanning,
/// <summary>
/// hamming         2            ..FV....... Hamming
/// </summary>
[Name("hamming")] hamming,
/// <summary>
/// blackman        3            ..FV....... Blackman
/// </summary>
[Name("blackman")] blackman,
/// <summary>
/// welch           5            ..FV....... Welch
/// </summary>
[Name("welch")] welch,
/// <summary>
/// flattop         6            ..FV....... Flat-top
/// </summary>
[Name("flattop")] flattop,
/// <summary>
/// bharris         7            ..FV....... Blackman-Harris
/// </summary>
[Name("bharris")] bharris,
/// <summary>
/// bnuttall        8            ..FV....... Blackman-Nuttall
/// </summary>
[Name("bnuttall")] bnuttall,
/// <summary>
/// bhann           11           ..FV....... Bartlett-Hann
/// </summary>
[Name("bhann")] bhann,
/// <summary>
/// sine            9            ..FV....... Sine
/// </summary>
[Name("sine")] sine,
/// <summary>
/// nuttall         10           ..FV....... Nuttall
/// </summary>
[Name("nuttall")] nuttall,
/// <summary>
/// lanczos         12           ..FV....... Lanczos
/// </summary>
[Name("lanczos")] lanczos,
/// <summary>
/// gauss           13           ..FV....... Gauss
/// </summary>
[Name("gauss")] gauss,
/// <summary>
/// tukey           14           ..FV....... Tukey
/// </summary>
[Name("tukey")] tukey,
/// <summary>
/// dolph           15           ..FV....... Dolph-Chebyshev
/// </summary>
[Name("dolph")] dolph,
/// <summary>
/// cauchy          16           ..FV....... Cauchy
/// </summary>
[Name("cauchy")] cauchy,
/// <summary>
/// parzen          17           ..FV....... Parzen
/// </summary>
[Name("parzen")] parzen,
/// <summary>
/// poisson         18           ..FV....... Poisson
/// </summary>
[Name("poisson")] poisson,
/// <summary>
/// bohman          19           ..FV....... Bohman
/// </summary>
[Name("bohman")] bohman,
/// <summary>
/// kaiser          20           ..FV....... Kaiser
/// </summary>
[Name("kaiser")] kaiser,
}

/// <summary>
///  set channel mode (from 0 to 1) (default combined)
/// </summary>
public enum ShowfreqsFilterGenCmode
{
/// <summary>
/// combined        0            ..FV....... show all channels in same window
/// </summary>
[Name("combined")] combined,
/// <summary>
/// separate        1            ..FV....... show each channel in own window
/// </summary>
[Name("separate")] separate,
}

/// <summary>
///  set data mode (from 0 to 2) (default magnitude)
/// </summary>
public enum ShowfreqsFilterGenData
{
/// <summary>
/// magnitude       0            ..FV....... show magnitude
/// </summary>
[Name("magnitude")] magnitude,
/// <summary>
/// phase           1            ..FV....... show phase
/// </summary>
[Name("phase")] phase,
/// <summary>
/// delay           2            ..FV....... show group delay
/// </summary>
[Name("delay")] delay,
}

}
