namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC fftdnoiz          V->V       Denoise frames using 3D FFT.
/// </summary>
public class FftdnoizFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal FftdnoizFilterGen(ImageMap input) : base("fftdnoiz",input) { AddMapOut(); }
/// <summary>
///  set denoise strength (from 0 to 100) (default 1)
/// </summary>
public FftdnoizFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma,0,100);
/// <summary>
///  set amount of denoising (from 0.01 to 1) (default 1)
/// </summary>
public FftdnoizFilterGen amount(float amount) => this.SetOptionRange("amount", amount,0.01,1);
/// <summary>
///  set block size (from 8 to 256) (default 32)
/// </summary>
public FftdnoizFilterGen block(int block) => this.SetOptionRange("block", block,8,256);
/// <summary>
///  set block overlap (from 0.2 to 0.8) (default 0.5)
/// </summary>
public FftdnoizFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap,0.2,0.8);
/// <summary>
///  set method of denoising (from 0 to 1) (default wiener)
/// </summary>
public FftdnoizFilterGen method(FftdnoizFilterGenMethod method) => this.SetOption("method", method.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set number of previous frames for temporal denoising (from 0 to 1) (default 0)
/// </summary>
public FftdnoizFilterGen prev(int prev) => this.SetOptionRange("prev", prev,0,1);
/// <summary>
///  set number of next frames for temporal denoising (from 0 to 1) (default 0)
/// </summary>
public FftdnoizFilterGen next(int next) => this.SetOptionRange("next", next,0,1);
/// <summary>
///  set planes to filter (from 0 to 15) (default 7)
/// </summary>
public FftdnoizFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public FftdnoizFilterGen window(FftdnoizFilterGenWindow window) => this.SetOption("window", window.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Denoise frames using 3D FFT.
/// </summary>
public static FftdnoizFilterGen FftdnoizFilterGen(this ImageMap input0) => new FftdnoizFilterGen(input0);
}
/// <summary>
///  set method of denoising (from 0 to 1) (default wiener)
/// </summary>
public enum FftdnoizFilterGenMethod
{
/// <summary>
/// wiener          0            ..FV.....T. wiener method
/// </summary>
[Name("wiener")] wiener,
/// <summary>
/// hard            1            ..FV.....T. hard thresholding
/// </summary>
[Name("hard")] hard,
}

/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public enum FftdnoizFilterGenWindow
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
