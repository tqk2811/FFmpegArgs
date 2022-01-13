namespace FFmpegArgs.Filters.Autogens
{
public class FreezeframesFilterGen : ImageToImageFilter
{
internal FreezeframesFilterGen(params ImageMap[] inputs) : base("freezeframes",inputs) { AddMapOut(); }
/// <summary>
///  set first frame to freeze (from 0 to I64_MAX) (default 0)
/// </summary>
public FreezeframesFilterGen first(long first) => this.SetOptionRange("first", first,0,I64_MAX);
/// <summary>
///  set last frame to freeze (from 0 to I64_MAX) (default 0)
/// </summary>
public FreezeframesFilterGen last(long last) => this.SetOptionRange("last", last,0,I64_MAX);
/// <summary>
///  set frame to replace (from 0 to I64_MAX) (default 0)
/// </summary>
public FreezeframesFilterGen replace(long replace) => this.SetOptionRange("replace", replace,0,I64_MAX);
}
public static class FreezeframesFilterGenExtensions
{
/// <summary>
/// Freeze video frames.
/// </summary>
public static FreezeframesFilterGen FreezeframesFilterGen(this ImageMap input0, ImageMap input1) => new FreezeframesFilterGen(input0, input1);
/// <summary>
/// Freeze video frames.
/// </summary>
public static FreezeframesFilterGen FreezeframesFilterGen(this ImageMap input0, ImageMap input1,FreezeframesFilterGenConfig config)
{
var result = new FreezeframesFilterGen(input0, input1);
if(config?.first != null) result.first(config.first.Value);
if(config?.last != null) result.last(config.last.Value);
if(config?.replace != null) result.replace(config.replace.Value);
return result;
}
}
public class FreezeframesFilterGenConfig
{
/// <summary>
///  set first frame to freeze (from 0 to I64_MAX) (default 0)
/// </summary>
public long? first { get; set; }
/// <summary>
///  set last frame to freeze (from 0 to I64_MAX) (default 0)
/// </summary>
public long? last { get; set; }
/// <summary>
///  set frame to replace (from 0 to I64_MAX) (default 0)
/// </summary>
public long? replace { get; set; }
}
}
