namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... settb             V->V       Set timebase for the video output link.
/// </summary>
public class SettbFilterGen : ImageToImageFilter
{
internal SettbFilterGen(ImageMap input) : base("settb",input) { AddMapOut(); }
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public SettbFilterGen expr(string expr) => this.SetOption("expr",expr);
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public SettbFilterGen tb(string tb) => this.SetOption("tb",tb);
}
/// <summary>
/// </summary>
public static class SettbFilterGenExtensions
{
/// <summary>
/// Set timebase for the video output link.
/// </summary>
public static SettbFilterGen SettbFilterGen(this ImageMap input0) => new SettbFilterGen(input0);
}
}
