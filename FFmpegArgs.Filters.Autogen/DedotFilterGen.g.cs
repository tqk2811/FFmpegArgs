namespace FFmpegArgs.Filters.Autogens
{
public class DedotFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal DedotFilterGen(ImageMap input) : base("dedot",input) { AddMapOut(); }
/// <summary>
///  set filtering mode (default dotcrawl+rainbows)
/// </summary>
public DedotFilterGen m(DedotFilterGenM m) => this.SetOption("m", m.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set spatial luma threshold (from 0 to 1) (default 0.079)
/// </summary>
public DedotFilterGen lt(float lt) => this.SetOptionRange("lt", lt,0,1);
/// <summary>
///  set tolerance for temporal luma (from 0 to 1) (default 0.079)
/// </summary>
public DedotFilterGen tl(float tl) => this.SetOptionRange("tl", tl,0,1);
/// <summary>
///  set tolerance for chroma temporal variation (from 0 to 1) (default 0.058)
/// </summary>
public DedotFilterGen tc(float tc) => this.SetOptionRange("tc", tc,0,1);
/// <summary>
///  set temporal chroma threshold (from 0 to 1) (default 0.019)
/// </summary>
public DedotFilterGen ct(float ct) => this.SetOptionRange("ct", ct,0,1);
}
public static class DedotFilterGenExtensions
{
/// <summary>
/// Reduce cross-luminance and cross-color.
/// </summary>
public static DedotFilterGen DedotFilterGen(this ImageMap input0) => new DedotFilterGen(input0);
/// <summary>
/// Reduce cross-luminance and cross-color.
/// </summary>
public static DedotFilterGen DedotFilterGen(this ImageMap input0,DedotFilterGenConfig config)
{
var result = new DedotFilterGen(input0);
if(config?.m != null) result.m(config.m.Value);
if(config?.lt != null) result.lt(config.lt.Value);
if(config?.tl != null) result.tl(config.tl.Value);
if(config?.tc != null) result.tc(config.tc.Value);
if(config?.ct != null) result.ct(config.ct.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class DedotFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set filtering mode (default dotcrawl+rainbows)
/// </summary>
public DedotFilterGenM? m { get; set; }
/// <summary>
///  set spatial luma threshold (from 0 to 1) (default 0.079)
/// </summary>
public float? lt { get; set; }
/// <summary>
///  set tolerance for temporal luma (from 0 to 1) (default 0.079)
/// </summary>
public float? tl { get; set; }
/// <summary>
///  set tolerance for chroma temporal variation (from 0 to 1) (default 0.058)
/// </summary>
public float? tc { get; set; }
/// <summary>
///  set temporal chroma threshold (from 0 to 1) (default 0.019)
/// </summary>
public float? ct { get; set; }
public string TimelineSupport { get; set; }
}
public enum DedotFilterGenM
{
[Name("dotcrawl")] dotcrawl,
[Name("rainbows")] rainbows,
}

}
