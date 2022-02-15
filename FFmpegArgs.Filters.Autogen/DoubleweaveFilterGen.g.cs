namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// .S. doubleweave       V->V       Weave input video fields into double number of frames.
/// </summary>
public class DoubleweaveFilterGen : ImageToImageFilter,ISliceThreading
{
internal DoubleweaveFilterGen(ImageMap input) : base("doubleweave",input) { AddMapOut(); }
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public DoubleweaveFilterGen first_field(DoubleweaveFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class DoubleweaveFilterGenExtensions
{
/// <summary>
/// Weave input video fields into double number of frames.
/// </summary>
public static DoubleweaveFilterGen DoubleweaveFilterGen(this ImageMap input0) => new DoubleweaveFilterGen(input0);
}
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public enum DoubleweaveFilterGenFirst_field
{
/// <summary>
/// top             0            ..FV....... set top field first
/// </summary>
[Name("top")] top,
/// <summary>
/// t               0            ..FV....... set top field first
/// </summary>
[Name("t")] t,
/// <summary>
/// bottom          1            ..FV....... set bottom field first
/// </summary>
[Name("bottom")] bottom,
/// <summary>
/// b               1            ..FV....... set bottom field first
/// </summary>
[Name("b")] b,
}

}
