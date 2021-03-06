namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C crossfeed         A->A       Apply headphone crossfeed filter.
/// </summary>
public class CrossfeedFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal CrossfeedFilterGen(AudioMap input) : base("crossfeed",input) { AddMapOut(); }
/// <summary>
///  set crossfeed strength (from 0 to 1) (default 0.2)
/// </summary>
public CrossfeedFilterGen strength(double strength) => this.SetOptionRange("strength", strength,0,1);
/// <summary>
///  set soundstage wideness (from 0 to 1) (default 0.5)
/// </summary>
public CrossfeedFilterGen range(double range) => this.SetOptionRange("range", range,0,1);
/// <summary>
///  set curve slope (from 0.01 to 1) (default 0.5)
/// </summary>
public CrossfeedFilterGen slope(double slope) => this.SetOptionRange("slope", slope,0.01,1);
/// <summary>
///  set level in (from 0 to 1) (default 0.9)
/// </summary>
public CrossfeedFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0,1);
/// <summary>
///  set level out (from 0 to 1) (default 1)
/// </summary>
public CrossfeedFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0,1);
}
/// <summary>
/// </summary>
public static class CrossfeedFilterGenExtensions
{
/// <summary>
/// Apply headphone crossfeed filter.
/// </summary>
public static CrossfeedFilterGen CrossfeedFilterGen(this AudioMap input0) => new CrossfeedFilterGen(input0);
}
}
