namespace FFmpegArgs.Filters.Autogens
{
public class FormatFilterGen : ImageToImageFilter
{
internal FormatFilterGen(ImageMap input) : base("format",input) { AddMapOut(); }
/// <summary>
///  A '|'-separated list of pixel formats
/// </summary>
public FormatFilterGen pix_fmts(string pix_fmts) => this.SetOption("pix_fmts",pix_fmts);
}
public static class FormatFilterGenExtensions
{
/// <summary>
/// Convert the input video to one of the specified pixel formats.
/// </summary>
public static FormatFilterGen FormatFilterGen(this ImageMap input0) => new FormatFilterGen(input0);
/// <summary>
/// Convert the input video to one of the specified pixel formats.
/// </summary>
public static FormatFilterGen FormatFilterGen(this ImageMap input0,FormatFilterGenConfig config)
{
var result = new FormatFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.pix_fmts)) result.pix_fmts(config.pix_fmts);
return result;
}
}
public class FormatFilterGenConfig
{
/// <summary>
///  A '|'-separated list of pixel formats
/// </summary>
public string pix_fmts { get; set; }
}
}
