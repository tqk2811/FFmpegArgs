namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... scale_vulkan      V->V       Scale Vulkan frames
/// </summary>
public class Scale_vulkanFilterGen : ImageToImageFilter
{
internal Scale_vulkanFilterGen(ImageMap input) : base("scale_vulkan",input) { AddMapOut(); }
/// <summary>
///  Output video width (default "iw")
/// </summary>
public Scale_vulkanFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video height (default "ih")
/// </summary>
public Scale_vulkanFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Scaler function (from 0 to 2) (default bilinear)
/// </summary>
public Scale_vulkanFilterGen scaler(Scale_vulkanFilterGenScaler scaler) => this.SetOption("scaler", scaler.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output video format (software format of hardware frames)
/// </summary>
public Scale_vulkanFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
/// </summary>
public Scale_vulkanFilterGen out_range(Scale_vulkanFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class Scale_vulkanFilterGenExtensions
{
/// <summary>
/// Scale Vulkan frames
/// </summary>
public static Scale_vulkanFilterGen Scale_vulkanFilterGen(this ImageMap input0) => new Scale_vulkanFilterGen(input0);
}
/// <summary>
///  Scaler function (from 0 to 2) (default bilinear)
/// </summary>
public enum Scale_vulkanFilterGenScaler
{
/// <summary>
/// bilinear        0            ..FV....... Bilinear interpolation (fastest)
/// </summary>
[Name("bilinear")] bilinear,
/// <summary>
/// nearest         1            ..FV....... Nearest (useful for pixel art)
/// </summary>
[Name("nearest")] nearest,
}

/// <summary>
///  Output colour range (from 0 to 2) (default 0) (from 0 to 2) (default 0)
/// </summary>
public enum Scale_vulkanFilterGenOut_range
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
