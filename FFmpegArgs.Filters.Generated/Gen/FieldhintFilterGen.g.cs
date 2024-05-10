namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... fieldhint         V->V       Field matching using hints.
/// </summary>
public class FieldhintFilterGen : ImageToImageFilter
{
internal FieldhintFilterGen(ImageMap input) : base("fieldhint",input) { AddMapOut(); }
/// <summary>
///  set hint file
/// </summary>
public FieldhintFilterGen hint(string hint) => this.SetOption("hint",hint);
/// <summary>
///  set hint mode (from 0 to 2) (default absolute)
/// </summary>
public FieldhintFilterGen mode(FieldhintFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Field matching using hints.
/// </summary>
public static FieldhintFilterGen FieldhintFilterGen(this ImageMap input0) => new FieldhintFilterGen(input0);
}
/// <summary>
///  set hint mode (from 0 to 2) (default absolute)
/// </summary>
public enum FieldhintFilterGenMode
{
/// <summary>
/// absolute        0            ..FV.......
/// </summary>
[Name("absolute")] absolute,
/// <summary>
/// relative        1            ..FV.......
/// </summary>
[Name("relative")] relative,
/// <summary>
/// pattern         2            ..FV.......
/// </summary>
[Name("pattern")] pattern,
}

}
