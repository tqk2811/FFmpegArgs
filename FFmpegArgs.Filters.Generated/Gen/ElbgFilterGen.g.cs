namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... elbg              V-&gt;V       Apply posterize effect, using the ELBG algorithm.
/// </summary>
public class ElbgFilterGen : ImageToImageFilter
{
internal ElbgFilterGen(ImageMap input) : base("elbg",input) { AddMapOut(); }
/// <summary>
///  set codebook length (from 1 to INT_MAX) (default 256)
/// </summary>
public ElbgFilterGen codebook_length(int codebook_length) => this.SetOptionRange("codebook_length", codebook_length,1,INT_MAX);
/// <summary>
///  set codebook length (from 1 to INT_MAX) (default 256)
/// </summary>
public ElbgFilterGen l(int l) => this.SetOptionRange("l", l,1,INT_MAX);
/// <summary>
///  set max number of steps used to compute the mapping (from 1 to INT_MAX) (default 1)
/// </summary>
public ElbgFilterGen nb_steps(int nb_steps) => this.SetOptionRange("nb_steps", nb_steps,1,INT_MAX);
/// <summary>
///  set the random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public ElbgFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set the pal8 output (default false)
/// </summary>
public ElbgFilterGen pal8(bool pal8) => this.SetOption("pal8",pal8.ToFFmpegFlag());
/// <summary>
///  use alpha channel for mapping (default false)
/// </summary>
public ElbgFilterGen use_alpha(bool use_alpha) => this.SetOption("use_alpha",use_alpha.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply posterize effect, using the ELBG algorithm.
/// </summary>
public static ElbgFilterGen ElbgFilterGen(this ImageMap input0) => new ElbgFilterGen(input0);
}
}
