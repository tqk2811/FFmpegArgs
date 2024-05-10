namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. bwdif_vulkan      V->V       Deinterlace Vulkan frames via bwdif
/// </summary>
public class Bwdif_vulkanFilterGen : ImageToImageFilter,ITimelineSupport
{
internal Bwdif_vulkanFilterGen(ImageMap input) : base("bwdif_vulkan",input) { AddMapOut(); }
/// <summary>
///  specify the interlacing mode (from 0 to 3) (default send_frame)
/// </summary>
public Bwdif_vulkanFilterGen mode(Bwdif_vulkanFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public Bwdif_vulkanFilterGen parity(Bwdif_vulkanFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public Bwdif_vulkanFilterGen deint(Bwdif_vulkanFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Deinterlace Vulkan frames via bwdif
/// </summary>
public static Bwdif_vulkanFilterGen Bwdif_vulkanFilterGen(this ImageMap input0) => new Bwdif_vulkanFilterGen(input0);
}
/// <summary>
///  specify the interlacing mode (from 0 to 3) (default send_frame)
/// </summary>
public enum Bwdif_vulkanFilterGenMode
{
/// <summary>
/// send_frame      0            ..FV....... send one frame for each frame
/// </summary>
[Name("send_frame")] send_frame,
/// <summary>
/// send_field      1            ..FV....... send one frame for each field
/// </summary>
[Name("send_field")] send_field,
/// <summary>
/// send_frame_nospatial 2            ..FV....... send one frame for each frame, but skip spatial interlacing check
/// </summary>
[Name("send_frame_nospatial")] send_frame_nospatial,
/// <summary>
/// send_field_nospatial 3            ..FV....... send one frame for each field, but skip spatial interlacing check
/// </summary>
[Name("send_field_nospatial")] send_field_nospatial,
}

/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public enum Bwdif_vulkanFilterGenParity
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
public enum Bwdif_vulkanFilterGenDeint
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
