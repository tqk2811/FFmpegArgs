namespace FFmpegArgs.Filters.Autogens
{
public class HaldclutFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal HaldclutFilterGen(params ImageMap[] inputs) : base("haldclut",inputs) { AddMapOut(); }
/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public HaldclutFilterGen interp(HaldclutFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
}
public static class HaldclutFilterGenExtensions
{
/// <summary>
/// Adjust colors using a Hald CLUT.
/// </summary>
public static HaldclutFilterGen HaldclutFilterGen(this ImageMap input0, ImageMap input1) => new HaldclutFilterGen(input0, input1);
/// <summary>
/// Adjust colors using a Hald CLUT.
/// </summary>
public static HaldclutFilterGen HaldclutFilterGen(this ImageMap input0, ImageMap input1,HaldclutFilterGenConfig config)
{
var result = new HaldclutFilterGen(input0, input1);
if(config?.interp != null) result.interp(config.interp.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class HaldclutFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public HaldclutFilterGenInterp? interp { get; set; }
public string TimelineSupport { get; set; }
}
public enum HaldclutFilterGenInterp
{
[Name("nearest")] nearest,
[Name("trilinear")] trilinear,
[Name("tetrahedral")] tetrahedral,
[Name("pyramid")] pyramid,
[Name("prism")] prism,
}

}
