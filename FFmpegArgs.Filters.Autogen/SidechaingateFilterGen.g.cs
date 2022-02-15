namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C sidechaingate     AA->A      Audio sidechain gate.
/// </summary>
public class SidechaingateFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal SidechaingateFilterGen(params AudioMap[] inputs) : base("sidechaingate",inputs) { AddMapOut(); }
/// <summary>
///  set input level (from 0.015625 to 64) (default 1)
/// </summary>
public SidechaingateFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public SidechaingateFilterGen mode(SidechaingateFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set max gain reduction (from 0 to 1) (default 0.06125)
/// </summary>
public SidechaingateFilterGen range(double range) => this.SetOptionRange("range", range,0,1);
/// <summary>
///  set threshold (from 0 to 1) (default 0.125)
/// </summary>
public SidechaingateFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,1);
/// <summary>
///  set ratio (from 1 to 9000) (default 2)
/// </summary>
public SidechaingateFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,1,9000);
/// <summary>
///  set attack (from 0.01 to 9000) (default 20)
/// </summary>
public SidechaingateFilterGen attack(double attack) => this.SetOptionRange("attack", attack,0.01,9000);
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public SidechaingateFilterGen release(double release) => this.SetOptionRange("release", release,0.01,9000);
/// <summary>
///  set makeup gain (from 1 to 64) (default 1)
/// </summary>
public SidechaingateFilterGen makeup(double makeup) => this.SetOptionRange("makeup", makeup,1,64);
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public SidechaingateFilterGen knee(double knee) => this.SetOptionRange("knee", knee,1,8);
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public SidechaingateFilterGen detection(SidechaingateFilterGenDetection detection) => this.SetOption("detection", detection.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set link (from 0 to 1) (default average)
/// </summary>
public SidechaingateFilterGen link(SidechaingateFilterGenLink link) => this.SetOption("link", link.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public SidechaingateFilterGen level_sc(double level_sc) => this.SetOptionRange("level_sc", level_sc,0.015625,64);
}
/// <summary>
/// </summary>
public static class SidechaingateFilterGenExtensions
{
/// <summary>
/// Audio sidechain gate.
/// </summary>
public static SidechaingateFilterGen SidechaingateFilterGen(this AudioMap input0, AudioMap input1) => new SidechaingateFilterGen(input0, input1);
}
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public enum SidechaingateFilterGenMode
{
/// <summary>
/// downward        0            ..F.A....T.
/// </summary>
[Name("downward")] downward,
/// <summary>
/// upward          1            ..F.A....T.
/// </summary>
[Name("upward")] upward,
}

/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public enum SidechaingateFilterGenDetection
{
/// <summary>
/// peak            0            ..F.A....T.
/// </summary>
[Name("peak")] peak,
/// <summary>
/// rms             1            ..F.A....T.
/// </summary>
[Name("rms")] rms,
}

/// <summary>
///  set link (from 0 to 1) (default average)
/// </summary>
public enum SidechaingateFilterGenLink
{
/// <summary>
/// average         0            ..F.A....T.
/// </summary>
[Name("average")] average,
/// <summary>
/// maximum         1            ..F.A....T.
/// </summary>
[Name("maximum")] maximum,
}

}
