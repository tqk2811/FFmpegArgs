namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC limiter           V-&gt;V       Limit pixels components to the specified range.
/// </summary>
public class LimiterFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LimiterFilterGen(ImageMap input) : base("limiter",input) { AddMapOut(); }
/// <summary>
///  set min value (from 0 to 65535) (default 0)
/// </summary>
public LimiterFilterGen min(int min) => this.SetOptionRange("min", min,0,65535);
/// <summary>
///  set max value (from 0 to 65535) (default 65535)
/// </summary>
public LimiterFilterGen max(int max) => this.SetOptionRange("max", max,0,65535);
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public LimiterFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Limit pixels components to the specified range.
/// </summary>
public static LimiterFilterGen LimiterFilterGen(this ImageMap input0) => new LimiterFilterGen(input0);
}
}
