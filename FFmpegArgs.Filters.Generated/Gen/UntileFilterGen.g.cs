namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... untile            V->V       Untile a frame into a sequence of frames.
/// </summary>
public class UntileFilterGen : ImageToImageFilter
{
internal UntileFilterGen(ImageMap input) : base("untile",input) { AddMapOut(); }
/// <summary>
///  set grid size (default "6x5")
/// </summary>
public UntileFilterGen layout(Size layout) => this.SetOption("layout",$"{layout.Width}x{layout.Height}");
}
/// <summary>
/// </summary>
public static class UntileFilterGenExtensions
{
/// <summary>
/// Untile a frame into a sequence of frames.
/// </summary>
public static UntileFilterGen UntileFilterGen(this ImageMap input0) => new UntileFilterGen(input0);
}
}
