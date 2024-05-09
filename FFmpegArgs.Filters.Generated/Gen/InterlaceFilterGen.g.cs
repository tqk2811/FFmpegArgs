namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... interlace         V->V       Convert progressive video into interlaced.
/// </summary>
public class InterlaceFilterGen : ImageToImageFilter
{
internal InterlaceFilterGen(ImageMap input) : base("interlace",input) { AddMapOut(); }
/// <summary>
///  scanning mode (from 0 to 1) (default tff)
/// </summary>
public InterlaceFilterGen scan(InterlaceFilterGenScan scan) => this.SetOption("scan", scan.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set vertical low-pass filter (from 0 to 2) (default linear)
/// </summary>
public InterlaceFilterGen lowpass(InterlaceFilterGenLowpass lowpass) => this.SetOption("lowpass", lowpass.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class InterlaceFilterGenExtensions
{
/// <summary>
/// Convert progressive video into interlaced.
/// </summary>
public static InterlaceFilterGen InterlaceFilterGen(this ImageMap input0) => new InterlaceFilterGen(input0);
}
/// <summary>
///  scanning mode (from 0 to 1) (default tff)
/// </summary>
public enum InterlaceFilterGenScan
{
/// <summary>
/// tff             0            ..FV....... top field first
/// </summary>
[Name("tff")] tff,
/// <summary>
/// bff             1            ..FV....... bottom field first
/// </summary>
[Name("bff")] bff,
}

/// <summary>
///  set vertical low-pass filter (from 0 to 2) (default linear)
/// </summary>
public enum InterlaceFilterGenLowpass
{
/// <summary>
/// off             0            ..FV....... disable vertical low-pass filter
/// </summary>
[Name("off")] off,
/// <summary>
/// linear          1            ..FV....... linear vertical low-pass filter
/// </summary>
[Name("linear")] linear,
/// <summary>
/// complex         2            ..FV....... complex vertical low-pass filter
/// </summary>
[Name("complex")] complex,
}

}
