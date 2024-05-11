namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. showspatial       A->V       Convert input audio to a spatial video output.
/// </summary>
public class ShowspatialFilterGen : AudioToImageFilter,ISliceThreading
{
internal ShowspatialFilterGen(AudioMap input) : base("showspatial",input) { AddMapOut(); }
/// <summary>
///  set video size (default "512x512")
/// </summary>
public ShowspatialFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set window size (from 1024 to 65536) (default 4096)
/// </summary>
public ShowspatialFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size,1024,65536);
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public ShowspatialFilterGen win_func(ShowspatialFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set video rate (default "25")
/// </summary>
public ShowspatialFilterGen rate(Rational rate) => this.SetOption("rate",rate);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to a spatial video output.
/// </summary>
public static ShowspatialFilterGen ShowspatialFilterGen(this AudioMap input0) => new ShowspatialFilterGen(input0);
}
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public enum ShowspatialFilterGenWin_func
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

}
