namespace FFmpegArgs.Filters.Autogens
{
public class Lut3dFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Lut3dFilterGen(ImageMap input) : base("lut3d",input) { AddMapOut(); }
/// <summary>
///  set 3D LUT file name
/// </summary>
public Lut3dFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public Lut3dFilterGen interp(Lut3dFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
}
public static class Lut3dFilterGenExtensions
{
/// <summary>
/// Adjust colors using a 3D LUT.
/// </summary>
public static Lut3dFilterGen Lut3dFilterGen(this ImageMap input0) => new Lut3dFilterGen(input0);
/// <summary>
/// Adjust colors using a 3D LUT.
/// </summary>
public static Lut3dFilterGen Lut3dFilterGen(this ImageMap input0,Lut3dFilterGenConfig config)
{
var result = new Lut3dFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.file)) result.file(config.file);
if(config?.interp != null) result.interp(config.interp.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class Lut3dFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set 3D LUT file name
/// </summary>
public string file { get; set; }
/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public Lut3dFilterGenInterp? interp { get; set; }
public string TimelineSupport { get; set; }
}
public enum Lut3dFilterGenInterp
{
[Name("nearest")] nearest,
[Name("trilinear")] trilinear,
[Name("tetrahedral")] tetrahedral,
[Name("pyramid")] pyramid,
[Name("prism")] prism,
}

}
