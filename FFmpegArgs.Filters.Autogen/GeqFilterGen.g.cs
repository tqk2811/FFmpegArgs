namespace FFmpegArgs.Filters.Autogens
{
public class GeqFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal GeqFilterGen(ImageMap input) : base("geq",input) { AddMapOut(); }
/// <summary>
///  set luminance expression
/// </summary>
public GeqFilterGen lum_expr(string lum_expr) => this.SetOption("lum_expr",lum_expr);
/// <summary>
///  set chroma blue expression
/// </summary>
public GeqFilterGen cb_expr(string cb_expr) => this.SetOption("cb_expr",cb_expr);
/// <summary>
///  set chroma red expression
/// </summary>
public GeqFilterGen cr_expr(string cr_expr) => this.SetOption("cr_expr",cr_expr);
/// <summary>
///  set alpha expression
/// </summary>
public GeqFilterGen alpha_expr(string alpha_expr) => this.SetOption("alpha_expr",alpha_expr);
/// <summary>
///  set red expression
/// </summary>
public GeqFilterGen red_expr(string red_expr) => this.SetOption("red_expr",red_expr);
/// <summary>
///  set green expression
/// </summary>
public GeqFilterGen green_expr(string green_expr) => this.SetOption("green_expr",green_expr);
/// <summary>
///  set blue expression
/// </summary>
public GeqFilterGen blue_expr(string blue_expr) => this.SetOption("blue_expr",blue_expr);
/// <summary>
///  set interpolation method (from 0 to 1) (default bilinear)
/// </summary>
public GeqFilterGen interpolation(GeqFilterGenInterpolation interpolation) => this.SetOption("interpolation", interpolation.GetEnumAttribute<NameAttribute>().Name);
}
public static class GeqFilterGenExtensions
{
/// <summary>
/// Apply generic equation to each pixel.
/// </summary>
public static GeqFilterGen GeqFilterGen(this ImageMap input0) => new GeqFilterGen(input0);
/// <summary>
/// Apply generic equation to each pixel.
/// </summary>
public static GeqFilterGen GeqFilterGen(this ImageMap input0,GeqFilterGenConfig config)
{
var result = new GeqFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.lum_expr)) result.lum_expr(config.lum_expr);
if(!string.IsNullOrWhiteSpace(config?.cb_expr)) result.cb_expr(config.cb_expr);
if(!string.IsNullOrWhiteSpace(config?.cr_expr)) result.cr_expr(config.cr_expr);
if(!string.IsNullOrWhiteSpace(config?.alpha_expr)) result.alpha_expr(config.alpha_expr);
if(!string.IsNullOrWhiteSpace(config?.red_expr)) result.red_expr(config.red_expr);
if(!string.IsNullOrWhiteSpace(config?.green_expr)) result.green_expr(config.green_expr);
if(!string.IsNullOrWhiteSpace(config?.blue_expr)) result.blue_expr(config.blue_expr);
if(config?.interpolation != null) result.interpolation(config.interpolation.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class GeqFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set luminance expression
/// </summary>
public string lum_expr { get; set; }
/// <summary>
///  set chroma blue expression
/// </summary>
public string cb_expr { get; set; }
/// <summary>
///  set chroma red expression
/// </summary>
public string cr_expr { get; set; }
/// <summary>
///  set alpha expression
/// </summary>
public string alpha_expr { get; set; }
/// <summary>
///  set red expression
/// </summary>
public string red_expr { get; set; }
/// <summary>
///  set green expression
/// </summary>
public string green_expr { get; set; }
/// <summary>
///  set blue expression
/// </summary>
public string blue_expr { get; set; }
/// <summary>
///  set interpolation method (from 0 to 1) (default bilinear)
/// </summary>
public GeqFilterGenInterpolation? interpolation { get; set; }
public string TimelineSupport { get; set; }
}
public enum GeqFilterGenInterpolation
{
[Name("nearest")] nearest,
[Name("n")] n,
[Name("bilinear")] bilinear,
[Name("b")] b,
}

}
