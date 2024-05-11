namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC tlut2             V-&gt;V       Compute and apply a lookup table from two successive frames.
/// </summary>
public class Tlut2FilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Tlut2FilterGen(ImageMap input) : base("tlut2",input) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default &quot;x&quot;)
/// </summary>
public Tlut2FilterGen c0(ExpressionValue c0) => this.SetOption("c0",(string)c0);
/// <summary>
///  set component #1 expression (default &quot;x&quot;)
/// </summary>
public Tlut2FilterGen c1(ExpressionValue c1) => this.SetOption("c1",(string)c1);
/// <summary>
///  set component #2 expression (default &quot;x&quot;)
/// </summary>
public Tlut2FilterGen c2(ExpressionValue c2) => this.SetOption("c2",(string)c2);
/// <summary>
///  set component #3 expression (default &quot;x&quot;)
/// </summary>
public Tlut2FilterGen c3(ExpressionValue c3) => this.SetOption("c3",(string)c3);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Compute and apply a lookup table from two successive frames.
/// </summary>
public static Tlut2FilterGen Tlut2FilterGen(this ImageMap input0) => new Tlut2FilterGen(input0);
}
}
