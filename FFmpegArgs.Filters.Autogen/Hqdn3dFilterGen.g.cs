namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC hqdn3d            V->V       Apply a High Quality 3D Denoiser.
/// </summary>
public class Hqdn3dFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Hqdn3dFilterGen(ImageMap input) : base("hqdn3d",input) { AddMapOut(); }
/// <summary>
///  spatial luma strength (from 0 to DBL_MAX) (default 0)
/// </summary>
public Hqdn3dFilterGen luma_spatial(double luma_spatial) => this.SetOptionRange("luma_spatial", luma_spatial,0,DBL_MAX);
/// <summary>
///  spatial chroma strength (from 0 to DBL_MAX) (default 0)
/// </summary>
public Hqdn3dFilterGen chroma_spatial(double chroma_spatial) => this.SetOptionRange("chroma_spatial", chroma_spatial,0,DBL_MAX);
/// <summary>
///  temporal luma strength (from 0 to DBL_MAX) (default 0)
/// </summary>
public Hqdn3dFilterGen luma_tmp(double luma_tmp) => this.SetOptionRange("luma_tmp", luma_tmp,0,DBL_MAX);
/// <summary>
///  temporal chroma strength (from 0 to DBL_MAX) (default 0)
/// </summary>
public Hqdn3dFilterGen chroma_tmp(double chroma_tmp) => this.SetOptionRange("chroma_tmp", chroma_tmp,0,DBL_MAX);
}
/// <summary>
/// </summary>
public static class Hqdn3dFilterGenExtensions
{
/// <summary>
/// Apply a High Quality 3D Denoiser.
/// </summary>
public static Hqdn3dFilterGen Hqdn3dFilterGen(this ImageMap input0) => new Hqdn3dFilterGen(input0);
}
}
