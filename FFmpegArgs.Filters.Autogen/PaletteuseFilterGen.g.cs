namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... paletteuse        VV->V      Use a palette to downsample an input video stream.
/// </summary>
public class PaletteuseFilterGen : ImageToImageFilter
{
internal PaletteuseFilterGen(params ImageMap[] inputs) : base("paletteuse",inputs) { AddMapOut(); }
/// <summary>
///  select dithering mode (from 0 to 5) (default sierra2_4a)
/// </summary>
public PaletteuseFilterGen dither(PaletteuseFilterGenDither dither) => this.SetOption("dither", dither.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set scale for bayer dithering (from 0 to 5) (default 2)
/// </summary>
public PaletteuseFilterGen bayer_scale(int bayer_scale) => this.SetOptionRange("bayer_scale", bayer_scale,0,5);
/// <summary>
///  set frame difference mode (from 0 to 1) (default 0)
/// </summary>
public PaletteuseFilterGen diff_mode(PaletteuseFilterGenDiff_mode diff_mode) => this.SetOption("diff_mode", diff_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  take new palette for each output frame (default false)
/// </summary>
public PaletteuseFilterGen _new(bool _new) => this.SetOption("new",_new.ToFFmpegFlag());
/// <summary>
///  set the alpha threshold for transparency (from 0 to 255) (default 128)
/// </summary>
public PaletteuseFilterGen alpha_threshold(int alpha_threshold) => this.SetOptionRange("alpha_threshold", alpha_threshold,0,255);
/// <summary>
///  use alpha channel for mapping (default false)
/// </summary>
public PaletteuseFilterGen use_alpha(bool use_alpha) => this.SetOption("use_alpha",use_alpha.ToFFmpegFlag());
/// <summary>
///  save Graphviz graph of the kdtree in specified file
/// </summary>
public PaletteuseFilterGen debug_kdtree(string debug_kdtree) => this.SetOption("debug_kdtree",debug_kdtree);
/// <summary>
///  set reverse colormap color search method (from 0 to 2) (default nns_iterative)
/// </summary>
public PaletteuseFilterGen color_search(PaletteuseFilterGenColor_search color_search) => this.SetOption("color_search", color_search.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  compute and print mean error (default false)
/// </summary>
public PaletteuseFilterGen mean_err(bool mean_err) => this.SetOption("mean_err",mean_err.ToFFmpegFlag());
/// <summary>
///  test color search accuracy (default false)
/// </summary>
public PaletteuseFilterGen debug_accuracy(bool debug_accuracy) => this.SetOption("debug_accuracy",debug_accuracy.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class PaletteuseFilterGenExtensions
{
/// <summary>
/// Use a palette to downsample an input video stream.
/// </summary>
public static PaletteuseFilterGen PaletteuseFilterGen(this ImageMap input0, ImageMap input1) => new PaletteuseFilterGen(input0, input1);
}
/// <summary>
///  select dithering mode (from 0 to 5) (default sierra2_4a)
/// </summary>
public enum PaletteuseFilterGenDither
{
/// <summary>
/// bayer           1            ..FV....... ordered 8x8 bayer dithering (deterministic)
/// </summary>
[Name("bayer")] bayer,
/// <summary>
/// heckbert        2            ..FV....... dithering as defined by Paul Heckbert in 1982 (simple error diffusion)
/// </summary>
[Name("heckbert")] heckbert,
/// <summary>
/// floyd_steinberg 3            ..FV....... Floyd and Steingberg dithering (error diffusion)
/// </summary>
[Name("floyd_steinberg")] floyd_steinberg,
/// <summary>
/// sierra2         4            ..FV....... Frankie Sierra dithering v2 (error diffusion)
/// </summary>
[Name("sierra2")] sierra2,
/// <summary>
/// sierra2_4a      5            ..FV....... Frankie Sierra dithering v2 "Lite" (error diffusion)
/// </summary>
[Name("sierra2_4a")] sierra2_4a,
}

/// <summary>
///  set frame difference mode (from 0 to 1) (default 0)
/// </summary>
public enum PaletteuseFilterGenDiff_mode
{
/// <summary>
/// rectangle       1            ..FV....... process smallest different rectangle
/// </summary>
[Name("rectangle")] rectangle,
}

/// <summary>
///  set reverse colormap color search method (from 0 to 2) (default nns_iterative)
/// </summary>
public enum PaletteuseFilterGenColor_search
{
/// <summary>
/// nns_iterative   0            ..FV....... iterative search
/// </summary>
[Name("nns_iterative")] nns_iterative,
/// <summary>
/// nns_recursive   1            ..FV....... recursive search
/// </summary>
[Name("nns_recursive")] nns_recursive,
/// <summary>
/// bruteforce      2            ..FV....... brute-force into the palette
/// </summary>
[Name("bruteforce")] bruteforce,
}

}
