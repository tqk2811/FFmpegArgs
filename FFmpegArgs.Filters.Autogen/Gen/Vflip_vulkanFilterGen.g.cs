namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... vflip_vulkan      V->V       Vertically flip the input video in Vulkan
/// </summary>
public class Vflip_vulkanFilterGen : ImageToImageFilter
{
internal Vflip_vulkanFilterGen(ImageMap input) : base("vflip_vulkan",input) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class Vflip_vulkanFilterGenExtensions
{
/// <summary>
/// Vertically flip the input video in Vulkan
/// </summary>
public static Vflip_vulkanFilterGen Vflip_vulkanFilterGen(this ImageMap input0) => new Vflip_vulkanFilterGen(input0);
}
}
