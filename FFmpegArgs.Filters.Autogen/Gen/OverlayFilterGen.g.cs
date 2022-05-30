namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC overlay           VV->V      Overlay a video source on top of the input.
/// </summary>
public class OverlayFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal OverlayFilterGen(params ImageMap[] inputs) : base("overlay",inputs) { AddMapOut(); }
/// <summary>
///  set the x expression (default "0")
/// </summary>
public OverlayFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set the y expression (default "0")
/// </summary>
public OverlayFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public OverlayFilterGen eof_action(OverlayFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default frame)
/// </summary>
public OverlayFilterGen eval(OverlayFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public OverlayFilterGen shortest(bool shortest) => this.SetOption("shortest",shortest.ToFFmpegFlag());
/// <summary>
///  set output format (from 0 to 7) (default yuv420)
/// </summary>
public OverlayFilterGen format(OverlayFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public OverlayFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast",repeatlast.ToFFmpegFlag());
/// <summary>
///  alpha format (from 0 to 1) (default straight)
/// </summary>
public OverlayFilterGen alpha(OverlayFilterGenAlpha alpha) => this.SetOption("alpha", alpha.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class OverlayFilterGenExtensions
{
/// <summary>
/// Overlay a video source on top of the input.
/// </summary>
public static OverlayFilterGen OverlayFilterGen(this ImageMap input0, ImageMap input1) => new OverlayFilterGen(input0, input1);
}
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public enum OverlayFilterGenEof_action
{
/// <summary>
/// repeat          0            ..FV....... Repeat the previous frame.
/// </summary>
[Name("repeat")] repeat,
/// <summary>
/// endall          1            ..FV....... End both streams.
/// </summary>
[Name("endall")] endall,
/// <summary>
/// pass            2            ..FV....... Pass through the main input.
/// </summary>
[Name("pass")] pass,
}

/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default frame)
/// </summary>
public enum OverlayFilterGenEval
{
/// <summary>
/// init            0            ..FV....... eval expressions once during initialization
/// </summary>
[Name("init")] init,
/// <summary>
/// frame           1            ..FV....... eval expressions per-frame
/// </summary>
[Name("frame")] frame,
}

/// <summary>
///  set output format (from 0 to 7) (default yuv420)
/// </summary>
public enum OverlayFilterGenFormat
{
/// <summary>
/// yuv420          0            ..FV.......
/// </summary>
[Name("yuv420")] yuv420,
/// <summary>
/// yuv420p10       1            ..FV.......
/// </summary>
[Name("yuv420p10")] yuv420p10,
/// <summary>
/// yuv422          2            ..FV.......
/// </summary>
[Name("yuv422")] yuv422,
/// <summary>
/// yuv422p10       3            ..FV.......
/// </summary>
[Name("yuv422p10")] yuv422p10,
/// <summary>
/// yuv444          4            ..FV.......
/// </summary>
[Name("yuv444")] yuv444,
/// <summary>
/// rgb             5            ..FV.......
/// </summary>
[Name("rgb")] rgb,
/// <summary>
/// gbrp            6            ..FV.......
/// </summary>
[Name("gbrp")] gbrp,
/// <summary>
/// auto            7            ..FV.......
/// </summary>
[Name("auto")] auto,
}

/// <summary>
///  alpha format (from 0 to 1) (default straight)
/// </summary>
public enum OverlayFilterGenAlpha
{
/// <summary>
/// straight        0            ..FV.......
/// </summary>
[Name("straight")] straight,
/// <summary>
/// premultiplied   1            ..FV.......
/// </summary>
[Name("premultiplied")] premultiplied,
}

}
