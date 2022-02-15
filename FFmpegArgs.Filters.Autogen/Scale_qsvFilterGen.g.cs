namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... scale_qsv         V->V       QuickSync video scaling and format conversion
/// </summary>
public class Scale_qsvFilterGen : ImageToImageFilter
{
internal Scale_qsvFilterGen(ImageMap input) : base("scale_qsv",input) { AddMapOut(); }
/// <summary>
///  Output video width (default "iw")
/// </summary>
public Scale_qsvFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video height (default "ih")
/// </summary>
public Scale_qsvFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Output pixel format (default "same")
/// </summary>
public Scale_qsvFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  set scaling mode (from 0 to 2) (default 0)
/// </summary>
public Scale_qsvFilterGen mode(Scale_qsvFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class Scale_qsvFilterGenExtensions
{
/// <summary>
/// QuickSync video scaling and format conversion
/// </summary>
public static Scale_qsvFilterGen Scale_qsvFilterGen(this ImageMap input0) => new Scale_qsvFilterGen(input0);
}
/// <summary>
///  set scaling mode (from 0 to 2) (default 0)
/// </summary>
public enum Scale_qsvFilterGenMode
{
/// <summary>
/// low_power       1            ..FV....... low power mode
/// </summary>
[Name("low_power")] low_power,
/// <summary>
/// hq              2            ..FV....... high quality mode
/// </summary>
[Name("hq")] hq,
}

}
