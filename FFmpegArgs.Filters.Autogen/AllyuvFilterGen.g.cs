namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... allyuv            |->V       Generate all yuv colors.
/// </summary>
public class AllyuvFilterGen : SourceImageFilter
{
internal AllyuvFilterGen(IFilterGraph input) : base("allyuv",input) { AddMapOut(); }
/// <summary>
///  set video rate (default "25")
/// </summary>
public AllyuvFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public AllyuvFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public AllyuvFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class AllyuvFilterGenExtensions
{
/// <summary>
/// Generate all yuv colors.
/// </summary>
public static AllyuvFilterGen AllyuvFilterGen(this IFilterGraph input0) => new AllyuvFilterGen(input0);
}
}
