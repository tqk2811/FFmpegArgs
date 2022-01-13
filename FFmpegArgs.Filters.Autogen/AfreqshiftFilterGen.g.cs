namespace FFmpegArgs.Filters.Autogens
{
public class AfreqshiftFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AfreqshiftFilterGen(AudioMap input) : base("afreqshift",input) { AddMapOut(); }
/// <summary>
///  set frequency shift (from -2.14748e+09 to INT_MAX) (default 0)
/// </summary>
public AfreqshiftFilterGen shift(double shift) => this.SetOptionRange("shift", shift,-2.14748e+09,INT_MAX);
/// <summary>
///  set output level (from 0 to 1) (default 1)
/// </summary>
public AfreqshiftFilterGen level(double level) => this.SetOptionRange("level", level,0,1);
}
public static class AfreqshiftFilterGenExtensions
{
/// <summary>
/// Apply frequency shifting to input audio.
/// </summary>
public static AfreqshiftFilterGen AfreqshiftFilterGen(this AudioMap input0) => new AfreqshiftFilterGen(input0);
/// <summary>
/// Apply frequency shifting to input audio.
/// </summary>
public static AfreqshiftFilterGen AfreqshiftFilterGen(this AudioMap input0,AfreqshiftFilterGenConfig config)
{
var result = new AfreqshiftFilterGen(input0);
if(config?.shift != null) result.shift(config.shift.Value);
if(config?.level != null) result.level(config.level.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AfreqshiftFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set frequency shift (from -2.14748e+09 to INT_MAX) (default 0)
/// </summary>
public double? shift { get; set; }
/// <summary>
///  set output level (from 0 to 1) (default 1)
/// </summary>
public double? level { get; set; }
public string TimelineSupport { get; set; }
}
}
