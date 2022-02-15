namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... realtime          V->V       Slow down filtering to match realtime.
/// </summary>
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
/// <summary>
/// </summary>
public static class RealtimeFilterGenExtensions
{
/// <summary>
/// Slow down filtering to match realtime.
/// </summary>
public static RealtimeFilterGen RealtimeFilterGen(this ImageMap input0) => new RealtimeFilterGen(input0);
}
}
