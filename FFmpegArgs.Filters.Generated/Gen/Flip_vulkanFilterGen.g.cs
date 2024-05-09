namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... flip_vulkan       V->V       Flip both horizontally and vertically
/// </summary>
public class Flip_vulkanFilterGen : ImageToImageFilter
{
internal Flip_vulkanFilterGen(ImageMap input) : base("flip_vulkan",input) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class Flip_vulkanFilterGenExtensions
{
/// <summary>
/// Flip both horizontally and vertically
/// </summary>
public static Flip_vulkanFilterGen Flip_vulkanFilterGen(this ImageMap input0) => new Flip_vulkanFilterGen(input0);
}
}
