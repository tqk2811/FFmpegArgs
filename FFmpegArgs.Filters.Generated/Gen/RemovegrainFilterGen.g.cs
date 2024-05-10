namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. removegrain       V->V       Remove grain.
/// </summary>
public class RemovegrainFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal RemovegrainFilterGen(ImageMap input) : base("removegrain",input) { AddMapOut(); }
/// <summary>
///  set mode for 1st plane (from 0 to 24) (default 0)
/// </summary>
public RemovegrainFilterGen m0(int m0) => this.SetOptionRange("m0", m0,0,24);
/// <summary>
///  set mode for 2nd plane (from 0 to 24) (default 0)
/// </summary>
public RemovegrainFilterGen m1(int m1) => this.SetOptionRange("m1", m1,0,24);
/// <summary>
///  set mode for 3rd plane (from 0 to 24) (default 0)
/// </summary>
public RemovegrainFilterGen m2(int m2) => this.SetOptionRange("m2", m2,0,24);
/// <summary>
///  set mode for 4th plane (from 0 to 24) (default 0)
/// </summary>
public RemovegrainFilterGen m3(int m3) => this.SetOptionRange("m3", m3,0,24);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Remove grain.
/// </summary>
public static RemovegrainFilterGen RemovegrainFilterGen(this ImageMap input0) => new RemovegrainFilterGen(input0);
}
}
