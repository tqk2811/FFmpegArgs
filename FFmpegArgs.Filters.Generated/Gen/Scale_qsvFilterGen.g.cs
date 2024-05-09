namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... scale_qsv         V->V       Quick Sync Video "scaling and format conversion"
/// </summary>
public class Scale_qsvFilterGen : ImageToImageFilter
{
internal Scale_qsvFilterGen(ImageMap input) : base("scale_qsv",input) { AddMapOut(); }
/// <summary>
///  Output video width(0=input video width, -1=keep input video aspect) (default "iw")
/// </summary>
public Scale_qsvFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video height(0=input video height, -1=keep input video aspect) (default "ih")
/// </summary>
public Scale_qsvFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Output pixel format (default "same")
/// </summary>
public Scale_qsvFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  scaling &amp; format conversion mode (mode compute(3), vd(4) and ve(5) are only available on some platforms) (from 0 to 5) (default 0)
/// </summary>
public Scale_qsvFilterGen mode(Scale_qsvFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class Scale_qsvFilterGenExtensions
{
/// <summary>
/// Quick Sync Video "scaling and format conversion"
/// </summary>
public static Scale_qsvFilterGen Scale_qsvFilterGen(this ImageMap input0) => new Scale_qsvFilterGen(input0);
}
/// <summary>
///  scaling &amp; format conversion mode (mode compute(3), vd(4) and ve(5) are only available on some platforms) (from 0 to 5) (default 0)
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
/// <summary>
/// compute         3            ..FV....... compute
/// </summary>
[Name("compute")] compute,
/// <summary>
/// vd              4            ..FV....... vd
/// </summary>
[Name("vd")] vd,
/// <summary>
/// ve              5            ..FV....... ve
/// </summary>
[Name("ve")] ve,
}

}
