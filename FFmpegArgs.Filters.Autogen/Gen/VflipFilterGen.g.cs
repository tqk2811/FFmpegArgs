namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. vflip             V->V       Flip the input video vertically.
/// </summary>
public class VflipFilterGen : ImageToImageFilter,ITimelineSupport
{
internal VflipFilterGen(ImageMap input) : base("vflip",input) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class VflipFilterGenExtensions
{
/// <summary>
/// Flip the input video vertically.
/// </summary>
public static VflipFilterGen VflipFilterGen(this ImageMap input0) => new VflipFilterGen(input0);
}
}
