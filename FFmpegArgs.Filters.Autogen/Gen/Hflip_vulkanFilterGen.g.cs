namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... hflip_vulkan      V->V       Horizontally flip the input video in Vulkan
/// </summary>
public class Hflip_vulkanFilterGen : ImageToImageFilter
{
internal Hflip_vulkanFilterGen(ImageMap input) : base("hflip_vulkan",input) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class Hflip_vulkanFilterGenExtensions
{
/// <summary>
/// Horizontally flip the input video in Vulkan
/// </summary>
public static Hflip_vulkanFilterGen Hflip_vulkanFilterGen(this ImageMap input0) => new Hflip_vulkanFilterGen(input0);
}
}
