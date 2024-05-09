namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. blackdetect       V->V       Detect video intervals that are (almost) black.
/// </summary>
public class BlackdetectFilterGen : ImageToImageFilter,ISliceThreading
{
internal BlackdetectFilterGen(ImageMap input) : base("blackdetect",input) { AddMapOut(); }
/// <summary>
///  set minimum detected black duration in seconds (from 0 to DBL_MAX) (default 2)
/// </summary>
public BlackdetectFilterGen d(double d) => this.SetOptionRange("d", d,0,DBL_MAX);
/// <summary>
///  set minimum detected black duration in seconds (from 0 to DBL_MAX) (default 2)
/// </summary>
public BlackdetectFilterGen black_min_duration(double black_min_duration) => this.SetOptionRange("black_min_duration", black_min_duration,0,DBL_MAX);
/// <summary>
///  set the picture black ratio threshold (from 0 to 1) (default 0.98)
/// </summary>
public BlackdetectFilterGen picture_black_ratio_th(double picture_black_ratio_th) => this.SetOptionRange("picture_black_ratio_th", picture_black_ratio_th,0,1);
/// <summary>
///  set the picture black ratio threshold (from 0 to 1) (default 0.98)
/// </summary>
public BlackdetectFilterGen pic_th(double pic_th) => this.SetOptionRange("pic_th", pic_th,0,1);
/// <summary>
///  set the pixel black threshold (from 0 to 1) (default 0.1)
/// </summary>
public BlackdetectFilterGen pixel_black_th(double pixel_black_th) => this.SetOptionRange("pixel_black_th", pixel_black_th,0,1);
/// <summary>
///  set the pixel black threshold (from 0 to 1) (default 0.1)
/// </summary>
public BlackdetectFilterGen pix_th(double pix_th) => this.SetOptionRange("pix_th", pix_th,0,1);
}
/// <summary>
/// </summary>
public static class BlackdetectFilterGenExtensions
{
/// <summary>
/// Detect video intervals that are (almost) black.
/// </summary>
public static BlackdetectFilterGen BlackdetectFilterGen(this ImageMap input0) => new BlackdetectFilterGen(input0);
}
}
