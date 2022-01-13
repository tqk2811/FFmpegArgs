namespace FFmpegArgs.Filters.Autogens
{
public class Find_rectFilterGen : ImageToImageFilter
{
internal Find_rectFilterGen(ImageMap input) : base("find_rect",input) { AddMapOut(); }
/// <summary>
///  object bitmap filename
/// </summary>
public Find_rectFilterGen _object(string _object) => this.SetOption("object",_object);
/// <summary>
///  set threshold (from 0 to 1) (default 0.5)
/// </summary>
public Find_rectFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold,0,1);
/// <summary>
///  set mipmaps (from 1 to 5) (default 3)
/// </summary>
public Find_rectFilterGen mipmaps(int mipmaps) => this.SetOptionRange("mipmaps", mipmaps,1,5);
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public Find_rectFilterGen xmin(int xmin) => this.SetOptionRange("xmin", xmin,0,INT_MAX);
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public Find_rectFilterGen ymin(int ymin) => this.SetOptionRange("ymin", ymin,0,INT_MAX);
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public Find_rectFilterGen xmax(int xmax) => this.SetOptionRange("xmax", xmax,0,INT_MAX);
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public Find_rectFilterGen ymax(int ymax) => this.SetOptionRange("ymax", ymax,0,INT_MAX);
}
public static class Find_rectFilterGenExtensions
{
/// <summary>
/// Find a user specified object.
/// </summary>
public static Find_rectFilterGen Find_rectFilterGen(this ImageMap input0) => new Find_rectFilterGen(input0);
/// <summary>
/// Find a user specified object.
/// </summary>
public static Find_rectFilterGen Find_rectFilterGen(this ImageMap input0,Find_rectFilterGenConfig config)
{
var result = new Find_rectFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?._object)) result._object(config._object);
if(config?.threshold != null) result.threshold(config.threshold.Value);
if(config?.mipmaps != null) result.mipmaps(config.mipmaps.Value);
if(config?.xmin != null) result.xmin(config.xmin.Value);
if(config?.ymin != null) result.ymin(config.ymin.Value);
if(config?.xmax != null) result.xmax(config.xmax.Value);
if(config?.ymax != null) result.ymax(config.ymax.Value);
return result;
}
}
public class Find_rectFilterGenConfig
{
/// <summary>
///  object bitmap filename
/// </summary>
public string _object { get; set; }
/// <summary>
///  set threshold (from 0 to 1) (default 0.5)
/// </summary>
public float? threshold { get; set; }
/// <summary>
///  set mipmaps (from 1 to 5) (default 3)
/// </summary>
public int? mipmaps { get; set; }
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public int? xmin { get; set; }
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public int? ymin { get; set; }
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public int? xmax { get; set; }
/// <summary>
///   (from 0 to INT_MAX) (default 0)
/// </summary>
public int? ymax { get; set; }
}
}
