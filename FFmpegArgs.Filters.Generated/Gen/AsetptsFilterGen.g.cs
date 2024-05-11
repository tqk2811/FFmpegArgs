namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C asetpts           A-&gt;A       Set PTS for the output audio frame.
/// </summary>
public class AsetptsFilterGen : AudioToAudioFilter,ICommandSupport
{
internal AsetptsFilterGen(AudioMap input) : base("asetpts",input) { AddMapOut(); }
/// <summary>
///  Expression determining the frame timestamp (default &quot;PTS&quot;)
/// </summary>
public AsetptsFilterGen expr(ExpressionValue expr) => this.SetOption("expr",(string)expr);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Set PTS for the output audio frame.
/// </summary>
public static AsetptsFilterGen AsetptsFilterGen(this AudioMap input0) => new AsetptsFilterGen(input0);
}
}
