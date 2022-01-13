namespace FFmpegArgs.Filters.Autogens
{
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
public static class Yadif_cudaFilterGenExtensions
{
/// <summary>
/// Deinterlace CUDA frames
/// </summary>
public static Yadif_cudaFilterGen Yadif_cudaFilterGen(this ImageMap input0) => new Yadif_cudaFilterGen(input0);
/// <summary>
/// Deinterlace CUDA frames
/// </summary>
public static Yadif_cudaFilterGen Yadif_cudaFilterGen(this ImageMap input0,Yadif_cudaFilterGenConfig config)
{
var result = new Yadif_cudaFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.parity != null) result.parity(config.parity.Value);
if(config?.deint != null) result.deint(config.deint.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class Yadif_cudaFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  specify the interlacing mode (from 0 to 3) (default send_frame)
/// </summary>
public Yadif_cudaFilterGenMode? mode { get; set; }
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public Yadif_cudaFilterGenParity? parity { get; set; }
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public Yadif_cudaFilterGenDeint? deint { get; set; }
public string TimelineSupport { get; set; }
}
public enum Yadif_cudaFilterGenMode
{
[Name("send_frame")] send_frame,
[Name("send_field")] send_field,
[Name("send_frame_nospatial")] send_frame_nospatial,
[Name("send_field_nospatial")] send_field_nospatial,
}

public enum Yadif_cudaFilterGenParity
{
[Name("tff")] tff,
[Name("bff")] bff,
[Name("auto")] auto,
}

public enum Yadif_cudaFilterGenDeint
{
[Name("all")] all,
[Name("interlaced")] interlaced,
}

}
