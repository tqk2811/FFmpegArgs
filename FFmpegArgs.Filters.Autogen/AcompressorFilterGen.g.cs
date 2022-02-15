namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ..C acompressor       A->A       Audio compressor.
/// </summary>
public class AcompressorFilterGen : AudioToAudioFilter,ICommandSupport
{
internal AcompressorFilterGen(AudioMap input) : base("acompressor",input) { AddMapOut(); }
/// <summary>
///  set input gain (from 0.015625 to 64) (default 1)
/// </summary>
public AcompressorFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public AcompressorFilterGen mode(AcompressorFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set threshold (from 0.000976563 to 1) (default 0.125)
/// </summary>
public AcompressorFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0.000976563,1);
/// <summary>
///  set ratio (from 1 to 20) (default 2)
/// </summary>
public AcompressorFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,1,20);
/// <summary>
///  set attack (from 0.01 to 2000) (default 20)
/// </summary>
public AcompressorFilterGen attack(double attack) => this.SetOptionRange("attack", attack,0.01,2000);
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public AcompressorFilterGen release(double release) => this.SetOptionRange("release", release,0.01,9000);
/// <summary>
///  set make up gain (from 1 to 64) (default 1)
/// </summary>
public AcompressorFilterGen makeup(double makeup) => this.SetOptionRange("makeup", makeup,1,64);
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public AcompressorFilterGen knee(double knee) => this.SetOptionRange("knee", knee,1,8);
/// <summary>
///  set link type (from 0 to 1) (default average)
/// </summary>
public AcompressorFilterGen link(AcompressorFilterGenLink link) => this.SetOption("link", link.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public AcompressorFilterGen detection(AcompressorFilterGenDetection detection) => this.SetOption("detection", detection.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public AcompressorFilterGen level_sc(double level_sc) => this.SetOptionRange("level_sc", level_sc,0.015625,64);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public AcompressorFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
}
/// <summary>
/// </summary>
public static class AcompressorFilterGenExtensions
{
/// <summary>
/// Audio compressor.
/// </summary>
public static AcompressorFilterGen AcompressorFilterGen(this AudioMap input0) => new AcompressorFilterGen(input0);
}
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public enum AcompressorFilterGenMode
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
public enum AcompressorFilterGenLink
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
public enum AcompressorFilterGenDetection
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
