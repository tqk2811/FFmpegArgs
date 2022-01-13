namespace FFmpegArgs.Filters.Autogens
{
public class BilateralFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal BilateralFilterGen(ImageMap input) : base("bilateral",input) { AddMapOut(); }
/// <summary>
///  set spatial sigma (from 0 to 512) (default 0.1)
/// </summary>
public BilateralFilterGen sigmaS(float sigmaS) => this.SetOptionRange("sigmaS", sigmaS,0,512);
/// <summary>
///  set range sigma (from 0 to 1) (default 0.1)
/// </summary>
public BilateralFilterGen sigmaR(float sigmaR) => this.SetOptionRange("sigmaR", sigmaR,0,1);
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public BilateralFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class BilateralFilterGenExtensions
{
/// <summary>
/// Apply Bilateral filter.
/// </summary>
public static BilateralFilterGen BilateralFilterGen(this ImageMap input0) => new BilateralFilterGen(input0);
/// <summary>
/// Apply Bilateral filter.
/// </summary>
public static BilateralFilterGen BilateralFilterGen(this ImageMap input0,BilateralFilterGenConfig config)
{
var result = new BilateralFilterGen(input0);
if(config?.sigmaS != null) result.sigmaS(config.sigmaS.Value);
if(config?.sigmaR != null) result.sigmaR(config.sigmaR.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class BilateralFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set spatial sigma (from 0 to 512) (default 0.1)
/// </summary>
public float? sigmaS { get; set; }
/// <summary>
///  set range sigma (from 0 to 1) (default 0.1)
/// </summary>
public float? sigmaR { get; set; }
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public int? planes { get; set; }
public string TimelineSupport { get; set; }
}
}
