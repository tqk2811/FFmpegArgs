namespace FFmpegArgs.Filters.Autogens
{
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
public static class AcompressorFilterGenExtensions
{
/// <summary>
/// Audio compressor.
/// </summary>
public static AcompressorFilterGen AcompressorFilterGen(this AudioMap input0) => new AcompressorFilterGen(input0);
/// <summary>
/// Audio compressor.
/// </summary>
public static AcompressorFilterGen AcompressorFilterGen(this AudioMap input0,AcompressorFilterGenConfig config)
{
var result = new AcompressorFilterGen(input0);
if(config?.level_in != null) result.level_in(config.level_in.Value);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.threshold != null) result.threshold(config.threshold.Value);
if(config?.ratio != null) result.ratio(config.ratio.Value);
if(config?.attack != null) result.attack(config.attack.Value);
if(config?.release != null) result.release(config.release.Value);
if(config?.makeup != null) result.makeup(config.makeup.Value);
if(config?.knee != null) result.knee(config.knee.Value);
if(config?.link != null) result.link(config.link.Value);
if(config?.detection != null) result.detection(config.detection.Value);
if(config?.level_sc != null) result.level_sc(config.level_sc.Value);
if(config?.mix != null) result.mix(config.mix.Value);
return result;
}
}
public class AcompressorFilterGenConfig
{
/// <summary>
///  set input gain (from 0.015625 to 64) (default 1)
/// </summary>
public double? level_in { get; set; }
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public AcompressorFilterGenMode? mode { get; set; }
/// <summary>
///  set threshold (from 0.000976563 to 1) (default 0.125)
/// </summary>
public double? threshold { get; set; }
/// <summary>
///  set ratio (from 1 to 20) (default 2)
/// </summary>
public double? ratio { get; set; }
/// <summary>
///  set attack (from 0.01 to 2000) (default 20)
/// </summary>
public double? attack { get; set; }
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public double? release { get; set; }
/// <summary>
///  set make up gain (from 1 to 64) (default 1)
/// </summary>
public double? makeup { get; set; }
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public double? knee { get; set; }
/// <summary>
///  set link type (from 0 to 1) (default average)
/// </summary>
public AcompressorFilterGenLink? link { get; set; }
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public AcompressorFilterGenDetection? detection { get; set; }
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public double? level_sc { get; set; }
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public double? mix { get; set; }
}
public enum AcompressorFilterGenMode
{
[Name("downward")] downward,
[Name("upward")] upward,
}

public enum AcompressorFilterGenLink
{
[Name("average")] average,
[Name("maximum")] maximum,
}

public enum AcompressorFilterGenDetection
{
[Name("peak")] peak,
[Name("rms")] rms,
}

}
