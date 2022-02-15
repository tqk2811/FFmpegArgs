namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TS. hflip             V->V       Horizontally flip the input video.
/// </summary>
public class HflipFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal HflipFilterGen(ImageMap input) : base("hflip",input) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class HflipFilterGenExtensions
{
/// <summary>
/// Horizontally flip the input video.
/// </summary>
public static HflipFilterGen HflipFilterGen(this ImageMap input0) => new HflipFilterGen(input0);
}
}
