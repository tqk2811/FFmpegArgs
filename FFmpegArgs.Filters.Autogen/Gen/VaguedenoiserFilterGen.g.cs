namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. vaguedenoiser     V->V       Apply a Wavelet based Denoiser.
/// </summary>
public class VaguedenoiserFilterGen : ImageToImageFilter,ITimelineSupport
{
internal VaguedenoiserFilterGen(ImageMap input) : base("vaguedenoiser",input) { AddMapOut(); }
/// <summary>
///  set filtering strength (from 0 to DBL_MAX) (default 2)
/// </summary>
public VaguedenoiserFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold,0,DBL_MAX);
/// <summary>
///  set filtering method (from 0 to 2) (default garrote)
/// </summary>
public VaguedenoiserFilterGen method(VaguedenoiserFilterGenMethod method) => this.SetOption("method", method.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set number of steps (from 1 to 32) (default 6)
/// </summary>
public VaguedenoiserFilterGen nsteps(int nsteps) => this.SetOptionRange("nsteps", nsteps,1,32);
/// <summary>
///  set percent of full denoising (from 0 to 100) (default 85)
/// </summary>
public VaguedenoiserFilterGen percent(float percent) => this.SetOptionRange("percent", percent,0,100);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public VaguedenoiserFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set threshold type (from 0 to 1) (default universal)
/// </summary>
public VaguedenoiserFilterGen type(VaguedenoiserFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class VaguedenoiserFilterGenExtensions
{
/// <summary>
/// Apply a Wavelet based Denoiser.
/// </summary>
public static VaguedenoiserFilterGen VaguedenoiserFilterGen(this ImageMap input0) => new VaguedenoiserFilterGen(input0);
}
/// <summary>
///  set filtering method (from 0 to 2) (default garrote)
/// </summary>
public enum VaguedenoiserFilterGenMethod
{
/// <summary>
/// hard            0            ..FV....... hard thresholding
/// </summary>
[Name("hard")] hard,
/// <summary>
/// soft            1            ..FV....... soft thresholding
/// </summary>
[Name("soft")] soft,
/// <summary>
/// garrote         2            ..FV....... garrote thresholding
/// </summary>
[Name("garrote")] garrote,
}

/// <summary>
///  set threshold type (from 0 to 1) (default universal)
/// </summary>
public enum VaguedenoiserFilterGenType
{
/// <summary>
/// universal       0            ..FV....... universal (VisuShrink)
/// </summary>
[Name("universal")] universal,
/// <summary>
/// bayes           1            ..FV....... bayes (BayesShrink)
/// </summary>
[Name("bayes")] bayes,
}

}
