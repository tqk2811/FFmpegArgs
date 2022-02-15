namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... drawgraph         V->V       Draw a graph using input video metadata.
/// </summary>
public class DrawgraphFilterGen : ImageToImageFilter
{
internal DrawgraphFilterGen(ImageMap input) : base("drawgraph",input) { AddMapOut(); }
/// <summary>
///  set 1st metadata key (default "")
/// </summary>
public DrawgraphFilterGen m1(string m1) => this.SetOption("m1",m1);
/// <summary>
///  set 1st foreground color expression (default "0xffff0000")
/// </summary>
public DrawgraphFilterGen fg1(string fg1) => this.SetOption("fg1",fg1);
/// <summary>
///  set 2nd metadata key (default "")
/// </summary>
public DrawgraphFilterGen m2(string m2) => this.SetOption("m2",m2);
/// <summary>
///  set 2nd foreground color expression (default "0xff00ff00")
/// </summary>
public DrawgraphFilterGen fg2(string fg2) => this.SetOption("fg2",fg2);
/// <summary>
///  set 3rd metadata key (default "")
/// </summary>
public DrawgraphFilterGen m3(string m3) => this.SetOption("m3",m3);
/// <summary>
///  set 3rd foreground color expression (default "0xffff00ff")
/// </summary>
public DrawgraphFilterGen fg3(string fg3) => this.SetOption("fg3",fg3);
/// <summary>
///  set 4th metadata key (default "")
/// </summary>
public DrawgraphFilterGen m4(string m4) => this.SetOption("m4",m4);
/// <summary>
///  set 4th foreground color expression (default "0xffffff00")
/// </summary>
public DrawgraphFilterGen fg4(string fg4) => this.SetOption("fg4",fg4);
/// <summary>
///  set background color (default "white")
/// </summary>
public DrawgraphFilterGen bg(Color bg) => this.SetOption("bg",bg.ToHexStringRGBA());
/// <summary>
///  set minimal value (from INT_MIN to INT_MAX) (default -1)
/// </summary>
public DrawgraphFilterGen min(float min) => this.SetOptionRange("min", min,INT_MIN,INT_MAX);
/// <summary>
///  set maximal value (from INT_MIN to INT_MAX) (default 1)
/// </summary>
public DrawgraphFilterGen max(float max) => this.SetOptionRange("max", max,INT_MIN,INT_MAX);
/// <summary>
///  set graph mode (from 0 to 2) (default line)
/// </summary>
public DrawgraphFilterGen mode(DrawgraphFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set slide mode (from 0 to 4) (default frame)
/// </summary>
public DrawgraphFilterGen slide(DrawgraphFilterGenSlide slide) => this.SetOption("slide", slide.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set graph size (default "900x256")
/// </summary>
public DrawgraphFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public DrawgraphFilterGen rate(Rational rate) => this.SetOption("rate",rate);
}
/// <summary>
/// </summary>
public static class DrawgraphFilterGenExtensions
{
/// <summary>
/// Draw a graph using input video metadata.
/// </summary>
public static DrawgraphFilterGen DrawgraphFilterGen(this ImageMap input0) => new DrawgraphFilterGen(input0);
}
/// <summary>
///  set graph mode (from 0 to 2) (default line)
/// </summary>
public enum DrawgraphFilterGenMode
{
/// <summary>
/// bar             0            ..FV....... draw bars
/// </summary>
[Name("bar")] bar,
/// <summary>
/// dot             1            ..FV....... draw dots
/// </summary>
[Name("dot")] dot,
/// <summary>
/// line            2            ..FV....... draw lines
/// </summary>
[Name("line")] line,
}

/// <summary>
///  set slide mode (from 0 to 4) (default frame)
/// </summary>
public enum DrawgraphFilterGenSlide
{
/// <summary>
/// frame           0            ..FV....... draw new frames
/// </summary>
[Name("frame")] frame,
/// <summary>
/// replace         1            ..FV....... replace old columns with new
/// </summary>
[Name("replace")] replace,
/// <summary>
/// scroll          2            ..FV....... scroll from right to left
/// </summary>
[Name("scroll")] scroll,
/// <summary>
/// rscroll         3            ..FV....... scroll from left to right
/// </summary>
[Name("rscroll")] rscroll,
/// <summary>
/// picture         4            ..FV....... display graph in single frame
/// </summary>
[Name("picture")] picture,
}

}
