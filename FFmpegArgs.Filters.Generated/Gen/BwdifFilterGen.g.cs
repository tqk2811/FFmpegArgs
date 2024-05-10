namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. bwdif             V->V       Deinterlace the input image.
/// </summary>
public class BwdifFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal BwdifFilterGen(ImageMap input) : base("bwdif",input) { AddMapOut(); }
/// <summary>
///  specify the interlacing mode (from 0 to 1) (default send_field)
/// </summary>
public BwdifFilterGen mode(BwdifFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public BwdifFilterGen parity(BwdifFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public BwdifFilterGen deint(BwdifFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Deinterlace the input image.
/// </summary>
public static BwdifFilterGen BwdifFilterGen(this ImageMap input0) => new BwdifFilterGen(input0);
}
/// <summary>
///  specify the interlacing mode (from 0 to 1) (default send_field)
/// </summary>
public enum BwdifFilterGenMode
{
/// <summary>
/// send_frame      0            ..FV....... send one frame for each frame
/// </summary>
[Name("send_frame")] send_frame,
/// <summary>
/// send_field      1            ..FV....... send one frame for each field
/// </summary>
[Name("send_field")] send_field,
}

/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public enum BwdifFilterGenParity
{
/// <summary>
/// tff             0            ..FV....... assume top field first
/// </summary>
[Name("tff")] tff,
/// <summary>
/// bff             1            ..FV....... assume bottom field first
/// </summary>
[Name("bff")] bff,
/// <summary>
/// auto            -1           ..FV....... auto detect parity
/// </summary>
[Name("auto")] auto,
}

/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public enum BwdifFilterGenDeint
{
/// <summary>
/// all             0            ..FV....... deinterlace all frames
/// </summary>
[Name("all")] all,
/// <summary>
/// interlaced      1            ..FV....... only deinterlace frames marked as interlaced
/// </summary>
[Name("interlaced")] interlaced,
}

}
