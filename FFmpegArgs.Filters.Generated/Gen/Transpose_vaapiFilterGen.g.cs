namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... transpose_vaapi   V-&gt;V       VAAPI VPP for transpose
/// </summary>
public class Transpose_vaapiFilterGen : ImageToImageFilter
{
internal Transpose_vaapiFilterGen(ImageMap input) : base("transpose_vaapi",input) { AddMapOut(); }
/// <summary>
///  set transpose direction (from 0 to 6) (default cclock_flip)
/// </summary>
public Transpose_vaapiFilterGen dir(Transpose_vaapiFilterGenDir dir) => this.SetOption("dir", dir.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
/// </summary>
public Transpose_vaapiFilterGen passthrough(Transpose_vaapiFilterGenPassthrough passthrough) => this.SetOption("passthrough", passthrough.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// VAAPI VPP for transpose
/// </summary>
public static Transpose_vaapiFilterGen Transpose_vaapiFilterGen(this ImageMap input0) => new Transpose_vaapiFilterGen(input0);
}
/// <summary>
///  set transpose direction (from 0 to 6) (default cclock_flip)
/// </summary>
public enum Transpose_vaapiFilterGenDir
{
/// <summary>
/// cclock_flip     0            ..FV....... rotate counter-clockwise with vertical flip
/// </summary>
[Name("cclock_flip")] cclock_flip,
/// <summary>
/// clock           1            ..FV....... rotate clockwise
/// </summary>
[Name("clock")] clock,
/// <summary>
/// cclock          2            ..FV....... rotate counter-clockwise
/// </summary>
[Name("cclock")] cclock,
/// <summary>
/// clock_flip      3            ..FV....... rotate clockwise with vertical flip
/// </summary>
[Name("clock_flip")] clock_flip,
/// <summary>
/// reversal        4            ..FV....... rotate by half-turn
/// </summary>
[Name("reversal")] reversal,
/// <summary>
/// hflip           5            ..FV....... flip horizontally
/// </summary>
[Name("hflip")] hflip,
/// <summary>
/// vflip           6            ..FV....... flip vertically
/// </summary>
[Name("vflip")] vflip,
}

/// <summary>
///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
/// </summary>
public enum Transpose_vaapiFilterGenPassthrough
{
/// <summary>
/// none            0            ..FV....... always apply transposition
/// </summary>
[Name("none")] none,
/// <summary>
/// portrait        2            ..FV....... preserve portrait geometry
/// </summary>
[Name("portrait")] portrait,
/// <summary>
/// landscape       1            ..FV....... preserve landscape geometry
/// </summary>
[Name("landscape")] landscape,
}

}
