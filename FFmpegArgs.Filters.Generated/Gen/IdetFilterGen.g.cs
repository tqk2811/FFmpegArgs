namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... idet              V->V       Interlace detect Filter.
/// </summary>
public class IdetFilterGen : ImageToImageFilter
{
internal IdetFilterGen(ImageMap input) : base("idet",input) { AddMapOut(); }
/// <summary>
///  set interlacing threshold (from -1 to FLT_MAX) (default 1.04)
/// </summary>
public IdetFilterGen intl_thres(float intl_thres) => this.SetOptionRange("intl_thres", intl_thres,-1,FLT_MAX);
/// <summary>
///  set progressive threshold (from -1 to FLT_MAX) (default 1.5)
/// </summary>
public IdetFilterGen prog_thres(float prog_thres) => this.SetOptionRange("prog_thres", prog_thres,-1,FLT_MAX);
/// <summary>
///  set repeat threshold (from -1 to FLT_MAX) (default 3)
/// </summary>
public IdetFilterGen rep_thres(float rep_thres) => this.SetOptionRange("rep_thres", rep_thres,-1,FLT_MAX);
/// <summary>
///  half life of cumulative statistics (from -1 to INT_MAX) (default 0)
/// </summary>
public IdetFilterGen half_life(float half_life) => this.SetOptionRange("half_life", half_life,-1,INT_MAX);
/// <summary>
///  set number of frames to use to determine if the interlace flag is accurate (from 0 to INT_MAX) (default 0)
/// </summary>
public IdetFilterGen analyze_interlaced_flag(int analyze_interlaced_flag) => this.SetOptionRange("analyze_interlaced_flag", analyze_interlaced_flag,0,INT_MAX);
}
/// <summary>
/// </summary>
public static class IdetFilterGenExtensions
{
/// <summary>
/// Interlace detect Filter.
/// </summary>
public static IdetFilterGen IdetFilterGen(this ImageMap input0) => new IdetFilterGen(input0);
}
}
