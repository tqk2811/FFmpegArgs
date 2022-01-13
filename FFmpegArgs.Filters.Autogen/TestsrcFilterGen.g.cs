namespace FFmpegArgs.Filters.Autogens
{
public class TestsrcFilterGen : SourceImageFilter
{
internal TestsrcFilterGen(FilterGraph input) : base("testsrc",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public TestsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public TestsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public TestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public TestsrcFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
/// <summary>
///  set number of decimals to show (from 0 to 17) (default 0)
/// </summary>
public TestsrcFilterGen decimals(int decimals) => this.SetOptionRange("decimals", decimals,0,17);
/// <summary>
///  set number of decimals to show (from 0 to 17) (default 0)
/// </summary>
public TestsrcFilterGen n(int n) => this.SetOptionRange("n", n,0,17);
}
public static class TestsrcFilterGenExtensions
{
/// <summary>
/// Generate test pattern.
/// </summary>
public static TestsrcFilterGen TestsrcFilterGen(this FilterGraph input0) => new TestsrcFilterGen(input0);
/// <summary>
/// Generate test pattern.
/// </summary>
public static TestsrcFilterGen TestsrcFilterGen(this FilterGraph input0,TestsrcFilterGenConfig config)
{
var result = new TestsrcFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.sar != null) result.sar(config.sar);
if(config?.decimals != null) result.decimals(config.decimals.Value);
if(config?.n != null) result.n(config.n.Value);
return result;
}
}
public class TestsrcFilterGenConfig
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
/// <summary>
///  set number of decimals to show (from 0 to 17) (default 0)
/// </summary>
public int? decimals { get; set; }
/// <summary>
///  set number of decimals to show (from 0 to 17) (default 0)
/// </summary>
public int? n { get; set; }
}
}
