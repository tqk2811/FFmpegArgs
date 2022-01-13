namespace FFmpegArgs.Filters.Autogens
{
public class LenscorrectionFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LenscorrectionFilterGen(ImageMap input) : base("lenscorrection",input) { AddMapOut(); }
/// <summary>
///  set relative center x (from 0 to 1) (default 0.5)
/// </summary>
public LenscorrectionFilterGen cx(double cx) => this.SetOptionRange("cx", cx,0,1);
/// <summary>
///  set relative center y (from 0 to 1) (default 0.5)
/// </summary>
public LenscorrectionFilterGen cy(double cy) => this.SetOptionRange("cy", cy,0,1);
/// <summary>
///  set quadratic distortion factor (from -1 to 1) (default 0)
/// </summary>
public LenscorrectionFilterGen k1(double k1) => this.SetOptionRange("k1", k1,-1,1);
/// <summary>
///  set double quadratic distortion factor (from -1 to 1) (default 0)
/// </summary>
public LenscorrectionFilterGen k2(double k2) => this.SetOptionRange("k2", k2,-1,1);
/// <summary>
///  set interpolation type (from 0 to 64) (default nearest)
/// </summary>
public LenscorrectionFilterGen i(LenscorrectionFilterGenI i) => this.SetOption("i", i.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the color of the unmapped pixels (default "black@0")
/// </summary>
public LenscorrectionFilterGen fc(Color fc) => this.SetOption("fc",fc.ToHexStringRGBA());
}
public static class LenscorrectionFilterGenExtensions
{
/// <summary>
/// Rectify the image by correcting for lens distortion.
/// </summary>
public static LenscorrectionFilterGen LenscorrectionFilterGen(this ImageMap input0) => new LenscorrectionFilterGen(input0);
/// <summary>
/// Rectify the image by correcting for lens distortion.
/// </summary>
public static LenscorrectionFilterGen LenscorrectionFilterGen(this ImageMap input0,LenscorrectionFilterGenConfig config)
{
var result = new LenscorrectionFilterGen(input0);
if(config?.cx != null) result.cx(config.cx.Value);
if(config?.cy != null) result.cy(config.cy.Value);
if(config?.k1 != null) result.k1(config.k1.Value);
if(config?.k2 != null) result.k2(config.k2.Value);
if(config?.i != null) result.i(config.i.Value);
if(config?.fc != null) result.fc(config.fc.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class LenscorrectionFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set relative center x (from 0 to 1) (default 0.5)
/// </summary>
public double? cx { get; set; }
/// <summary>
///  set relative center y (from 0 to 1) (default 0.5)
/// </summary>
public double? cy { get; set; }
/// <summary>
///  set quadratic distortion factor (from -1 to 1) (default 0)
/// </summary>
public double? k1 { get; set; }
/// <summary>
///  set double quadratic distortion factor (from -1 to 1) (default 0)
/// </summary>
public double? k2 { get; set; }
/// <summary>
///  set interpolation type (from 0 to 64) (default nearest)
/// </summary>
public LenscorrectionFilterGenI? i { get; set; }
/// <summary>
///  set the color of the unmapped pixels (default "black@0")
/// </summary>
public Color? fc { get; set; }
public string TimelineSupport { get; set; }
}
public enum LenscorrectionFilterGenI
{
[Name("nearest")] nearest,
[Name("bilinear")] bilinear,
}

}
