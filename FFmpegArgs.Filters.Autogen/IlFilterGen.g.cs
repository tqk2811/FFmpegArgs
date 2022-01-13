namespace FFmpegArgs.Filters.Autogens
{
public class IlFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal IlFilterGen(ImageMap input) : base("il",input) { AddMapOut(); }
/// <summary>
///  select luma mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen luma_mode(IlFilterGenLuma_mode luma_mode) => this.SetOption("luma_mode", luma_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select chroma mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen chroma_mode(IlFilterGenChroma_mode chroma_mode) => this.SetOption("chroma_mode", chroma_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select alpha mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen alpha_mode(IlFilterGenAlpha_mode alpha_mode) => this.SetOption("alpha_mode", alpha_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  swap luma fields (default false)
/// </summary>
public IlFilterGen luma_swap(bool luma_swap) => this.SetOption("luma_swap",luma_swap.ToFFmpegFlag());
/// <summary>
///  swap luma fields (default false)
/// </summary>
public IlFilterGen ls(bool ls) => this.SetOption("ls",ls.ToFFmpegFlag());
/// <summary>
///  swap chroma fields (default false)
/// </summary>
public IlFilterGen chroma_swap(bool chroma_swap) => this.SetOption("chroma_swap",chroma_swap.ToFFmpegFlag());
/// <summary>
///  swap chroma fields (default false)
/// </summary>
public IlFilterGen cs(bool cs) => this.SetOption("cs",cs.ToFFmpegFlag());
/// <summary>
///  swap alpha fields (default false)
/// </summary>
public IlFilterGen alpha_swap(bool alpha_swap) => this.SetOption("alpha_swap",alpha_swap.ToFFmpegFlag());
/// <summary>
///  swap alpha fields (default false)
/// </summary>
public IlFilterGen _as(bool _as) => this.SetOption("as",_as.ToFFmpegFlag());
}
public static class IlFilterGenExtensions
{
/// <summary>
/// Deinterleave or interleave fields.
/// </summary>
public static IlFilterGen IlFilterGen(this ImageMap input0) => new IlFilterGen(input0);
/// <summary>
/// Deinterleave or interleave fields.
/// </summary>
public static IlFilterGen IlFilterGen(this ImageMap input0,IlFilterGenConfig config)
{
var result = new IlFilterGen(input0);
if(config?.luma_mode != null) result.luma_mode(config.luma_mode.Value);
if(config?.chroma_mode != null) result.chroma_mode(config.chroma_mode.Value);
if(config?.alpha_mode != null) result.alpha_mode(config.alpha_mode.Value);
if(config?.luma_swap != null) result.luma_swap(config.luma_swap.Value);
if(config?.ls != null) result.ls(config.ls.Value);
if(config?.chroma_swap != null) result.chroma_swap(config.chroma_swap.Value);
if(config?.cs != null) result.cs(config.cs.Value);
if(config?.alpha_swap != null) result.alpha_swap(config.alpha_swap.Value);
if(config?._as != null) result._as(config._as.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class IlFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  select luma mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGenLuma_mode? luma_mode { get; set; }
/// <summary>
///  select chroma mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGenChroma_mode? chroma_mode { get; set; }
/// <summary>
///  select alpha mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGenAlpha_mode? alpha_mode { get; set; }
/// <summary>
///  swap luma fields (default false)
/// </summary>
public bool? luma_swap { get; set; }
/// <summary>
///  swap luma fields (default false)
/// </summary>
public bool? ls { get; set; }
/// <summary>
///  swap chroma fields (default false)
/// </summary>
public bool? chroma_swap { get; set; }
/// <summary>
///  swap chroma fields (default false)
/// </summary>
public bool? cs { get; set; }
/// <summary>
///  swap alpha fields (default false)
/// </summary>
public bool? alpha_swap { get; set; }
/// <summary>
///  swap alpha fields (default false)
/// </summary>
public bool? _as { get; set; }
public string TimelineSupport { get; set; }
}
public enum IlFilterGenLuma_mode
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

public enum IlFilterGenChroma_mode
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

public enum IlFilterGenAlpha_mode
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

}
