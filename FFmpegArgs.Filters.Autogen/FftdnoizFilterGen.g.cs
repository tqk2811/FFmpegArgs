namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC fftdnoiz          V->V       Denoise frames using 3D FFT.
/// </summary>
public class FftdnoizFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal FftdnoizFilterGen(ImageMap input) : base("fftdnoiz",input) { AddMapOut(); }
/// <summary>
///  set denoise strength (from 0 to 30) (default 1)
/// </summary>
public FftdnoizFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma,0,30);
/// <summary>
///  set amount of denoising (from 0.01 to 1) (default 1)
/// </summary>
public FftdnoizFilterGen amount(float amount) => this.SetOptionRange("amount", amount,0.01,1);
/// <summary>
///  set block log2(size) (from 3 to 6) (default 4)
/// </summary>
public FftdnoizFilterGen block(int block) => this.SetOptionRange("block", block,3,6);
/// <summary>
///  set block overlap (from 0.2 to 0.8) (default 0.5)
/// </summary>
public FftdnoizFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap,0.2,0.8);
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
}
/// <summary>
/// </summary>
public static class FftdnoizFilterGenExtensions
{
/// <summary>
/// Denoise frames using 3D FFT.
/// </summary>
public static FftdnoizFilterGen FftdnoizFilterGen(this ImageMap input0) => new FftdnoizFilterGen(input0);
}
}
