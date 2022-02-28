namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... pal75bars         |->V       Generate PAL 75% color bars.
/// </summary>
public class Pal75barsFilterGen : SourceImageFilter
{
internal Pal75barsFilterGen(BaseFilterGraph input) : base("pal75bars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Pal75barsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public Pal75barsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Pal75barsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Pal75barsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class Pal75barsFilterGenExtensions
{
/// <summary>
/// Generate PAL 75% color bars.
/// </summary>
public static Pal75barsFilterGen Pal75barsFilterGen(this BaseFilterGraph input0) => new Pal75barsFilterGen(input0);
}
}
