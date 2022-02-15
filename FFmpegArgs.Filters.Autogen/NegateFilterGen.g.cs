namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC negate            V->V       Negate input video.
/// </summary>
public class NegateFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal NegateFilterGen(ImageMap input) : base("negate",input) { AddMapOut(); }
/// <summary>
///  (default false)
/// </summary>
public NegateFilterGen negate_alpha(bool negate_alpha) => this.SetOption("negate_alpha",negate_alpha.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class NegateFilterGenExtensions
{
/// <summary>
/// Negate input video.
/// </summary>
public static NegateFilterGen NegateFilterGen(this ImageMap input0) => new NegateFilterGen(input0);
}
}
