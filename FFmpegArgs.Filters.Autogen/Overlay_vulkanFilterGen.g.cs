namespace FFmpegArgs.Filters.Autogens
{
public class Overlay_vulkanFilterGen : ImageToImageFilter
{
internal Overlay_vulkanFilterGen(params ImageMap[] inputs) : base("overlay_vulkan",inputs) { AddMapOut(); }
/// <summary>
///  Set horizontal offset (from 0 to INT_MAX) (default 0)
/// </summary>
public Overlay_vulkanFilterGen x(int x) => this.SetOptionRange("x", x,0,INT_MAX);
/// <summary>
///  Set vertical offset (from 0 to INT_MAX) (default 0)
/// </summary>
public Overlay_vulkanFilterGen y(int y) => this.SetOptionRange("y", y,0,INT_MAX);
}
public static class Overlay_vulkanFilterGenExtensions
{
/// <summary>
/// Overlay a source on top of another
/// </summary>
public static Overlay_vulkanFilterGen Overlay_vulkanFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_vulkanFilterGen(input0, input1);
/// <summary>
/// Overlay a source on top of another
/// </summary>
public static Overlay_vulkanFilterGen Overlay_vulkanFilterGen(this ImageMap input0, ImageMap input1,Overlay_vulkanFilterGenConfig config)
{
var result = new Overlay_vulkanFilterGen(input0, input1);
if(config?.x != null) result.x(config.x.Value);
if(config?.y != null) result.y(config.y.Value);
return result;
}
}
public class Overlay_vulkanFilterGenConfig
{
/// <summary>
///  Set horizontal offset (from 0 to INT_MAX) (default 0)
/// </summary>
public int? x { get; set; }
/// <summary>
///  Set vertical offset (from 0 to INT_MAX) (default 0)
/// </summary>
public int? y { get; set; }
}
}
