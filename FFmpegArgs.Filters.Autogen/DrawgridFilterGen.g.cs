namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C drawgrid          V->V       Draw a colored grid on the input video.
/// </summary>
public class DrawgridFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal DrawgridFilterGen(ImageMap input) : base("drawgrid",input) { AddMapOut(); }
/// <summary>
///  set horizontal offset (default "0")
/// </summary>
public DrawgridFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set vertical offset (default "0")
/// </summary>
public DrawgridFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set width of grid cell (default "0")
/// </summary>
public DrawgridFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  set height of grid cell (default "0")
/// </summary>
public DrawgridFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  set color of the grid (default "black")
/// </summary>
public DrawgridFilterGen color(string color) => this.SetOption("color",color);
/// <summary>
///  set grid line thickness (default "1")
/// </summary>
public DrawgridFilterGen thickness(string thickness) => this.SetOption("thickness",thickness);
/// <summary>
///  replace color & alpha (default false)
/// </summary>
public DrawgridFilterGen replace(bool replace) => this.SetOption("replace",replace.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class DrawgridFilterGenExtensions
{
/// <summary>
/// Draw a colored grid on the input video.
/// </summary>
public static DrawgridFilterGen DrawgridFilterGen(this ImageMap input0) => new DrawgridFilterGen(input0);
}
}
