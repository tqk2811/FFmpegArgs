namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. showcwt           A-&gt;V       Convert input audio to a CWT (Continuous Wavelet Transform) spectrum video output.
/// </summary>
public class ShowcwtFilterGen : AudioToImageFilter,ISliceThreading
{
internal ShowcwtFilterGen(AudioMap input) : base("showcwt",input) { AddMapOut(); }
/// <summary>
///  set video size (default &quot;640x512&quot;)
/// </summary>
public ShowcwtFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default &quot;25&quot;)
/// </summary>
public ShowcwtFilterGen rate(string rate) => this.SetOption("rate",rate);
/// <summary>
///  set frequency scale (from 0 to 8) (default linear)
/// </summary>
public ShowcwtFilterGen scale(ShowcwtFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set intensity scale (from 0 to 4) (default log)
/// </summary>
public ShowcwtFilterGen iscale(ShowcwtFilterGenIscale iscale) => this.SetOption("iscale", iscale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set minimum frequency (from 1 to 192000) (default 20)
/// </summary>
public ShowcwtFilterGen min(float min) => this.SetOptionRange("min", min,1,192000);
/// <summary>
///  set maximum frequency (from 1 to 192000) (default 20000)
/// </summary>
public ShowcwtFilterGen max(float max) => this.SetOptionRange("max", max,1,192000);
/// <summary>
///  set minimum intensity (from 0 to 1) (default 0)
/// </summary>
public ShowcwtFilterGen imin(float imin) => this.SetOptionRange("imin", imin,0,1);
/// <summary>
///  set maximum intensity (from 0 to 1) (default 1)
/// </summary>
public ShowcwtFilterGen imax(float imax) => this.SetOptionRange("imax", imax,0,1);
/// <summary>
///  set logarithmic basis (from 0 to 1) (default 0.0001)
/// </summary>
public ShowcwtFilterGen logb(float logb) => this.SetOptionRange("logb", logb,0,1);
/// <summary>
///  set frequency deviation (from 0 to 100) (default 1)
/// </summary>
public ShowcwtFilterGen deviation(float deviation) => this.SetOptionRange("deviation", deviation,0,100);
/// <summary>
///  set pixels per second (from 1 to 1024) (default 64)
/// </summary>
public ShowcwtFilterGen pps(int pps) => this.SetOptionRange("pps", pps,1,1024);
/// <summary>
///  set output mode (from 0 to 4) (default magnitude)
/// </summary>
public ShowcwtFilterGen mode(ShowcwtFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set slide mode (from 0 to 2) (default replace)
/// </summary>
public ShowcwtFilterGen slide(ShowcwtFilterGenSlide slide) => this.SetOption("slide", slide.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set direction mode (from 0 to 3) (default lr)
/// </summary>
public ShowcwtFilterGen direction(ShowcwtFilterGenDirection direction) => this.SetOption("direction", direction.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set bargraph ratio (from 0 to 1) (default 0)
/// </summary>
public ShowcwtFilterGen bar(float bar) => this.SetOptionRange("bar", bar,0,1);
/// <summary>
///  set color rotation (from -1 to 1) (default 0)
/// </summary>
public ShowcwtFilterGen rotation(float rotation) => this.SetOptionRange("rotation", rotation,-1,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to a CWT (Continuous Wavelet Transform) spectrum video output.
/// </summary>
public static ShowcwtFilterGen ShowcwtFilterGen(this AudioMap input0) => new ShowcwtFilterGen(input0);
}
/// <summary>
///  set frequency scale (from 0 to 8) (default linear)
/// </summary>
public enum ShowcwtFilterGenScale
{
/// <summary>
/// linear          0            ..FV....... linear
/// </summary>
[Name("linear")] linear,
/// <summary>
/// log             1            ..FV....... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// bark            2            ..FV....... bark
/// </summary>
[Name("bark")] bark,
/// <summary>
/// mel             3            ..FV....... mel
/// </summary>
[Name("mel")] mel,
/// <summary>
/// erbs            4            ..FV....... erbs
/// </summary>
[Name("erbs")] erbs,
/// <summary>
/// sqrt            5            ..FV....... sqrt
/// </summary>
[Name("sqrt")] sqrt,
/// <summary>
/// cbrt            6            ..FV....... cbrt
/// </summary>
[Name("cbrt")] cbrt,
/// <summary>
/// qdrt            7            ..FV....... qdrt
/// </summary>
[Name("qdrt")] qdrt,
/// <summary>
/// fm              8            ..FV....... fm
/// </summary>
[Name("fm")] fm,
}

/// <summary>
///  set intensity scale (from 0 to 4) (default log)
/// </summary>
public enum ShowcwtFilterGenIscale
{
/// <summary>
/// linear          1            ..FV....... linear
/// </summary>
[Name("linear")] linear,
/// <summary>
/// log             0            ..FV....... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// sqrt            2            ..FV....... sqrt
/// </summary>
[Name("sqrt")] sqrt,
/// <summary>
/// cbrt            3            ..FV....... cbrt
/// </summary>
[Name("cbrt")] cbrt,
/// <summary>
/// qdrt            4            ..FV....... qdrt
/// </summary>
[Name("qdrt")] qdrt,
}

/// <summary>
///  set output mode (from 0 to 4) (default magnitude)
/// </summary>
public enum ShowcwtFilterGenMode
{
/// <summary>
/// magnitude       0            ..FV....... magnitude
/// </summary>
[Name("magnitude")] magnitude,
/// <summary>
/// phase           1            ..FV....... phase
/// </summary>
[Name("phase")] phase,
/// <summary>
/// magphase        2            ..FV....... magnitude+phase
/// </summary>
[Name("magphase")] magphase,
/// <summary>
/// channel         3            ..FV....... color per channel
/// </summary>
[Name("channel")] channel,
/// <summary>
/// stereo          4            ..FV....... stereo difference
/// </summary>
[Name("stereo")] stereo,
}

/// <summary>
///  set slide mode (from 0 to 2) (default replace)
/// </summary>
public enum ShowcwtFilterGenSlide
{
/// <summary>
/// replace         0            ..FV....... replace
/// </summary>
[Name("replace")] replace,
/// <summary>
/// scroll          1            ..FV....... scroll
/// </summary>
[Name("scroll")] scroll,
/// <summary>
/// frame           2            ..FV....... frame
/// </summary>
[Name("frame")] frame,
}

/// <summary>
///  set direction mode (from 0 to 3) (default lr)
/// </summary>
public enum ShowcwtFilterGenDirection
{
/// <summary>
/// lr              0            ..FV....... left to right
/// </summary>
[Name("lr")] lr,
/// <summary>
/// rl              1            ..FV....... right to left
/// </summary>
[Name("rl")] rl,
/// <summary>
/// ud              2            ..FV....... up to down
/// </summary>
[Name("ud")] ud,
/// <summary>
/// du              3            ..FV....... down to up
/// </summary>
[Name("du")] du,
}

}
