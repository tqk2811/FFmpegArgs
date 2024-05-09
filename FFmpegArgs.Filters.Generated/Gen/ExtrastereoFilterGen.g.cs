namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C extrastereo       A->A       Increase difference between stereo audio channels.
/// </summary>
public class ExtrastereoFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal ExtrastereoFilterGen(AudioMap input) : base("extrastereo",input) { AddMapOut(); }
/// <summary>
///  set the difference coefficient (from -10 to 10) (default 2.5)
/// </summary>
public ExtrastereoFilterGen m(float m) => this.SetOptionRange("m", m,-10,10);
/// <summary>
///  enable clipping (default true)
/// </summary>
public ExtrastereoFilterGen c(bool c) => this.SetOption("c",c.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class ExtrastereoFilterGenExtensions
{
/// <summary>
/// Increase difference between stereo audio channels.
/// </summary>
public static ExtrastereoFilterGen ExtrastereoFilterGen(this AudioMap input0) => new ExtrastereoFilterGen(input0);
}
}
