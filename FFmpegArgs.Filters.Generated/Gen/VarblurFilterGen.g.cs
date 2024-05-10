namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC varblur           VV->V      Apply Variable Blur filter.
/// </summary>
public class VarblurFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal VarblurFilterGen(params ImageMap[] inputs) : base("varblur",inputs) { AddMapOut(); }
/// <summary>
///  set min blur radius (from 0 to 254) (default 0)
/// </summary>
public VarblurFilterGen min_r(int min_r) => this.SetOptionRange("min_r", min_r,0,254);
/// <summary>
///  set max blur radius (from 1 to 255) (default 8)
/// </summary>
public VarblurFilterGen max_r(int max_r) => this.SetOptionRange("max_r", max_r,1,255);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public VarblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Variable Blur filter.
/// </summary>
public static VarblurFilterGen VarblurFilterGen(this ImageMap input0, ImageMap input1) => new VarblurFilterGen(input0, input1);
}
}
