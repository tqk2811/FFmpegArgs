namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. displace          VVV->V     Displace pixels.
/// </summary>
public class DisplaceFilterGen : ImageToImageFilter,ITimelineSupport
{
internal DisplaceFilterGen(params ImageMap[] inputs) : base("displace",inputs) { AddMapOut(); }
/// <summary>
///  set edge mode (from 0 to 3) (default smear)
/// </summary>
public DisplaceFilterGen edge(DisplaceFilterGenEdge edge) => this.SetOption("edge", edge.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class DisplaceFilterGenExtensions
{
/// <summary>
/// Displace pixels.
/// </summary>
public static DisplaceFilterGen DisplaceFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new DisplaceFilterGen(input0, input1, input2);
}
/// <summary>
///  set edge mode (from 0 to 3) (default smear)
/// </summary>
public enum DisplaceFilterGenEdge
{
/// <summary>
/// blank           0            ..FV.......
/// </summary>
[Name("blank")] blank,
/// <summary>
/// smear           1            ..FV.......
/// </summary>
[Name("smear")] smear,
/// <summary>
/// wrap            2            ..FV.......
/// </summary>
[Name("wrap")] wrap,
/// <summary>
/// mirror          3            ..FV.......
/// </summary>
[Name("mirror")] mirror,
}

}
