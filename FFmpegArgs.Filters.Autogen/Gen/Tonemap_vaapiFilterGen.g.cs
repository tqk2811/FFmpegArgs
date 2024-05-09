namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... tonemap_vaapi     V->V       VAAPI VPP for tone-mapping
/// </summary>
public class Tonemap_vaapiFilterGen : ImageToImageFilter
{
internal Tonemap_vaapiFilterGen(ImageMap input) : base("tonemap_vaapi",input) { AddMapOut(); }
/// <summary>
///  Output pixel format set
/// </summary>
public Tonemap_vaapiFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  Output color matrix coefficient set
/// </summary>
public Tonemap_vaapiFilterGen matrix(string matrix) => this.SetOption("matrix",matrix);
/// <summary>
///  Output color primaries set
/// </summary>
public Tonemap_vaapiFilterGen primaries(string primaries) => this.SetOption("primaries",primaries);
/// <summary>
///  Output color transfer characteristics set
/// </summary>
public Tonemap_vaapiFilterGen transfer(string transfer) => this.SetOption("transfer",transfer);
}
/// <summary>
/// </summary>
public static class Tonemap_vaapiFilterGenExtensions
{
/// <summary>
/// VAAPI VPP for tone-mapping
/// </summary>
public static Tonemap_vaapiFilterGen Tonemap_vaapiFilterGen(this ImageMap input0) => new Tonemap_vaapiFilterGen(input0);
}
}
