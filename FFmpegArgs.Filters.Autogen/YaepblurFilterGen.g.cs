namespace FFmpegArgs.Filters.Autogens
{
public class YaepblurFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal YaepblurFilterGen(ImageMap input) : base("yaepblur",input) { AddMapOut(); }
/// <summary>
///  set window radius (from 0 to INT_MAX) (default 3)
/// </summary>
public YaepblurFilterGen radius(int radius) => this.SetOptionRange("radius", radius,0,INT_MAX);
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public YaepblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set blur strength (from 1 to INT_MAX) (default 128)
/// </summary>
public YaepblurFilterGen sigma(int sigma) => this.SetOptionRange("sigma", sigma,1,INT_MAX);
}
public static class YaepblurFilterGenExtensions
{
/// <summary>
/// Yet another edge preserving blur filter.
/// </summary>
public static YaepblurFilterGen YaepblurFilterGen(this ImageMap input0) => new YaepblurFilterGen(input0);
/// <summary>
/// Yet another edge preserving blur filter.
/// </summary>
public static YaepblurFilterGen YaepblurFilterGen(this ImageMap input0,YaepblurFilterGenConfig config)
{
var result = new YaepblurFilterGen(input0);
if(config?.radius != null) result.radius(config.radius.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(config?.sigma != null) result.sigma(config.sigma.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class YaepblurFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set window radius (from 0 to INT_MAX) (default 3)
/// </summary>
public int? radius { get; set; }
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public int? planes { get; set; }
/// <summary>
///  set blur strength (from 1 to INT_MAX) (default 128)
/// </summary>
public int? sigma { get; set; }
public string TimelineSupport { get; set; }
}
}
