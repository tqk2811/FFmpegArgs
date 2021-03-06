namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. delogo            V->V       Remove logo from input video.
/// </summary>
public class DelogoFilterGen : ImageToImageFilter,ITimelineSupport
{
internal DelogoFilterGen(ImageMap input) : base("delogo",input) { AddMapOut(); }
/// <summary>
///  set logo x position (default "-1")
/// </summary>
public DelogoFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set logo y position (default "-1")
/// </summary>
public DelogoFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set logo width (default "-1")
/// </summary>
public DelogoFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  set logo height (default "-1")
/// </summary>
public DelogoFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  show delogo area (default false)
/// </summary>
public DelogoFilterGen show(bool show) => this.SetOption("show",show.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class DelogoFilterGenExtensions
{
/// <summary>
/// Remove logo from input video.
/// </summary>
public static DelogoFilterGen DelogoFilterGen(this ImageMap input0) => new DelogoFilterGen(input0);
}
}
