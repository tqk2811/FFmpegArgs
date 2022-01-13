namespace FFmpegArgs.Filters.Autogens
{
public class RealtimeFilterGen : ImageToImageFilter
{
internal RealtimeFilterGen(ImageMap input) : base("realtime",input) { AddMapOut(); }
/// <summary>
///  sleep time limit (default 2)
/// </summary>
public RealtimeFilterGen limit(TimeSpan limit) => this.SetOptionRange("limit",limit,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  speed factor (from DBL_MIN to DBL_MAX) (default 1)
/// </summary>
public RealtimeFilterGen speed(double speed) => this.SetOptionRange("speed", speed,DBL_MIN,DBL_MAX);
}
public static class RealtimeFilterGenExtensions
{
/// <summary>
/// Slow down filtering to match realtime.
/// </summary>
public static RealtimeFilterGen RealtimeFilterGen(this ImageMap input0) => new RealtimeFilterGen(input0);
/// <summary>
/// Slow down filtering to match realtime.
/// </summary>
public static RealtimeFilterGen RealtimeFilterGen(this ImageMap input0,RealtimeFilterGenConfig config)
{
var result = new RealtimeFilterGen(input0);
if(config?.limit != null) result.limit(config.limit.Value);
if(config?.speed != null) result.speed(config.speed.Value);
return result;
}
}
public class RealtimeFilterGenConfig
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
