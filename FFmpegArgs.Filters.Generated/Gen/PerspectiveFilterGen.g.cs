namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. perspective       V-&gt;V       Correct the perspective of video.
/// </summary>
public class PerspectiveFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal PerspectiveFilterGen(ImageMap input) : base("perspective",input) { AddMapOut(); }
/// <summary>
///  set top left x coordinate (default &quot;0&quot;)
/// </summary>
public PerspectiveFilterGen x0(string x0) => this.SetOption("x0",x0);
/// <summary>
///  set top left y coordinate (default &quot;0&quot;)
/// </summary>
public PerspectiveFilterGen y0(string y0) => this.SetOption("y0",y0);
/// <summary>
///  set top right x coordinate (default &quot;W&quot;)
/// </summary>
public PerspectiveFilterGen x1(string x1) => this.SetOption("x1",x1);
/// <summary>
///  set top right y coordinate (default &quot;0&quot;)
/// </summary>
public PerspectiveFilterGen y1(string y1) => this.SetOption("y1",y1);
/// <summary>
///  set bottom left x coordinate (default &quot;0&quot;)
/// </summary>
public PerspectiveFilterGen x2(string x2) => this.SetOption("x2",x2);
/// <summary>
///  set bottom left y coordinate (default &quot;H&quot;)
/// </summary>
public PerspectiveFilterGen y2(string y2) => this.SetOption("y2",y2);
/// <summary>
///  set bottom right x coordinate (default &quot;W&quot;)
/// </summary>
public PerspectiveFilterGen x3(string x3) => this.SetOption("x3",x3);
/// <summary>
///  set bottom right y coordinate (default &quot;H&quot;)
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
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Correct the perspective of video.
/// </summary>
public static PerspectiveFilterGen PerspectiveFilterGen(this ImageMap input0) => new PerspectiveFilterGen(input0);
}
/// <summary>
///  set interpolation (from 0 to 1) (default linear)
/// </summary>
public enum PerspectiveFilterGenInterpolation
{
/// <summary>
/// linear          0            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// cubic           1            ..FV.......
/// </summary>
[Name("cubic")] cubic,
}

/// <summary>
///  specify the sense of the coordinates (from 0 to 1) (default source)
/// </summary>
public enum PerspectiveFilterGenSense
{
/// <summary>
/// source          0            ..FV....... specify locations in source to send to corners in destination
/// </summary>
[Name("source")] source,
/// <summary>
/// destination     1            ..FV....... specify locations in destination to send corners of source
/// </summary>
[Name("destination")] destination,
}

/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public enum PerspectiveFilterGenEval
{
/// <summary>
/// init            0            ..FV....... eval expressions once during initialization
/// </summary>
[Name("init")] init,
/// <summary>
/// frame           1            ..FV....... eval expressions per-frame
/// </summary>
[Name("frame")] frame,
}

}
