namespace FFmpegArgs.Filters.Autogens
{
public class GblurFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal GblurFilterGen(ImageMap input) : base("gblur",input) { AddMapOut(); }
/// <summary>
///  set sigma (from 0 to 1024) (default 0.5)
/// </summary>
public GblurFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma,0,1024);
/// <summary>
///  set number of steps (from 1 to 6) (default 1)
/// </summary>
public GblurFilterGen steps(int steps) => this.SetOptionRange("steps", steps,1,6);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public GblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set vertical sigma (from -1 to 1024) (default -1)
/// </summary>
public GblurFilterGen sigmaV(float sigmaV) => this.SetOptionRange("sigmaV", sigmaV,-1,1024);
}
public static class GblurFilterGenExtensions
{
/// <summary>
/// Apply Gaussian Blur filter.
/// </summary>
public static GblurFilterGen GblurFilterGen(this ImageMap input0) => new GblurFilterGen(input0);
/// <summary>
/// Apply Gaussian Blur filter.
/// </summary>
public static GblurFilterGen GblurFilterGen(this ImageMap input0,GblurFilterGenConfig config)
{
var result = new GblurFilterGen(input0);
if(config?.sigma != null) result.sigma(config.sigma.Value);
if(config?.steps != null) result.steps(config.steps.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(config?.sigmaV != null) result.sigmaV(config.sigmaV.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class GblurFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set sigma (from 0 to 1024) (default 0.5)
/// </summary>
public float? sigma { get; set; }
/// <summary>
///  set number of steps (from 1 to 6) (default 1)
/// </summary>
public int? steps { get; set; }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
/// <summary>
///  set vertical sigma (from -1 to 1024) (default -1)
/// </summary>
public float? sigmaV { get; set; }
public string TimelineSupport { get; set; }
}
}
