namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... setsar            V->V       Set the pixel sample aspect ratio.
/// </summary>
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
/// <summary>
/// </summary>
public static class SetsarFilterGenExtensions
{
/// <summary>
/// Set the pixel sample aspect ratio.
/// </summary>
public static SetsarFilterGen SetsarFilterGen(this ImageMap input0) => new SetsarFilterGen(input0);
}
}
