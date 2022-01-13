namespace FFmpegArgs.Filters.Autogens
{
public class SetsarFilterGen : ImageToImageFilter
{
internal SetsarFilterGen(ImageMap input) : base("setsar",input) { AddMapOut(); }
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public SetsarFilterGen sar(string sar) => this.SetOption("sar",sar);
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public SetsarFilterGen ratio(string ratio) => this.SetOption("ratio",ratio);
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public SetsarFilterGen r(string r) => this.SetOption("r",r);
/// <summary>
///  set max value for nominator or denominator in the ratio (from 1 to INT_MAX) (default 100)
/// </summary>
public SetsarFilterGen max(int max) => this.SetOptionRange("max", max,1,INT_MAX);
}
public static class SetsarFilterGenExtensions
{
/// <summary>
/// Set the pixel sample aspect ratio.
/// </summary>
public static SetsarFilterGen SetsarFilterGen(this ImageMap input0) => new SetsarFilterGen(input0);
/// <summary>
/// Set the pixel sample aspect ratio.
/// </summary>
public static SetsarFilterGen SetsarFilterGen(this ImageMap input0,SetsarFilterGenConfig config)
{
var result = new SetsarFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.sar)) result.sar(config.sar);
if(!string.IsNullOrWhiteSpace(config?.ratio)) result.ratio(config.ratio);
if(!string.IsNullOrWhiteSpace(config?.r)) result.r(config.r);
if(config?.max != null) result.max(config.max.Value);
return result;
}
}
public class SetsarFilterGenConfig
{
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public string sar { get; set; }
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public string ratio { get; set; }
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public string r { get; set; }
/// <summary>
///  set max value for nominator or denominator in the ratio (from 1 to INT_MAX) (default 100)
/// </summary>
public int? max { get; set; }
}
}
