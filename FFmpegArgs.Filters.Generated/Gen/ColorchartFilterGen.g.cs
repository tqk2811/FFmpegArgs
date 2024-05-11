namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... colorchart        |->V       Generate color checker chart.
/// </summary>
public class ColorchartFilterGen : SourceToImageFilter
{
internal ColorchartFilterGen(IImageFilterGraph input) : base("colorchart",input) { AddMapOut(); }
/// <summary>
///  set video rate (default "25")
/// </summary>
public ColorchartFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public ColorchartFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public ColorchartFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
/// <summary>
///  set the single patch size (default "64x64")
/// </summary>
public ColorchartFilterGen patch_size(Size patch_size) => this.SetOption("patch_size",$"{patch_size.Width}x{patch_size.Height}");
/// <summary>
///  set the color checker chart preset (from 0 to 1) (default reference)
/// </summary>
public ColorchartFilterGen preset(ColorchartFilterGenPreset preset) => this.SetOption("preset", preset.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Generate color checker chart.
/// </summary>
public static ColorchartFilterGen ColorchartFilterGen(this IImageFilterGraph input0) => new ColorchartFilterGen(input0);
}
/// <summary>
///  set the color checker chart preset (from 0 to 1) (default reference)
/// </summary>
public enum ColorchartFilterGenPreset
{
/// <summary>
/// reference       0            ..FV....... reference
/// </summary>
[Name("reference")] reference,
/// <summary>
/// skintones       1            ..FV....... skintones
/// </summary>
[Name("skintones")] skintones,
}

}
