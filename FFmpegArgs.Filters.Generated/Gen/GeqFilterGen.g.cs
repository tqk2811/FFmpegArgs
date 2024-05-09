namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. geq               V->V       Apply generic equation to each pixel.
/// </summary>
public class GeqFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal GeqFilterGen(ImageMap input) : base("geq",input) { AddMapOut(); }
/// <summary>
///  set luminance expression
/// </summary>
public GeqFilterGen lum_expr(string lum_expr) => this.SetOption("lum_expr",lum_expr);
/// <summary>
///  set chroma blue expression
/// </summary>
public GeqFilterGen cb_expr(string cb_expr) => this.SetOption("cb_expr",cb_expr);
/// <summary>
///  set chroma red expression
/// </summary>
public GeqFilterGen cr_expr(string cr_expr) => this.SetOption("cr_expr",cr_expr);
/// <summary>
///  set alpha expression
/// </summary>
public GeqFilterGen alpha_expr(string alpha_expr) => this.SetOption("alpha_expr",alpha_expr);
/// <summary>
///  set red expression
/// </summary>
public GeqFilterGen red_expr(string red_expr) => this.SetOption("red_expr",red_expr);
/// <summary>
///  set green expression
/// </summary>
public GeqFilterGen green_expr(string green_expr) => this.SetOption("green_expr",green_expr);
/// <summary>
///  set blue expression
/// </summary>
public GeqFilterGen blue_expr(string blue_expr) => this.SetOption("blue_expr",blue_expr);
/// <summary>
///  set interpolation method (from 0 to 1) (default bilinear)
/// </summary>
public GeqFilterGen interpolation(GeqFilterGenInterpolation interpolation) => this.SetOption("interpolation", interpolation.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class GeqFilterGenExtensions
{
/// <summary>
/// Apply generic equation to each pixel.
/// </summary>
public static GeqFilterGen GeqFilterGen(this ImageMap input0) => new GeqFilterGen(input0);
}
/// <summary>
///  set interpolation method (from 0 to 1) (default bilinear)
/// </summary>
public enum GeqFilterGenInterpolation
{
/// <summary>
/// nearest         0            ..FV....... nearest interpolation
/// </summary>
[Name("nearest")] nearest,
/// <summary>
/// n               0            ..FV....... nearest interpolation
/// </summary>
[Name("n")] n,
/// <summary>
/// bilinear        1            ..FV....... bilinear interpolation
/// </summary>
[Name("bilinear")] bilinear,
/// <summary>
/// b               1            ..FV....... bilinear interpolation
/// </summary>
[Name("b")] b,
}

}
