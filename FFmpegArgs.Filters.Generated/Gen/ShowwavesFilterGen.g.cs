namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... showwaves         A->V       Convert input audio to a video output.
/// </summary>
public class ShowwavesFilterGen : AudioToImageFilter
{
internal ShowwavesFilterGen(AudioMap input) : base("showwaves",input) { AddMapOut(); }
/// <summary>
///  set video size (default "600x240")
/// </summary>
public ShowwavesFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  select display mode (from 0 to 3) (default point)
/// </summary>
public ShowwavesFilterGen mode(ShowwavesFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set how many samples to show in the same point (from 0 to INT_MAX) (default 0/1)
/// </summary>
public ShowwavesFilterGen n(Rational n) => this.SetOption("n",n.Check(0,INT_MAX));
/// <summary>
///  set video rate (default "25")
/// </summary>
public ShowwavesFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  draw channels separately (default false)
/// </summary>
public ShowwavesFilterGen split_channels(bool split_channels) => this.SetOption("split_channels",split_channels.ToFFmpegFlag());
/// <summary>
///  set channels colors (default "red|green|blue|yellow|orange|lime|pink|magenta|brown")
/// </summary>
public ShowwavesFilterGen colors(string colors) => this.SetOption("colors",colors);
/// <summary>
///  set amplitude scale (from 0 to 3) (default lin)
/// </summary>
public ShowwavesFilterGen scale(ShowwavesFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set draw mode (from 0 to 1) (default scale)
/// </summary>
public ShowwavesFilterGen draw(ShowwavesFilterGenDraw draw) => this.SetOption("draw", draw.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to a video output.
/// </summary>
public static ShowwavesFilterGen ShowwavesFilterGen(this AudioMap input0) => new ShowwavesFilterGen(input0);
}
/// <summary>
///  select display mode (from 0 to 3) (default point)
/// </summary>
public enum ShowwavesFilterGenMode
{
/// <summary>
/// point           0            ..FV....... draw a point for each sample
/// </summary>
[Name("point")] point,
/// <summary>
/// line            1            ..FV....... draw a line for each sample
/// </summary>
[Name("line")] line,
/// <summary>
/// p2p             2            ..FV....... draw a line between samples
/// </summary>
[Name("p2p")] p2p,
/// <summary>
/// cline           3            ..FV....... draw a centered line for each sample
/// </summary>
[Name("cline")] cline,
}

/// <summary>
///  set amplitude scale (from 0 to 3) (default lin)
/// </summary>
public enum ShowwavesFilterGenScale
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
public enum ShowwavesFilterGenDraw
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

}
