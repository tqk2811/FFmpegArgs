namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... thistogram        V->V       Compute and draw a temporal histogram.
/// </summary>
public class ThistogramFilterGen : ImageToImageFilter
{
internal ThistogramFilterGen(ImageMap input) : base("thistogram",input) { AddMapOut(); }
/// <summary>
///  set width (from 0 to 8192) (default 0)
/// </summary>
public ThistogramFilterGen width(int width) => this.SetOptionRange("width", width,0,8192);
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public ThistogramFilterGen display_mode(ThistogramFilterGenDisplay_mode display_mode) => this.SetOption("display_mode", display_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public ThistogramFilterGen levels_mode(ThistogramFilterGenLevels_mode levels_mode) => this.SetOption("levels_mode", levels_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public ThistogramFilterGen m(ThistogramFilterGenM m) => this.SetOption("m", m.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set color components to display (from 1 to 15) (default 7)
/// </summary>
public ThistogramFilterGen components(int components) => this.SetOptionRange("components", components,1,15);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.9)
/// </summary>
public ThistogramFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
/// <summary>
///  display envelope (default false)
/// </summary>
public ThistogramFilterGen envelope(bool envelope) => this.SetOption("envelope",envelope.ToFFmpegFlag());
/// <summary>
///  set envelope color (default "gold")
/// </summary>
public ThistogramFilterGen ecolor(Color ecolor) => this.SetOption("ecolor",ecolor.ToHexStringRGBA());
/// <summary>
///  set slide mode (from 0 to 4) (default replace)
/// </summary>
public ThistogramFilterGen slide(ThistogramFilterGenSlide slide) => this.SetOption("slide", slide.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class ThistogramFilterGenExtensions
{
/// <summary>
/// Compute and draw a temporal histogram.
/// </summary>
public static ThistogramFilterGen ThistogramFilterGen(this ImageMap input0) => new ThistogramFilterGen(input0);
}
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public enum ThistogramFilterGenDisplay_mode
{
/// <summary>
/// overlay         0            ..FV.......
/// </summary>
[Name("overlay")] overlay,
/// <summary>
/// parade          1            ..FV.......
/// </summary>
[Name("parade")] parade,
/// <summary>
/// stack           2            ..FV.......
/// </summary>
[Name("stack")] stack,
}

/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public enum ThistogramFilterGenLevels_mode
{
/// <summary>
/// linear          0            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// logarithmic     1            ..FV.......
/// </summary>
[Name("logarithmic")] logarithmic,
}

/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public enum ThistogramFilterGenM
{
/// <summary>
/// linear          0            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// logarithmic     1            ..FV.......
/// </summary>
[Name("logarithmic")] logarithmic,
}

/// <summary>
///  set slide mode (from 0 to 4) (default replace)
/// </summary>
public enum ThistogramFilterGenSlide
{
/// <summary>
/// frame           0            ..FV....... draw new frames
/// </summary>
[Name("frame")] frame,
/// <summary>
/// replace         1            ..FV....... replace old columns with new
/// </summary>
[Name("replace")] replace,
/// <summary>
/// scroll          2            ..FV....... scroll from right to left
/// </summary>
[Name("scroll")] scroll,
/// <summary>
/// rscroll         3            ..FV....... scroll from left to right
/// </summary>
[Name("rscroll")] rscroll,
/// <summary>
/// picture         4            ..FV....... display graph in single frame
/// </summary>
[Name("picture")] picture,
}

}
