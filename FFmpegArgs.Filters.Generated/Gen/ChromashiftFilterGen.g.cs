namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC chromashift       V->V       Shift chroma.
/// </summary>
public class ChromashiftFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ChromashiftFilterGen(ImageMap input) : base("chromashift",input) { AddMapOut(); }
/// <summary>
///  shift chroma-blue horizontally (from -255 to 255) (default 0)
/// </summary>
public ChromashiftFilterGen cbh(int cbh) => this.SetOptionRange("cbh", cbh,-255,255);
/// <summary>
///  shift chroma-blue vertically (from -255 to 255) (default 0)
/// </summary>
public ChromashiftFilterGen cbv(int cbv) => this.SetOptionRange("cbv", cbv,-255,255);
/// <summary>
///  shift chroma-red horizontally (from -255 to 255) (default 0)
/// </summary>
public ChromashiftFilterGen crh(int crh) => this.SetOptionRange("crh", crh,-255,255);
/// <summary>
///  shift chroma-red vertically (from -255 to 255) (default 0)
/// </summary>
public ChromashiftFilterGen crv(int crv) => this.SetOptionRange("crv", crv,-255,255);
/// <summary>
///  set edge operation (from 0 to 1) (default smear)
/// </summary>
public ChromashiftFilterGen edge(ChromashiftFilterGenEdge edge) => this.SetOption("edge", edge.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class ChromashiftFilterGenExtensions
{
/// <summary>
/// Shift chroma.
/// </summary>
public static ChromashiftFilterGen ChromashiftFilterGen(this ImageMap input0) => new ChromashiftFilterGen(input0);
}
/// <summary>
///  set edge operation (from 0 to 1) (default smear)
/// </summary>
public enum ChromashiftFilterGenEdge
{
/// <summary>
/// smear           0            ..FV.....T.
/// </summary>
[Name("smear")] smear,
/// <summary>
/// wrap            1            ..FV.....T.
/// </summary>
[Name("wrap")] wrap,
}

}
