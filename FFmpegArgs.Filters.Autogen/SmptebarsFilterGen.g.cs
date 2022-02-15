namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... smptebars         |->V       Generate SMPTE color bars.
/// </summary>
public class SmptebarsFilterGen : SourceImageFilter
{
internal SmptebarsFilterGen(IFilterGraph input) : base("smptebars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public SmptebarsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public SmptebarsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public SmptebarsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public SmptebarsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class SmptebarsFilterGenExtensions
{
/// <summary>
/// Generate SMPTE color bars.
/// </summary>
public static SmptebarsFilterGen SmptebarsFilterGen(this IFilterGraph input0) => new SmptebarsFilterGen(input0);
}
}
