namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... tinterlace        V->V       Perform temporal field interlacing.
/// </summary>
public class TinterlaceFilterGen : ImageToImageFilter
{
internal TinterlaceFilterGen(ImageMap input) : base("tinterlace",input) { AddMapOut(); }
/// <summary>
///  select interlace mode (from 0 to 7) (default merge)
/// </summary>
public TinterlaceFilterGen mode(TinterlaceFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class TinterlaceFilterGenExtensions
{
/// <summary>
/// Perform temporal field interlacing.
/// </summary>
public static TinterlaceFilterGen TinterlaceFilterGen(this ImageMap input0) => new TinterlaceFilterGen(input0);
}
/// <summary>
///  select interlace mode (from 0 to 7) (default merge)
/// </summary>
public enum TinterlaceFilterGenMode
{
/// <summary>
/// merge           0            ..FV....... merge fields
/// </summary>
[Name("merge")] merge,
/// <summary>
/// drop_even       1            ..FV....... drop even fields
/// </summary>
[Name("drop_even")] drop_even,
/// <summary>
/// drop_odd        2            ..FV....... drop odd fields
/// </summary>
[Name("drop_odd")] drop_odd,
/// <summary>
/// pad             3            ..FV....... pad alternate lines with black
/// </summary>
[Name("pad")] pad,
/// <summary>
/// interleave_top  4            ..FV....... interleave top and bottom fields
/// </summary>
[Name("interleave_top")] interleave_top,
/// <summary>
/// interleave_bottom 5            ..FV....... interleave bottom and top fields
/// </summary>
[Name("interleave_bottom")] interleave_bottom,
/// <summary>
/// interlacex2     6            ..FV....... interlace fields from two consecutive frames
/// </summary>
[Name("interlacex2")] interlacex2,
/// <summary>
/// mergex2         7            ..FV....... merge fields keeping same frame rate
/// </summary>
[Name("mergex2")] mergex2,
}

}
