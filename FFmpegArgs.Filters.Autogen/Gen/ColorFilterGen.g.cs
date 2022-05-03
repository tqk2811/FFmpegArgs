namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ..C color             |->V       Provide an uniformly colored input.
/// </summary>
public class ColorFilterGen : SourceImageFilter,ICommandSupport
{
internal ColorFilterGen(IImageFilterGraph input) : base("color",input) { AddMapOut(); }
/// <summary>
///  set color (default "black")
/// </summary>
public ColorFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set video size (default "320x240")
/// </summary>
public ColorFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public ColorFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public ColorFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public ColorFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
/// <summary>
/// </summary>
public static class ColorFilterGenExtensions
{
/// <summary>
/// Provide an uniformly colored input.
/// </summary>
public static ColorFilterGen ColorFilterGen(this IImageFilterGraph input0) => new ColorFilterGen(input0);
}
}
