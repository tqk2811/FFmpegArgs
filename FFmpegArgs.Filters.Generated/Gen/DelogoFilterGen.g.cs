namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. delogo            V-&gt;V       Remove logo from input video.
/// </summary>
public class DelogoFilterGen : ImageToImageFilter,ITimelineSupport
{
internal DelogoFilterGen(ImageMap input) : base("delogo",input) { AddMapOut(); }
/// <summary>
///  set logo x position (default &quot;-1&quot;)
/// </summary>
public DelogoFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set logo y position (default &quot;-1&quot;)
/// </summary>
public DelogoFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set logo width (default &quot;-1&quot;)
/// </summary>
public DelogoFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  set logo height (default &quot;-1&quot;)
/// </summary>
public DelogoFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  show delogo area (default false)
/// </summary>
public DelogoFilterGen show(bool show) => this.SetOption("show",show.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Remove logo from input video.
/// </summary>
public static DelogoFilterGen DelogoFilterGen(this ImageMap input0) => new DelogoFilterGen(input0);
}
}
