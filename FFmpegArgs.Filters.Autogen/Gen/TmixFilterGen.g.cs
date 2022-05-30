namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC tmix              V->V       Mix successive video frames.
/// </summary>
public class TmixFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal TmixFilterGen(ImageMap input) : base("tmix",input) { AddMapOut(); }
/// <summary>
///  set number of successive frames to mix (from 1 to 128) (default 3)
/// </summary>
public TmixFilterGen frames(int frames) => this.SetOptionRange("frames", frames,1,128);
/// <summary>
///  set weight for each frame (default "1 1 1")
/// </summary>
public TmixFilterGen weights(string weights) => this.SetOption("weights",weights);
/// <summary>
///  set scale (from 0 to 32767) (default 0)
/// </summary>
public TmixFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,32767);
}
/// <summary>
/// </summary>
public static class TmixFilterGenExtensions
{
/// <summary>
/// Mix successive video frames.
/// </summary>
public static TmixFilterGen TmixFilterGen(this ImageMap input0) => new TmixFilterGen(input0);
}
}
