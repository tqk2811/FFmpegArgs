namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C hue               V-&gt;V       Adjust the hue and saturation of the input video.
/// </summary>
public class HueFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal HueFilterGen(ImageMap input) : base("hue",input) { AddMapOut(); }
/// <summary>
///  set the hue angle degrees expression
/// </summary>
public HueFilterGen h(ExpressionValue h) => this.SetOption("h",(string)h);
/// <summary>
///  set the saturation expression (default &quot;1&quot;)
/// </summary>
public HueFilterGen s(ExpressionValue s) => this.SetOption("s",(string)s);
/// <summary>
///  set the hue angle radians expression
/// </summary>
public HueFilterGen H(ExpressionValue H) => this.SetOption("H",(string)H);
/// <summary>
///  set the brightness expression (default &quot;0&quot;)
/// </summary>
public HueFilterGen b(ExpressionValue b) => this.SetOption("b",(string)b);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Adjust the hue and saturation of the input video.
/// </summary>
public static HueFilterGen HueFilterGen(this ImageMap input0) => new HueFilterGen(input0);
}
}
