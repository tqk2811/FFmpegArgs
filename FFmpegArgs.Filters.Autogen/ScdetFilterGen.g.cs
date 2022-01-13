namespace FFmpegArgs.Filters.Autogens
{
public class ScdetFilterGen : ImageToImageFilter
{
internal ScdetFilterGen(ImageMap input) : base("scdet",input) { AddMapOut(); }
/// <summary>
///  set scene change detect threshold (from 0 to 100) (default 10)
/// </summary>
public ScdetFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,100);
/// <summary>
///  Set the flag to pass scene change frames (default false)
/// </summary>
public ScdetFilterGen sc_pass(bool sc_pass) => this.SetOption("sc_pass",sc_pass.ToFFmpegFlag());
}
public static class ScdetFilterGenExtensions
{
/// <summary>
/// Detect video scene change
/// </summary>
public static ScdetFilterGen ScdetFilterGen(this ImageMap input0) => new ScdetFilterGen(input0);
/// <summary>
/// Detect video scene change
/// </summary>
public static ScdetFilterGen ScdetFilterGen(this ImageMap input0,ScdetFilterGenConfig config)
{
var result = new ScdetFilterGen(input0);
if(config?.threshold != null) result.threshold(config.threshold.Value);
if(config?.sc_pass != null) result.sc_pass(config.sc_pass.Value);
return result;
}
}
public class ScdetFilterGenConfig
{
/// <summary>
///  set scene change detect threshold (from 0 to 100) (default 10)
/// </summary>
public double? threshold { get; set; }
/// <summary>
///  Set the flag to pass scene change frames (default false)
/// </summary>
public bool? sc_pass { get; set; }
}
}
