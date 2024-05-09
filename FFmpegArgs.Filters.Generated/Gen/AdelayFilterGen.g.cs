namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C adelay            A->A       Delay one or more audio channels.
/// </summary>
public class AdelayFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal AdelayFilterGen(AudioMap input) : base("adelay",input) { AddMapOut(); }
/// <summary>
///  set list of delays for each channel
/// </summary>
public AdelayFilterGen delays(string delays) => this.SetOption("delays",delays);
/// <summary>
///  use last available delay for remained channels (default false)
/// </summary>
public AdelayFilterGen all(bool all) => this.SetOption("all",all.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class AdelayFilterGenExtensions
{
/// <summary>
/// Delay one or more audio channels.
/// </summary>
public static AdelayFilterGen AdelayFilterGen(this AudioMap input0) => new AdelayFilterGen(input0);
}
}
