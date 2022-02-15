namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// .S. xbr               V->V       Scale the input using xBR algorithm.
/// </summary>
public class XbrFilterGen : ImageToImageFilter,ISliceThreading
{
internal XbrFilterGen(ImageMap input) : base("xbr",input) { AddMapOut(); }
/// <summary>
///  set scale factor (from 2 to 4) (default 3)
/// </summary>
public XbrFilterGen n(int n) => this.SetOptionRange("n", n,2,4);
}
/// <summary>
/// </summary>
public static class XbrFilterGenExtensions
{
/// <summary>
/// Scale the input using xBR algorithm.
/// </summary>
public static XbrFilterGen XbrFilterGen(this ImageMap input0) => new XbrFilterGen(input0);
}
}
