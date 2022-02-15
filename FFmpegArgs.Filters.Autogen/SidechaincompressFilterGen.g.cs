namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ..C sidechaincompress AA->A      Sidechain compressor.
/// </summary>
public class SidechaincompressFilterGen : AudioToAudioFilter,ICommandSupport
{
internal SidechaincompressFilterGen(params AudioMap[] inputs) : base("sidechaincompress",inputs) { AddMapOut(); }
/// <summary>
///  set input gain (from 0.015625 to 64) (default 1)
/// </summary>
public SidechaincompressFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public SidechaincompressFilterGen mode(SidechaincompressFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set threshold (from 0.000976563 to 1) (default 0.125)
/// </summary>
public SidechaincompressFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0.000976563,1);
/// <summary>
///  set ratio (from 1 to 20) (default 2)
/// </summary>
public SidechaincompressFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,1,20);
/// <summary>
///  set attack (from 0.01 to 2000) (default 20)
/// </summary>
public SidechaincompressFilterGen attack(double attack) => this.SetOptionRange("attack", attack,0.01,2000);
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public SidechaincompressFilterGen release(double release) => this.SetOptionRange("release", release,0.01,9000);
/// <summary>
///  set make up gain (from 1 to 64) (default 1)
/// </summary>
public SidechaincompressFilterGen makeup(double makeup) => this.SetOptionRange("makeup", makeup,1,64);
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public SidechaincompressFilterGen knee(double knee) => this.SetOptionRange("knee", knee,1,8);
/// <summary>
///  set link type (from 0 to 1) (default average)
/// </summary>
public SidechaincompressFilterGen link(SidechaincompressFilterGenLink link) => this.SetOption("link", link.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public SidechaincompressFilterGen detection(SidechaincompressFilterGenDetection detection) => this.SetOption("detection", detection.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public SidechaincompressFilterGen level_sc(double level_sc) => this.SetOptionRange("level_sc", level_sc,0.015625,64);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public SidechaincompressFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
}
/// <summary>
/// </summary>
public static class SidechaincompressFilterGenExtensions
{
/// <summary>
/// Sidechain compressor.
/// </summary>
public static SidechaincompressFilterGen SidechaincompressFilterGen(this AudioMap input0, AudioMap input1) => new SidechaincompressFilterGen(input0, input1);
}
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public enum SidechaincompressFilterGenMode
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
///  set link type (from 0 to 1) (default average)
/// </summary>
public enum SidechaincompressFilterGenLink
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

/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public enum SidechaincompressFilterGenDetection
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

}
