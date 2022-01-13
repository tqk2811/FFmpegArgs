namespace FFmpegArgs.Filters.Autogens
{
public class AsuperstopFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsuperstopFilterGen(AudioMap input) : base("asuperstop",input) { AddMapOut(); }
/// <summary>
///  set center frequency (from 2 to 999999) (default 1000)
/// </summary>
public AsuperstopFilterGen centerf(double centerf) => this.SetOptionRange("centerf", centerf,2,999999);
/// <summary>
///  set filter order (from 4 to 20) (default 4)
/// </summary>
public AsuperstopFilterGen order(int order) => this.SetOptionRange("order", order,4,20);
/// <summary>
///  set Q-factor (from 0.01 to 100) (default 1)
/// </summary>
public AsuperstopFilterGen qfactor(double qfactor) => this.SetOptionRange("qfactor", qfactor,0.01,100);
/// <summary>
///  set input level (from 0 to 2) (default 1)
/// </summary>
public AsuperstopFilterGen level(double level) => this.SetOptionRange("level", level,0,2);
}
public static class AsuperstopFilterGenExtensions
{
/// <summary>
/// Apply high order Butterworth band-stop filter.
/// </summary>
public static AsuperstopFilterGen AsuperstopFilterGen(this AudioMap input0) => new AsuperstopFilterGen(input0);
/// <summary>
/// Apply high order Butterworth band-stop filter.
/// </summary>
public static AsuperstopFilterGen AsuperstopFilterGen(this AudioMap input0,AsuperstopFilterGenConfig config)
{
var result = new AsuperstopFilterGen(input0);
if(config?.centerf != null) result.centerf(config.centerf.Value);
if(config?.order != null) result.order(config.order.Value);
if(config?.qfactor != null) result.qfactor(config.qfactor.Value);
if(config?.level != null) result.level(config.level.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AsuperstopFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set center frequency (from 2 to 999999) (default 1000)
/// </summary>
public double? centerf { get; set; }
/// <summary>
///  set filter order (from 4 to 20) (default 4)
/// </summary>
public int? order { get; set; }
/// <summary>
///  set Q-factor (from 0.01 to 100) (default 1)
/// </summary>
public double? qfactor { get; set; }
/// <summary>
///  set input level (from 0 to 2) (default 1)
/// </summary>
public double? level { get; set; }
public string TimelineSupport { get; set; }
}
}
