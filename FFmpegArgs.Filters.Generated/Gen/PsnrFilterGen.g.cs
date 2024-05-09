namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. psnr              VV->V      Calculate the PSNR between two video streams.
/// </summary>
public class PsnrFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal PsnrFilterGen(params ImageMap[] inputs) : base("psnr",inputs) { AddMapOut(); }
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public PsnrFilterGen stats_file(string stats_file) => this.SetOption("stats_file",stats_file);
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public PsnrFilterGen f(string f) => this.SetOption("f",f);
/// <summary>
///  Set the format version for the stats file. (from 1 to 2) (default 1)
/// </summary>
public PsnrFilterGen stats_version(int stats_version) => this.SetOptionRange("stats_version", stats_version,1,2);
/// <summary>
///  Add raw stats (max values) to the output log. (default false)
/// </summary>
public PsnrFilterGen output_max(bool output_max) => this.SetOption("output_max",output_max.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class PsnrFilterGenExtensions
{
/// <summary>
/// Calculate the PSNR between two video streams.
/// </summary>
public static PsnrFilterGen PsnrFilterGen(this ImageMap input0, ImageMap input1) => new PsnrFilterGen(input0, input1);
}
}
