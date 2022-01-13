namespace FFmpegArgs.Filters.Autogens
{
public class PanFilterGen : AudioToAudioFilter
{
internal PanFilterGen(AudioMap input) : base("pan",input) { AddMapOut(); }
/// <summary>
/// 
/// </summary>
public PanFilterGen args(string args) => this.SetOption("args",args);
}
public static class PanFilterGenExtensions
{
/// <summary>
/// Remix channels with coefficients (panning).
/// </summary>
public static PanFilterGen PanFilterGen(this AudioMap input0) => new PanFilterGen(input0);
/// <summary>
/// Remix channels with coefficients (panning).
/// </summary>
public static PanFilterGen PanFilterGen(this AudioMap input0,PanFilterGenConfig config)
{
var result = new PanFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.args)) result.args(config.args);
return result;
}
}
public class PanFilterGenConfig
{
/// <summary>
/// 
/// </summary>
public string args { get; set; }
}
}
