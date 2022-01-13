namespace FFmpegArgs.Filters.Autogens
{
public class Avgblur_vulkanFilterGen : ImageToImageFilter
{
internal Avgblur_vulkanFilterGen(ImageMap input) : base("avgblur_vulkan",input) { AddMapOut(); }
/// <summary>
///  Set horizontal radius (from 1 to 32) (default 3)
/// </summary>
public Avgblur_vulkanFilterGen sizeX(int sizeX) => this.SetOptionRange("sizeX", sizeX,1,32);
/// <summary>
///  Set planes to filter (bitmask) (from 0 to 15) (default 15)
/// </summary>
public Avgblur_vulkanFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  Set vertical radius (from 1 to 32) (default 3)
/// </summary>
public Avgblur_vulkanFilterGen sizeY(int sizeY) => this.SetOptionRange("sizeY", sizeY,1,32);
}
public static class Avgblur_vulkanFilterGenExtensions
{
/// <summary>
/// Apply avgblur mask to input video
/// </summary>
public static Avgblur_vulkanFilterGen Avgblur_vulkanFilterGen(this ImageMap input0) => new Avgblur_vulkanFilterGen(input0);
/// <summary>
/// Apply avgblur mask to input video
/// </summary>
public static Avgblur_vulkanFilterGen Avgblur_vulkanFilterGen(this ImageMap input0,Avgblur_vulkanFilterGenConfig config)
{
var result = new Avgblur_vulkanFilterGen(input0);
if(config?.sizeX != null) result.sizeX(config.sizeX.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(config?.sizeY != null) result.sizeY(config.sizeY.Value);
return result;
}
}
public class Avgblur_vulkanFilterGenConfig
{
/// <summary>
///  Set horizontal radius (from 1 to 32) (default 3)
/// </summary>
public int? sizeX { get; set; }
/// <summary>
///  Set planes to filter (bitmask) (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
/// <summary>
///  Set vertical radius (from 1 to 32) (default 3)
/// </summary>
public int? sizeY { get; set; }
}
}
