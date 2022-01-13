namespace FFmpegArgs.Filters.Autogens
{
public class Overlay_cudaFilterGen : ImageToImageFilter
{
internal Overlay_cudaFilterGen(params ImageMap[] inputs) : base("overlay_cuda",inputs) { AddMapOut(); }
/// <summary>
///  Overlay x position (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public Overlay_cudaFilterGen x(int x) => this.SetOptionRange("x", x,INT_MIN,INT_MAX);
/// <summary>
///  Overlay y position (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public Overlay_cudaFilterGen y(int y) => this.SetOptionRange("y", y,INT_MIN,INT_MAX);
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public Overlay_cudaFilterGen eof_action(Overlay_cudaFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public Overlay_cudaFilterGen shortest(bool shortest) => this.SetOption("shortest",shortest.ToFFmpegFlag());
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public Overlay_cudaFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast",repeatlast.ToFFmpegFlag());
}
public static class Overlay_cudaFilterGenExtensions
{
/// <summary>
/// Overlay one video on top of another using CUDA
/// </summary>
public static Overlay_cudaFilterGen Overlay_cudaFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_cudaFilterGen(input0, input1);
/// <summary>
/// Overlay one video on top of another using CUDA
/// </summary>
public static Overlay_cudaFilterGen Overlay_cudaFilterGen(this ImageMap input0, ImageMap input1,Overlay_cudaFilterGenConfig config)
{
var result = new Overlay_cudaFilterGen(input0, input1);
if(config?.x != null) result.x(config.x.Value);
if(config?.y != null) result.y(config.y.Value);
if(config?.eof_action != null) result.eof_action(config.eof_action.Value);
if(config?.shortest != null) result.shortest(config.shortest.Value);
if(config?.repeatlast != null) result.repeatlast(config.repeatlast.Value);
return result;
}
}
public class Overlay_cudaFilterGenConfig
{
/// <summary>
///  Overlay x position (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public int? x { get; set; }
/// <summary>
///  Overlay y position (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public int? y { get; set; }
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public Overlay_cudaFilterGenEof_action? eof_action { get; set; }
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public bool? shortest { get; set; }
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public bool? repeatlast { get; set; }
}
public enum Overlay_cudaFilterGenEof_action
{
[Name("repeat")] repeat,
[Name("endall")] endall,
[Name("pass")] pass,
}

}
