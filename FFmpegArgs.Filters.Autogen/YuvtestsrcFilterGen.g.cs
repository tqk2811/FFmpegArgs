namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... yuvtestsrc        |->V       Generate YUV test pattern.
/// </summary>
public class YuvtestsrcFilterGen : SourceImageFilter
{
internal YuvtestsrcFilterGen(BaseFilterGraph input) : base("yuvtestsrc",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public YuvtestsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public YuvtestsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public YuvtestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public YuvtestsrcFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class YuvtestsrcFilterGenExtensions
{
/// <summary>
/// Generate YUV test pattern.
/// </summary>
public static YuvtestsrcFilterGen YuvtestsrcFilterGen(this BaseFilterGraph input0) => new YuvtestsrcFilterGen(input0);
}
}
