namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C pp                V->V       Filter video using libpostproc.
/// </summary>
public class PpFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal PpFilterGen(ImageMap input) : base("pp",input) { AddMapOut(); }
/// <summary>
///  set postprocess subfilters (default "de")
/// </summary>
public PpFilterGen subfilters(string subfilters) => this.SetOption("subfilters",subfilters);
}
/// <summary>
/// </summary>
public static class PpFilterGenExtensions
{
/// <summary>
/// Filter video using libpostproc.
/// </summary>
public static PpFilterGen PpFilterGen(this ImageMap input0) => new PpFilterGen(input0);
}
}
