namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. nlmeans           V->V       Non-local means denoiser.
/// </summary>
public class NlmeansFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal NlmeansFilterGen(ImageMap input) : base("nlmeans",input) { AddMapOut(); }
/// <summary>
///  denoising strength (from 1 to 30) (default 1)
/// </summary>
public NlmeansFilterGen s(double s) => this.SetOptionRange("s", s,1,30);
/// <summary>
///  patch size (from 0 to 99) (default 7)
/// </summary>
public NlmeansFilterGen p(int p) => this.SetOptionRange("p", p,0,99);
/// <summary>
///  patch size for chroma planes (from 0 to 99) (default 0)
/// </summary>
public NlmeansFilterGen pc(int pc) => this.SetOptionRange("pc", pc,0,99);
/// <summary>
///  research window (from 0 to 99) (default 15)
/// </summary>
public NlmeansFilterGen r(int r) => this.SetOptionRange("r", r,0,99);
/// <summary>
///  research window for chroma planes (from 0 to 99) (default 0)
/// </summary>
public NlmeansFilterGen rc(int rc) => this.SetOptionRange("rc", rc,0,99);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Non-local means denoiser.
/// </summary>
public static NlmeansFilterGen NlmeansFilterGen(this ImageMap input0) => new NlmeansFilterGen(input0);
}
}
