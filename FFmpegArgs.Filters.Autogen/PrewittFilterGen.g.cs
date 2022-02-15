namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC prewitt           V->V       Apply prewitt operator.
/// </summary>
public class PrewittFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal PrewittFilterGen(ImageMap input) : base("prewitt",input) { AddMapOut(); }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public PrewittFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set scale (from 0 to 65535) (default 1)
/// </summary>
public PrewittFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,65535);
/// <summary>
///  set delta (from -65535 to 65535) (default 0)
/// </summary>
public PrewittFilterGen delta(float delta) => this.SetOptionRange("delta", delta,-65535,65535);
}
/// <summary>
/// </summary>
public static class PrewittFilterGenExtensions
{
/// <summary>
/// Apply prewitt operator.
/// </summary>
public static PrewittFilterGen PrewittFilterGen(this ImageMap input0) => new PrewittFilterGen(input0);
}
}
