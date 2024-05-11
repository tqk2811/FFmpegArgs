namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... ddagrab           |->V       Grab Windows Desktop images using Desktop Duplication API
/// </summary>
public class DdagrabFilterGen : SourceToImageFilter
{
internal DdagrabFilterGen(IImageFilterGraph input) : base("ddagrab",input) { AddMapOut(); }
/// <summary>
///  dda output index to capture (from 0 to INT_MAX) (default 0)
/// </summary>
public DdagrabFilterGen output_idx(int output_idx) => this.SetOptionRange("output_idx", output_idx,0,INT_MAX);
/// <summary>
///  draw the mouse pointer (default true)
/// </summary>
public DdagrabFilterGen draw_mouse(bool draw_mouse) => this.SetOption("draw_mouse",draw_mouse.ToFFmpegFlag());
/// <summary>
///  set video frame rate (default "30")
/// </summary>
public DdagrabFilterGen framerate(Rational framerate) => this.SetOption("framerate",framerate);
/// <summary>
///  set video frame size
/// </summary>
public DdagrabFilterGen video_size(Size video_size) => this.SetOption("video_size",$"{video_size.Width}x{video_size.Height}");
/// <summary>
///  capture area x offset (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public DdagrabFilterGen offset_x(int offset_x) => this.SetOptionRange("offset_x", offset_x,INT_MIN,INT_MAX);
/// <summary>
///  capture area y offset (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public DdagrabFilterGen offset_y(int offset_y) => this.SetOptionRange("offset_y", offset_y,INT_MIN,INT_MAX);
/// <summary>
///  desired output format (from 0 to INT_MAX) (default 8bit)
/// </summary>
public DdagrabFilterGen output_fmt(DdagrabFilterGenOutput_fmt output_fmt) => this.SetOption("output_fmt", output_fmt.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  don't error on fallback to default 8 Bit format (default false)
/// </summary>
public DdagrabFilterGen allow_fallback(bool allow_fallback) => this.SetOption("allow_fallback",allow_fallback.ToFFmpegFlag());
/// <summary>
///  exclude BGRA from format list (experimental, discouraged by Microsoft) (default false)
/// </summary>
public DdagrabFilterGen force_fmt(bool force_fmt) => this.SetOption("force_fmt",force_fmt.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Grab Windows Desktop images using Desktop Duplication API
/// </summary>
public static DdagrabFilterGen DdagrabFilterGen(this IImageFilterGraph input0) => new DdagrabFilterGen(input0);
}
/// <summary>
///  desired output format (from 0 to INT_MAX) (default 8bit)
/// </summary>
public enum DdagrabFilterGenOutput_fmt
{
/// <summary>
/// auto            0            ..FV....... let dda pick its preferred format
/// </summary>
[Name("auto")] auto,
/// <summary>
/// 8bit            87           ..FV....... only output default 8 Bit format
/// </summary>
[Name("8bit")] _8bit,
/// <summary>
/// bgra            87           ..FV....... only output 8 Bit BGRA
/// </summary>
[Name("bgra")] bgra,
/// <summary>
/// 10bit           24           ..FV....... only output default 10 Bit format
/// </summary>
[Name("10bit")] _10bit,
/// <summary>
/// x2bgr10         24           ..FV....... only output 10 Bit X2BGR10
/// </summary>
[Name("x2bgr10")] x2bgr10,
/// <summary>
/// 16bit           10           ..FV....... only output default 16 Bit format
/// </summary>
[Name("16bit")] _16bit,
/// <summary>
/// rgbaf16         10           ..FV....... only output 16 Bit RGBAF16
/// </summary>
[Name("rgbaf16")] rgbaf16,
}

}
