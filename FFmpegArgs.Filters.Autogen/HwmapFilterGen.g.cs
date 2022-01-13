namespace FFmpegArgs.Filters.Autogens
{
public class HwmapFilterGen : ImageToImageFilter
{
internal HwmapFilterGen(ImageMap input) : base("hwmap",input) { AddMapOut(); }
/// <summary>
///  Frame mapping mode (default read+write)
/// </summary>
public HwmapFilterGen mode(HwmapFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Derive a new device of this type
/// </summary>
public HwmapFilterGen derive_device(string derive_device) => this.SetOption("derive_device",derive_device);
/// <summary>
///  Map in reverse (create and allocate in the sink) (from 0 to 1) (default 0)
/// </summary>
public HwmapFilterGen reverse(int reverse) => this.SetOptionRange("reverse", reverse,0,1);
}
public static class HwmapFilterGenExtensions
{
/// <summary>
/// Map hardware frames
/// </summary>
public static HwmapFilterGen HwmapFilterGen(this ImageMap input0) => new HwmapFilterGen(input0);
/// <summary>
/// Map hardware frames
/// </summary>
public static HwmapFilterGen HwmapFilterGen(this ImageMap input0,HwmapFilterGenConfig config)
{
var result = new HwmapFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(!string.IsNullOrWhiteSpace(config?.derive_device)) result.derive_device(config.derive_device);
if(config?.reverse != null) result.reverse(config.reverse.Value);
return result;
}
}
public class HwmapFilterGenConfig
{
/// <summary>
///  Frame mapping mode (default read+write)
/// </summary>
public HwmapFilterGenMode? mode { get; set; }
/// <summary>
///  Derive a new device of this type
/// </summary>
public string derive_device { get; set; }
/// <summary>
///  Map in reverse (create and allocate in the sink) (from 0 to 1) (default 0)
/// </summary>
public int? reverse { get; set; }
}
public enum HwmapFilterGenMode
{
[Name("read")] read,
[Name("write")] write,
[Name("overwrite")] overwrite,
[Name("direct")] direct,
}

}
