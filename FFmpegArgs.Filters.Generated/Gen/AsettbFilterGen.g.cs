namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... asettb            A-&gt;A       Set timebase for the audio output link.
/// </summary>
public class AsettbFilterGen : AudioToAudioFilter
{
internal AsettbFilterGen(AudioMap input) : base("asettb",input) { AddMapOut(); }
/// <summary>
///  set expression determining the output timebase (default &quot;intb&quot;)
/// </summary>
public AsettbFilterGen expr(ExpressionValue expr) => this.SetOption("expr",(string)expr);
/// <summary>
///  set expression determining the output timebase (default &quot;intb&quot;)
/// </summary>
public AsettbFilterGen tb(ExpressionValue tb) => this.SetOption("tb",(string)tb);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Set timebase for the audio output link.
/// </summary>
public static AsettbFilterGen AsettbFilterGen(this AudioMap input0) => new AsettbFilterGen(input0);
}
}
