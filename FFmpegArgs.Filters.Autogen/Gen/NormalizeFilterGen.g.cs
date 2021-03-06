namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C normalize         V->V       Normalize RGB video.
/// </summary>
public class NormalizeFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal NormalizeFilterGen(ImageMap input) : base("normalize",input) { AddMapOut(); }
/// <summary>
///  output color to which darkest input color is mapped (default "black")
/// </summary>
public NormalizeFilterGen blackpt(Color blackpt) => this.SetOption("blackpt",blackpt.ToHexStringRGBA());
/// <summary>
///  output color to which brightest input color is mapped (default "white")
/// </summary>
public NormalizeFilterGen whitept(Color whitept) => this.SetOption("whitept",whitept.ToHexStringRGBA());
/// <summary>
///  amount of temporal smoothing of the input range, to reduce flicker (from 0 to 2.68435e+08) (default 0)
/// </summary>
public NormalizeFilterGen smoothing(int smoothing) => this.SetOptionRange("smoothing", smoothing,0,2.68435e+08);
/// <summary>
///  proportion of independent to linked channel normalization (from 0 to 1) (default 1)
/// </summary>
public NormalizeFilterGen independence(float independence) => this.SetOptionRange("independence", independence,0,1);
/// <summary>
///  strength of filter, from no effect to full normalization (from 0 to 1) (default 1)
/// </summary>
public NormalizeFilterGen strength(float strength) => this.SetOptionRange("strength", strength,0,1);
}
/// <summary>
/// </summary>
public static class NormalizeFilterGenExtensions
{
/// <summary>
/// Normalize RGB video.
/// </summary>
public static NormalizeFilterGen NormalizeFilterGen(this ImageMap input0) => new NormalizeFilterGen(input0);
}
}
