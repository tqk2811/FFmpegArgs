namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC kirsch            V->V       Apply kirsch operator.
/// </summary>
public class KirschFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal KirschFilterGen(ImageMap input) : base("kirsch",input) { AddMapOut(); }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public KirschFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public KirschFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,65535);
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public KirschFilterGen delta(float delta) => this.SetOptionRange("delta", delta,-65535,65535);
}
/// <summary>
/// </summary>
public static class KirschFilterGenExtensions
{
/// <summary>
/// Apply kirsch operator.
/// </summary>
public static KirschFilterGen KirschFilterGen(this ImageMap input0) => new KirschFilterGen(input0);
}
}
