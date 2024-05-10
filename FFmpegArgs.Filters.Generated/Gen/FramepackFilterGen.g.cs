namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... framepack         VV->V      Generate a frame packed stereoscopic video.
/// </summary>
public class FramepackFilterGen : ImageToImageFilter
{
internal FramepackFilterGen(params ImageMap[] inputs) : base("framepack",inputs) { AddMapOut(); }
/// <summary>
///  Frame pack output format (from 0 to INT_MAX) (default sbs)
/// </summary>
public FramepackFilterGen format(FramepackFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Generate a frame packed stereoscopic video.
/// </summary>
public static FramepackFilterGen FramepackFilterGen(this ImageMap input0, ImageMap input1) => new FramepackFilterGen(input0, input1);
}
/// <summary>
///  Frame pack output format (from 0 to INT_MAX) (default sbs)
/// </summary>
public enum FramepackFilterGenFormat
{
/// <summary>
/// sbs             1            ..FV....... Views are packed next to each other
/// </summary>
[Name("sbs")] sbs,
/// <summary>
/// tab             2            ..FV....... Views are packed on top of each other
/// </summary>
[Name("tab")] tab,
/// <summary>
/// frameseq        3            ..FV....... Views are one after the other
/// </summary>
[Name("frameseq")] frameseq,
/// <summary>
/// lines           6            ..FV....... Views are interleaved by lines
/// </summary>
[Name("lines")] lines,
/// <summary>
/// columns         7            ..FV....... Views are interleaved by columns
/// </summary>
[Name("columns")] columns,
}

}
