namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... denoise_vaapi     V->V       VAAPI VPP for de-noise
/// </summary>
public class Denoise_vaapiFilterGen : ImageToImageFilter
{
internal Denoise_vaapiFilterGen(ImageMap input) : base("denoise_vaapi",input) { AddMapOut(); }
/// <summary>
///  denoise level (from 0 to 64) (default 0)
/// </summary>
public Denoise_vaapiFilterGen denoise(int denoise) => this.SetOptionRange("denoise", denoise,0,64);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// VAAPI VPP for de-noise
/// </summary>
public static Denoise_vaapiFilterGen Denoise_vaapiFilterGen(this ImageMap input0) => new Denoise_vaapiFilterGen(input0);
}
}
