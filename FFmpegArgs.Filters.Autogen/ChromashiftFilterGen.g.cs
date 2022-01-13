namespace FFmpegArgs.Filters.Autogens
{
public class ChromashiftFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ChromashiftFilterGen(ImageMap input) : base("chromashift",input) { AddMapOut(); }
/// <summary>
///  shift chroma-blue horizontally (from -255 to 255) (default 0)
/// </summary>
public ChromashiftFilterGen cbh(int cbh) => this.SetOptionRange("cbh", cbh,-255,255);
/// <summary>
///  shift chroma-blue vertically (from -255 to 255) (default 0)
/// </summary>
public ChromashiftFilterGen cbv(int cbv) => this.SetOptionRange("cbv", cbv,-255,255);
/// <summary>
///  shift chroma-red horizontally (from -255 to 255) (default 0)
/// </summary>
public ChromashiftFilterGen crh(int crh) => this.SetOptionRange("crh", crh,-255,255);
/// <summary>
///  shift chroma-red vertically (from -255 to 255) (default 0)
/// </summary>
public ChromashiftFilterGen crv(int crv) => this.SetOptionRange("crv", crv,-255,255);
/// <summary>
///  set edge operation (from 0 to 1) (default smear)
/// </summary>
public ChromashiftFilterGen edge(ChromashiftFilterGenEdge edge) => this.SetOption("edge", edge.GetEnumAttribute<NameAttribute>().Name);
}
public static class ChromashiftFilterGenExtensions
{
/// <summary>
/// Shift chroma.
/// </summary>
public static ChromashiftFilterGen ChromashiftFilterGen(this ImageMap input0) => new ChromashiftFilterGen(input0);
/// <summary>
/// Shift chroma.
/// </summary>
public static ChromashiftFilterGen ChromashiftFilterGen(this ImageMap input0,ChromashiftFilterGenConfig config)
{
var result = new ChromashiftFilterGen(input0);
if(config?.cbh != null) result.cbh(config.cbh.Value);
if(config?.cbv != null) result.cbv(config.cbv.Value);
if(config?.crh != null) result.crh(config.crh.Value);
if(config?.crv != null) result.crv(config.crv.Value);
if(config?.edge != null) result.edge(config.edge.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ChromashiftFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  shift chroma-blue horizontally (from -255 to 255) (default 0)
/// </summary>
public int? cbh { get; set; }
/// <summary>
///  shift chroma-blue vertically (from -255 to 255) (default 0)
/// </summary>
public int? cbv { get; set; }
/// <summary>
///  shift chroma-red horizontally (from -255 to 255) (default 0)
/// </summary>
public int? crh { get; set; }
/// <summary>
///  shift chroma-red vertically (from -255 to 255) (default 0)
/// </summary>
public int? crv { get; set; }
/// <summary>
///  set edge operation (from 0 to 1) (default smear)
/// </summary>
public ChromashiftFilterGenEdge? edge { get; set; }
public string TimelineSupport { get; set; }
}
public enum ChromashiftFilterGenEdge
{
[Name("smear")] smear,
[Name("wrap")] wrap,
}

}
