namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... noformat          V->V       Force libavfilter not to use any of the specified pixel formats for the input to the next filter.
/// </summary>
public class NoformatFilterGen : ImageToImageFilter
{
internal NoformatFilterGen(ImageMap input) : base("noformat",input) { AddMapOut(); }
/// <summary>
///  A '|'-separated list of pixel formats
/// </summary>
public NoformatFilterGen pix_fmts(string pix_fmts) => this.SetOption("pix_fmts",pix_fmts);
}
/// <summary>
/// </summary>
public static class NoformatFilterGenExtensions
{
/// <summary>
/// Force libavfilter not to use any of the specified pixel formats for the input to the next filter.
/// </summary>
public static NoformatFilterGen NoformatFilterGen(this ImageMap input0) => new NoformatFilterGen(input0);
}
}
