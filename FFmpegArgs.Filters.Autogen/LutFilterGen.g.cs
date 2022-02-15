namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC lut               V->V       Compute and apply a lookup table to the RGB/YUV input video.
/// </summary>
public class LutFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LutFilterGen(ImageMap input) : base("lut",input) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default "clipval")
/// </summary>
public LutFilterGen c0(string c0) => this.SetOption("c0",c0);
/// <summary>
///  set component #1 expression (default "clipval")
/// </summary>
public LutFilterGen c1(string c1) => this.SetOption("c1",c1);
/// <summary>
///  set component #2 expression (default "clipval")
/// </summary>
public LutFilterGen c2(string c2) => this.SetOption("c2",c2);
/// <summary>
///  set component #3 expression (default "clipval")
/// </summary>
public LutFilterGen c3(string c3) => this.SetOption("c3",c3);
/// <summary>
///  set Y expression (default "clipval")
/// </summary>
public LutFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set U expression (default "clipval")
/// </summary>
public LutFilterGen u(string u) => this.SetOption("u",u);
/// <summary>
///  set V expression (default "clipval")
/// </summary>
public LutFilterGen v(string v) => this.SetOption("v",v);
/// <summary>
///  set R expression (default "clipval")
/// </summary>
public LutFilterGen r(string r) => this.SetOption("r",r);
/// <summary>
///  set G expression (default "clipval")
/// </summary>
public LutFilterGen g(string g) => this.SetOption("g",g);
/// <summary>
///  set B expression (default "clipval")
/// </summary>
public LutFilterGen b(string b) => this.SetOption("b",b);
/// <summary>
///  set A expression (default "clipval")
/// </summary>
public LutFilterGen a(string a) => this.SetOption("a",a);
}
/// <summary>
/// </summary>
public static class LutFilterGenExtensions
{
/// <summary>
/// Compute and apply a lookup table to the RGB/YUV input video.
/// </summary>
public static LutFilterGen LutFilterGen(this ImageMap input0) => new LutFilterGen(input0);
}
}
