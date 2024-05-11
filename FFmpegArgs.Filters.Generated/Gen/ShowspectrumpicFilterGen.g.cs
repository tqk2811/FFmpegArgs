namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. showspectrumpic   A-&gt;V       Convert input audio to a spectrum video output single picture.
/// </summary>
public class ShowspectrumpicFilterGen : AudioToImageFilter,ISliceThreading
{
internal ShowspectrumpicFilterGen(AudioMap input) : base("showspectrumpic",input) { AddMapOut(); }
/// <summary>
///  set video size (default &quot;4096x2048&quot;)
/// </summary>
public ShowspectrumpicFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set channel display mode (from 0 to 1) (default combined)
/// </summary>
public ShowspectrumpicFilterGen mode(ShowspectrumpicFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set channel coloring (from 0 to 14) (default intensity)
/// </summary>
public ShowspectrumpicFilterGen color(ShowspectrumpicFilterGenColor color) => this.SetOption("color", color.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set display scale (from 0 to 5) (default log)
/// </summary>
public ShowspectrumpicFilterGen scale(ShowspectrumpicFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set frequency scale (from 0 to 1) (default lin)
/// </summary>
public ShowspectrumpicFilterGen fscale(ShowspectrumpicFilterGenFscale fscale) => this.SetOption("fscale", fscale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  color saturation multiplier (from -10 to 10) (default 1)
/// </summary>
public ShowspectrumpicFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation,-10,10);
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public ShowspectrumpicFilterGen win_func(ShowspectrumpicFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set orientation (from 0 to 1) (default vertical)
/// </summary>
public ShowspectrumpicFilterGen orientation(ShowspectrumpicFilterGenOrientation orientation) => this.SetOption("orientation", orientation.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set scale gain (from 0 to 128) (default 1)
/// </summary>
public ShowspectrumpicFilterGen gain(float gain) => this.SetOptionRange("gain", gain,0,128);
/// <summary>
///  draw legend (default true)
/// </summary>
public ShowspectrumpicFilterGen legend(bool legend) => this.SetOption("legend",legend.ToFFmpegFlag());
/// <summary>
///  color rotation (from -1 to 1) (default 0)
/// </summary>
public ShowspectrumpicFilterGen rotation(float rotation) => this.SetOptionRange("rotation", rotation,-1,1);
/// <summary>
///  start frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public ShowspectrumpicFilterGen start(int start) => this.SetOptionRange("start", start,0,INT_MAX);
/// <summary>
///  stop frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public ShowspectrumpicFilterGen stop(int stop) => this.SetOptionRange("stop", stop,0,INT_MAX);
/// <summary>
///  set dynamic range in dBFS (from 10 to 200) (default 120)
/// </summary>
public ShowspectrumpicFilterGen drange(float drange) => this.SetOptionRange("drange", drange,10,200);
/// <summary>
///  set upper limit in dBFS (from -100 to 100) (default 0)
/// </summary>
public ShowspectrumpicFilterGen limit(float limit) => this.SetOptionRange("limit", limit,-100,100);
/// <summary>
///  set opacity strength (from 0 to 10) (default 1)
/// </summary>
public ShowspectrumpicFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,10);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to a spectrum video output single picture.
/// </summary>
public static ShowspectrumpicFilterGen ShowspectrumpicFilterGen(this AudioMap input0) => new ShowspectrumpicFilterGen(input0);
}
/// <summary>
///  set channel display mode (from 0 to 1) (default combined)
/// </summary>
public enum ShowspectrumpicFilterGenMode
{
/// <summary>
/// combined        0            ..FV....... combined mode
/// </summary>
[Name("combined")] combined,
/// <summary>
/// separate        1            ..FV....... separate mode
/// </summary>
[Name("separate")] separate,
}

/// <summary>
///  set channel coloring (from 0 to 14) (default intensity)
/// </summary>
public enum ShowspectrumpicFilterGenColor
{
/// <summary>
/// channel         0            ..FV....... separate color for each channel
/// </summary>
[Name("channel")] channel,
/// <summary>
/// intensity       1            ..FV....... intensity based coloring
/// </summary>
[Name("intensity")] intensity,
/// <summary>
/// rainbow         2            ..FV....... rainbow based coloring
/// </summary>
[Name("rainbow")] rainbow,
/// <summary>
/// moreland        3            ..FV....... moreland based coloring
/// </summary>
[Name("moreland")] moreland,
/// <summary>
/// nebulae         4            ..FV....... nebulae based coloring
/// </summary>
[Name("nebulae")] nebulae,
/// <summary>
/// fire            5            ..FV....... fire based coloring
/// </summary>
[Name("fire")] fire,
/// <summary>
/// fiery           6            ..FV....... fiery based coloring
/// </summary>
[Name("fiery")] fiery,
/// <summary>
/// fruit           7            ..FV....... fruit based coloring
/// </summary>
[Name("fruit")] fruit,
/// <summary>
/// cool            8            ..FV....... cool based coloring
/// </summary>
[Name("cool")] cool,
/// <summary>
/// magma           9            ..FV....... magma based coloring
/// </summary>
[Name("magma")] magma,
/// <summary>
/// green           10           ..FV....... green based coloring
/// </summary>
[Name("green")] green,
/// <summary>
/// viridis         11           ..FV....... viridis based coloring
/// </summary>
[Name("viridis")] viridis,
/// <summary>
/// plasma          12           ..FV....... plasma based coloring
/// </summary>
[Name("plasma")] plasma,
/// <summary>
/// cividis         13           ..FV....... cividis based coloring
/// </summary>
[Name("cividis")] cividis,
/// <summary>
/// terrain         14           ..FV....... terrain based coloring
/// </summary>
[Name("terrain")] terrain,
}

/// <summary>
///  set display scale (from 0 to 5) (default log)
/// </summary>
public enum ShowspectrumpicFilterGenScale
{
/// <summary>
/// lin             0            ..FV....... linear
/// </summary>
[Name("lin")] lin,
/// <summary>
/// sqrt            1            ..FV....... square root
/// </summary>
[Name("sqrt")] sqrt,
/// <summary>
/// cbrt            2            ..FV....... cubic root
/// </summary>
[Name("cbrt")] cbrt,
/// <summary>
/// log             3            ..FV....... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// 4thrt           4            ..FV....... 4th root
/// </summary>
[Name("4thrt")] _4thrt,
/// <summary>
/// 5thrt           5            ..FV....... 5th root
/// </summary>
[Name("5thrt")] _5thrt,
}

/// <summary>
///  set frequency scale (from 0 to 1) (default lin)
/// </summary>
public enum ShowspectrumpicFilterGenFscale
{
/// <summary>
/// lin             0            ..FV....... linear
/// </summary>
[Name("lin")] lin,
/// <summary>
/// log             1            ..FV....... logarithmic
/// </summary>
[Name("log")] log,
}

/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public enum ShowspectrumpicFilterGenWin_func
{
/// <summary>
/// rect            0            ..FV....... Rectangular
/// </summary>
[Name("rect")] rect,
/// <summary>
/// bartlett        4            ..FV....... Bartlett
/// </summary>
[Name("bartlett")] bartlett,
/// <summary>
/// hann            1            ..FV....... Hann
/// </summary>
[Name("hann")] hann,
/// <summary>
/// hanning         1            ..FV....... Hanning
/// </summary>
[Name("hanning")] hanning,
/// <summary>
/// hamming         2            ..FV....... Hamming
/// </summary>
[Name("hamming")] hamming,
/// <summary>
/// blackman        3            ..FV....... Blackman
/// </summary>
[Name("blackman")] blackman,
/// <summary>
/// welch           5            ..FV....... Welch
/// </summary>
[Name("welch")] welch,
/// <summary>
/// flattop         6            ..FV....... Flat-top
/// </summary>
[Name("flattop")] flattop,
/// <summary>
/// bharris         7            ..FV....... Blackman-Harris
/// </summary>
[Name("bharris")] bharris,
/// <summary>
/// bnuttall        8            ..FV....... Blackman-Nuttall
/// </summary>
[Name("bnuttall")] bnuttall,
/// <summary>
/// bhann           11           ..FV....... Bartlett-Hann
/// </summary>
[Name("bhann")] bhann,
/// <summary>
/// sine            9            ..FV....... Sine
/// </summary>
[Name("sine")] sine,
/// <summary>
/// nuttall         10           ..FV....... Nuttall
/// </summary>
[Name("nuttall")] nuttall,
/// <summary>
/// lanczos         12           ..FV....... Lanczos
/// </summary>
[Name("lanczos")] lanczos,
/// <summary>
/// gauss           13           ..FV....... Gauss
/// </summary>
[Name("gauss")] gauss,
/// <summary>
/// tukey           14           ..FV....... Tukey
/// </summary>
[Name("tukey")] tukey,
/// <summary>
/// dolph           15           ..FV....... Dolph-Chebyshev
/// </summary>
[Name("dolph")] dolph,
/// <summary>
/// cauchy          16           ..FV....... Cauchy
/// </summary>
[Name("cauchy")] cauchy,
/// <summary>
/// parzen          17           ..FV....... Parzen
/// </summary>
[Name("parzen")] parzen,
/// <summary>
/// poisson         18           ..FV....... Poisson
/// </summary>
[Name("poisson")] poisson,
/// <summary>
/// bohman          19           ..FV....... Bohman
/// </summary>
[Name("bohman")] bohman,
/// <summary>
/// kaiser          20           ..FV....... Kaiser
/// </summary>
[Name("kaiser")] kaiser,
}

/// <summary>
///  set orientation (from 0 to 1) (default vertical)
/// </summary>
public enum ShowspectrumpicFilterGenOrientation
{
/// <summary>
/// vertical        0            ..FV.......
/// </summary>
[Name("vertical")] vertical,
/// <summary>
/// horizontal      1            ..FV.......
/// </summary>
[Name("horizontal")] horizontal,
}

}
