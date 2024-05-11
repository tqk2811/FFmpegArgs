namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... spectrumsynth     VV-&gt;A      Convert input spectrum videos to audio output.
/// </summary>
public class SpectrumsynthFilterGen : ImageToAudioFilter
{
internal SpectrumsynthFilterGen(params ImageMap[] inputs) : base("spectrumsynth",inputs) { AddMapOut(); }
/// <summary>
///  set sample rate (from 15 to INT_MAX) (default 44100)
/// </summary>
public SpectrumsynthFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,15,INT_MAX);
/// <summary>
///  set channels (from 1 to 8) (default 1)
/// </summary>
public SpectrumsynthFilterGen channels(int channels) => this.SetOptionRange("channels", channels,1,8);
/// <summary>
///  set input amplitude scale (from 0 to 1) (default log)
/// </summary>
public SpectrumsynthFilterGen scale(SpectrumsynthFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set input sliding mode (from 0 to 3) (default fullframe)
/// </summary>
public SpectrumsynthFilterGen slide(SpectrumsynthFilterGenSlide slide) => this.SetOption("slide", slide.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set window function (from 0 to 20) (default rect)
/// </summary>
public SpectrumsynthFilterGen win_func(SpectrumsynthFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set window overlap (from 0 to 1) (default 1)
/// </summary>
public SpectrumsynthFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap,0,1);
/// <summary>
///  set orientation (from 0 to 1) (default vertical)
/// </summary>
public SpectrumsynthFilterGen orientation(SpectrumsynthFilterGenOrientation orientation) => this.SetOption("orientation", orientation.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input spectrum videos to audio output.
/// </summary>
public static SpectrumsynthFilterGen SpectrumsynthFilterGen(this ImageMap input0, ImageMap input1) => new SpectrumsynthFilterGen(input0, input1);
}
/// <summary>
///  set input amplitude scale (from 0 to 1) (default log)
/// </summary>
public enum SpectrumsynthFilterGenScale
{
/// <summary>
/// lin             0            ..FV....... linear
/// </summary>
[Name("lin")] lin,
/// <summary>
/// log             1            ..FV....... logarithmic
/// </summary>
[Name("log")] log,
}

/// <summary>
///  set input sliding mode (from 0 to 3) (default fullframe)
/// </summary>
public enum SpectrumsynthFilterGenSlide
{
/// <summary>
/// replace         0            ..FV....... consume old columns with new
/// </summary>
[Name("replace")] replace,
/// <summary>
/// scroll          1            ..FV....... consume only most right column
/// </summary>
[Name("scroll")] scroll,
/// <summary>
/// fullframe       2            ..FV....... consume full frames
/// </summary>
[Name("fullframe")] fullframe,
/// <summary>
/// rscroll         3            ..FV....... consume only most left column
/// </summary>
[Name("rscroll")] rscroll,
}

/// <summary>
///  set window function (from 0 to 20) (default rect)
/// </summary>
public enum SpectrumsynthFilterGenWin_func
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
///  set orientation (from 0 to 1) (default vertical)
/// </summary>
public enum SpectrumsynthFilterGenOrientation
{
/// <summary>
/// vertical        0            ..FV.......
/// </summary>
[Name("vertical")] vertical,
/// <summary>
/// horizontal      1            ..FV.......
/// </summary>
[Name("horizontal")] horizontal,
}

}
