namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TS. grayworld         V->V       Adjust white balance using LAB gray world algorithm
/// </summary>
public class GrayworldFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal GrayworldFilterGen(ImageMap input) : base("grayworld",input) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class GrayworldFilterGenExtensions
{
/// <summary>
/// Adjust white balance using LAB gray world algorithm
/// </summary>
public static GrayworldFilterGen GrayworldFilterGen(this ImageMap input0) => new GrayworldFilterGen(input0);
}
}
