namespace FFmpegArgs.Filters.Autogens
{
public class Erosion_openclFilterGen : ImageToImageFilter
{
internal Erosion_openclFilterGen(ImageMap input) : base("erosion_opencl",input) { AddMapOut(); }
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public Erosion_openclFilterGen threshold0(float threshold0) => this.SetOptionRange("threshold0", threshold0,0,65535);
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public Erosion_openclFilterGen threshold1(float threshold1) => this.SetOptionRange("threshold1", threshold1,0,65535);
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public Erosion_openclFilterGen threshold2(float threshold2) => this.SetOptionRange("threshold2", threshold2,0,65535);
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public Erosion_openclFilterGen threshold3(float threshold3) => this.SetOptionRange("threshold3", threshold3,0,65535);
/// <summary>
///  set coordinates (from 0 to 255) (default 255)
/// </summary>
public Erosion_openclFilterGen coordinates(int coordinates) => this.SetOptionRange("coordinates", coordinates,0,255);
}
public static class Erosion_openclFilterGenExtensions
{
/// <summary>
/// Apply erosion effect
/// </summary>
public static Erosion_openclFilterGen Erosion_openclFilterGen(this ImageMap input0) => new Erosion_openclFilterGen(input0);
/// <summary>
/// Apply erosion effect
/// </summary>
public static Erosion_openclFilterGen Erosion_openclFilterGen(this ImageMap input0,Erosion_openclFilterGenConfig config)
{
var result = new Erosion_openclFilterGen(input0);
if(config?.threshold0 != null) result.threshold0(config.threshold0.Value);
if(config?.threshold1 != null) result.threshold1(config.threshold1.Value);
if(config?.threshold2 != null) result.threshold2(config.threshold2.Value);
if(config?.threshold3 != null) result.threshold3(config.threshold3.Value);
if(config?.coordinates != null) result.coordinates(config.coordinates.Value);
return result;
}
}
public class Erosion_openclFilterGenConfig
{
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public float? threshold0 { get; set; }
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public float? threshold1 { get; set; }
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public float? threshold2 { get; set; }
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public float? threshold3 { get; set; }
/// <summary>
///  set coordinates (from 0 to 255) (default 255)
/// </summary>
public int? coordinates { get; set; }
}
}
