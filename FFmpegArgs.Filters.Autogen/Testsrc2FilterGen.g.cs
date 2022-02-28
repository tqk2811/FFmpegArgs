namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... testsrc2          |->V       Generate another test pattern.
/// </summary>
public class Testsrc2FilterGen : SourceImageFilter
{
internal Testsrc2FilterGen(BaseFilterGraph input) : base("testsrc2",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Testsrc2FilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public Testsrc2FilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Testsrc2FilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Testsrc2FilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
/// <summary>
///  set global alpha (opacity) (from 0 to 255) (default 255)
/// </summary>
public Testsrc2FilterGen alpha(int alpha) => this.SetOptionRange("alpha", alpha,0,255);
}
/// <summary>
/// </summary>
public static class Testsrc2FilterGenExtensions
{
/// <summary>
/// Generate another test pattern.
/// </summary>
public static Testsrc2FilterGen Testsrc2FilterGen(this BaseFilterGraph input0) => new Testsrc2FilterGen(input0);
}
}
