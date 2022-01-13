namespace FFmpegArgs.Filters.Autogens
{
public class HqxFilterGen : ImageToImageFilter,ISliceThreading
{
internal HqxFilterGen(ImageMap input) : base("hqx",input) { AddMapOut(); }
/// <summary>
///  set scale factor (from 2 to 4) (default 3)
/// </summary>
public HqxFilterGen n(int n) => this.SetOptionRange("n", n,2,4);
}
public static class HqxFilterGenExtensions
{
/// <summary>
/// Scale the input by 2, 3 or 4 using the hq*x magnification algorithm.
/// </summary>
public static HqxFilterGen HqxFilterGen(this ImageMap input0) => new HqxFilterGen(input0);
/// <summary>
/// Scale the input by 2, 3 or 4 using the hq*x magnification algorithm.
/// </summary>
public static HqxFilterGen HqxFilterGen(this ImageMap input0,HqxFilterGenConfig config)
{
var result = new HqxFilterGen(input0);
if(config?.n != null) result.n(config.n.Value);
return result;
}
}
public class HqxFilterGenConfig
{
/// <summary>
///  set scale factor (from 2 to 4) (default 3)
/// </summary>
public int? n { get; set; }
}
}
