namespace FFmpegArgs.Filters.Autogens
{
public class SmartblurFilterGen : ImageToImageFilter,ITimelineSupport
{
internal SmartblurFilterGen(ImageMap input) : base("smartblur",input) { AddMapOut(); }
/// <summary>
///  set luma radius (from 0.1 to 5) (default 1)
/// </summary>
public SmartblurFilterGen luma_radius(float luma_radius) => this.SetOptionRange("luma_radius", luma_radius,0.1,5);
/// <summary>
///  set luma radius (from 0.1 to 5) (default 1)
/// </summary>
public SmartblurFilterGen lr(float lr) => this.SetOptionRange("lr", lr,0.1,5);
/// <summary>
///  set luma strength (from -1 to 1) (default 1)
/// </summary>
public SmartblurFilterGen luma_strength(float luma_strength) => this.SetOptionRange("luma_strength", luma_strength,-1,1);
/// <summary>
///  set luma strength (from -1 to 1) (default 1)
/// </summary>
public SmartblurFilterGen ls(float ls) => this.SetOptionRange("ls", ls,-1,1);
/// <summary>
///  set luma threshold (from -30 to 30) (default 0)
/// </summary>
public SmartblurFilterGen luma_threshold(int luma_threshold) => this.SetOptionRange("luma_threshold", luma_threshold,-30,30);
/// <summary>
///  set luma threshold (from -30 to 30) (default 0)
/// </summary>
public SmartblurFilterGen lt(int lt) => this.SetOptionRange("lt", lt,-30,30);
/// <summary>
///  set chroma radius (from -0.9 to 5) (default -0.9)
/// </summary>
public SmartblurFilterGen chroma_radius(float chroma_radius) => this.SetOptionRange("chroma_radius", chroma_radius,-0.9,5);
/// <summary>
///  set chroma radius (from -0.9 to 5) (default -0.9)
/// </summary>
public SmartblurFilterGen cr(float cr) => this.SetOptionRange("cr", cr,-0.9,5);
/// <summary>
///  set chroma strength (from -2 to 1) (default -2)
/// </summary>
public SmartblurFilterGen chroma_strength(float chroma_strength) => this.SetOptionRange("chroma_strength", chroma_strength,-2,1);
/// <summary>
///  set chroma strength (from -2 to 1) (default -2)
/// </summary>
public SmartblurFilterGen cs(float cs) => this.SetOptionRange("cs", cs,-2,1);
/// <summary>
///  set chroma threshold (from -31 to 30) (default -31)
/// </summary>
public SmartblurFilterGen chroma_threshold(int chroma_threshold) => this.SetOptionRange("chroma_threshold", chroma_threshold,-31,30);
/// <summary>
///  set chroma threshold (from -31 to 30) (default -31)
/// </summary>
public SmartblurFilterGen ct(int ct) => this.SetOptionRange("ct", ct,-31,30);
}
public static class SmartblurFilterGenExtensions
{
/// <summary>
/// Blur the input video without impacting the outlines.
/// </summary>
public static SmartblurFilterGen SmartblurFilterGen(this ImageMap input0) => new SmartblurFilterGen(input0);
/// <summary>
/// Blur the input video without impacting the outlines.
/// </summary>
public static SmartblurFilterGen SmartblurFilterGen(this ImageMap input0,SmartblurFilterGenConfig config)
{
var result = new SmartblurFilterGen(input0);
if(config?.luma_radius != null) result.luma_radius(config.luma_radius.Value);
if(config?.lr != null) result.lr(config.lr.Value);
if(config?.luma_strength != null) result.luma_strength(config.luma_strength.Value);
if(config?.ls != null) result.ls(config.ls.Value);
if(config?.luma_threshold != null) result.luma_threshold(config.luma_threshold.Value);
if(config?.lt != null) result.lt(config.lt.Value);
if(config?.chroma_radius != null) result.chroma_radius(config.chroma_radius.Value);
if(config?.cr != null) result.cr(config.cr.Value);
if(config?.chroma_strength != null) result.chroma_strength(config.chroma_strength.Value);
if(config?.cs != null) result.cs(config.cs.Value);
if(config?.chroma_threshold != null) result.chroma_threshold(config.chroma_threshold.Value);
if(config?.ct != null) result.ct(config.ct.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class SmartblurFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set luma radius (from 0.1 to 5) (default 1)
/// </summary>
public float? luma_radius { get; set; }
/// <summary>
///  set luma radius (from 0.1 to 5) (default 1)
/// </summary>
public float? lr { get; set; }
/// <summary>
///  set luma strength (from -1 to 1) (default 1)
/// </summary>
public float? luma_strength { get; set; }
/// <summary>
///  set luma strength (from -1 to 1) (default 1)
/// </summary>
public float? ls { get; set; }
/// <summary>
///  set luma threshold (from -30 to 30) (default 0)
/// </summary>
public int? luma_threshold { get; set; }
/// <summary>
///  set luma threshold (from -30 to 30) (default 0)
/// </summary>
public int? lt { get; set; }
/// <summary>
///  set chroma radius (from -0.9 to 5) (default -0.9)
/// </summary>
public float? chroma_radius { get; set; }
/// <summary>
///  set chroma radius (from -0.9 to 5) (default -0.9)
/// </summary>
public float? cr { get; set; }
/// <summary>
///  set chroma strength (from -2 to 1) (default -2)
/// </summary>
public float? chroma_strength { get; set; }
/// <summary>
///  set chroma strength (from -2 to 1) (default -2)
/// </summary>
public float? cs { get; set; }
/// <summary>
///  set chroma threshold (from -31 to 30) (default -31)
/// </summary>
public int? chroma_threshold { get; set; }
/// <summary>
///  set chroma threshold (from -31 to 30) (default -31)
/// </summary>
public int? ct { get; set; }
public string TimelineSupport { get; set; }
}
}
