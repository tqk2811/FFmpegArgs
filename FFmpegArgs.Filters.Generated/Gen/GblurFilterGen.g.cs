namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC gblur             V->V       Apply Gaussian Blur filter.
/// </summary>
public class GblurFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal GblurFilterGen(ImageMap input) : base("gblur",input) { AddMapOut(); }
/// <summary>
///  set sigma (from 0 to 1024) (default 0.5)
/// </summary>
public GblurFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma,0,1024);
/// <summary>
///  set number of steps (from 1 to 6) (default 1)
/// </summary>
public GblurFilterGen steps(int steps) => this.SetOptionRange("steps", steps,1,6);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public GblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set vertical sigma (from -1 to 1024) (default -1)
/// </summary>
public GblurFilterGen sigmaV(float sigmaV) => this.SetOptionRange("sigmaV", sigmaV,-1,1024);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Gaussian Blur filter.
/// </summary>
public static GblurFilterGen GblurFilterGen(this ImageMap input0) => new GblurFilterGen(input0);
}
}
