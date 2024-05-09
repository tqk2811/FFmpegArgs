namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC negate            V->V       Negate input video.
/// </summary>
public class NegateFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal NegateFilterGen(ImageMap input) : base("negate",input) { AddMapOut(); }
/// <summary>
///  set components to negate (default y+u+v+r+g+b)
/// </summary>
public NegateFilterGen components(NegateFilterGenComponents components) => this.SetOption("components", components.GetEnumAttribute<NameAttribute>().Name);
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
/// <summary>
///  set components to negate (default y+u+v+r+g+b)
/// </summary>
public enum NegateFilterGenComponents
{
/// <summary>
/// y                            ..FV.....T. set luma component
/// </summary>
[Name("y")] y,
/// <summary>
/// u                            ..FV.....T. set u component
/// </summary>
[Name("u")] u,
/// <summary>
/// v                            ..FV.....T. set v component
/// </summary>
[Name("v")] v,
/// <summary>
/// r                            ..FV.....T. set red component
/// </summary>
[Name("r")] r,
/// <summary>
/// g                            ..FV.....T. set green component
/// </summary>
[Name("g")] g,
/// <summary>
/// b                            ..FV.....T. set blue component
/// </summary>
[Name("b")] b,
/// <summary>
/// a                            ..FV.....T. set alpha component
/// </summary>
[Name("a")] a,
}

}
