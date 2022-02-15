namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// .S. weave             V->V       Weave input video fields into frames.
/// </summary>
public class WeaveFilterGen : ImageToImageFilter,ISliceThreading
{
internal WeaveFilterGen(ImageMap input) : base("weave",input) { AddMapOut(); }
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public WeaveFilterGen first_field(WeaveFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class WeaveFilterGenExtensions
{
/// <summary>
/// Weave input video fields into frames.
/// </summary>
public static WeaveFilterGen WeaveFilterGen(this ImageMap input0) => new WeaveFilterGen(input0);
}
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public enum WeaveFilterGenFirst_field
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
