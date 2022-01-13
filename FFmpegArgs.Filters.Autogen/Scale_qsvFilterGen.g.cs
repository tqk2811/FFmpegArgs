namespace FFmpegArgs.Filters.Autogens
{
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
public static class Scale_qsvFilterGenExtensions
{
/// <summary>
/// QuickSync video scaling and format conversion
/// </summary>
public static Scale_qsvFilterGen Scale_qsvFilterGen(this ImageMap input0) => new Scale_qsvFilterGen(input0);
/// <summary>
/// QuickSync video scaling and format conversion
/// </summary>
public static Scale_qsvFilterGen Scale_qsvFilterGen(this ImageMap input0,Scale_qsvFilterGenConfig config)
{
var result = new Scale_qsvFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.w)) result.w(config.w);
if(!string.IsNullOrWhiteSpace(config?.h)) result.h(config.h);
if(!string.IsNullOrWhiteSpace(config?.format)) result.format(config.format);
if(config?.mode != null) result.mode(config.mode.Value);
return result;
}
}
public class Scale_qsvFilterGenConfig
{
/// <summary>
///  Output video width (default "iw")
/// </summary>
public string w { get; set; }
/// <summary>
///  Output video height (default "ih")
/// </summary>
public string h { get; set; }
/// <summary>
///  Output pixel format (default "same")
/// </summary>
public string format { get; set; }
/// <summary>
///  set scaling mode (from 0 to 2) (default 0)
/// </summary>
public Scale_qsvFilterGenMode? mode { get; set; }
}
public enum Scale_qsvFilterGenMode
{
[Name("low_power")] low_power,
[Name("hq")] hq,
}

}
