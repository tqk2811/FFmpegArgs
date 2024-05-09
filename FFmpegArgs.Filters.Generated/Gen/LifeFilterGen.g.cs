namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... life              |->V       Create life.
/// </summary>
public class LifeFilterGen : SourceImageFilter
{
internal LifeFilterGen(IImageFilterGraph input) : base("life",input) { AddMapOut(); }
/// <summary>
///  set source file
/// </summary>
public LifeFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set video size
/// </summary>
public LifeFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public LifeFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set rule (default "B3/S23")
/// </summary>
public LifeFilterGen rule(string rule) => this.SetOption("rule",rule);
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public LifeFilterGen random_fill_ratio(double random_fill_ratio) => this.SetOptionRange("random_fill_ratio", random_fill_ratio,0,1);
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public LifeFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,0,1);
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public LifeFilterGen random_seed(long random_seed) => this.SetOptionRange("random_seed", random_seed,-1,UINT32_MAX);
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public LifeFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  stitch boundaries (default true)
/// </summary>
public LifeFilterGen stitch(bool stitch) => this.SetOption("stitch",stitch.ToFFmpegFlag());
/// <summary>
///  set mold speed for dead cells (from 0 to 255) (default 0)
/// </summary>
public LifeFilterGen mold(int mold) => this.SetOptionRange("mold", mold,0,255);
/// <summary>
///  set life color (default "white")
/// </summary>
public LifeFilterGen life_color(Color life_color) => this.SetOption("life_color",life_color.ToHexStringRGBA());
/// <summary>
///  set death color (default "black")
/// </summary>
public LifeFilterGen death_color(Color death_color) => this.SetOption("death_color",death_color.ToHexStringRGBA());
/// <summary>
///  set mold color (default "black")
/// </summary>
public LifeFilterGen mold_color(Color mold_color) => this.SetOption("mold_color",mold_color.ToHexStringRGBA());
}
/// <summary>
/// </summary>
public static class LifeFilterGenExtensions
{
/// <summary>
/// Create life.
/// </summary>
public static LifeFilterGen LifeFilterGen(this IImageFilterGraph input0) => new LifeFilterGen(input0);
}
}
