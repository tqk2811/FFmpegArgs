namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... format            V->V       Convert the input video to one of the specified pixel formats.
/// </summary>
public class FormatFilterGen : ImageToImageFilter
{
internal FormatFilterGen(ImageMap input) : base("format",input) { AddMapOut(); }
/// <summary>
///  A '|'-separated list of pixel formats
/// </summary>
public FormatFilterGen pix_fmts(string pix_fmts) => this.SetOption("pix_fmts",pix_fmts);
}
/// <summary>
/// </summary>
public static class FormatFilterGenExtensions
{
/// <summary>
/// Convert the input video to one of the specified pixel formats.
/// </summary>
public static FormatFilterGen FormatFilterGen(this ImageMap input0) => new FormatFilterGen(input0);
}
}
