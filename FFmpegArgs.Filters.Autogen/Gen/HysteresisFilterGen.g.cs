namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. hysteresis        VV->V      Grow first stream into second stream by connecting components.
/// </summary>
public class HysteresisFilterGen : ImageToImageFilter,ITimelineSupport
{
internal HysteresisFilterGen(params ImageMap[] inputs) : base("hysteresis",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public HysteresisFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set threshold (from 0 to 65535) (default 0)
/// </summary>
public HysteresisFilterGen threshold(int threshold) => this.SetOptionRange("threshold", threshold,0,65535);
}
/// <summary>
/// </summary>
public static class HysteresisFilterGenExtensions
{
/// <summary>
/// Grow first stream into second stream by connecting components.
/// </summary>
public static HysteresisFilterGen HysteresisFilterGen(this ImageMap input0, ImageMap input1) => new HysteresisFilterGen(input0, input1);
}
}
