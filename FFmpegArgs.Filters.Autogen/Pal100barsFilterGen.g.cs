namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... pal100bars        |->V       Generate PAL 100% color bars.
/// </summary>
public class Pal100barsFilterGen : SourceImageFilter
{
internal Pal100barsFilterGen(IFilterGraph input) : base("pal100bars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Pal100barsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public Pal100barsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Pal100barsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Pal100barsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class Pal100barsFilterGenExtensions
{
/// <summary>
/// Generate PAL 100% color bars.
/// </summary>
public static Pal100barsFilterGen Pal100barsFilterGen(this IFilterGraph input0) => new Pal100barsFilterGen(input0);
}
}
