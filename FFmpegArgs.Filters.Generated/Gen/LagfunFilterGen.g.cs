namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC lagfun            V-&gt;V       Slowly update darker pixels.
/// </summary>
public class LagfunFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LagfunFilterGen(ImageMap input) : base("lagfun",input) { AddMapOut(); }
/// <summary>
///  set decay (from 0 to 1) (default 0.95)
/// </summary>
public LagfunFilterGen decay(float decay) => this.SetOptionRange("decay", decay,0,1);
/// <summary>
///  set what planes to filter (default F)
/// </summary>
public LagfunFilterGen planes(LagfunFilterGenPlanes planes) => this.SetOption("planes", planes.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Slowly update darker pixels.
/// </summary>
public static LagfunFilterGen LagfunFilterGen(this ImageMap input0) => new LagfunFilterGen(input0);
}
/// <summary>
///  set what planes to filter (default F)
/// </summary>
public enum LagfunFilterGenPlanes
{
}

}
