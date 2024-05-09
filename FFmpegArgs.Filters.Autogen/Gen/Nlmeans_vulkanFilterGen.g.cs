namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... nlmeans_vulkan    V->V       Non-local means denoiser (Vulkan)
/// </summary>
public class Nlmeans_vulkanFilterGen : ImageToImageFilter
{
internal Nlmeans_vulkanFilterGen(ImageMap input) : base("nlmeans_vulkan",input) { AddMapOut(); }
/// <summary>
///  denoising strength for all components (from 1 to 100) (default 1)
/// </summary>
public Nlmeans_vulkanFilterGen s(double s) => this.SetOptionRange("s", s,1,100);
/// <summary>
///  patch size for all components (from 0 to 99) (default 7)
/// </summary>
public Nlmeans_vulkanFilterGen p(int p) => this.SetOptionRange("p", p,0,99);
/// <summary>
///  research window radius (from 0 to 99) (default 15)
/// </summary>
public Nlmeans_vulkanFilterGen r(int r) => this.SetOptionRange("r", r,0,99);
/// <summary>
///  parallelism (from 1 to 168) (default 36)
/// </summary>
public Nlmeans_vulkanFilterGen t(int t) => this.SetOptionRange("t", t,1,168);
/// <summary>
///  denoising strength for component 1 (from 1 to 100) (default 1)
/// </summary>
public Nlmeans_vulkanFilterGen s1(double s1) => this.SetOptionRange("s1", s1,1,100);
/// <summary>
///  denoising strength for component 2 (from 1 to 100) (default 1)
/// </summary>
public Nlmeans_vulkanFilterGen s2(double s2) => this.SetOptionRange("s2", s2,1,100);
/// <summary>
///  denoising strength for component 3 (from 1 to 100) (default 1)
/// </summary>
public Nlmeans_vulkanFilterGen s3(double s3) => this.SetOptionRange("s3", s3,1,100);
/// <summary>
///  denoising strength for component 4 (from 1 to 100) (default 1)
/// </summary>
public Nlmeans_vulkanFilterGen s4(double s4) => this.SetOptionRange("s4", s4,1,100);
/// <summary>
///  patch size for component 1 (from 0 to 99) (default 0)
/// </summary>
public Nlmeans_vulkanFilterGen p1(int p1) => this.SetOptionRange("p1", p1,0,99);
/// <summary>
///  patch size for component 2 (from 0 to 99) (default 0)
/// </summary>
public Nlmeans_vulkanFilterGen p2(int p2) => this.SetOptionRange("p2", p2,0,99);
/// <summary>
///  patch size for component 3 (from 0 to 99) (default 0)
/// </summary>
public Nlmeans_vulkanFilterGen p3(int p3) => this.SetOptionRange("p3", p3,0,99);
/// <summary>
///  patch size for component 4 (from 0 to 99) (default 0)
/// </summary>
public Nlmeans_vulkanFilterGen p4(int p4) => this.SetOptionRange("p4", p4,0,99);
}
/// <summary>
/// </summary>
public static class Nlmeans_vulkanFilterGenExtensions
{
/// <summary>
/// Non-local means denoiser (Vulkan)
/// </summary>
public static Nlmeans_vulkanFilterGen Nlmeans_vulkanFilterGen(this ImageMap input0) => new Nlmeans_vulkanFilterGen(input0);
}
}
