namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C asetpts           A->A       Set PTS for the output audio frame.
/// </summary>
public class AsetptsFilterGen : AudioToAudioFilter,ICommandSupport
{
internal AsetptsFilterGen(AudioMap input) : base("asetpts",input) { AddMapOut(); }
/// <summary>
///  Expression determining the frame timestamp (default "PTS")
/// </summary>
public AsetptsFilterGen expr(ExpressionValue expr) => this.SetOption("expr",(string)expr);
}
/// <summary>
/// </summary>
public static class AsetptsFilterGenExtensions
{
/// <summary>
/// Set PTS for the output audio frame.
/// </summary>
public static AsetptsFilterGen AsetptsFilterGen(this AudioMap input0) => new AsetptsFilterGen(input0);
}
}
