namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. codecview         V-&gt;V       Visualize information about some codecs.
/// </summary>
public class CodecviewFilterGen : ImageToImageFilter,ITimelineSupport
{
internal CodecviewFilterGen(ImageMap input) : base("codecview",input) { AddMapOut(); }
/// <summary>
///  set motion vectors to visualize (default 0)
/// </summary>
public CodecviewFilterGen mv(CodecviewFilterGenMv mv) => this.SetOption("mv", mv.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  (default false)
/// </summary>
public CodecviewFilterGen qp(bool qp) => this.SetOption("qp",qp.ToFFmpegFlag());
/// <summary>
///  set motion vectors type (default 0)
/// </summary>
public CodecviewFilterGen mv_type(CodecviewFilterGenMv_type mv_type) => this.SetOption("mv_type", mv_type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set motion vectors type (default 0)
/// </summary>
public CodecviewFilterGen mvt(CodecviewFilterGenMvt mvt) => this.SetOption("mvt", mvt.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set frame types to visualize motion vectors of (default 0)
/// </summary>
public CodecviewFilterGen frame_type(CodecviewFilterGenFrame_type frame_type) => this.SetOption("frame_type", frame_type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set frame types to visualize motion vectors of (default 0)
/// </summary>
public CodecviewFilterGen ft(CodecviewFilterGenFt ft) => this.SetOption("ft", ft.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set block partitioning structure to visualize (default false)
/// </summary>
public CodecviewFilterGen block(bool block) => this.SetOption("block",block.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Visualize information about some codecs.
/// </summary>
public static CodecviewFilterGen CodecviewFilterGen(this ImageMap input0) => new CodecviewFilterGen(input0);
}
/// <summary>
///  set motion vectors to visualize (default 0)
/// </summary>
public enum CodecviewFilterGenMv
{
/// <summary>
/// pf                           ..FV....... forward predicted MVs of P-frames
/// </summary>
[Name("pf")] pf,
/// <summary>
/// bf                           ..FV....... forward predicted MVs of B-frames
/// </summary>
[Name("bf")] bf,
/// <summary>
/// bb                           ..FV....... backward predicted MVs of B-frames
/// </summary>
[Name("bb")] bb,
}

/// <summary>
///  set motion vectors type (default 0)
/// </summary>
public enum CodecviewFilterGenMv_type
{
/// <summary>
/// fp                           ..FV....... forward predicted MVs
/// </summary>
[Name("fp")] fp,
/// <summary>
/// bp                           ..FV....... backward predicted MVs
/// </summary>
[Name("bp")] bp,
}

/// <summary>
///  set motion vectors type (default 0)
/// </summary>
public enum CodecviewFilterGenMvt
{
/// <summary>
/// fp                           ..FV....... forward predicted MVs
/// </summary>
[Name("fp")] fp,
/// <summary>
/// bp                           ..FV....... backward predicted MVs
/// </summary>
[Name("bp")] bp,
}

/// <summary>
///  set frame types to visualize motion vectors of (default 0)
/// </summary>
public enum CodecviewFilterGenFrame_type
{
/// <summary>
/// if                           ..FV....... I-frames
/// </summary>
[Name("if")] _if,
/// <summary>
/// pf                           ..FV....... P-frames
/// </summary>
[Name("pf")] pf,
/// <summary>
/// bf                           ..FV....... B-frames
/// </summary>
[Name("bf")] bf,
}

/// <summary>
///  set frame types to visualize motion vectors of (default 0)
/// </summary>
public enum CodecviewFilterGenFt
{
/// <summary>
/// if                           ..FV....... I-frames
/// </summary>
[Name("if")] _if,
/// <summary>
/// pf                           ..FV....... P-frames
/// </summary>
[Name("pf")] pf,
/// <summary>
/// bf                           ..FV....... B-frames
/// </summary>
[Name("bf")] bf,
}

}
