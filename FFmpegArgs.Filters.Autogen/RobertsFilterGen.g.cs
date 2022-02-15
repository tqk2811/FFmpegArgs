namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC roberts           V->V       Apply roberts cross operator.
/// </summary>
public class RobertsFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal RobertsFilterGen(ImageMap input) : base("roberts",input) { AddMapOut(); }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public RobertsFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public RobertsFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,65535);
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public RobertsFilterGen delta(float delta) => this.SetOptionRange("delta", delta,-65535,65535);
}
/// <summary>
/// </summary>
public static class RobertsFilterGenExtensions
{
/// <summary>
/// Apply roberts cross operator.
/// </summary>
public static RobertsFilterGen RobertsFilterGen(this ImageMap input0) => new RobertsFilterGen(input0);
}
}
