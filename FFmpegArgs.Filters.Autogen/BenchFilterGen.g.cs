namespace FFmpegArgs.Filters.Autogens
{
public class BenchFilterGen : ImageToImageFilter
{
internal BenchFilterGen(ImageMap input) : base("bench",input) { AddMapOut(); }
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public BenchFilterGen action(BenchFilterGenAction action) => this.SetOption("action", action.GetEnumAttribute<NameAttribute>().Name);
}
public static class BenchFilterGenExtensions
{
/// <summary>
/// Benchmark part of a filtergraph.
/// </summary>
public static BenchFilterGen BenchFilterGen(this ImageMap input0) => new BenchFilterGen(input0);
/// <summary>
/// Benchmark part of a filtergraph.
/// </summary>
public static BenchFilterGen BenchFilterGen(this ImageMap input0,BenchFilterGenConfig config)
{
var result = new BenchFilterGen(input0);
if(config?.action != null) result.action(config.action.Value);
return result;
}
}
public class BenchFilterGenConfig
{
/// <summary>
///  set action (from 0 to 1) (default start)
/// </summary>
public BenchFilterGenAction? action { get; set; }
}
public enum BenchFilterGenAction
{
[Name("start")] start,
[Name("stop")] stop,
}

}
