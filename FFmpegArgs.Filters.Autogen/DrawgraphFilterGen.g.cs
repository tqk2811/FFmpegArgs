namespace FFmpegArgs.Filters.Autogens
{
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
public static class DrawgraphFilterGenExtensions
{
/// <summary>
/// Draw a graph using input video metadata.
/// </summary>
public static DrawgraphFilterGen DrawgraphFilterGen(this ImageMap input0) => new DrawgraphFilterGen(input0);
/// <summary>
/// Draw a graph using input video metadata.
/// </summary>
public static DrawgraphFilterGen DrawgraphFilterGen(this ImageMap input0,DrawgraphFilterGenConfig config)
{
var result = new DrawgraphFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.m1)) result.m1(config.m1);
if(!string.IsNullOrWhiteSpace(config?.fg1)) result.fg1(config.fg1);
if(!string.IsNullOrWhiteSpace(config?.m2)) result.m2(config.m2);
if(!string.IsNullOrWhiteSpace(config?.fg2)) result.fg2(config.fg2);
if(!string.IsNullOrWhiteSpace(config?.m3)) result.m3(config.m3);
if(!string.IsNullOrWhiteSpace(config?.fg3)) result.fg3(config.fg3);
if(!string.IsNullOrWhiteSpace(config?.m4)) result.m4(config.m4);
if(!string.IsNullOrWhiteSpace(config?.fg4)) result.fg4(config.fg4);
if(config?.bg != null) result.bg(config.bg.Value);
if(config?.min != null) result.min(config.min.Value);
if(config?.max != null) result.max(config.max.Value);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.slide != null) result.slide(config.slide.Value);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
return result;
}
}
public class DrawgraphFilterGenConfig
{
/// <summary>
///  set 1st metadata key (default "")
/// </summary>
public string m1 { get; set; }
/// <summary>
///  set 1st foreground color expression (default "0xffff0000")
/// </summary>
public string fg1 { get; set; }
/// <summary>
///  set 2nd metadata key (default "")
/// </summary>
public string m2 { get; set; }
/// <summary>
///  set 2nd foreground color expression (default "0xff00ff00")
/// </summary>
public string fg2 { get; set; }
/// <summary>
///  set 3rd metadata key (default "")
/// </summary>
public string m3 { get; set; }
/// <summary>
///  set 3rd foreground color expression (default "0xffff00ff")
/// </summary>
public string fg3 { get; set; }
/// <summary>
///  set 4th metadata key (default "")
/// </summary>
public string m4 { get; set; }
/// <summary>
///  set 4th foreground color expression (default "0xffffff00")
/// </summary>
public string fg4 { get; set; }
/// <summary>
///  set background color (default "white")
/// </summary>
public Color? bg { get; set; }
/// <summary>
///  set minimal value (from INT_MIN to INT_MAX) (default -1)
/// </summary>
public float? min { get; set; }
/// <summary>
///  set maximal value (from INT_MIN to INT_MAX) (default 1)
/// </summary>
public float? max { get; set; }
/// <summary>
///  set graph mode (from 0 to 2) (default line)
/// </summary>
public DrawgraphFilterGenMode? mode { get; set; }
/// <summary>
///  set slide mode (from 0 to 4) (default frame)
/// </summary>
public DrawgraphFilterGenSlide? slide { get; set; }
/// <summary>
///  set graph size (default "900x256")
/// </summary>
public Size? size { get; set; }
/// <summary>
///  set video rate (default "25")
/// </summary>
public Rational rate { get; set; }
}
public enum DrawgraphFilterGenMode
{
[Name("bar")] bar,
[Name("dot")] dot,
[Name("line")] line,
}

public enum DrawgraphFilterGenSlide
{
[Name("frame")] frame,
[Name("replace")] replace,
[Name("scroll")] scroll,
[Name("rscroll")] rscroll,
[Name("picture")] picture,
}

}
