namespace FFmpegArgs.Filters.Autogens
{
public class ArealtimeFilterGen : AudioToAudioFilter
{
internal ArealtimeFilterGen(AudioMap input) : base("arealtime",input) { AddMapOut(); }
/// <summary>
///  sleep time limit (default 2)
/// </summary>
public ArealtimeFilterGen limit(TimeSpan limit) => this.SetOptionRange("limit",limit,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  speed factor (from DBL_MIN to DBL_MAX) (default 1)
/// </summary>
public ArealtimeFilterGen speed(double speed) => this.SetOptionRange("speed", speed,DBL_MIN,DBL_MAX);
}
public static class ArealtimeFilterGenExtensions
{
/// <summary>
/// Slow down filtering to match realtime.
/// </summary>
public static ArealtimeFilterGen ArealtimeFilterGen(this AudioMap input0) => new ArealtimeFilterGen(input0);
/// <summary>
/// Slow down filtering to match realtime.
/// </summary>
public static ArealtimeFilterGen ArealtimeFilterGen(this AudioMap input0,ArealtimeFilterGenConfig config)
{
var result = new ArealtimeFilterGen(input0);
if(config?.limit != null) result.limit(config.limit.Value);
if(config?.speed != null) result.speed(config.speed.Value);
return result;
}
}
public class ArealtimeFilterGenConfig
{
/// <summary>
///  sleep time limit (default 2)
/// </summary>
public TimeSpan? limit { get; set; }
/// <summary>
///  speed factor (from DBL_MIN to DBL_MAX) (default 1)
/// </summary>
public double? speed { get; set; }
}
}
