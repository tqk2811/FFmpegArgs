namespace FFmpegArgs.Filters.Autogens
{
public class AbenchFilterGen : AudioToAudioFilter
{
internal AbenchFilterGen(AudioMap input) : base("abench",input) { AddMapOut(); }
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public AbenchFilterGen action(AbenchFilterGenAction action) => this.SetOption("action", action.GetEnumAttribute<NameAttribute>().Name);
}
public static class AbenchFilterGenExtensions
{
/// <summary>
/// Benchmark part of a filtergraph.
/// </summary>
public static AbenchFilterGen AbenchFilterGen(this AudioMap input0) => new AbenchFilterGen(input0);
/// <summary>
/// Benchmark part of a filtergraph.
/// </summary>
public static AbenchFilterGen AbenchFilterGen(this AudioMap input0,AbenchFilterGenConfig config)
{
var result = new AbenchFilterGen(input0);
if(config?.action != null) result.action(config.action.Value);
return result;
}
}
public class AbenchFilterGenConfig
{
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public AbenchFilterGenAction? action { get; set; }
}
public enum AbenchFilterGenAction
{
[Name("start")] start,
[Name("stop")] stop,
}

}
