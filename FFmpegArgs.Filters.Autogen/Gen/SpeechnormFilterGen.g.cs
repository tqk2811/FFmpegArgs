namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C speechnorm        A->A       Speech Normalizer.
/// </summary>
public class SpeechnormFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal SpeechnormFilterGen(AudioMap input) : base("speechnorm",input) { AddMapOut(); }
/// <summary>
///  set the peak value (from 0 to 1) (default 0.95)
/// </summary>
public SpeechnormFilterGen peak(double peak) => this.SetOptionRange("peak", peak,0,1);
/// <summary>
///  set the max expansion factor (from 1 to 50) (default 2)
/// </summary>
public SpeechnormFilterGen expansion(double expansion) => this.SetOptionRange("expansion", expansion,1,50);
/// <summary>
///  set the max compression factor (from 1 to 50) (default 2)
/// </summary>
public SpeechnormFilterGen compression(double compression) => this.SetOptionRange("compression", compression,1,50);
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public SpeechnormFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,1);
/// <summary>
///  set the expansion raising amount (from 0 to 1) (default 0.001)
/// </summary>
public SpeechnormFilterGen raise(double raise) => this.SetOptionRange("raise", raise,0,1);
/// <summary>
///  set the compression raising amount (from 0 to 1) (default 0.001)
/// </summary>
public SpeechnormFilterGen fall(double fall) => this.SetOptionRange("fall", fall,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public SpeechnormFilterGen channels(ChannelLayout channels) => this.SetOption("channels",channels.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public SpeechnormFilterGen h(ChannelLayout h) => this.SetOption("h",h.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set inverted filtering (default false)
/// </summary>
public SpeechnormFilterGen invert(bool invert) => this.SetOption("invert",invert.ToFFmpegFlag());
/// <summary>
///  set linked channels filtering (default false)
/// </summary>
public SpeechnormFilterGen link(bool link) => this.SetOption("link",link.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class SpeechnormFilterGenExtensions
{
/// <summary>
/// Speech Normalizer.
/// </summary>
public static SpeechnormFilterGen SpeechnormFilterGen(this AudioMap input0) => new SpeechnormFilterGen(input0);
}
}
