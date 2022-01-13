namespace FFmpegArgs.Filters.Autogens
{
public class BlackframeFilterGen : ImageToImageFilter
{
internal BlackframeFilterGen(ImageMap input) : base("blackframe",input) { AddMapOut(); }
/// <summary>
///  percentage of the pixels that have to be below the threshold for the frame to be considered black (from 0 to 100) (default 98)
/// </summary>
public BlackframeFilterGen amount(int amount) => this.SetOptionRange("amount", amount,0,100);
/// <summary>
///  threshold below which a pixel value is considered black (from 0 to 255) (default 32)
/// </summary>
public BlackframeFilterGen threshold(int threshold) => this.SetOptionRange("threshold", threshold,0,255);
}
public static class BlackframeFilterGenExtensions
{
/// <summary>
/// Detect frames that are (almost) black.
/// </summary>
public static BlackframeFilterGen BlackframeFilterGen(this ImageMap input0) => new BlackframeFilterGen(input0);
/// <summary>
/// Detect frames that are (almost) black.
/// </summary>
public static BlackframeFilterGen BlackframeFilterGen(this ImageMap input0,BlackframeFilterGenConfig config)
{
var result = new BlackframeFilterGen(input0);
if(config?.amount != null) result.amount(config.amount.Value);
if(config?.threshold != null) result.threshold(config.threshold.Value);
return result;
}
}
public class BlackframeFilterGenConfig
{
/// <summary>
///  percentage of the pixels that have to be below the threshold for the frame to be considered black (from 0 to 100) (default 98)
/// </summary>
public int? amount { get; set; }
/// <summary>
///  threshold below which a pixel value is considered black (from 0 to 255) (default 32)
/// </summary>
public int? threshold { get; set; }
}
}
