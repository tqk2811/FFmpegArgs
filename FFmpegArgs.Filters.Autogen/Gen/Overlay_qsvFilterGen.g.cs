namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... overlay_qsv       VV->V      Quick Sync Video overlay.
/// </summary>
public class Overlay_qsvFilterGen : ImageToImageFilter
{
internal Overlay_qsvFilterGen(params ImageMap[] inputs) : base("overlay_qsv",inputs) { AddMapOut(); }
/// <summary>
///  Overlay x position (default "0")
/// </summary>
public Overlay_qsvFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  Overlay y position (default "0")
/// </summary>
public Overlay_qsvFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  Overlay width (default "overlay_iw")
/// </summary>
public Overlay_qsvFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Overlay height (default "overlay_ih*w/overlay_iw")
/// </summary>
public Overlay_qsvFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Overlay global alpha (from 0 to 255) (default 255)
/// </summary>
public Overlay_qsvFilterGen alpha(int alpha) => this.SetOptionRange("alpha", alpha,0,255);
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public Overlay_qsvFilterGen eof_action(Overlay_qsvFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public Overlay_qsvFilterGen shortest(bool shortest) => this.SetOption("shortest",shortest.ToFFmpegFlag());
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public Overlay_qsvFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast",repeatlast.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class Overlay_qsvFilterGenExtensions
{
/// <summary>
/// Quick Sync Video overlay.
/// </summary>
public static Overlay_qsvFilterGen Overlay_qsvFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_qsvFilterGen(input0, input1);
}
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public enum Overlay_qsvFilterGenEof_action
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

}
