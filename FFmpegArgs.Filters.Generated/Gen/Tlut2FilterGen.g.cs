namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC tlut2             V->V       Compute and apply a lookup table from two successive frames.
/// </summary>
public class Tlut2FilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Tlut2FilterGen(ImageMap input) : base("tlut2",input) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default "x")
/// </summary>
public Tlut2FilterGen c0(string c0) => this.SetOption("c0",c0);
/// <summary>
///  set component #1 expression (default "x")
/// </summary>
public Tlut2FilterGen c1(string c1) => this.SetOption("c1",c1);
/// <summary>
///  set component #2 expression (default "x")
/// </summary>
public Tlut2FilterGen c2(string c2) => this.SetOption("c2",c2);
/// <summary>
///  set component #3 expression (default "x")
/// </summary>
public Tlut2FilterGen c3(string c3) => this.SetOption("c3",c3);
}
/// <summary>
/// </summary>
public static class Tlut2FilterGenExtensions
{
/// <summary>
/// Compute and apply a lookup table from two successive frames.
/// </summary>
public static Tlut2FilterGen Tlut2FilterGen(this ImageMap input0) => new Tlut2FilterGen(input0);
}
}
