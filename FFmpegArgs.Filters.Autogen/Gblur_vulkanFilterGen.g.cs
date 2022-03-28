namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... gblur_vulkan      V->V       Gaussian Blur in Vulkan
/// </summary>
public class Gblur_vulkanFilterGen : ImageToImageFilter
{
internal Gblur_vulkanFilterGen(ImageMap input) : base("gblur_vulkan",input) { AddMapOut(); }
/// <summary>
///  Set sigma (from 0.01 to 1024) (default 0.5)
/// </summary>
public Gblur_vulkanFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma,0.01,1024);
/// <summary>
///  Set vertical sigma (from 0 to 1024) (default 0)
/// </summary>
public Gblur_vulkanFilterGen sigmaV(float sigmaV) => this.SetOptionRange("sigmaV", sigmaV,0,1024);
/// <summary>
///  Set planes to filter (from 0 to 15) (default 15)
/// </summary>
public Gblur_vulkanFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  Set kernel size (from 1 to 127) (default 19)
/// </summary>
public Gblur_vulkanFilterGen size(int size) => this.SetOptionRange("size", size,1,127);
}
/// <summary>
/// </summary>
public static class Gblur_vulkanFilterGenExtensions
{
/// <summary>
/// Gaussian Blur in Vulkan
/// </summary>
public static Gblur_vulkanFilterGen Gblur_vulkanFilterGen(this ImageMap input0) => new Gblur_vulkanFilterGen(input0);
}
}
