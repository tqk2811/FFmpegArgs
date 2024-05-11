namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C drawbox           V-&gt;V       Draw a colored box on the input video.
/// </summary>
public class DrawboxFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal DrawboxFilterGen(ImageMap input) : base("drawbox",input) { AddMapOut(); }
/// <summary>
///  set horizontal position of the left box edge (default &quot;0&quot;)
/// </summary>
public DrawboxFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set vertical position of the top box edge (default &quot;0&quot;)
/// </summary>
public DrawboxFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set width of the box (default &quot;0&quot;)
/// </summary>
public DrawboxFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  set height of the box (default &quot;0&quot;)
/// </summary>
public DrawboxFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set color of the box (default &quot;black&quot;)
/// </summary>
public DrawboxFilterGen color(string color) => this.SetOption("color",color);
/// <summary>
///  set the box thickness (default &quot;3&quot;)
/// </summary>
public DrawboxFilterGen thickness(string thickness) => this.SetOption("thickness",thickness);
/// <summary>
///  replace color &amp; alpha (default false)
/// </summary>
public DrawboxFilterGen replace(bool replace) => this.SetOption("replace",replace.ToFFmpegFlag());
/// <summary>
///  use datas from bounding box in side data
/// </summary>
public DrawboxFilterGen box_source(string box_source) => this.SetOption("box_source",box_source);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Draw a colored box on the input video.
/// </summary>
public static DrawboxFilterGen DrawboxFilterGen(this ImageMap input0) => new DrawboxFilterGen(input0);
}
}
