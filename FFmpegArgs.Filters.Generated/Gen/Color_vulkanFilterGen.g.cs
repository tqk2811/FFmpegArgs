namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... color_vulkan      |->V       Generate a constant color (Vulkan)
/// </summary>
public class Color_vulkanFilterGen : SourceImageFilter
{
internal Color_vulkanFilterGen(IImageFilterGraph input) : base("color_vulkan",input) { AddMapOut(); }
/// <summary>
///  set color (default "black")
/// </summary>
public Color_vulkanFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set video size (default "1920x1080")
/// </summary>
public Color_vulkanFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "60")
/// </summary>
public Color_vulkanFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Color_vulkanFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Color_vulkanFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
/// <summary>
///  Output video format (software format of hardware frames)
/// </summary>
public Color_vulkanFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
/// </summary>
public Color_vulkanFilterGen out_range(Color_vulkanFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Generate a constant color (Vulkan)
/// </summary>
public static Color_vulkanFilterGen Color_vulkanFilterGen(this IImageFilterGraph input0) => new Color_vulkanFilterGen(input0);
}
/// <summary>
///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
/// </summary>
public enum Color_vulkanFilterGenOut_range
{
/// <summary>
/// full            2            ..FV....... Full range
/// </summary>
[Name("full")] full,
/// <summary>
/// limited         1            ..FV....... Limited range
/// </summary>
[Name("limited")] limited,
/// <summary>
/// jpeg            2            ..FV....... Full range
/// </summary>
[Name("jpeg")] jpeg,
/// <summary>
/// mpeg            1            ..FV....... Limited range
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// tv              1            ..FV....... Limited range
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              2            ..FV....... Full range
/// </summary>
[Name("pc")] pc,
}

}
