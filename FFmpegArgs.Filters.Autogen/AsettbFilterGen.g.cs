namespace FFmpegArgs.Filters.Autogens
{
public class AsettbFilterGen : AudioToAudioFilter
{
internal AsettbFilterGen(AudioMap input) : base("asettb",input) { AddMapOut(); }
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public AsettbFilterGen expr(string expr) => this.SetOption("expr",expr);
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public AsettbFilterGen tb(string tb) => this.SetOption("tb",tb);
}
public static class AsettbFilterGenExtensions
{
/// <summary>
/// Set timebase for the audio output link.
/// </summary>
public static AsettbFilterGen AsettbFilterGen(this AudioMap input0) => new AsettbFilterGen(input0);
/// <summary>
/// Set timebase for the audio output link.
/// </summary>
public static AsettbFilterGen AsettbFilterGen(this AudioMap input0,AsettbFilterGenConfig config)
{
var result = new AsettbFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.expr)) result.expr(config.expr);
if(!string.IsNullOrWhiteSpace(config?.tb)) result.tb(config.tb);
return result;
}
}
public class AsettbFilterGenConfig
{
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public string expr { get; set; }
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public string tb { get; set; }
}
}
