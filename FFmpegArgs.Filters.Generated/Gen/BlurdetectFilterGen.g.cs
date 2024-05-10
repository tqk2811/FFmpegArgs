namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... blurdetect        V->V       Blurdetect filter.
/// </summary>
public class BlurdetectFilterGen : ImageToImageFilter
{
internal BlurdetectFilterGen(ImageMap input) : base("blurdetect",input) { AddMapOut(); }
/// <summary>
///  set high threshold (from 0 to 1) (default 0.117647)
/// </summary>
public BlurdetectFilterGen high(float high) => this.SetOptionRange("high", high,0,1);
/// <summary>
///  set low threshold (from 0 to 1) (default 0.0588235)
/// </summary>
public BlurdetectFilterGen low(float low) => this.SetOptionRange("low", low,0,1);
/// <summary>
///  search radius for maxima detection (from 1 to 100) (default 50)
/// </summary>
public BlurdetectFilterGen radius(int radius) => this.SetOptionRange("radius", radius,1,100);
/// <summary>
///  block pooling threshold when calculating blurriness (from 1 to 100) (default 80)
/// </summary>
public BlurdetectFilterGen block_pct(int block_pct) => this.SetOptionRange("block_pct", block_pct,1,100);
/// <summary>
///  block size for block-based abbreviation of blurriness (from -1 to INT_MAX) (default -1)
/// </summary>
public BlurdetectFilterGen block_width(int block_width) => this.SetOptionRange("block_width", block_width,-1,INT_MAX);
/// <summary>
///  block size for block-based abbreviation of blurriness (from -1 to INT_MAX) (default -1)
/// </summary>
public BlurdetectFilterGen block_height(int block_height) => this.SetOptionRange("block_height", block_height,-1,INT_MAX);
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public BlurdetectFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Blurdetect filter.
/// </summary>
public static BlurdetectFilterGen BlurdetectFilterGen(this ImageMap input0) => new BlurdetectFilterGen(input0);
}
}
