namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... colorkey_opencl   V-&gt;V       Turns a certain color into transparency. Operates on RGB colors.
/// </summary>
public class Colorkey_openclFilterGen : ImageToImageFilter
{
internal Colorkey_openclFilterGen(ImageMap input) : base("colorkey_opencl",input) { AddMapOut(); }
/// <summary>
///  set the colorkey key color (default &quot;black&quot;)
/// </summary>
public Colorkey_openclFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set the colorkey similarity value (from 0.01 to 1) (default 0.01)
/// </summary>
public Colorkey_openclFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,0.01,1);
/// <summary>
///  set the colorkey key blend value (from 0 to 1) (default 0)
/// </summary>
public Colorkey_openclFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Turns a certain color into transparency. Operates on RGB colors.
/// </summary>
public static Colorkey_openclFilterGen Colorkey_openclFilterGen(this ImageMap input0) => new Colorkey_openclFilterGen(input0);
}
}
