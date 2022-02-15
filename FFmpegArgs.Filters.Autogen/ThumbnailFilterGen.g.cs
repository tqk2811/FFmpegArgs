namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. thumbnail         V->V       Select the most representative frame in a given sequence of consecutive frames.
/// </summary>
public class ThumbnailFilterGen : ImageToImageFilter,ITimelineSupport
{
internal ThumbnailFilterGen(ImageMap input) : base("thumbnail",input) { AddMapOut(); }
/// <summary>
///  set the frames batch size (from 2 to INT_MAX) (default 100)
/// </summary>
public ThumbnailFilterGen n(int n) => this.SetOptionRange("n", n,2,INT_MAX);
}
/// <summary>
/// </summary>
public static class ThumbnailFilterGenExtensions
{
/// <summary>
/// Select the most representative frame in a given sequence of consecutive frames.
/// </summary>
public static ThumbnailFilterGen ThumbnailFilterGen(this ImageMap input0) => new ThumbnailFilterGen(input0);
}
}
