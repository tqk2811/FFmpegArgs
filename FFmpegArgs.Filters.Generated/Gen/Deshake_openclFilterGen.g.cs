namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... deshake_opencl    V->V       Feature-point based video stabilization filter
/// </summary>
public class Deshake_openclFilterGen : ImageToImageFilter
{
internal Deshake_openclFilterGen(ImageMap input) : base("deshake_opencl",input) { AddMapOut(); }
/// <summary>
///  simulates a tripod by preventing any camera movement whatsoever from the original frame (default false)
/// </summary>
public Deshake_openclFilterGen tripod(bool tripod) => this.SetOption("tripod",tripod.ToFFmpegFlag());
/// <summary>
///  turn on additional debugging information (default false)
/// </summary>
public Deshake_openclFilterGen debug(bool debug) => this.SetOption("debug",debug.ToFFmpegFlag());
/// <summary>
///  attempt to subtly crop borders to reduce mirrored content (default true)
/// </summary>
public Deshake_openclFilterGen adaptive_crop(bool adaptive_crop) => this.SetOption("adaptive_crop",adaptive_crop.ToFFmpegFlag());
/// <summary>
///  refine feature point locations at a sub-pixel level (default true)
/// </summary>
public Deshake_openclFilterGen refine_features(bool refine_features) => this.SetOption("refine_features",refine_features.ToFFmpegFlag());
/// <summary>
///  smoothing strength (0 attempts to adaptively determine optimal strength) (from 0 to 1) (default 0)
/// </summary>
public Deshake_openclFilterGen smooth_strength(float smooth_strength) => this.SetOptionRange("smooth_strength", smooth_strength,0,1);
/// <summary>
///  multiplier for number of frames to buffer for motion data (from 0.1 to 10) (default 2)
/// </summary>
public Deshake_openclFilterGen smooth_window_multiplier(float smooth_window_multiplier) => this.SetOptionRange("smooth_window_multiplier", smooth_window_multiplier,0.1,10);
}
/// <summary>
/// </summary>
public static class Deshake_openclFilterGenExtensions
{
/// <summary>
/// Feature-point based video stabilization filter
/// </summary>
public static Deshake_openclFilterGen Deshake_openclFilterGen(this ImageMap input0) => new Deshake_openclFilterGen(input0);
}
}
