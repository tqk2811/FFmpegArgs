namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. yadif_cuda        V->V       Deinterlace CUDA frames
/// </summary>
public class Yadif_cudaFilterGen : ImageToImageFilter,ITimelineSupport
{
internal Yadif_cudaFilterGen(ImageMap input) : base("yadif_cuda",input) { AddMapOut(); }
/// <summary>
///  specify the interlacing mode (from 0 to 3) (default send_frame)
/// </summary>
public Yadif_cudaFilterGen mode(Yadif_cudaFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public Yadif_cudaFilterGen parity(Yadif_cudaFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public Yadif_cudaFilterGen deint(Yadif_cudaFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class Yadif_cudaFilterGenExtensions
{
/// <summary>
/// Deinterlace CUDA frames
/// </summary>
public static Yadif_cudaFilterGen Yadif_cudaFilterGen(this ImageMap input0) => new Yadif_cudaFilterGen(input0);
}
/// <summary>
///  specify the interlacing mode (from 0 to 3) (default send_frame)
/// </summary>
public enum Yadif_cudaFilterGenMode
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
public enum Yadif_cudaFilterGenParity
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
public enum Yadif_cudaFilterGenDeint
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
