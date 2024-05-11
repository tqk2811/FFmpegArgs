namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC lut2              VV-&gt;V      Compute and apply a lookup table from two video inputs.
/// </summary>
public class Lut2FilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Lut2FilterGen(params ImageMap[] inputs) : base("lut2",inputs) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default &quot;x&quot;)
/// </summary>
public Lut2FilterGen c0(ExpressionValue c0) => this.SetOption("c0",(string)c0);
/// <summary>
///  set component #1 expression (default &quot;x&quot;)
/// </summary>
public Lut2FilterGen c1(ExpressionValue c1) => this.SetOption("c1",(string)c1);
/// <summary>
///  set component #2 expression (default &quot;x&quot;)
/// </summary>
public Lut2FilterGen c2(ExpressionValue c2) => this.SetOption("c2",(string)c2);
/// <summary>
///  set component #3 expression (default &quot;x&quot;)
/// </summary>
public Lut2FilterGen c3(ExpressionValue c3) => this.SetOption("c3",(string)c3);
/// <summary>
///  set output depth (from 0 to 16) (default 0)
/// </summary>
public Lut2FilterGen d(int d) => this.SetOptionRange("d", d,0,16);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Compute and apply a lookup table from two video inputs.
/// </summary>
public static Lut2FilterGen Lut2FilterGen(this ImageMap input0, ImageMap input1) => new Lut2FilterGen(input0, input1);
}
}
