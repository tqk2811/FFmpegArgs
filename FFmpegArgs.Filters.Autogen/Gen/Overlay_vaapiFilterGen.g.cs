namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... overlay_vaapi     VV->V      Overlay one video on top of another
/// </summary>
public class Overlay_vaapiFilterGen : ImageToImageFilter
{
internal Overlay_vaapiFilterGen(params ImageMap[] inputs) : base("overlay_vaapi",inputs) { AddMapOut(); }
/// <summary>
///  Overlay x position (default "0")
/// </summary>
public Overlay_vaapiFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  Overlay y position (default "0")
/// </summary>
public Overlay_vaapiFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  Overlay width (default "overlay_iw")
/// </summary>
public Overlay_vaapiFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Overlay height (default "overlay_ih*w/overlay_iw")
/// </summary>
public Overlay_vaapiFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Overlay global alpha (from 0 to 1) (default 1)
/// </summary>
public Overlay_vaapiFilterGen alpha(float alpha) => this.SetOptionRange("alpha", alpha,0,1);
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public Overlay_vaapiFilterGen eof_action(Overlay_vaapiFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public Overlay_vaapiFilterGen shortest(bool shortest) => this.SetOption("shortest",shortest.ToFFmpegFlag());
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public Overlay_vaapiFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast",repeatlast.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class Overlay_vaapiFilterGenExtensions
{
/// <summary>
/// Overlay one video on top of another
/// </summary>
public static Overlay_vaapiFilterGen Overlay_vaapiFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_vaapiFilterGen(input0, input1);
}
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public enum Overlay_vaapiFilterGenEof_action
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
