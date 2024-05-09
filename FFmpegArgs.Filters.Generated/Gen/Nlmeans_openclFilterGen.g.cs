namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... nlmeans_opencl    V->V       Non-local means denoiser through OpenCL
/// </summary>
public class Nlmeans_openclFilterGen : ImageToImageFilter
{
internal Nlmeans_openclFilterGen(ImageMap input) : base("nlmeans_opencl",input) { AddMapOut(); }
/// <summary>
///  denoising strength (from 1 to 30) (default 1)
/// </summary>
public Nlmeans_openclFilterGen s(double s) => this.SetOptionRange("s", s,1,30);
/// <summary>
///  patch size (from 0 to 99) (default 7)
/// </summary>
public Nlmeans_openclFilterGen p(int p) => this.SetOptionRange("p", p,0,99);
/// <summary>
///  patch size for chroma planes (from 0 to 99) (default 0)
/// </summary>
public Nlmeans_openclFilterGen pc(int pc) => this.SetOptionRange("pc", pc,0,99);
/// <summary>
///  research window (from 0 to 99) (default 15)
/// </summary>
public Nlmeans_openclFilterGen r(int r) => this.SetOptionRange("r", r,0,99);
/// <summary>
///  research window for chroma planes (from 0 to 99) (default 0)
/// </summary>
public Nlmeans_openclFilterGen rc(int rc) => this.SetOptionRange("rc", rc,0,99);
}
/// <summary>
/// </summary>
public static class Nlmeans_openclFilterGenExtensions
{
/// <summary>
/// Non-local means denoiser through OpenCL
/// </summary>
public static Nlmeans_openclFilterGen Nlmeans_openclFilterGen(this ImageMap input0) => new Nlmeans_openclFilterGen(input0);
}
}
