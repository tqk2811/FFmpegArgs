namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... pad_opencl        V->V       Pad the input video.
/// </summary>
public class Pad_openclFilterGen : ImageToImageFilter
{
internal Pad_openclFilterGen(ImageMap input) : base("pad_opencl",input) { AddMapOut(); }
/// <summary>
///  set the pad area width (default "iw")
/// </summary>
public Pad_openclFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  set the pad area height (default "ih")
/// </summary>
public Pad_openclFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set the x offset for the input image position (default "0")
/// </summary>
public Pad_openclFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set the y offset for the input image position (default "0")
/// </summary>
public Pad_openclFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set the color of the padded area border (default "black")
/// </summary>
public Pad_openclFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  pad to fit an aspect instead of a resolution (from 0 to 32767) (default 0/1)
/// </summary>
public Pad_openclFilterGen aspect(Rational aspect) => this.SetOption("aspect",aspect.Check(0,32767));
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Pad the input video.
/// </summary>
public static Pad_openclFilterGen Pad_openclFilterGen(this ImageMap input0) => new Pad_openclFilterGen(input0);
}
}
