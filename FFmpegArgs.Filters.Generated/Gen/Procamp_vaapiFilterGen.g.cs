namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... procamp_vaapi     V->V       ProcAmp (color balance) adjustments for hue, saturation, brightness, contrast
/// </summary>
public class Procamp_vaapiFilterGen : ImageToImageFilter
{
internal Procamp_vaapiFilterGen(ImageMap input) : base("procamp_vaapi",input) { AddMapOut(); }
/// <summary>
///  Output video brightness (from -100 to 100) (default 0)
/// </summary>
public Procamp_vaapiFilterGen brightness(float brightness) => this.SetOptionRange("brightness", brightness,-100,100);
/// <summary>
///  Output video saturation (from 0 to 10) (default 1)
/// </summary>
public Procamp_vaapiFilterGen saturatio(float saturatio) => this.SetOptionRange("saturatio", saturatio,0,10);
/// <summary>
///  Output video contrast (from 0 to 10) (default 1)
/// </summary>
public Procamp_vaapiFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast,0,10);
/// <summary>
///  Output video hue (from -180 to 180) (default 0)
/// </summary>
public Procamp_vaapiFilterGen hue(float hue) => this.SetOptionRange("hue", hue,-180,180);
}
/// <summary>
/// </summary>
public static class Procamp_vaapiFilterGenExtensions
{
/// <summary>
/// ProcAmp (color balance) adjustments for hue, saturation, brightness, contrast
/// </summary>
public static Procamp_vaapiFilterGen Procamp_vaapiFilterGen(this ImageMap input0) => new Procamp_vaapiFilterGen(input0);
}
}
