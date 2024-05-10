namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... abench            A->A       Benchmark part of a filtergraph.
/// </summary>
public class AbenchFilterGen : AudioToAudioFilter
{
internal AbenchFilterGen(AudioMap input) : base("abench",input) { AddMapOut(); }
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public AbenchFilterGen action(AbenchFilterGenAction action) => this.SetOption("action", action.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Benchmark part of a filtergraph.
/// </summary>
public static AbenchFilterGen AbenchFilterGen(this AudioMap input0) => new AbenchFilterGen(input0);
}
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public enum AbenchFilterGenAction
{
/// <summary>
/// start           0            ..F.A...... start timer
/// </summary>
[Name("start")] start,
/// <summary>
/// stop            1            ..F.A...... stop timer
/// </summary>
[Name("stop")] stop,
}

}
