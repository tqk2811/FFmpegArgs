namespace FFmpegArgs.Filters.Autogens
{
public class Roberts_openclFilterGen : ImageToImageFilter
{
internal Roberts_openclFilterGen(ImageMap input) : base("roberts_opencl",input) { AddMapOut(); }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public Roberts_openclFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public Roberts_openclFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,65535);
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public Roberts_openclFilterGen delta(float delta) => this.SetOptionRange("delta", delta,-65535,65535);
}
public static class Roberts_openclFilterGenExtensions
{
/// <summary>
/// Apply roberts operator
/// </summary>
public static Roberts_openclFilterGen Roberts_openclFilterGen(this ImageMap input0) => new Roberts_openclFilterGen(input0);
/// <summary>
/// Apply roberts operator
/// </summary>
public static Roberts_openclFilterGen Roberts_openclFilterGen(this ImageMap input0,Roberts_openclFilterGenConfig config)
{
var result = new Roberts_openclFilterGen(input0);
if(config?.planes != null) result.planes(config.planes.Value);
if(config?.scale != null) result.scale(config.scale.Value);
if(config?.delta != null) result.delta(config.delta.Value);
return result;
}
}
public class Roberts_openclFilterGenConfig
{
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public float? scale { get; set; }
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public float? delta { get; set; }
}
}
