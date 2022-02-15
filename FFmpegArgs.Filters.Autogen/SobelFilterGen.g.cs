namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC sobel             V->V       Apply sobel operator.
/// </summary>
public class SobelFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal SobelFilterGen(ImageMap input) : base("sobel",input) { AddMapOut(); }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public SobelFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public SobelFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,65535);
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public SobelFilterGen delta(float delta) => this.SetOptionRange("delta", delta,-65535,65535);
}
/// <summary>
/// </summary>
public static class SobelFilterGenExtensions
{
/// <summary>
/// Apply sobel operator.
/// </summary>
public static SobelFilterGen SobelFilterGen(this ImageMap input0) => new SobelFilterGen(input0);
}
}
