namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... smptehdbars       |->V       Generate SMPTE HD color bars.
/// </summary>
public class SmptehdbarsFilterGen : SourceImageFilter
{
internal SmptehdbarsFilterGen(BaseFilterGraph input) : base("smptehdbars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public SmptehdbarsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public SmptehdbarsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public SmptehdbarsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public SmptehdbarsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class SmptehdbarsFilterGenExtensions
{
/// <summary>
/// Generate SMPTE HD color bars.
/// </summary>
public static SmptehdbarsFilterGen SmptehdbarsFilterGen(this BaseFilterGraph input0) => new SmptehdbarsFilterGen(input0);
}
}
