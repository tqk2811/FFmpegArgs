namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... zoompan           V->V       Apply Zoom & Pan effect.
/// </summary>
public class ZoompanFilterGen : ImageToImageFilter
{
internal ZoompanFilterGen(ImageMap input) : base("zoompan",input) { AddMapOut(); }
/// <summary>
///  set the zoom expression (default "1")
/// </summary>
public ZoompanFilterGen zoom(string zoom) => this.SetOption("zoom",zoom);
/// <summary>
///  set the x expression (default "0")
/// </summary>
public ZoompanFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set the y expression (default "0")
/// </summary>
public ZoompanFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set the duration expression (default "90")
/// </summary>
public ZoompanFilterGen d(string d) => this.SetOption("d",d);
/// <summary>
///  set the output image size (default "hd720")
/// </summary>
public ZoompanFilterGen s(Size s) => this.SetOption("s",$"{s.Width}x{s.Height}");
/// <summary>
///  set the output framerate (default "25")
/// </summary>
public ZoompanFilterGen fps(Rational fps) => this.SetOption("fps",fps);
}
/// <summary>
/// </summary>
public static class ZoompanFilterGenExtensions
{
/// <summary>
/// Apply Zoom & Pan effect.
/// </summary>
public static ZoompanFilterGen ZoompanFilterGen(this ImageMap input0) => new ZoompanFilterGen(input0);
}
}
