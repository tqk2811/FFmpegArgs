namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... nullsrc           |->V       Null video source, return unprocessed video frames.
/// </summary>
public class NullsrcFilterGen : SourceImageFilter
{
internal NullsrcFilterGen(IFilterGraph input) : base("nullsrc",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public NullsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public NullsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public NullsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public NullsrcFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class NullsrcFilterGenExtensions
{
/// <summary>
/// Null video source, return unprocessed video frames.
/// </summary>
public static NullsrcFilterGen NullsrcFilterGen(this IFilterGraph input0) => new NullsrcFilterGen(input0);
}
}
