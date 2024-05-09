namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... frei0r_src        |->V       Generate a frei0r source.
/// </summary>
public class Frei0r_srcFilterGen : SourceImageFilter
{
internal Frei0r_srcFilterGen(IImageFilterGraph input) : base("frei0r_src",input) { AddMapOut(); }
/// <summary>
///  Dimensions of the generated video. (default "320x240")
/// </summary>
public Frei0r_srcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  (default "25")
/// </summary>
public Frei0r_srcFilterGen framerate(Rational framerate) => this.SetOption("framerate",framerate);
/// <summary>
/// 
/// </summary>
public Frei0r_srcFilterGen filter_name(string filter_name) => this.SetOption("filter_name",filter_name);
/// <summary>
/// 
/// </summary>
public Frei0r_srcFilterGen filter_params(string filter_params) => this.SetOption("filter_params",filter_params);
}
/// <summary>
/// </summary>
public static class Frei0r_srcFilterGenExtensions
{
/// <summary>
/// Generate a frei0r source.
/// </summary>
public static Frei0r_srcFilterGen Frei0r_srcFilterGen(this IImageFilterGraph input0) => new Frei0r_srcFilterGen(input0);
}
}
