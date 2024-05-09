namespace FFmpegArgs.Filters.Generated
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
///  set channels to filter (default "all")
/// </summary>
public SpeechnormFilterGen channels(string channels) => this.SetOption("channels",channels);
/// <summary>
///  set channels to filter (default "all")
/// </summary>
public SpeechnormFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  set inverted filtering (default false)
/// </summary>
public SpeechnormFilterGen invert(bool invert) => this.SetOption("invert",invert.ToFFmpegFlag());
/// <summary>
///  set linked channels filtering (default false)
/// </summary>
public SpeechnormFilterGen link(bool link) => this.SetOption("link",link.ToFFmpegFlag());
/// <summary>
///  set the RMS value (from 0 to 1) (default 0)
/// </summary>
public SpeechnormFilterGen rms(double rms) => this.SetOptionRange("rms", rms,0,1);
/// <summary>
///  set the RMS value (from 0 to 1) (default 0)
/// </summary>
public SpeechnormFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
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
