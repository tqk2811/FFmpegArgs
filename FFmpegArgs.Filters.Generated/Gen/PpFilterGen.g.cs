namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C pp                V-&gt;V       Filter video using libpostproc.
/// </summary>
public class PpFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal PpFilterGen(ImageMap input) : base("pp",input) { AddMapOut(); }
/// <summary>
///  set postprocess subfilters (default &quot;de&quot;)
/// </summary>
public PpFilterGen subfilters(string subfilters) => this.SetOption("subfilters",subfilters);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Filter video using libpostproc.
/// </summary>
public static PpFilterGen PpFilterGen(this ImageMap input0) => new PpFilterGen(input0);
}
}
