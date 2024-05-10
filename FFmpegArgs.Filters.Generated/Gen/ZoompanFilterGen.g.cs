namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... zoompan           V->V       Apply Zoom &amp; Pan effect.
/// </summary>
public class ZoompanFilterGen : ImageToImageFilter
{
internal ZoompanFilterGen(ImageMap input) : base("zoompan",input) { AddMapOut(); }
/// <summary>
///  set the zoom expression (default "1")
/// </summary>
public ZoompanFilterGen zoom(ExpressionValue zoom) => this.SetOption("zoom",(string)zoom);
/// <summary>
///  set the x expression (default "0")
/// </summary>
public ZoompanFilterGen x(ExpressionValue x) => this.SetOption("x",(string)x);
/// <summary>
///  set the y expression (default "0")
/// </summary>
public ZoompanFilterGen y(ExpressionValue y) => this.SetOption("y",(string)y);
/// <summary>
///  set the duration expression (default "90")
/// </summary>
public ZoompanFilterGen d(ExpressionValue d) => this.SetOption("d",(string)d);
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
/// Apply Zoom &amp; Pan effect.
/// </summary>
public static ZoompanFilterGen ZoompanFilterGen(this ImageMap input0) => new ZoompanFilterGen(input0);
}
}
