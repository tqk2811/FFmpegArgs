namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC deflate           V->V       Apply deflate effect.
/// </summary>
public class DeflateFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal DeflateFilterGen(ImageMap input) : base("deflate",input) { AddMapOut(); }
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public DeflateFilterGen threshold0(int threshold0) => this.SetOptionRange("threshold0", threshold0,0,65535);
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public DeflateFilterGen threshold1(int threshold1) => this.SetOptionRange("threshold1", threshold1,0,65535);
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public DeflateFilterGen threshold2(int threshold2) => this.SetOptionRange("threshold2", threshold2,0,65535);
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public DeflateFilterGen threshold3(int threshold3) => this.SetOptionRange("threshold3", threshold3,0,65535);
}
/// <summary>
/// </summary>
public static class DeflateFilterGenExtensions
{
/// <summary>
/// Apply deflate effect.
/// </summary>
public static DeflateFilterGen DeflateFilterGen(this ImageMap input0) => new DeflateFilterGen(input0);
}
}
