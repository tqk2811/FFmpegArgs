namespace FFmpegArgs.Filters.Autogens
{
public class Chromaber_vulkanFilterGen : ImageToImageFilter
{
internal Chromaber_vulkanFilterGen(ImageMap input) : base("chromaber_vulkan",input) { AddMapOut(); }
/// <summary>
///  Set horizontal distortion amount (from -10 to 10) (default 0)
/// </summary>
public Chromaber_vulkanFilterGen dist_x(float dist_x) => this.SetOptionRange("dist_x", dist_x,-10,10);
/// <summary>
///  Set vertical distortion amount (from -10 to 10) (default 0)
/// </summary>
public Chromaber_vulkanFilterGen dist_y(float dist_y) => this.SetOptionRange("dist_y", dist_y,-10,10);
}
public static class Chromaber_vulkanFilterGenExtensions
{
/// <summary>
/// Offset chroma of input video (chromatic aberration)
/// </summary>
public static Chromaber_vulkanFilterGen Chromaber_vulkanFilterGen(this ImageMap input0) => new Chromaber_vulkanFilterGen(input0);
/// <summary>
/// Offset chroma of input video (chromatic aberration)
/// </summary>
public static Chromaber_vulkanFilterGen Chromaber_vulkanFilterGen(this ImageMap input0,Chromaber_vulkanFilterGenConfig config)
{
var result = new Chromaber_vulkanFilterGen(input0);
if(config?.dist_x != null) result.dist_x(config.dist_x.Value);
if(config?.dist_y != null) result.dist_y(config.dist_y.Value);
return result;
}
}
public class Chromaber_vulkanFilterGenConfig
{
/// <summary>
///  Set horizontal distortion amount (from -10 to 10) (default 0)
/// </summary>
public float? dist_x { get; set; }
/// <summary>
///  Set vertical distortion amount (from -10 to 10) (default 0)
/// </summary>
public float? dist_y { get; set; }
}
}
