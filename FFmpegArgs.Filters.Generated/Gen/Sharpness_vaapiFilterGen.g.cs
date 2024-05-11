namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... sharpness_vaapi   V-&gt;V       VAAPI VPP for sharpness
/// </summary>
public class Sharpness_vaapiFilterGen : ImageToImageFilter
{
internal Sharpness_vaapiFilterGen(ImageMap input) : base("sharpness_vaapi",input) { AddMapOut(); }
/// <summary>
///  sharpness level (from 0 to 64) (default 44)
/// </summary>
public Sharpness_vaapiFilterGen sharpness(int sharpness) => this.SetOptionRange("sharpness", sharpness,0,64);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// VAAPI VPP for sharpness
/// </summary>
public static Sharpness_vaapiFilterGen Sharpness_vaapiFilterGen(this ImageMap input0) => new Sharpness_vaapiFilterGen(input0);
}
}
