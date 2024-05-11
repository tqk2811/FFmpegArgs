namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... loop              V-&gt;V       Loop video frames.
/// </summary>
public class LoopFilterGen : ImageToImageFilter
{
internal LoopFilterGen(ImageMap input) : base("loop",input) { AddMapOut(); }
/// <summary>
///  number of loops (from -1 to INT_MAX) (default 0)
/// </summary>
public LoopFilterGen loop(int loop) => this.SetOptionRange("loop", loop,-1,INT_MAX);
/// <summary>
///  max number of frames to loop (from 0 to 32767) (default 0)
/// </summary>
public LoopFilterGen size(long size) => this.SetOptionRange("size", size,0,32767);
/// <summary>
///  set the loop start frame (from -1 to I64_MAX) (default 0)
/// </summary>
public LoopFilterGen start(long start) => this.SetOptionRange("start", start,-1,I64_MAX);
/// <summary>
///  set the loop start time (default INT64_MAX)
/// </summary>
public LoopFilterGen time(TimeSpan time) => this.SetOptionRange("time",time,TimeSpan.Zero,TimeSpan.MaxValue);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Loop video frames.
/// </summary>
public static LoopFilterGen LoopFilterGen(this ImageMap input0) => new LoopFilterGen(input0);
}
}
