namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... allrgb            |->V       Generate all RGB colors.
/// </summary>
public class AllrgbFilterGen : SourceImageFilter
{
internal AllrgbFilterGen(IFilterGraph input) : base("allrgb",input) { AddMapOut(); }
/// <summary>
///  set video rate (default "25")
/// </summary>
public AllrgbFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public AllrgbFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public AllrgbFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class AllrgbFilterGenExtensions
{
/// <summary>
/// Generate all RGB colors.
/// </summary>
public static AllrgbFilterGen AllrgbFilterGen(this IFilterGraph input0) => new AllrgbFilterGen(input0);
}
}
