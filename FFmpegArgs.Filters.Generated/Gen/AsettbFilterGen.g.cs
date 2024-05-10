namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... asettb            A->A       Set timebase for the audio output link.
/// </summary>
public class AsettbFilterGen : AudioToAudioFilter
{
internal AsettbFilterGen(AudioMap input) : base("asettb",input) { AddMapOut(); }
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public AsettbFilterGen expr(ExpressionValue expr) => this.SetOption("expr",(string)expr);
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public AsettbFilterGen tb(ExpressionValue tb) => this.SetOption("tb",(string)tb);
}
/// <summary>
/// </summary>
public static class AsettbFilterGenExtensions
{
/// <summary>
/// Set timebase for the audio output link.
/// </summary>
public static AsettbFilterGen AsettbFilterGen(this AudioMap input0) => new AsettbFilterGen(input0);
}
}
