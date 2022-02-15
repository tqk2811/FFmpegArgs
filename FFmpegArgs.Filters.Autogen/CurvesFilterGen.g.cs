namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC curves            V->V       Adjust components curves.
/// </summary>
public class CurvesFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal CurvesFilterGen(ImageMap input) : base("curves",input) { AddMapOut(); }
/// <summary>
///  select a color curves preset (from 0 to 10) (default none)
/// </summary>
public CurvesFilterGen preset(CurvesFilterGenPreset preset) => this.SetOption("preset", preset.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set master points coordinates
/// </summary>
public CurvesFilterGen master(string master) => this.SetOption("master",master);
/// <summary>
///  set red points coordinates
/// </summary>
public CurvesFilterGen red(string red) => this.SetOption("red",red);
/// <summary>
///  set green points coordinates
/// </summary>
public CurvesFilterGen green(string green) => this.SetOption("green",green);
/// <summary>
///  set blue points coordinates
/// </summary>
public CurvesFilterGen blue(string blue) => this.SetOption("blue",blue);
/// <summary>
///  set points coordinates for all components
/// </summary>
public CurvesFilterGen all(string all) => this.SetOption("all",all);
/// <summary>
///  set Photoshop curves file name
/// </summary>
public CurvesFilterGen psfile(string psfile) => this.SetOption("psfile",psfile);
/// <summary>
///  save Gnuplot script of the curves in specified file
/// </summary>
public CurvesFilterGen plot(string plot) => this.SetOption("plot",plot);
}
/// <summary>
/// </summary>
public static class CurvesFilterGenExtensions
{
/// <summary>
/// Adjust components curves.
/// </summary>
public static CurvesFilterGen CurvesFilterGen(this ImageMap input0) => new CurvesFilterGen(input0);
}
/// <summary>
///  select a color curves preset (from 0 to 10) (default none)
/// </summary>
public enum CurvesFilterGenPreset
{
/// <summary>
/// none            0            ..FV.....T.
/// </summary>
[Name("none")] none,
/// <summary>
/// color_negative  1            ..FV.....T.
/// </summary>
[Name("color_negative")] color_negative,
/// <summary>
/// cross_process   2            ..FV.....T.
/// </summary>
[Name("cross_process")] cross_process,
/// <summary>
/// darker          3            ..FV.....T.
/// </summary>
[Name("darker")] darker,
/// <summary>
/// increase_contrast 4            ..FV.....T.
/// </summary>
[Name("increase_contrast")] increase_contrast,
/// <summary>
/// lighter         5            ..FV.....T.
/// </summary>
[Name("lighter")] lighter,
/// <summary>
/// linear_contrast 6            ..FV.....T.
/// </summary>
[Name("linear_contrast")] linear_contrast,
/// <summary>
/// medium_contrast 7            ..FV.....T.
/// </summary>
[Name("medium_contrast")] medium_contrast,
/// <summary>
/// negative        8            ..FV.....T.
/// </summary>
[Name("negative")] negative,
/// <summary>
/// strong_contrast 9            ..FV.....T.
/// </summary>
[Name("strong_contrast")] strong_contrast,
/// <summary>
/// vintage         10           ..FV.....T.
/// </summary>
[Name("vintage")] vintage,
}

}
