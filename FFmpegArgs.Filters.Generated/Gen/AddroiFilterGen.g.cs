namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... addroi            V->V       Add region of interest to frame.
/// </summary>
public class AddroiFilterGen : ImageToImageFilter
{
internal AddroiFilterGen(ImageMap input) : base("addroi",input) { AddMapOut(); }
/// <summary>
///  Region distance from left edge of frame. (default "0")
/// </summary>
public AddroiFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  Region distance from top edge of frame. (default "0")
/// </summary>
public AddroiFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  Region width. (default "0")
/// </summary>
public AddroiFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Region height. (default "0")
/// </summary>
public AddroiFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Quantisation offset to apply in the region. (from -1 to 1) (default -1/10)
/// </summary>
public AddroiFilterGen qoffset(Rational qoffset) => this.SetOption("qoffset",qoffset.Check(-1,1));
/// <summary>
///  Remove any existing regions of interest before adding the new one. (default false)
/// </summary>
public AddroiFilterGen clear(bool clear) => this.SetOption("clear",clear.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Add region of interest to frame.
/// </summary>
public static AddroiFilterGen AddroiFilterGen(this ImageMap input0) => new AddroiFilterGen(input0);
}
}
