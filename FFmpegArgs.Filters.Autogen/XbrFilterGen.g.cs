namespace FFmpegArgs.Filters.Autogens
{
public class XbrFilterGen : ImageToImageFilter,ISliceThreading
{
internal XbrFilterGen(ImageMap input) : base("xbr",input) { AddMapOut(); }
/// <summary>
///  set scale factor (from 2 to 4) (default 3)
/// </summary>
public XbrFilterGen n(int n) => this.SetOptionRange("n", n,2,4);
}
public static class XbrFilterGenExtensions
{
/// <summary>
/// Scale the input using xBR algorithm.
/// </summary>
public static XbrFilterGen XbrFilterGen(this ImageMap input0) => new XbrFilterGen(input0);
/// <summary>
/// Scale the input using xBR algorithm.
/// </summary>
public static XbrFilterGen XbrFilterGen(this ImageMap input0,XbrFilterGenConfig config)
{
var result = new XbrFilterGen(input0);
if(config?.n != null) result.n(config.n.Value);
return result;
}
}
public class XbrFilterGenConfig
{
/// <summary>
///  set scale factor (from 2 to 4) (default 3)
/// </summary>
public int? n { get; set; }
}
}
