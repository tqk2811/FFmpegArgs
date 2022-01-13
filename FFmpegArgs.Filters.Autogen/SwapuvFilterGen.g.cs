namespace FFmpegArgs.Filters.Autogens
{
public class SwapuvFilterGen : ImageToImageFilter,ITimelineSupport
{
internal SwapuvFilterGen(ImageMap input) : base("swapuv",input) { AddMapOut(); }
}
public static class SwapuvFilterGenExtensions
{
/// <summary>
/// Swap U and V components.
/// </summary>
public static SwapuvFilterGen SwapuvFilterGen(this ImageMap input0) => new SwapuvFilterGen(input0);
/// <summary>
/// Swap U and V components.
/// </summary>
public static SwapuvFilterGen SwapuvFilterGen(this ImageMap input0,SwapuvFilterGenConfig config)
{
var result = new SwapuvFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class SwapuvFilterGenConfig
:ITimelineSupportConfig
{
public string TimelineSupport { get; set; }
}
}
