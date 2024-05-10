namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... bench             V->V       Benchmark part of a filtergraph.
/// </summary>
public class BenchFilterGen : ImageToImageFilter
{
internal BenchFilterGen(ImageMap input) : base("bench",input) { AddMapOut(); }
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public BenchFilterGen action(BenchFilterGenAction action) => this.SetOption("action", action.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Benchmark part of a filtergraph.
/// </summary>
public static BenchFilterGen BenchFilterGen(this ImageMap input0) => new BenchFilterGen(input0);
}
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public enum BenchFilterGenAction
{
/// <summary>
/// start           0            ..FV....... start timer
/// </summary>
[Name("start")] start,
/// <summary>
/// stop            1            ..FV....... stop timer
/// </summary>
[Name("stop")] stop,
}

}
