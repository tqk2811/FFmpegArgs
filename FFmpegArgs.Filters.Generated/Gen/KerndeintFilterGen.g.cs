namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... kerndeint         V->V       Apply kernel deinterlacing to the input.
/// </summary>
public class KerndeintFilterGen : ImageToImageFilter
{
internal KerndeintFilterGen(ImageMap input) : base("kerndeint",input) { AddMapOut(); }
/// <summary>
///  set the threshold (from 0 to 255) (default 10)
/// </summary>
public KerndeintFilterGen thresh(int thresh) => this.SetOptionRange("thresh", thresh,0,255);
/// <summary>
///  set the map (default false)
/// </summary>
public KerndeintFilterGen map(bool map) => this.SetOption("map",map.ToFFmpegFlag());
/// <summary>
///  set the order (default false)
/// </summary>
public KerndeintFilterGen order(bool order) => this.SetOption("order",order.ToFFmpegFlag());
/// <summary>
///  set sharpening (default false)
/// </summary>
public KerndeintFilterGen sharp(bool sharp) => this.SetOption("sharp",sharp.ToFFmpegFlag());
/// <summary>
///  set twoway (default false)
/// </summary>
public KerndeintFilterGen twoway(bool twoway) => this.SetOption("twoway",twoway.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply kernel deinterlacing to the input.
/// </summary>
public static KerndeintFilterGen KerndeintFilterGen(this ImageMap input0) => new KerndeintFilterGen(input0);
}
}
