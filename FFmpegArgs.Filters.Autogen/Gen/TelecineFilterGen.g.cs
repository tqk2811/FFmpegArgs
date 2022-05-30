namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... telecine          V->V       Apply a telecine pattern.
/// </summary>
public class TelecineFilterGen : ImageToImageFilter
{
internal TelecineFilterGen(ImageMap input) : base("telecine",input) { AddMapOut(); }
/// <summary>
///  select first field (from 0 to 1) (default top)
/// </summary>
public TelecineFilterGen first_field(TelecineFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  pattern that describe for how many fields a frame is to be displayed (default "23")
/// </summary>
public TelecineFilterGen pattern(string pattern) => this.SetOption("pattern",pattern);
}
/// <summary>
/// </summary>
public static class TelecineFilterGenExtensions
{
/// <summary>
/// Apply a telecine pattern.
/// </summary>
public static TelecineFilterGen TelecineFilterGen(this ImageMap input0) => new TelecineFilterGen(input0);
}
/// <summary>
///  select first field (from 0 to 1) (default top)
/// </summary>
public enum TelecineFilterGenFirst_field
{
/// <summary>
/// top             0            ..FV....... select top field first
/// </summary>
[Name("top")] top,
/// <summary>
/// t               0            ..FV....... select top field first
/// </summary>
[Name("t")] t,
/// <summary>
/// bottom          1            ..FV....... select bottom field first
/// </summary>
[Name("bottom")] bottom,
/// <summary>
/// b               1            ..FV....... select bottom field first
/// </summary>
[Name("b")] b,
}

}
