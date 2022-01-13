namespace FFmpegArgs.Filters.Autogens
{
public class AddroiFilterGen : ImageToImageFilter
{
internal AddroiFilterGen(ImageMap input) : base("addroi",input) { AddMapOut(); }
/// <summary>
///  Region distance from left edge of frame. (default "0")
/// </summary>
public AddroiFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  Region distance from top edge of frame. (default "0")
/// </summary>
public AddroiFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  Region width. (default "0")
/// </summary>
public AddroiFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Region height. (default "0")
/// </summary>
public AddroiFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Quantisation offset to apply in the region. (from -1 to 1) (default -1/10)
/// </summary>
public AddroiFilterGen qoffset(Rational qoffset) => this.SetOption("qoffset",qoffset.Check(-1,1));
/// <summary>
///  Remove any existing regions of interest before adding the new one. (default false)
/// </summary>
public AddroiFilterGen clear(bool clear) => this.SetOption("clear",clear.ToFFmpegFlag());
}
public static class AddroiFilterGenExtensions
{
/// <summary>
/// Add region of interest to frame.
/// </summary>
public static AddroiFilterGen AddroiFilterGen(this ImageMap input0) => new AddroiFilterGen(input0);
/// <summary>
/// Add region of interest to frame.
/// </summary>
public static AddroiFilterGen AddroiFilterGen(this ImageMap input0,AddroiFilterGenConfig config)
{
var result = new AddroiFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.x)) result.x(config.x);
if(!string.IsNullOrWhiteSpace(config?.y)) result.y(config.y);
if(!string.IsNullOrWhiteSpace(config?.w)) result.w(config.w);
if(!string.IsNullOrWhiteSpace(config?.h)) result.h(config.h);
if(config?.qoffset != null) result.qoffset(config.qoffset);
if(config?.clear != null) result.clear(config.clear.Value);
return result;
}
}
public class AddroiFilterGenConfig
{
/// <summary>
///  Region distance from left edge of frame. (default "0")
/// </summary>
public string x { get; set; }
/// <summary>
///  Region distance from top edge of frame. (default "0")
/// </summary>
public string y { get; set; }
/// <summary>
///  Region width. (default "0")
/// </summary>
public string w { get; set; }
/// <summary>
///  Region height. (default "0")
/// </summary>
public string h { get; set; }
/// <summary>
///  Quantisation offset to apply in the region. (from -1 to 1) (default -1/10)
/// </summary>
public Rational qoffset { get; set; }
/// <summary>
///  Remove any existing regions of interest before adding the new one. (default false)
/// </summary>
public bool? clear { get; set; }
}
}
