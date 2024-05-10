namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... setrange          V->V       Force color range for the output video frame.
/// </summary>
public class SetrangeFilterGen : ImageToImageFilter
{
internal SetrangeFilterGen(ImageMap input) : base("setrange",input) { AddMapOut(); }
/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public SetrangeFilterGen range(SetrangeFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Force color range for the output video frame.
/// </summary>
public static SetrangeFilterGen SetrangeFilterGen(this ImageMap input0) => new SetrangeFilterGen(input0);
}
/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public enum SetrangeFilterGenRange
{
/// <summary>
/// auto            -1           ..FV....... keep the same color range
/// </summary>
[Name("auto")] auto,
/// <summary>
/// unspecified     0            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// unknown         0            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// limited         1            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// tv              1            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// mpeg            1            ..FV.......
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// full            2            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// pc              2            ..FV.......
/// </summary>
[Name("pc")] pc,
/// <summary>
/// jpeg            2            ..FV.......
/// </summary>
[Name("jpeg")] jpeg,
}

}
