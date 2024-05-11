namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC guided            N->V       Apply Guided filter.
/// </summary>
public class GuidedFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal GuidedFilterGen(params ImageMap[] inputs) : base("guided",inputs) { AddMapOut(); }
/// <summary>
///  set the box radius (from 1 to 20) (default 3)
/// </summary>
public GuidedFilterGen radius(int radius) => this.SetOptionRange("radius", radius,1,20);
/// <summary>
///  set the regularization parameter (with square) (from 0 to 1) (default 0.01)
/// </summary>
public GuidedFilterGen eps(float eps) => this.SetOptionRange("eps", eps,0,1);
/// <summary>
///  set filtering mode (0: basic mode; 1: fast mode) (from 0 to 1) (default basic)
/// </summary>
public GuidedFilterGen mode(GuidedFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  subsampling ratio for fast mode (from 2 to 64) (default 4)
/// </summary>
public GuidedFilterGen sub(int sub) => this.SetOptionRange("sub", sub,2,64);
/// <summary>
///  set guidance mode (0: off mode; 1: on mode) (from 0 to 1) (default off)
/// </summary>
public GuidedFilterGen guidance(GuidedFilterGenGuidance guidance) => this.SetOption("guidance", guidance.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public GuidedFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Guided filter.
/// </summary>
public static GuidedFilterGen GuidedFilterGen(this IEnumerable<ImageMap> inputs) => new GuidedFilterGen(inputs.ToArray());
}
/// <summary>
///  set filtering mode (0: basic mode; 1: fast mode) (from 0 to 1) (default basic)
/// </summary>
public enum GuidedFilterGenMode
{
/// <summary>
/// basic           0            ..FV.....T. basic guided filter
/// </summary>
[Name("basic")] basic,
/// <summary>
/// fast            1            ..FV.....T. fast guided filter
/// </summary>
[Name("fast")] fast,
}

/// <summary>
///  set guidance mode (0: off mode; 1: on mode) (from 0 to 1) (default off)
/// </summary>
public enum GuidedFilterGenGuidance
{
/// <summary>
/// off             0            ..FV....... only one input is enabled
/// </summary>
[Name("off")] off,
/// <summary>
/// on              1            ..FV....... two inputs are required
/// </summary>
[Name("on")] on,
}

}
