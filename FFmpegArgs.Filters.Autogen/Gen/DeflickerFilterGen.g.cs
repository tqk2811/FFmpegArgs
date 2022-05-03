namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... deflicker         V->V       Remove temporal frame luminance variations.
/// </summary>
public class DeflickerFilterGen : ImageToImageFilter
{
internal DeflickerFilterGen(ImageMap input) : base("deflicker",input) { AddMapOut(); }
/// <summary>
///  set how many frames to use (from 2 to 129) (default 5)
/// </summary>
public DeflickerFilterGen size(int size) => this.SetOptionRange("size", size,2,129);
/// <summary>
///  set how to smooth luminance (from 0 to 6) (default am)
/// </summary>
public DeflickerFilterGen mode(DeflickerFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  leave frames unchanged (default false)
/// </summary>
public DeflickerFilterGen bypass(bool bypass) => this.SetOption("bypass",bypass.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class DeflickerFilterGenExtensions
{
/// <summary>
/// Remove temporal frame luminance variations.
/// </summary>
public static DeflickerFilterGen DeflickerFilterGen(this ImageMap input0) => new DeflickerFilterGen(input0);
}
/// <summary>
///  set how to smooth luminance (from 0 to 6) (default am)
/// </summary>
public enum DeflickerFilterGenMode
{
/// <summary>
/// am              0            ..FV....... arithmetic mean
/// </summary>
[Name("am")] am,
/// <summary>
/// gm              1            ..FV....... geometric mean
/// </summary>
[Name("gm")] gm,
/// <summary>
/// hm              2            ..FV....... harmonic mean
/// </summary>
[Name("hm")] hm,
/// <summary>
/// qm              3            ..FV....... quadratic mean
/// </summary>
[Name("qm")] qm,
/// <summary>
/// cm              4            ..FV....... cubic mean
/// </summary>
[Name("cm")] cm,
/// <summary>
/// pm              5            ..FV....... power mean
/// </summary>
[Name("pm")] pm,
/// <summary>
/// median          6            ..FV....... median
/// </summary>
[Name("median")] median,
}

}
