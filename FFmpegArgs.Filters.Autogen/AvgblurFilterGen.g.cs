namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC avgblur           V->V       Apply Average Blur filter.
/// </summary>
public class AvgblurFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AvgblurFilterGen(ImageMap input) : base("avgblur",input) { AddMapOut(); }
/// <summary>
///  set horizontal size (from 1 to 1024) (default 1)
/// </summary>
public AvgblurFilterGen sizeX(int sizeX) => this.SetOptionRange("sizeX", sizeX,1,1024);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public AvgblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set vertical size (from 0 to 1024) (default 0)
/// </summary>
public AvgblurFilterGen sizeY(int sizeY) => this.SetOptionRange("sizeY", sizeY,0,1024);
}
/// <summary>
/// </summary>
public static class AvgblurFilterGenExtensions
{
/// <summary>
/// Apply Average Blur filter.
/// </summary>
public static AvgblurFilterGen AvgblurFilterGen(this ImageMap input0) => new AvgblurFilterGen(input0);
}
}
