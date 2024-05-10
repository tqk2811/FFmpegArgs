namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC rgbashift         V->V       Shift RGBA.
/// </summary>
public class RgbashiftFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal RgbashiftFilterGen(ImageMap input) : base("rgbashift",input) { AddMapOut(); }
/// <summary>
///  shift red horizontally (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen rh(int rh) => this.SetOptionRange("rh", rh,-255,255);
/// <summary>
///  shift red vertically (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen rv(int rv) => this.SetOptionRange("rv", rv,-255,255);
/// <summary>
///  shift green horizontally (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen gh(int gh) => this.SetOptionRange("gh", gh,-255,255);
/// <summary>
///  shift green vertically (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen gv(int gv) => this.SetOptionRange("gv", gv,-255,255);
/// <summary>
///  shift blue horizontally (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen bh(int bh) => this.SetOptionRange("bh", bh,-255,255);
/// <summary>
///  shift blue vertically (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen bv(int bv) => this.SetOptionRange("bv", bv,-255,255);
/// <summary>
///  shift alpha horizontally (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen ah(int ah) => this.SetOptionRange("ah", ah,-255,255);
/// <summary>
///  shift alpha vertically (from -255 to 255) (default 0)
/// </summary>
public RgbashiftFilterGen av(int av) => this.SetOptionRange("av", av,-255,255);
/// <summary>
///  set edge operation (from 0 to 1) (default smear)
/// </summary>
public RgbashiftFilterGen edge(RgbashiftFilterGenEdge edge) => this.SetOption("edge", edge.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Shift RGBA.
/// </summary>
public static RgbashiftFilterGen RgbashiftFilterGen(this ImageMap input0) => new RgbashiftFilterGen(input0);
}
/// <summary>
///  set edge operation (from 0 to 1) (default smear)
/// </summary>
public enum RgbashiftFilterGenEdge
{
/// <summary>
/// smear           0            ..FV.....T.
/// </summary>
[Name("smear")] smear,
/// <summary>
/// wrap            1            ..FV.....T.
/// </summary>
[Name("wrap")] wrap,
}

}
