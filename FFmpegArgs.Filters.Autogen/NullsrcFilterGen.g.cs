namespace FFmpegArgs.Filters.Autogens
{
public class NullsrcFilterGen : SourceImageFilter
{
internal NullsrcFilterGen(FilterGraph input) : base("nullsrc",input) { AddMapOut(); }
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
public static class NullsrcFilterGenExtensions
{
/// <summary>
/// Null video source, return unprocessed video frames.
/// </summary>
public static NullsrcFilterGen NullsrcFilterGen(this FilterGraph input0) => new NullsrcFilterGen(input0);
/// <summary>
/// Null video source, return unprocessed video frames.
/// </summary>
public static NullsrcFilterGen NullsrcFilterGen(this FilterGraph input0,NullsrcFilterGenConfig config)
{
var result = new NullsrcFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.sar != null) result.sar(config.sar);
return result;
}
}
public class NullsrcFilterGenConfig
{
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Size? size { get; set; }
/// <summary>
///  set video rate (default "25")
/// </summary>
public Rational rate { get; set; }
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public TimeSpan? duration { get; set; }
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Rational sar { get; set; }
}
}
