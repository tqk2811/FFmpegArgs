namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. hflip             V-&gt;V       Horizontally flip the input video.
/// </summary>
public class HflipFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal HflipFilterGen(ImageMap input) : base("hflip",input) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Horizontally flip the input video.
/// </summary>
public static HflipFilterGen HflipFilterGen(this ImageMap input0) => new HflipFilterGen(input0);
}
}
