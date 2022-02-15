namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. swapuv            V->V       Swap U and V components.
/// </summary>
public class SwapuvFilterGen : ImageToImageFilter,ITimelineSupport
{
internal SwapuvFilterGen(ImageMap input) : base("swapuv",input) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class SwapuvFilterGenExtensions
{
/// <summary>
/// Swap U and V components.
/// </summary>
public static SwapuvFilterGen SwapuvFilterGen(this ImageMap input0) => new SwapuvFilterGen(input0);
}
}
