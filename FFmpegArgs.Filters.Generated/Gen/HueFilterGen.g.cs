namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C hue               V->V       Adjust the hue and saturation of the input video.
/// </summary>
public class HueFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal HueFilterGen(ImageMap input) : base("hue",input) { AddMapOut(); }
/// <summary>
///  set the hue angle degrees expression
/// </summary>
public HueFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  set the saturation expression (default "1")
/// </summary>
public HueFilterGen s(string s) => this.SetOption("s",s);
/// <summary>
///  set the hue angle radians expression
/// </summary>
public HueFilterGen H(string H) => this.SetOption("H",H);
/// <summary>
///  set the brightness expression (default "0")
/// </summary>
public HueFilterGen b(string b) => this.SetOption("b",b);
}
/// <summary>
/// </summary>
public static class HueFilterGenExtensions
{
/// <summary>
/// Adjust the hue and saturation of the input video.
/// </summary>
public static HueFilterGen HueFilterGen(this ImageMap input0) => new HueFilterGen(input0);
}
}
