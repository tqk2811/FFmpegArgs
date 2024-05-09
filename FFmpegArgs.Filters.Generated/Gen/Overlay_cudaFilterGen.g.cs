namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... overlay_cuda      VV->V      Overlay one video on top of another using CUDA
/// </summary>
public class Overlay_cudaFilterGen : ImageToImageFilter
{
internal Overlay_cudaFilterGen(params ImageMap[] inputs) : base("overlay_cuda",inputs) { AddMapOut(); }
/// <summary>
///  set the x expression of overlay (default "0")
/// </summary>
public Overlay_cudaFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set the y expression of overlay (default "0")
/// </summary>
public Overlay_cudaFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public Overlay_cudaFilterGen eof_action(Overlay_cudaFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default frame)
/// </summary>
public Overlay_cudaFilterGen eval(Overlay_cudaFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public Overlay_cudaFilterGen shortest(bool shortest) => this.SetOption("shortest",shortest.ToFFmpegFlag());
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public Overlay_cudaFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast",repeatlast.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class Overlay_cudaFilterGenExtensions
{
/// <summary>
/// Overlay one video on top of another using CUDA
/// </summary>
public static Overlay_cudaFilterGen Overlay_cudaFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_cudaFilterGen(input0, input1);
}
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public enum Overlay_cudaFilterGenEof_action
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
public enum Overlay_cudaFilterGenEval
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

}
