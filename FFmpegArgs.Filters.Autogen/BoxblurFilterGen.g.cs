namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. boxblur           V->V       Blur the input.
/// </summary>
public class BoxblurFilterGen : ImageToImageFilter,ITimelineSupport
{
internal BoxblurFilterGen(ImageMap input) : base("boxblur",input) { AddMapOut(); }
/// <summary>
///  Radius of the luma blurring box (default "2")
/// </summary>
public BoxblurFilterGen luma_radius(string luma_radius) => this.SetOption("luma_radius",luma_radius);
/// <summary>
///  Radius of the luma blurring box (default "2")
/// </summary>
public BoxblurFilterGen lr(string lr) => this.SetOption("lr",lr);
/// <summary>
///  How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
/// </summary>
public BoxblurFilterGen luma_power(int luma_power) => this.SetOptionRange("luma_power", luma_power,0,INT_MAX);
/// <summary>
///  How many times should the boxblur be applied to luma (from 0 to INT_MAX) (default 2)
/// </summary>
public BoxblurFilterGen lp(int lp) => this.SetOptionRange("lp", lp,0,INT_MAX);
/// <summary>
///  Radius of the chroma blurring box
/// </summary>
public BoxblurFilterGen chroma_radius(string chroma_radius) => this.SetOption("chroma_radius",chroma_radius);
/// <summary>
///  Radius of the chroma blurring box
/// </summary>
public BoxblurFilterGen cr(string cr) => this.SetOption("cr",cr);
/// <summary>
///  How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
/// </summary>
public BoxblurFilterGen chroma_power(int chroma_power) => this.SetOptionRange("chroma_power", chroma_power,-1,INT_MAX);
/// <summary>
///  How many times should the boxblur be applied to chroma (from -1 to INT_MAX) (default -1)
/// </summary>
public BoxblurFilterGen cp(int cp) => this.SetOptionRange("cp", cp,-1,INT_MAX);
/// <summary>
///  Radius of the alpha blurring box
/// </summary>
public BoxblurFilterGen alpha_radius(string alpha_radius) => this.SetOption("alpha_radius",alpha_radius);
/// <summary>
///  Radius of the alpha blurring box
/// </summary>
public BoxblurFilterGen ar(string ar) => this.SetOption("ar",ar);
/// <summary>
///  How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
/// </summary>
public BoxblurFilterGen alpha_power(int alpha_power) => this.SetOptionRange("alpha_power", alpha_power,-1,INT_MAX);
/// <summary>
///  How many times should the boxblur be applied to alpha (from -1 to INT_MAX) (default -1)
/// </summary>
public BoxblurFilterGen ap(int ap) => this.SetOptionRange("ap", ap,-1,INT_MAX);
}
/// <summary>
/// </summary>
public static class BoxblurFilterGenExtensions
{
/// <summary>
/// Blur the input.
/// </summary>
public static BoxblurFilterGen BoxblurFilterGen(this ImageMap input0) => new BoxblurFilterGen(input0);
}
}
