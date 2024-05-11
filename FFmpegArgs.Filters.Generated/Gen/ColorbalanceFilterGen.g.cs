namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC colorbalance      V-&gt;V       Adjust the color balance.
/// </summary>
public class ColorbalanceFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorbalanceFilterGen(ImageMap input) : base("colorbalance",input) { AddMapOut(); }
/// <summary>
///  set red shadows (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen rs(float rs) => this.SetOptionRange("rs", rs,-1,1);
/// <summary>
///  set green shadows (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen gs(float gs) => this.SetOptionRange("gs", gs,-1,1);
/// <summary>
///  set blue shadows (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen bs(float bs) => this.SetOptionRange("bs", bs,-1,1);
/// <summary>
///  set red midtones (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen rm(float rm) => this.SetOptionRange("rm", rm,-1,1);
/// <summary>
///  set green midtones (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen gm(float gm) => this.SetOptionRange("gm", gm,-1,1);
/// <summary>
///  set blue midtones (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen bm(float bm) => this.SetOptionRange("bm", bm,-1,1);
/// <summary>
///  set red highlights (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen rh(float rh) => this.SetOptionRange("rh", rh,-1,1);
/// <summary>
///  set green highlights (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen gh(float gh) => this.SetOptionRange("gh", gh,-1,1);
/// <summary>
///  set blue highlights (from -1 to 1) (default 0)
/// </summary>
public ColorbalanceFilterGen bh(float bh) => this.SetOptionRange("bh", bh,-1,1);
/// <summary>
///  preserve lightness (default false)
/// </summary>
public ColorbalanceFilterGen pl(bool pl) => this.SetOption("pl",pl.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Adjust the color balance.
/// </summary>
public static ColorbalanceFilterGen ColorbalanceFilterGen(this ImageMap input0) => new ColorbalanceFilterGen(input0);
}
}
