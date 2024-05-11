namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. showspectrum      A->V       Convert input audio to a spectrum video output.
/// </summary>
public class ShowspectrumFilterGen : AudioToImageFilter,ISliceThreading
{
internal ShowspectrumFilterGen(AudioMap input) : base("showspectrum",input) { AddMapOut(); }
/// <summary>
///  set video size (default "640x512")
/// </summary>
public ShowspectrumFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set sliding mode (from 0 to 4) (default replace)
/// </summary>
public ShowspectrumFilterGen slide(ShowspectrumFilterGenSlide slide) => this.SetOption("slide", slide.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set channel display mode (from 0 to 1) (default combined)
/// </summary>
public ShowspectrumFilterGen mode(ShowspectrumFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set channel coloring (from 0 to 14) (default channel)
/// </summary>
public ShowspectrumFilterGen color(ShowspectrumFilterGenColor color) => this.SetOption("color", color.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set display scale (from 0 to 5) (default sqrt)
/// </summary>
public ShowspectrumFilterGen scale(ShowspectrumFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set frequency scale (from 0 to 1) (default lin)
/// </summary>
public ShowspectrumFilterGen fscale(ShowspectrumFilterGenFscale fscale) => this.SetOption("fscale", fscale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  color saturation multiplier (from -10 to 10) (default 1)
/// </summary>
public ShowspectrumFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation,-10,10);
/// <summary>
///  set window function (from 0 to 20) (default hann)
/// </summary>
public ShowspectrumFilterGen win_func(ShowspectrumFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set orientation (from 0 to 1) (default vertical)
/// </summary>
public ShowspectrumFilterGen orientation(ShowspectrumFilterGenOrientation orientation) => this.SetOption("orientation", orientation.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set window overlap (from 0 to 1) (default 0)
/// </summary>
public ShowspectrumFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap,0,1);
/// <summary>
///  set scale gain (from 0 to 128) (default 1)
/// </summary>
public ShowspectrumFilterGen gain(float gain) => this.SetOptionRange("gain", gain,0,128);
/// <summary>
///  set data mode (from 0 to 2) (default magnitude)
/// </summary>
public ShowspectrumFilterGen data(ShowspectrumFilterGenData data) => this.SetOption("data", data.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  color rotation (from -1 to 1) (default 0)
/// </summary>
public ShowspectrumFilterGen rotation(float rotation) => this.SetOptionRange("rotation", rotation,-1,1);
/// <summary>
///  start frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public ShowspectrumFilterGen start(int start) => this.SetOptionRange("start", start,0,INT_MAX);
/// <summary>
///  stop frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public ShowspectrumFilterGen stop(int stop) => this.SetOptionRange("stop", stop,0,INT_MAX);
/// <summary>
///  set video rate (default "auto")
/// </summary>
public ShowspectrumFilterGen fps(string fps) => this.SetOption("fps",fps);
/// <summary>
///  draw legend (default false)
/// </summary>
public ShowspectrumFilterGen legend(bool legend) => this.SetOption("legend",legend.ToFFmpegFlag());
/// <summary>
///  set dynamic range in dBFS (from 10 to 200) (default 120)
/// </summary>
public ShowspectrumFilterGen drange(float drange) => this.SetOptionRange("drange", drange,10,200);
/// <summary>
///  set upper limit in dBFS (from -100 to 100) (default 0)
/// </summary>
public ShowspectrumFilterGen limit(float limit) => this.SetOptionRange("limit", limit,-100,100);
/// <summary>
///  set opacity strength (from 0 to 10) (default 1)
/// </summary>
public ShowspectrumFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,10);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Convert input audio to a spectrum video output.
/// </summary>
public static ShowspectrumFilterGen ShowspectrumFilterGen(this AudioMap input0) => new ShowspectrumFilterGen(input0);
}
/// <summary>
///  set sliding mode (from 0 to 4) (default replace)
/// </summary>
public enum ShowspectrumFilterGenSlide
{
/// <summary>
/// replace         0            ..FV....... replace old columns with new
/// </summary>
[Name("replace")] replace,
/// <summary>
/// scroll          1            ..FV....... scroll from right to left
/// </summary>
[Name("scroll")] scroll,
/// <summary>
/// fullframe       2            ..FV....... return full frames
/// </summary>
[Name("fullframe")] fullframe,
/// <summary>
/// rscroll         3            ..FV....... scroll from left to right
/// </summary>
[Name("rscroll")] rscroll,
/// <summary>
/// lreplace        4            ..FV....... replace from right to left
/// </summary>
[Name("lreplace")] lreplace,
}

/// <summary>
///  set channel display mode (from 0 to 1) (default combined)
/// </summary>
public enum ShowspectrumFilterGenMode
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
///  set channel coloring (from 0 to 14) (default channel)
/// </summary>
public enum ShowspectrumFilterGenColor
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
///  set display scale (from 0 to 5) (default sqrt)
/// </summary>
public enum ShowspectrumFilterGenScale
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
public enum ShowspectrumFilterGenFscale
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
public enum ShowspectrumFilterGenWin_func
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
public enum ShowspectrumFilterGenOrientation
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

/// <summary>
///  set data mode (from 0 to 2) (default magnitude)
/// </summary>
public enum ShowspectrumFilterGenData
{
/// <summary>
/// magnitude       0            ..FV.......
/// </summary>
[Name("magnitude")] magnitude,
/// <summary>
/// phase           1            ..FV.......
/// </summary>
[Name("phase")] phase,
/// <summary>
/// uphase          2            ..FV.......
/// </summary>
[Name("uphase")] uphase,
}

}
