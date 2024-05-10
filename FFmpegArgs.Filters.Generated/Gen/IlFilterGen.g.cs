namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C il                V->V       Deinterleave or interleave fields.
/// </summary>
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
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Deinterleave or interleave fields.
/// </summary>
public static IlFilterGen IlFilterGen(this ImageMap input0) => new IlFilterGen(input0);
}
/// <summary>
///  select luma mode (from 0 to 2) (default none)
/// </summary>
public enum IlFilterGenLuma_mode
{
/// <summary>
/// none            0            ..FV.....T.
/// </summary>
[Name("none")] none,
/// <summary>
/// interleave      1            ..FV.....T.
/// </summary>
[Name("interleave")] interleave,
/// <summary>
/// i               1            ..FV.....T.
/// </summary>
[Name("i")] i,
/// <summary>
/// deinterleave    2            ..FV.....T.
/// </summary>
[Name("deinterleave")] deinterleave,
/// <summary>
/// d               2            ..FV.....T.
/// </summary>
[Name("d")] d,
}

/// <summary>
///  select chroma mode (from 0 to 2) (default none)
/// </summary>
public enum IlFilterGenChroma_mode
{
/// <summary>
/// none            0            ..FV.....T.
/// </summary>
[Name("none")] none,
/// <summary>
/// interleave      1            ..FV.....T.
/// </summary>
[Name("interleave")] interleave,
/// <summary>
/// i               1            ..FV.....T.
/// </summary>
[Name("i")] i,
/// <summary>
/// deinterleave    2            ..FV.....T.
/// </summary>
[Name("deinterleave")] deinterleave,
/// <summary>
/// d               2            ..FV.....T.
/// </summary>
[Name("d")] d,
}

/// <summary>
///  select alpha mode (from 0 to 2) (default none)
/// </summary>
public enum IlFilterGenAlpha_mode
{
/// <summary>
/// none            0            ..FV.....T.
/// </summary>
[Name("none")] none,
/// <summary>
/// interleave      1            ..FV.....T.
/// </summary>
[Name("interleave")] interleave,
/// <summary>
/// i               1            ..FV.....T.
/// </summary>
[Name("i")] i,
/// <summary>
/// deinterleave    2            ..FV.....T.
/// </summary>
[Name("deinterleave")] deinterleave,
/// <summary>
/// d               2            ..FV.....T.
/// </summary>
[Name("d")] d,
}

}
