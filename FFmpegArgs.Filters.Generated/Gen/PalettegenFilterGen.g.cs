namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... palettegen        V->V       Find the optimal palette for a given stream.
/// </summary>
public class PalettegenFilterGen : ImageToImageFilter
{
internal PalettegenFilterGen(ImageMap input) : base("palettegen",input) { AddMapOut(); }
/// <summary>
///  set the maximum number of colors to use in the palette (from 2 to 256) (default 256)
/// </summary>
public PalettegenFilterGen max_colors(int max_colors) => this.SetOptionRange("max_colors", max_colors,2,256);
/// <summary>
///  reserve a palette entry for transparency (default true)
/// </summary>
public PalettegenFilterGen reserve_transparent(bool reserve_transparent) => this.SetOption("reserve_transparent",reserve_transparent.ToFFmpegFlag());
/// <summary>
///  set a background color for transparency (default "lime")
/// </summary>
public PalettegenFilterGen transparency_color(Color transparency_color) => this.SetOption("transparency_color",transparency_color.ToHexStringRGBA());
/// <summary>
///  set statistics mode (from 0 to 2) (default full)
/// </summary>
public PalettegenFilterGen stats_mode(PalettegenFilterGenStats_mode stats_mode) => this.SetOption("stats_mode", stats_mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class PalettegenFilterGenExtensions
{
/// <summary>
/// Find the optimal palette for a given stream.
/// </summary>
public static PalettegenFilterGen PalettegenFilterGen(this ImageMap input0) => new PalettegenFilterGen(input0);
}
/// <summary>
///  set statistics mode (from 0 to 2) (default full)
/// </summary>
public enum PalettegenFilterGenStats_mode
{
/// <summary>
/// full            0            ..FV....... compute full frame histograms
/// </summary>
[Name("full")] full,
/// <summary>
/// diff            1            ..FV....... compute histograms only for the part that differs from previous frame
/// </summary>
[Name("diff")] diff,
/// <summary>
/// single          2            ..FV....... compute new histogram for each frame
/// </summary>
[Name("single")] single,
}

}
