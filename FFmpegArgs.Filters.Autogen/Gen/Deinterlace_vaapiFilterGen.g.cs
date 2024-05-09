namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... deinterlace_vaapi V->V       Deinterlacing of VAAPI surfaces
/// </summary>
public class Deinterlace_vaapiFilterGen : ImageToImageFilter
{
internal Deinterlace_vaapiFilterGen(ImageMap input) : base("deinterlace_vaapi",input) { AddMapOut(); }
/// <summary>
///  Deinterlacing mode (from 0 to 4) (default default)
/// </summary>
public Deinterlace_vaapiFilterGen mode(Deinterlace_vaapiFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Generate output at frame rate or field rate (from 1 to 2) (default frame)
/// </summary>
public Deinterlace_vaapiFilterGen rate(Deinterlace_vaapiFilterGenRate rate) => this.SetOption("rate", rate.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Only deinterlace fields, passing frames through unchanged (from 0 to 1) (default 0)
/// </summary>
public Deinterlace_vaapiFilterGen auto(int auto) => this.SetOptionRange("auto", auto,0,1);
}
/// <summary>
/// </summary>
public static class Deinterlace_vaapiFilterGenExtensions
{
/// <summary>
/// Deinterlacing of VAAPI surfaces
/// </summary>
public static Deinterlace_vaapiFilterGen Deinterlace_vaapiFilterGen(this ImageMap input0) => new Deinterlace_vaapiFilterGen(input0);
}
/// <summary>
///  Deinterlacing mode (from 0 to 4) (default default)
/// </summary>
public enum Deinterlace_vaapiFilterGenMode
{
/// <summary>
/// default         0            ..FV....... Use the highest-numbered (and therefore possibly most advanced) deinterlacing algorithm
/// </summary>
[Name("default")] _default,
/// <summary>
/// bob             1            ..FV....... Use the bob deinterlacing algorithm
/// </summary>
[Name("bob")] bob,
/// <summary>
/// weave           2            ..FV....... Use the weave deinterlacing algorithm
/// </summary>
[Name("weave")] weave,
/// <summary>
/// motion_adaptive 3            ..FV....... Use the motion adaptive deinterlacing algorithm
/// </summary>
[Name("motion_adaptive")] motion_adaptive,
/// <summary>
/// motion_compensated 4            ..FV....... Use the motion compensated deinterlacing algorithm
/// </summary>
[Name("motion_compensated")] motion_compensated,
}

/// <summary>
///  Generate output at frame rate or field rate (from 1 to 2) (default frame)
/// </summary>
public enum Deinterlace_vaapiFilterGenRate
{
/// <summary>
/// frame           1            ..FV....... Output at frame rate (one frame of output for each field-pair)
/// </summary>
[Name("frame")] frame,
/// <summary>
/// field           2            ..FV....... Output at field rate (one frame of output for each field)
/// </summary>
[Name("field")] field,
}

}
