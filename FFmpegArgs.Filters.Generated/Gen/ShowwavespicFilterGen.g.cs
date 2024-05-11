namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... showwavespic      A->V       Convert input audio to a video output single picture.
/// </summary>
public class ShowwavespicFilterGen : AudioToImageFilter
{
internal ShowwavespicFilterGen(AudioMap input) : base("showwavespic",input) { AddMapOut(); }
/// <summary>
///  set video size (default "600x240")
/// </summary>
public ShowwavespicFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  draw channels separately (default false)
/// </summary>
public ShowwavespicFilterGen split_channels(bool split_channels) => this.SetOption("split_channels",split_channels.ToFFmpegFlag());
/// <summary>
///  set channels colors (default "red|green|blue|yellow|orange|lime|pink|magenta|brown")
/// </summary>
public ShowwavespicFilterGen colors(string colors) => this.SetOption("colors",colors);
/// <summary>
///  set amplitude scale (from 0 to 3) (default lin)
/// </summary>
public ShowwavespicFilterGen scale(ShowwavespicFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set draw mode (from 0 to 1) (default scale)
/// </summary>
public ShowwavespicFilterGen draw(ShowwavespicFilterGenDraw draw) => this.SetOption("draw", draw.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filter mode (from 0 to 1) (default average)
/// </summary>
public ShowwavespicFilterGen filter(ShowwavespicFilterGenFilter filter) => this.SetOption("filter", filter.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to a video output single picture.
/// </summary>
public static ShowwavespicFilterGen ShowwavespicFilterGen(this AudioMap input0) => new ShowwavespicFilterGen(input0);
}
/// <summary>
///  set amplitude scale (from 0 to 3) (default lin)
/// </summary>
public enum ShowwavespicFilterGenScale
{
/// <summary>
/// lin             0            ..FV....... linear
/// </summary>
[Name("lin")] lin,
/// <summary>
/// log             1            ..FV....... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// sqrt            2            ..FV....... square root
/// </summary>
[Name("sqrt")] sqrt,
/// <summary>
/// cbrt            3            ..FV....... cubic root
/// </summary>
[Name("cbrt")] cbrt,
}

/// <summary>
///  set draw mode (from 0 to 1) (default scale)
/// </summary>
public enum ShowwavespicFilterGenDraw
{
/// <summary>
/// scale           0            ..FV....... scale pixel values for each drawn sample
/// </summary>
[Name("scale")] scale,
/// <summary>
/// full            1            ..FV....... draw every pixel for sample directly
/// </summary>
[Name("full")] full,
}

/// <summary>
///  set filter mode (from 0 to 1) (default average)
/// </summary>
public enum ShowwavespicFilterGenFilter
{
/// <summary>
/// average         0            ..FV....... use average samples
/// </summary>
[Name("average")] average,
/// <summary>
/// peak            1            ..FV....... use peak samples
/// </summary>
[Name("peak")] peak,
}

}
