namespace FFmpegArgs.Filters.Autogens
{
public class PerspectiveFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal PerspectiveFilterGen(ImageMap input) : base("perspective",input) { AddMapOut(); }
/// <summary>
///  set top left x coordinate (default "0")
/// </summary>
public PerspectiveFilterGen x0(string x0) => this.SetOption("x0",x0);
/// <summary>
///  set top left y coordinate (default "0")
/// </summary>
public PerspectiveFilterGen y0(string y0) => this.SetOption("y0",y0);
/// <summary>
///  set top right x coordinate (default "W")
/// </summary>
public PerspectiveFilterGen x1(string x1) => this.SetOption("x1",x1);
/// <summary>
///  set top right y coordinate (default "0")
/// </summary>
public PerspectiveFilterGen y1(string y1) => this.SetOption("y1",y1);
/// <summary>
///  set bottom left x coordinate (default "0")
/// </summary>
public PerspectiveFilterGen x2(string x2) => this.SetOption("x2",x2);
/// <summary>
///  set bottom left y coordinate (default "H")
/// </summary>
public PerspectiveFilterGen y2(string y2) => this.SetOption("y2",y2);
/// <summary>
///  set bottom right x coordinate (default "W")
/// </summary>
public PerspectiveFilterGen x3(string x3) => this.SetOption("x3",x3);
/// <summary>
///  set bottom right y coordinate (default "H")
/// </summary>
public PerspectiveFilterGen y3(string y3) => this.SetOption("y3",y3);
/// <summary>
///  set interpolation (from 0 to 1) (default linear)
/// </summary>
public PerspectiveFilterGen interpolation(PerspectiveFilterGenInterpolation interpolation) => this.SetOption("interpolation", interpolation.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify the sense of the coordinates (from 0 to 1) (default source)
/// </summary>
public PerspectiveFilterGen sense(PerspectiveFilterGenSense sense) => this.SetOption("sense", sense.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public PerspectiveFilterGen eval(PerspectiveFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
}
public static class PerspectiveFilterGenExtensions
{
/// <summary>
/// Correct the perspective of video.
/// </summary>
public static PerspectiveFilterGen PerspectiveFilterGen(this ImageMap input0) => new PerspectiveFilterGen(input0);
/// <summary>
/// Correct the perspective of video.
/// </summary>
public static PerspectiveFilterGen PerspectiveFilterGen(this ImageMap input0,PerspectiveFilterGenConfig config)
{
var result = new PerspectiveFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.x0)) result.x0(config.x0);
if(!string.IsNullOrWhiteSpace(config?.y0)) result.y0(config.y0);
if(!string.IsNullOrWhiteSpace(config?.x1)) result.x1(config.x1);
if(!string.IsNullOrWhiteSpace(config?.y1)) result.y1(config.y1);
if(!string.IsNullOrWhiteSpace(config?.x2)) result.x2(config.x2);
if(!string.IsNullOrWhiteSpace(config?.y2)) result.y2(config.y2);
if(!string.IsNullOrWhiteSpace(config?.x3)) result.x3(config.x3);
if(!string.IsNullOrWhiteSpace(config?.y3)) result.y3(config.y3);
if(config?.interpolation != null) result.interpolation(config.interpolation.Value);
if(config?.sense != null) result.sense(config.sense.Value);
if(config?.eval != null) result.eval(config.eval.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class PerspectiveFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set top left x coordinate (default "0")
/// </summary>
public string x0 { get; set; }
/// <summary>
///  set top left y coordinate (default "0")
/// </summary>
public string y0 { get; set; }
/// <summary>
///  set top right x coordinate (default "W")
/// </summary>
public string x1 { get; set; }
/// <summary>
///  set top right y coordinate (default "0")
/// </summary>
public string y1 { get; set; }
/// <summary>
///  set bottom left x coordinate (default "0")
/// </summary>
public string x2 { get; set; }
/// <summary>
///  set bottom left y coordinate (default "H")
/// </summary>
public string y2 { get; set; }
/// <summary>
///  set bottom right x coordinate (default "W")
/// </summary>
public string x3 { get; set; }
/// <summary>
///  set bottom right y coordinate (default "H")
/// </summary>
public string y3 { get; set; }
/// <summary>
///  set interpolation (from 0 to 1) (default linear)
/// </summary>
public PerspectiveFilterGenInterpolation? interpolation { get; set; }
/// <summary>
///  specify the sense of the coordinates (from 0 to 1) (default source)
/// </summary>
public PerspectiveFilterGenSense? sense { get; set; }
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public PerspectiveFilterGenEval? eval { get; set; }
public string TimelineSupport { get; set; }
}
public enum PerspectiveFilterGenInterpolation
{
[Name("linear")] linear,
[Name("cubic")] cubic,
}

public enum PerspectiveFilterGenSense
{
[Name("source")] source,
[Name("destination")] destination,
}

public enum PerspectiveFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
